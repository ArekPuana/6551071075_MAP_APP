using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;
using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.ThongKe
{
    public partial class FormThongKe : Form
    {
        private readonly CultureInfo viVN = new CultureInfo("vi-VN");

        private sealed class ThongKeLoaiPhong
        {
            public string TenLoaiPhong { get; set; } = "";
            public decimal DoanhThu { get; set; }
            public int SoLuot { get; set; }
        }

        private sealed class ThongKeDichVu
        {
            public string TenDichVu { get; set; } = "";
            public decimal DoanhThu { get; set; }
            public int SoLuong { get; set; }
        }

        private sealed class DongChiTiet
        {
            public string MaHD { get; set; } = "";
            public DateTime NgayLap { get; set; }
            public string TenKH { get; set; } = "";
            public string MaPhong { get; set; } = "";
            public string TenLoaiPhong { get; set; } = "";
            public decimal TienPhong { get; set; }
            public decimal TienDichVu { get; set; }
            public decimal TongTien { get; set; }
        }

        private List<ThongKeLoaiPhong> _duLieuLoaiPhong = new List<ThongKeLoaiPhong>();
        private List<ThongKeDichVu> _duLieuDichVu = new List<ThongKeDichVu>();
        private List<DongChiTiet> _duLieuChiTiet = new List<DongChiTiet>();

        public FormThongKe()
        {
            InitializeComponent();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpDenNgay.Value = DateTime.Today;

            CauHinhLuoi();
            ThucHienThongKe();
        }

        private void CauHinhLuoi()
        {
            dtgChiTiet.AutoGenerateColumns = false;
            dtgChiTiet.ReadOnly = true;
            dtgChiTiet.AllowUserToAddRows = false;
            dtgChiTiet.AllowUserToDeleteRows = false;
            dtgChiTiet.AllowUserToResizeRows = false;
            dtgChiTiet.MultiSelect = false;
            dtgChiTiet.RowHeadersVisible = false;
            dtgChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgChiTiet.RowTemplate.Height = 35;

            dtgChiTiet.Columns.Add(new DataGridViewTextBoxColumn { Name = "MaHD", DataPropertyName = "MaHD", HeaderText = "Mã HD", FillWeight = 10 });
            
            var colNgay = new DataGridViewTextBoxColumn { Name = "NgayLap", DataPropertyName = "NgayLap", HeaderText = "Ngày lập", FillWeight = 12 };
            colNgay.DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgChiTiet.Columns.Add(colNgay);

            dtgChiTiet.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenKH", DataPropertyName = "TenKH", HeaderText = "Khách hàng", FillWeight = 18 });
            dtgChiTiet.Columns.Add(new DataGridViewTextBoxColumn { Name = "MaPhong", DataPropertyName = "MaPhong", HeaderText = "Phòng", FillWeight = 10 });
            dtgChiTiet.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenLoaiPhong", DataPropertyName = "TenLoaiPhong", HeaderText = "Loại phòng", FillWeight = 14 });

            var colTienPhong = new DataGridViewTextBoxColumn { Name = "TienPhong", DataPropertyName = "TienPhong", HeaderText = "Tiền phòng", FillWeight = 12 };
            colTienPhong.DefaultCellStyle.Format = "N0";
            colTienPhong.DefaultCellStyle.FormatProvider = viVN;
            colTienPhong.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgChiTiet.Columns.Add(colTienPhong);

            var colTienDV = new DataGridViewTextBoxColumn { Name = "TienDichVu", DataPropertyName = "TienDichVu", HeaderText = "Tiền dịch vụ", FillWeight = 12 };
            colTienDV.DefaultCellStyle.Format = "N0";
            colTienDV.DefaultCellStyle.FormatProvider = viVN;
            colTienDV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgChiTiet.Columns.Add(colTienDV);

            var colTong = new DataGridViewTextBoxColumn { Name = "TongTien", DataPropertyName = "TongTien", HeaderText = "Tổng cộng", FillWeight = 14 };
            colTong.DefaultCellStyle.Format = "N0";
            colTong.DefaultCellStyle.FormatProvider = viVN;
            colTong.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgChiTiet.Columns.Add(colTong);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThucHienThongKe();
        }

        private void ThucHienThongKe()
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddTicks(-1);

            if (tuNgay > denNgay)
            {
                MessageBox.Show("Từ ngày không thể lớn hơn đến ngày!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var db = new HotelManagementContext();

                var hoaDons = db.HoaDons
                    .AsNoTracking()
                    .Where(h => h.DaXoa != true && h.NgHd >= tuNgay && h.NgHd <= denNgay)
                    .Select(h => new
                    {
                        h.MaHd,
                        NgHd = h.NgHd ?? DateTime.Today,
                        h.MaCtdp,
                        TenKH = h.MaCtdpNavigation.MaPtNavigation.MaKhNavigation.TenKh,
                        MaPH = h.MaCtdpNavigation.MaPh,
                        TenLPH = h.MaCtdpNavigation.MaPhNavigation.MaLphNavigation.TenLph,
                        TienPhong = h.MaCtdpNavigation.ThanhTien ?? 0,
                        DichVus = h.MaCtdpNavigation.Ctdvs
                            .Where(v => v.DaXoa != true)
                            .Select(v => new
                            {
                                TenDV = v.MaDvNavigation.TenDv,
                                ThanhTien = v.MaDvNavigation.DonGia * v.Sl,
                                v.Sl
                            }).ToList()
                    })
                    .ToList();

                decimal tongTienPhong = 0;
                decimal tongTienDV = 0;
                _duLieuChiTiet.Clear();

                var dictLoaiPhong = new Dictionary<string, (decimal doanhThu, int soLuot)>();
                var dictDichVu = new Dictionary<string, (decimal doanhThu, int soLuong)>();
                var dictKhachHang = new Dictionary<string, decimal>();

                foreach (var hd in hoaDons)
                {
                    decimal tienDV = hd.DichVus.Sum(d => d.ThanhTien);
                    decimal tongTienHD = hd.TienPhong + tienDV;

                    tongTienPhong += hd.TienPhong;
                    tongTienDV += tienDV;

                    _duLieuChiTiet.Add(new DongChiTiet
                    {
                        MaHD = hd.MaHd,
                        NgayLap = hd.NgHd,
                        TenKH = hd.TenKH ?? "",
                        MaPhong = hd.MaPH,
                        TenLoaiPhong = hd.TenLPH ?? "",
                        TienPhong = hd.TienPhong,
                        TienDichVu = tienDV,
                        TongTien = tongTienHD
                    });

                    string tenLp = string.IsNullOrEmpty(hd.TenLPH) ? "Khác" : hd.TenLPH;
                    if (!dictLoaiPhong.ContainsKey(tenLp))
                        dictLoaiPhong[tenLp] = (0, 0);
                    dictLoaiPhong[tenLp] = (dictLoaiPhong[tenLp].doanhThu + hd.TienPhong, dictLoaiPhong[tenLp].soLuot + 1);

                    foreach (var dv in hd.DichVus)
                    {
                        string tenDv = string.IsNullOrEmpty(dv.TenDV) ? "Khác" : dv.TenDV;
                        if (!dictDichVu.ContainsKey(tenDv))
                            dictDichVu[tenDv] = (0, 0);
                        dictDichVu[tenDv] = (dictDichVu[tenDv].doanhThu + dv.ThanhTien, dictDichVu[tenDv].soLuong + dv.Sl);
                    }

                    string tenKh = string.IsNullOrEmpty(hd.TenKH) ? "Khách vãng lai" : hd.TenKH;
                    if (!dictKhachHang.ContainsKey(tenKh))
                        dictKhachHang[tenKh] = 0;
                    dictKhachHang[tenKh] += tongTienHD;
                }

                decimal tongDoanhThu = tongTienPhong + tongTienDV;

                lbTienPhong.Text = tongTienPhong.ToString("N0", viVN) + " VND";
                lbTienDichVu.Text = tongTienDV.ToString("N0", viVN) + " VND";
                lbTongDoanhThu.Text = tongDoanhThu.ToString("N0", viVN) + " VND";
                lbSoPhongThue.Text = hoaDons.Count.ToString() + " lượt";

                var topLP = dictLoaiPhong.OrderByDescending(x => x.Value.doanhThu).FirstOrDefault();
                lbTopLoaiPhong.Text = topLP.Key != null
                    ? $"Top loại phòng: {topLP.Key} ({topLP.Value.doanhThu.ToString("N0", viVN)} VND)"
                    : "Top loại phòng: Chưa có";

                var topDV = dictDichVu.OrderByDescending(x => x.Value.doanhThu).FirstOrDefault();
                lbTopDichVu.Text = topDV.Key != null
                    ? $"Top dịch vụ: {topDV.Key} ({topDV.Value.doanhThu.ToString("N0", viVN)} VND)"
                    : "Top dịch vụ: Chưa có";

                var topKH = dictKhachHang.OrderByDescending(x => x.Value).FirstOrDefault();
                lbTopKhachHang.Text = topKH.Key != null
                    ? $"Top KH: {topKH.Key} ({topKH.Value.ToString("N0", viVN)} VND)"
                    : "Top KH: Chưa có";

                _duLieuLoaiPhong = dictLoaiPhong
                    .Select(x => new ThongKeLoaiPhong { TenLoaiPhong = x.Key, DoanhThu = x.Value.doanhThu, SoLuot = x.Value.soLuot })
                    .OrderByDescending(x => x.DoanhThu)
                    .ToList();

                _duLieuDichVu = dictDichVu
                    .Select(x => new ThongKeDichVu { TenDichVu = x.Key, DoanhThu = x.Value.doanhThu, SoLuong = x.Value.soLuong })
                    .OrderByDescending(x => x.DoanhThu)
                    .ToList();

                dtgChiTiet.DataSource = null;
                dtgChiTiet.DataSource = _duLieuChiTiet;
                dtgChiTiet.ClearSelection();

                picChartLoaiPhong.Invalidate();
                picChartDichVu.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực hiện thống kê: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picChartLoaiPhong_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int w = picChartLoaiPhong.Width;
            int h = picChartLoaiPhong.Height;

            using (Font titleFont = new Font("Segoe UI", 11, FontStyle.Bold))
            using (SolidBrush titleBrush = new SolidBrush(Color.FromArgb(40, 40, 40)))
            {
                g.DrawString("DOANH THU THEO LOẠI PHÒNG (VND)", titleFont, titleBrush, new PointF(15, 12));
            }

            if (_duLieuLoaiPhong.Count == 0)
            {
                using Font noDataFont = new Font("Segoe UI", 11, FontStyle.Italic);
                using SolidBrush noDataBrush = new SolidBrush(Color.Gray);
                g.DrawString("Chưa có dữ liệu", noDataFont, noDataBrush, new PointF(w / 3f, h / 2f));
                return;
            }

            decimal maxVal = _duLieuLoaiPhong.Max(x => x.DoanhThu);
            if (maxVal <= 0) maxVal = 1;

            int chartLeft = 50;
            int chartBottom = h - 45;
            int chartTop = 45;
            int chartWidth = w - chartLeft - 30;
            int chartHeight = chartBottom - chartTop;

            using (Pen axisPen = new Pen(Color.FromArgb(200, 200, 200), 1))
            {
                g.DrawLine(axisPen, chartLeft, chartTop, chartLeft, chartBottom);
                g.DrawLine(axisPen, chartLeft, chartBottom, chartLeft + chartWidth, chartBottom);
            }

            Color[] colors = { Color.FromArgb(70, 130, 180), Color.FromArgb(46, 139, 87), Color.FromArgb(218, 112, 214), Color.FromArgb(238, 118, 0), Color.FromArgb(106, 90, 205) };

            int barCount = _duLieuLoaiPhong.Count;
            int barWidth = Math.Min(60, (chartWidth / (barCount + 1)));
            int gap = (chartWidth - (barWidth * barCount)) / (barCount + 1);

            using Font labelFont = new Font("Segoe UI", 8.5f, FontStyle.Regular);
            using Font valFont = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            using SolidBrush textBrush = new SolidBrush(Color.FromArgb(50, 50, 50));

            for (int i = 0; i < barCount; i++)
            {
                var item = _duLieuLoaiPhong[i];
                int barH = (int)((item.DoanhThu / maxVal) * (chartHeight - 30));
                int x = chartLeft + gap + i * (barWidth + gap);
                int y = chartBottom - barH;

                Color c = colors[i % colors.Length];
                using (SolidBrush barBrush = new SolidBrush(c))
                {
                    g.FillRectangle(barBrush, x, y, barWidth, barH);
                }

                string valStr = item.DoanhThu >= 1_000_000
                    ? (item.DoanhThu / 1_000_000m).ToString("0.#") + "M"
                    : item.DoanhThu.ToString("N0", viVN);

                SizeF valSize = g.MeasureString(valStr, valFont);
                g.DrawString(valStr, valFont, textBrush, x + (barWidth - valSize.Width) / 2, y - valSize.Height - 3);

                string nameStr = item.TenLoaiPhong;
                if (nameStr.Length > 10) nameStr = nameStr.Substring(0, 9) + "..";
                SizeF nameSize = g.MeasureString(nameStr, labelFont);
                g.DrawString(nameStr, labelFont, textBrush, x + (barWidth - nameSize.Width) / 2, chartBottom + 5);
            }
        }

        private void picChartDichVu_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int w = picChartDichVu.Width;
            int h = picChartDichVu.Height;

            using (Font titleFont = new Font("Segoe UI", 11, FontStyle.Bold))
            using (SolidBrush titleBrush = new SolidBrush(Color.FromArgb(40, 40, 40)))
            {
                g.DrawString("TỶ LỆ DOANH THU DỊCH VỤ", titleFont, titleBrush, new PointF(15, 12));
            }

            if (_duLieuDichVu.Count == 0 || _duLieuDichVu.Sum(x => x.DoanhThu) <= 0)
            {
                using Font noDataFont = new Font("Segoe UI", 11, FontStyle.Italic);
                using SolidBrush noDataBrush = new SolidBrush(Color.Gray);
                g.DrawString("Chưa có dịch vụ sử dụng", noDataFont, noDataBrush, new PointF(w / 4f, h / 2f));
                return;
            }

            decimal totalDV = _duLieuDichVu.Sum(x => x.DoanhThu);
            Color[] colors = { Color.FromArgb(238, 99, 99), Color.FromArgb(67, 205, 128), Color.FromArgb(135, 206, 250), Color.FromArgb(255, 193, 37), Color.FromArgb(186, 85, 211), Color.FromArgb(0, 206, 209) };

            int diameter = Math.Min(h - 70, (w / 2) - 10);
            Rectangle pieRect = new Rectangle(20, 50, diameter, diameter);

            float startAngle = 0;
            int legendX = pieRect.Right + 20;
            int legendY = 60;

            using Font legendFont = new Font("Segoe UI", 9f);
            using SolidBrush textBrush = new SolidBrush(Color.FromArgb(50, 50, 50));

            for (int i = 0; i < _duLieuDichVu.Count; i++)
            {
                var item = _duLieuDichVu[i];
                float sweepAngle = (float)((item.DoanhThu / totalDV) * 360m);
                Color c = colors[i % colors.Length];

                using (SolidBrush sliceBrush = new SolidBrush(c))
                {
                    g.FillPie(sliceBrush, pieRect, startAngle, sweepAngle);
                }

                if (legendY + 22 < h)
                {
                    using (SolidBrush boxBrush = new SolidBrush(c))
                    {
                        g.FillRectangle(boxBrush, legendX, legendY + 2, 12, 12);
                    }

                    double pct = (double)(item.DoanhThu / totalDV * 100);
                    string legendText = $"{item.TenDichVu} ({pct:0.0}%)";
                    g.DrawString(legendText, legendFont, textBrush, legendX + 18, legendY);
                    legendY += 24;
                }

                startAngle += sweepAngle;
            }

            int innerD = diameter / 2;
            Rectangle innerRect = new Rectangle(pieRect.X + (diameter - innerD) / 2, pieRect.Y + (diameter - innerD) / 2, innerD, innerD);
            using (SolidBrush centerBrush = new SolidBrush(Color.White))
            {
                g.FillEllipse(centerBrush, innerRect);
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (_duLieuChiTiet.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Xuất báo cáo thống kê";
            saveDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            saveDialog.FileName = "BaoCaoThongKe_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";

            if (saveDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                using var workbook = new XLWorkbook();
                var ws = workbook.Worksheets.Add("Thống kê doanh thu");

                ws.Cell("A1").Value = "BÁO CÁO THỐNG KÊ KINH DOANH";
                ws.Cell("A1").Style.Font.Bold = true;
                ws.Cell("A1").Style.Font.FontSize = 16;
                ws.Range("A1:H1").Merge();

                ws.Cell("A2").Value = $"Từ ngày: {dtpTuNgay.Value:dd/MM/yyyy} - Đến ngày: {dtpDenNgay.Value:dd/MM/yyyy}";
                ws.Range("A2:H2").Merge();

                ws.Cell("A4").Value = "Doanh thu phòng:";
                ws.Cell("B4").Value = lbTienPhong.Text;
                ws.Cell("D4").Value = "Doanh thu dịch vụ:";
                ws.Cell("E4").Value = lbTienDichVu.Text;

                ws.Cell("A5").Value = "Tổng doanh thu:";
                ws.Cell("B5").Value = lbTongDoanhThu.Text;
                ws.Cell("D5").Value = "Lượt thuê:";
                ws.Cell("E5").Value = lbSoPhongThue.Text;

                string[] headers = { "Mã HD", "Ngày lập", "Khách hàng", "Phòng", "Loại phòng", "Tiền phòng", "Tiền dịch vụ", "Tổng tiền" };
                for (int i = 0; i < headers.Length; i++)
                {
                    var c = ws.Cell(7, i + 1);
                    c.Value = headers[i];
                    c.Style.Font.Bold = true;
                    c.Style.Fill.BackgroundColor = XLColor.LightSteelBlue;
                }

                int row = 8;
                foreach (var d in _duLieuChiTiet)
                {
                    ws.Cell(row, 1).Value = d.MaHD;
                    ws.Cell(row, 2).Value = d.NgayLap;
                    ws.Cell(row, 2).Style.DateFormat.Format = "dd/MM/yyyy";
                    ws.Cell(row, 3).Value = d.TenKH;
                    ws.Cell(row, 4).Value = d.MaPhong;
                    ws.Cell(row, 5).Value = d.TenLoaiPhong;

                    ws.Cell(row, 6).Value = d.TienPhong;
                    ws.Cell(row, 6).Style.NumberFormat.Format = "#,##0";

                    ws.Cell(row, 7).Value = d.TienDichVu;
                    ws.Cell(row, 7).Style.NumberFormat.Format = "#,##0";

                    ws.Cell(row, 8).Value = d.TongTien;
                    ws.Cell(row, 8).Style.NumberFormat.Format = "#,##0";

                    row++;
                }

                ws.Columns().AdjustToContents();
                workbook.SaveAs(saveDialog.FileName);

                DialogResult moFile = MessageBox.Show(
                    "Xuất báo cáo thành công!\nBạn có muốn mở file vừa xuất không?",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (moFile == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(saveDialog.FileName)
                    {
                        UseShellExecute = true
                    });
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Không thể ghi file. Có thể file đang được mở trong Excel.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất Excel: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
