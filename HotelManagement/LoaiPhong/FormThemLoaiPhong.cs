using System;
using System.Linq;
using System.Windows.Forms;
using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.LoaiPhong
{
    public partial class FormThemLoaiPhong : Form
    {
        public FormThemLoaiPhong()
        {
            InitializeComponent();
            AcceptButton = btnThemMoi;
            CancelButton = btnThoat;

            txtMaLoaiPhong.MaxLength = 5;
            txtMaLoaiPhong.ReadOnly = true;
            try
            {
                txtMaLoaiPhong.Text = GenerateMaLoaiPhong();
            }
            catch
            {
            }

            txtTenLP.MaxLength = 20;
            txtSoGiuong.MaxLength = 2;
            txtSoNguoiToiDa.MaxLength = 2;

            txtSoGiuong.KeyPress += ChiChoNhapSo;
            txtSoNguoiToiDa.KeyPress += ChiChoNhapSo;
        }

        private string GenerateMaLoaiPhong()
        {
            using var db = new HotelManagementContext();
            var danhSachMa = db.LoaiPhongs
                .AsNoTracking()
                .Select(l => l.MaLph)
                .ToList();

            int max = 0;
            foreach (string ma in danhSachMa)
            {
                if (ma != null && ma.StartsWith("LP", StringComparison.OrdinalIgnoreCase))
                {
                    string phanSo = ma.Substring(2);
                    if (int.TryParse(phanSo, out int so) && so > max)
                    {
                        max = so;
                    }
                }
            }
            return "LP" + (max + 1).ToString("D2");
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string maLPH = txtMaLoaiPhong.Text.Trim().ToUpper();
            string tenLPH = txtTenLP.Text.Trim();

            if (maLPH.Length == 0)
            {
                maLPH = GenerateMaLoaiPhong();
                txtMaLoaiPhong.Text = maLPH;
            }

            if (tenLPH.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên loại phòng.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLP.Focus();
                return;
            }

            if (!int.TryParse(txtSoGiuong.Text.Trim(), out int soGiuong) || soGiuong <= 0)
            {
                MessageBox.Show("Số giường không hợp lệ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoGiuong.Focus();
                return;
            }

            if (!int.TryParse(txtSoNguoiToiDa.Text.Trim(), out int soNguoiToiDa) || soNguoiToiDa <= 0)
            {
                MessageBox.Show("Số người tối đa không hợp lệ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoNguoiToiDa.Focus();
                return;
            }

            if (!decimal.TryParse(txtGiaNgay.Text.Trim(), out decimal giaNgay) || giaNgay <= 0)
            {
                MessageBox.Show("Giá ngày không hợp lệ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaNgay.Focus();
                return;
            }

            if (!decimal.TryParse(txtGiaGio.Text.Trim(), out decimal giaGio) || giaGio <= 0)
            {
                MessageBox.Show("Giá giờ không hợp lệ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaGio.Focus();
                return;
            }

            try
            {
                using var db = new HotelManagementContext();
                if (db.LoaiPhongs.Any(l => l.MaLph == maLPH))
                {
                    maLPH = GenerateMaLoaiPhong();
                    txtMaLoaiPhong.Text = maLPH;
                }

                db.LoaiPhongs.Add(new Models.LoaiPhong
                {
                    MaLph = maLPH,
                    TenLph = tenLPH,
                    SoGiuong = soGiuong,
                    SoNguoiToiDa = soNguoiToiDa,
                    GiaNgay = giaNgay,
                    GiaGio = giaGio
                });

                int rows = db.SaveChanges();
                if (rows > 0)
                {
                    MessageBox.Show("Thêm loại phòng thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể thêm loại phòng!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Lỗi: " + (ex.InnerException?.Message ?? ex.Message), "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ChiChoNhapSo(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
