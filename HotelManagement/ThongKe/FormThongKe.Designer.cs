namespace HotelManagement.ThongKe
{
    partial class FormThongKe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            btnXuatExcel = new Button();
            btnThongKe = new Button();
            dtpDenNgay = new DateTimePicker();
            label2 = new Label();
            dtpTuNgay = new DateTimePicker();
            label1 = new Label();
            pnlCards = new TableLayoutPanel();
            card1 = new Panel();
            lbTienPhong = new Label();
            lbTitle1 = new Label();
            card2 = new Panel();
            lbTienDichVu = new Label();
            lbTitle2 = new Label();
            card3 = new Panel();
            lbTongDoanhThu = new Label();
            lbTitle3 = new Label();
            card4 = new Panel();
            lbSoPhongThue = new Label();
            lbTitle4 = new Label();
            pnlHighlights = new Panel();
            lbTopKhachHang = new Label();
            lbTopDichVu = new Label();
            lbTopLoaiPhong = new Label();
            label3 = new Label();
            pnlCharts = new TableLayoutPanel();
            picChartLoaiPhong = new PictureBox();
            picChartDichVu = new PictureBox();
            dtgChiTiet = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlCards.SuspendLayout();
            card1.SuspendLayout();
            card2.SuspendLayout();
            card3.SuspendLayout();
            card4.SuspendLayout();
            pnlHighlights.SuspendLayout();
            pnlCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picChartLoaiPhong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChartDichVu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgChiTiet).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(btnXuatExcel);
            pnlHeader.Controls.Add(btnThongKe);
            pnlHeader.Controls.Add(dtpDenNgay);
            pnlHeader.Controls.Add(label2);
            pnlHeader.Controls.Add(dtpTuNgay);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1150, 60);
            pnlHeader.TabIndex = 0;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.DarkTurquoise;
            btnXuatExcel.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnXuatExcel.ForeColor = Color.White;
            btnXuatExcel.Location = new Point(780, 12);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(130, 36);
            btnXuatExcel.TabIndex = 5;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.SteelBlue;
            btnThongKe.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.Location = new Point(640, 12);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(125, 36);
            btnThongKe.TabIndex = 4;
            btnThongKe.Text = "Xem thống kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Font = new Font("Segoe UI", 11F);
            dtpDenNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Location = new Point(445, 15);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(160, 32);
            dtpDenNgay.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.Location = new Point(345, 18);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 2;
            label2.Text = "Đến ngày:";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Font = new Font("Segoe UI", 11F);
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpTuNgay.Location = new Point(160, 15);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(160, 32);
            dtpTuNgay.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label1.Location = new Point(20, 18);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 0;
            label1.Text = "Thống kê từ:";
            // 
            // pnlCards
            // 
            pnlCards.ColumnCount = 4;
            pnlCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlCards.Controls.Add(card1, 0, 0);
            pnlCards.Controls.Add(card2, 1, 0);
            pnlCards.Controls.Add(card3, 2, 0);
            pnlCards.Controls.Add(card4, 3, 0);
            pnlCards.Dock = DockStyle.Top;
            pnlCards.Location = new Point(0, 60);
            pnlCards.Name = "pnlCards";
            pnlCards.RowCount = 1;
            pnlCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlCards.Size = new Size(1150, 100);
            pnlCards.TabIndex = 1;
            // 
            // card1
            // 
            card1.BackColor = Color.FromArgb(70, 130, 180);
            card1.Controls.Add(lbTienPhong);
            card1.Controls.Add(lbTitle1);
            card1.Dock = DockStyle.Fill;
            card1.Location = new Point(10, 10);
            card1.Margin = new Padding(10);
            card1.Name = "card1";
            card1.Size = new Size(267, 80);
            card1.TabIndex = 0;
            // 
            // lbTienPhong
            // 
            lbTienPhong.Dock = DockStyle.Fill;
            lbTienPhong.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTienPhong.ForeColor = Color.White;
            lbTienPhong.Location = new Point(0, 30);
            lbTienPhong.Name = "lbTienPhong";
            lbTienPhong.Size = new Size(267, 50);
            lbTienPhong.TabIndex = 1;
            lbTienPhong.Text = "0 VND";
            lbTienPhong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbTitle1
            // 
            lbTitle1.Dock = DockStyle.Top;
            lbTitle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbTitle1.ForeColor = Color.WhiteSmoke;
            lbTitle1.Location = new Point(0, 0);
            lbTitle1.Name = "lbTitle1";
            lbTitle1.Size = new Size(267, 30);
            lbTitle1.TabIndex = 0;
            lbTitle1.Text = "DOANH THU PHÒNG";
            lbTitle1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // card2
            // 
            card2.BackColor = Color.FromArgb(46, 139, 87);
            card2.Controls.Add(lbTienDichVu);
            card2.Controls.Add(lbTitle2);
            card2.Dock = DockStyle.Fill;
            card2.Location = new Point(297, 10);
            card2.Margin = new Padding(10);
            card2.Name = "card2";
            card2.Size = new Size(267, 80);
            card2.TabIndex = 1;
            // 
            // lbTienDichVu
            // 
            lbTienDichVu.Dock = DockStyle.Fill;
            lbTienDichVu.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTienDichVu.ForeColor = Color.White;
            lbTienDichVu.Location = new Point(0, 30);
            lbTienDichVu.Name = "lbTienDichVu";
            lbTienDichVu.Size = new Size(267, 50);
            lbTienDichVu.TabIndex = 1;
            lbTienDichVu.Text = "0 VND";
            lbTienDichVu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbTitle2
            // 
            lbTitle2.Dock = DockStyle.Top;
            lbTitle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbTitle2.ForeColor = Color.WhiteSmoke;
            lbTitle2.Location = new Point(0, 0);
            lbTitle2.Name = "lbTitle2";
            lbTitle2.Size = new Size(267, 30);
            lbTitle2.TabIndex = 0;
            lbTitle2.Text = "DOANH THU DỊCH VỤ";
            lbTitle2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // card3
            // 
            card3.BackColor = Color.FromArgb(218, 112, 214);
            card3.Controls.Add(lbTongDoanhThu);
            card3.Controls.Add(lbTitle3);
            card3.Dock = DockStyle.Fill;
            card3.Location = new Point(584, 10);
            card3.Margin = new Padding(10);
            card3.Name = "card3";
            card3.Size = new Size(267, 80);
            card3.TabIndex = 2;
            // 
            // lbTongDoanhThu
            // 
            lbTongDoanhThu.Dock = DockStyle.Fill;
            lbTongDoanhThu.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTongDoanhThu.ForeColor = Color.White;
            lbTongDoanhThu.Location = new Point(0, 30);
            lbTongDoanhThu.Name = "lbTongDoanhThu";
            lbTongDoanhThu.Size = new Size(267, 50);
            lbTongDoanhThu.TabIndex = 1;
            lbTongDoanhThu.Text = "0 VND";
            lbTongDoanhThu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbTitle3
            // 
            lbTitle3.Dock = DockStyle.Top;
            lbTitle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbTitle3.ForeColor = Color.WhiteSmoke;
            lbTitle3.Location = new Point(0, 0);
            lbTitle3.Name = "lbTitle3";
            lbTitle3.Size = new Size(267, 30);
            lbTitle3.TabIndex = 0;
            lbTitle3.Text = "TỔNG DOANH THU";
            lbTitle3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // card4
            // 
            card4.BackColor = Color.FromArgb(238, 118, 0);
            card4.Controls.Add(lbSoPhongThue);
            card4.Controls.Add(lbTitle4);
            card4.Dock = DockStyle.Fill;
            card4.Location = new Point(871, 10);
            card4.Margin = new Padding(10);
            card4.Name = "card4";
            card4.Size = new Size(269, 80);
            card4.TabIndex = 3;
            // 
            // lbSoPhongThue
            // 
            lbSoPhongThue.Dock = DockStyle.Fill;
            lbSoPhongThue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbSoPhongThue.ForeColor = Color.White;
            lbSoPhongThue.Location = new Point(0, 30);
            lbSoPhongThue.Name = "lbSoPhongThue";
            lbSoPhongThue.Size = new Size(269, 50);
            lbSoPhongThue.TabIndex = 1;
            lbSoPhongThue.Text = "0 lượt";
            lbSoPhongThue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbTitle4
            // 
            lbTitle4.Dock = DockStyle.Top;
            lbTitle4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbTitle4.ForeColor = Color.WhiteSmoke;
            lbTitle4.Location = new Point(0, 0);
            lbTitle4.Name = "lbTitle4";
            lbTitle4.Size = new Size(269, 30);
            lbTitle4.TabIndex = 0;
            lbTitle4.Text = "LƯỢT THUÊ PHÒNG";
            lbTitle4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlHighlights
            // 
            pnlHighlights.BackColor = Color.FromArgb(245, 248, 250);
            pnlHighlights.Controls.Add(lbTopKhachHang);
            pnlHighlights.Controls.Add(lbTopDichVu);
            pnlHighlights.Controls.Add(lbTopLoaiPhong);
            pnlHighlights.Controls.Add(label3);
            pnlHighlights.Dock = DockStyle.Top;
            pnlHighlights.Location = new Point(0, 160);
            pnlHighlights.Name = "pnlHighlights";
            pnlHighlights.Size = new Size(1150, 48);
            pnlHighlights.TabIndex = 2;
            // 
            // lbTopKhachHang
            // 
            lbTopKhachHang.AutoSize = true;
            lbTopKhachHang.Font = new Font("Segoe UI", 10F);
            lbTopKhachHang.ForeColor = Color.FromArgb(60, 60, 60);
            lbTopKhachHang.Location = new Point(800, 13);
            lbTopKhachHang.Name = "lbTopKhachHang";
            lbTopKhachHang.Size = new Size(164, 23);
            lbTopKhachHang.TabIndex = 3;
            lbTopKhachHang.Text = "Top KH: Chưa có";
            // 
            // lbTopDichVu
            // 
            lbTopDichVu.AutoSize = true;
            lbTopDichVu.Font = new Font("Segoe UI", 10F);
            lbTopDichVu.ForeColor = Color.FromArgb(60, 60, 60);
            lbTopDichVu.Location = new Point(480, 13);
            lbTopDichVu.Name = "lbTopDichVu";
            lbTopDichVu.Size = new Size(183, 23);
            lbTopDichVu.TabIndex = 2;
            lbTopDichVu.Text = "Top dịch vụ: Chưa có";
            // 
            // lbTopLoaiPhong
            // 
            lbTopLoaiPhong.AutoSize = true;
            lbTopLoaiPhong.Font = new Font("Segoe UI", 10F);
            lbTopLoaiPhong.ForeColor = Color.FromArgb(60, 60, 60);
            lbTopLoaiPhong.Location = new Point(160, 13);
            lbTopLoaiPhong.Name = "lbTopLoaiPhong";
            lbTopLoaiPhong.Size = new Size(213, 23);
            lbTopLoaiPhong.TabIndex = 1;
            lbTopLoaiPhong.Text = "Top loại phòng: Chưa có";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.ForeColor = Color.DarkSlateBlue;
            label3.Location = new Point(20, 13);
            label3.Name = "label3";
            label3.Size = new Size(95, 23);
            label3.TabIndex = 0;
            label3.Text = "XẾP HẠNG:";
            // 
            // pnlCharts
            // 
            pnlCharts.ColumnCount = 2;
            pnlCharts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            pnlCharts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            pnlCharts.Controls.Add(picChartLoaiPhong, 0, 0);
            pnlCharts.Controls.Add(picChartDichVu, 1, 0);
            pnlCharts.Dock = DockStyle.Top;
            pnlCharts.Location = new Point(0, 208);
            pnlCharts.Name = "pnlCharts";
            pnlCharts.RowCount = 1;
            pnlCharts.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlCharts.Size = new Size(1150, 310);
            pnlCharts.TabIndex = 3;
            // 
            // picChartLoaiPhong
            // 
            picChartLoaiPhong.BackColor = Color.White;
            picChartLoaiPhong.Dock = DockStyle.Fill;
            picChartLoaiPhong.Location = new Point(10, 10);
            picChartLoaiPhong.Margin = new Padding(10);
            picChartLoaiPhong.Name = "picChartLoaiPhong";
            picChartLoaiPhong.Size = new Size(612, 290);
            picChartLoaiPhong.TabIndex = 0;
            picChartLoaiPhong.TabStop = false;
            picChartLoaiPhong.Paint += picChartLoaiPhong_Paint;
            // 
            // picChartDichVu
            // 
            picChartDichVu.BackColor = Color.White;
            picChartDichVu.Dock = DockStyle.Fill;
            picChartDichVu.Location = new Point(642, 10);
            picChartDichVu.Margin = new Padding(10);
            picChartDichVu.Name = "picChartDichVu";
            picChartDichVu.Size = new Size(498, 290);
            picChartDichVu.TabIndex = 1;
            picChartDichVu.TabStop = false;
            picChartDichVu.Paint += picChartDichVu_Paint;
            // 
            // dtgChiTiet
            // 
            dtgChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgChiTiet.Dock = DockStyle.Fill;
            dtgChiTiet.Location = new Point(0, 518);
            dtgChiTiet.Name = "dtgChiTiet";
            dtgChiTiet.RowHeadersWidth = 51;
            dtgChiTiet.Size = new Size(1150, 332);
            dtgChiTiet.TabIndex = 4;
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 850);
            Controls.Add(dtgChiTiet);
            Controls.Add(pnlCharts);
            Controls.Add(pnlHighlights);
            Controls.Add(pnlCards);
            Controls.Add(pnlHeader);
            Name = "FormThongKe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Báo cáo thống kê tình hình kinh doanh";
            Load += FormThongKe_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlCards.ResumeLayout(false);
            card1.ResumeLayout(false);
            card2.ResumeLayout(false);
            card3.ResumeLayout(false);
            card4.ResumeLayout(false);
            pnlHighlights.ResumeLayout(false);
            pnlHighlights.PerformLayout();
            pnlCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picChartLoaiPhong).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChartDichVu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgChiTiet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label label1;
        private DateTimePicker dtpTuNgay;
        private Label label2;
        private DateTimePicker dtpDenNgay;
        private Button btnThongKe;
        private Button btnXuatExcel;
        private TableLayoutPanel pnlCards;
        private Panel card1;
        private Label lbTitle1;
        private Label lbTienPhong;
        private Panel card2;
        private Label lbTitle2;
        private Label lbTienDichVu;
        private Panel card3;
        private Label lbTitle3;
        private Label lbTongDoanhThu;
        private Panel card4;
        private Label lbTitle4;
        private Label lbSoPhongThue;
        private Panel pnlHighlights;
        private Label label3;
        private Label lbTopLoaiPhong;
        private Label lbTopDichVu;
        private Label lbTopKhachHang;
        private TableLayoutPanel pnlCharts;
        private PictureBox picChartLoaiPhong;
        private PictureBox picChartDichVu;
        private DataGridView dtgChiTiet;
    }
}
