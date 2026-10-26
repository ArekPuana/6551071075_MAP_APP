namespace HotelManagement.SoDoPhong
{
    partial class FormSoDoPhong
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panel4 = new Panel();
            rdbTatCaPhong = new RadioButton();
            rdbPhongChuaDon = new RadioButton();
            rdbPhongDaDonDep = new RadioButton();
            label2 = new Label();
            panel3 = new Panel();
            rdbTatCaLoaiPhong = new RadioButton();
            rdbPhongVipDoi = new RadioButton();
            rdbPhongVipDon = new RadioButton();
            rdbPhongThuongDoi = new RadioButton();
            rdbPhongThuongDon = new RadioButton();
            label1 = new Label();
            panel2 = new Panel();
            rdbTatCaTrangThaiPhong = new RadioButton();
            rdbPhongDangSuaChua = new RadioButton();
            rdbPhongDangThue = new RadioButton();
            rdbPhongDaDat = new RadioButton();
            rdbPhongTrong = new RadioButton();
            LabelTrangThaiPhong = new Label();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            txtSearchMaPhong = new TextBox();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            dtNgayChon = new DateTimePicker();
            toolTip1 = new ToolTip(components);
            btnDatPhong = new Button();
            dataGridViewPhong = new DataGridView();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPhong).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(245, 250, 245);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 750);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(rdbTatCaPhong);
            panel4.Controls.Add(rdbPhongChuaDon);
            panel4.Controls.Add(rdbPhongDaDonDep);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 480);
            panel4.Name = "panel4";
            panel4.Size = new Size(268, 180);
            panel4.TabIndex = 8;
            // 
            // rdbTatCaPhong
            // 
            rdbTatCaPhong.AutoSize = true;
            rdbTatCaPhong.Location = new Point(15, 135);
            rdbTatCaPhong.Name = "rdbTatCaPhong";
            rdbTatCaPhong.Size = new Size(83, 28);
            rdbTatCaPhong.TabIndex = 4;
            rdbTatCaPhong.TabStop = true;
            rdbTatCaPhong.Text = "Tất cả";
            rdbTatCaPhong.UseVisualStyleBackColor = true;
            rdbTatCaPhong.CheckedChanged += rdbTatCaPhong_CheckedChanged;
            // 
            // rdbPhongChuaDon
            // 
            rdbPhongChuaDon.AutoSize = true;
            rdbPhongChuaDon.Location = new Point(15, 95);
            rdbPhongChuaDon.Name = "rdbPhongChuaDon";
            rdbPhongChuaDon.Size = new Size(149, 28);
            rdbPhongChuaDon.TabIndex = 3;
            rdbPhongChuaDon.TabStop = true;
            rdbPhongChuaDon.Text = "Chưa dọn dẹp";
            rdbPhongChuaDon.UseVisualStyleBackColor = true;
            rdbPhongChuaDon.CheckedChanged += rdbPhongChuaDon_CheckedChanged;
            // 
            // rdbPhongDaDonDep
            // 
            rdbPhongDaDonDep.AutoSize = true;
            rdbPhongDaDonDep.Location = new Point(15, 55);
            rdbPhongDaDonDep.Name = "rdbPhongDaDonDep";
            rdbPhongDaDonDep.Size = new Size(130, 28);
            rdbPhongDaDonDep.TabIndex = 2;
            rdbPhongDaDonDep.TabStop = true;
            rdbPhongDaDonDep.Text = "Đã dọn dẹp";
            rdbPhongDaDonDep.UseVisualStyleBackColor = true;
            rdbPhongDaDonDep.CheckedChanged += rdbPhongDaDonDep_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(12, 14);
            label2.Name = "label2";
            label2.Size = new Size(196, 28);
            label2.TabIndex = 1;
            label2.Text = "Tình trạng dọn dẹp";
            // 
            // panel3
            // 
            panel3.Controls.Add(rdbTatCaLoaiPhong);
            panel3.Controls.Add(rdbPhongVipDoi);
            panel3.Controls.Add(rdbPhongVipDon);
            panel3.Controls.Add(rdbPhongThuongDoi);
            panel3.Controls.Add(rdbPhongThuongDon);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 240);
            panel3.Name = "panel3";
            panel3.Size = new Size(268, 240);
            panel3.TabIndex = 7;
            // 
            // rdbTatCaLoaiPhong
            // 
            rdbTatCaLoaiPhong.AutoSize = true;
            rdbTatCaLoaiPhong.Location = new Point(15, 195);
            rdbTatCaLoaiPhong.Name = "rdbTatCaLoaiPhong";
            rdbTatCaLoaiPhong.Size = new Size(140, 28);
            rdbTatCaLoaiPhong.TabIndex = 7;
            rdbTatCaLoaiPhong.TabStop = true;
            rdbTatCaLoaiPhong.Text = "Tất cả phòng";
            rdbTatCaLoaiPhong.UseVisualStyleBackColor = true;
            rdbTatCaLoaiPhong.CheckedChanged += rdbTatCaLoaiPhong_CheckedChanged;
            // 
            // rdbPhongVipDoi
            // 
            rdbPhongVipDoi.AutoSize = true;
            rdbPhongVipDoi.Location = new Point(15, 160);
            rdbPhongVipDoi.Name = "rdbPhongVipDoi";
            rdbPhongVipDoi.Size = new Size(150, 28);
            rdbPhongVipDoi.TabIndex = 5;
            rdbPhongVipDoi.TabStop = true;
            rdbPhongVipDoi.Text = "Phòng VIP đôi";
            rdbPhongVipDoi.UseVisualStyleBackColor = true;
            rdbPhongVipDoi.CheckedChanged += rdbPhongVipDoi_CheckedChanged;
            // 
            // rdbPhongVipDon
            // 
            rdbPhongVipDon.AutoSize = true;
            rdbPhongVipDon.Location = new Point(15, 125);
            rdbPhongVipDon.Name = "rdbPhongVipDon";
            rdbPhongVipDon.Size = new Size(157, 28);
            rdbPhongVipDon.TabIndex = 4;
            rdbPhongVipDon.TabStop = true;
            rdbPhongVipDon.Text = "Phòng VIP đơn";
            rdbPhongVipDon.UseVisualStyleBackColor = true;
            rdbPhongVipDon.CheckedChanged += rdbPhongVipDon_CheckedChanged;
            // 
            // rdbPhongThuongDoi
            // 
            rdbPhongThuongDoi.AutoSize = true;
            rdbPhongThuongDoi.Location = new Point(15, 90);
            rdbPhongThuongDoi.Name = "rdbPhongThuongDoi";
            rdbPhongThuongDoi.Size = new Size(181, 28);
            rdbPhongThuongDoi.TabIndex = 3;
            rdbPhongThuongDoi.TabStop = true;
            rdbPhongThuongDoi.Text = "Phòng thường đôi";
            rdbPhongThuongDoi.UseVisualStyleBackColor = true;
            rdbPhongThuongDoi.CheckedChanged += rdbPhongThuongDoi_CheckedChanged;
            // 
            // rdbPhongThuongDon
            // 
            rdbPhongThuongDon.AutoSize = true;
            rdbPhongThuongDon.Location = new Point(15, 55);
            rdbPhongThuongDon.Name = "rdbPhongThuongDon";
            rdbPhongThuongDon.Size = new Size(188, 28);
            rdbPhongThuongDon.TabIndex = 2;
            rdbPhongThuongDon.TabStop = true;
            rdbPhongThuongDon.Text = "Phòng thường đơn";
            rdbPhongThuongDon.UseVisualStyleBackColor = true;
            rdbPhongThuongDon.CheckedChanged += rdbPhongThuongDon_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(119, 28);
            label1.TabIndex = 1;
            label1.Text = "Loại phòng";
            // 
            // panel2
            // 
            panel2.Controls.Add(rdbTatCaTrangThaiPhong);
            panel2.Controls.Add(rdbPhongDangSuaChua);
            panel2.Controls.Add(rdbPhongDangThue);
            panel2.Controls.Add(rdbPhongDaDat);
            panel2.Controls.Add(rdbPhongTrong);
            panel2.Controls.Add(LabelTrangThaiPhong);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(268, 240);
            panel2.TabIndex = 1;
            // 
            // rdbTatCaTrangThaiPhong
            // 
            rdbTatCaTrangThaiPhong.AutoSize = true;
            rdbTatCaTrangThaiPhong.Location = new Point(15, 195);
            rdbTatCaTrangThaiPhong.Name = "rdbTatCaTrangThaiPhong";
            rdbTatCaTrangThaiPhong.Size = new Size(140, 28);
            rdbTatCaTrangThaiPhong.TabIndex = 6;
            rdbTatCaTrangThaiPhong.TabStop = true;
            rdbTatCaTrangThaiPhong.Text = "Tất cả phòng";
            rdbTatCaTrangThaiPhong.UseVisualStyleBackColor = true;
            rdbTatCaTrangThaiPhong.CheckedChanged += rdbTatCaTrangThaiPhong_CheckedChanged;
            // 
            // rdbPhongDangSuaChua
            // 
            rdbPhongDangSuaChua.AutoSize = true;
            rdbPhongDangSuaChua.Location = new Point(15, 160);
            rdbPhongDangSuaChua.Name = "rdbPhongDangSuaChua";
            rdbPhongDangSuaChua.Size = new Size(215, 28);
            rdbPhongDangSuaChua.TabIndex = 5;
            rdbPhongDangSuaChua.TabStop = true;
            rdbPhongDangSuaChua.Text = "Phòng đang sửa chữa";
            rdbPhongDangSuaChua.UseVisualStyleBackColor = true;
            rdbPhongDangSuaChua.CheckedChanged += rdbPhongDangSuaChua_CheckedChanged;
            // 
            // rdbPhongDangThue
            // 
            rdbPhongDangThue.AutoSize = true;
            rdbPhongDangThue.Location = new Point(15, 125);
            rdbPhongDangThue.Name = "rdbPhongDangThue";
            rdbPhongDangThue.Size = new Size(174, 28);
            rdbPhongDangThue.TabIndex = 4;
            rdbPhongDangThue.TabStop = true;
            rdbPhongDangThue.Text = "Phòng đang thuê";
            rdbPhongDangThue.UseVisualStyleBackColor = true;
            rdbPhongDangThue.CheckedChanged += rdbPhongDangThue_CheckedChanged;
            // 
            // rdbPhongDaDat
            // 
            rdbPhongDaDat.AutoSize = true;
            rdbPhongDaDat.Location = new Point(15, 90);
            rdbPhongDaDat.Name = "rdbPhongDaDat";
            rdbPhongDaDat.Size = new Size(143, 28);
            rdbPhongDaDat.TabIndex = 3;
            rdbPhongDaDat.TabStop = true;
            rdbPhongDaDat.Text = "Phòng đã đặt";
            rdbPhongDaDat.UseVisualStyleBackColor = true;
            rdbPhongDaDat.CheckedChanged += rdbPhongDaDat_CheckedChanged;
            // 
            // rdbPhongTrong
            // 
            rdbPhongTrong.AutoSize = true;
            rdbPhongTrong.Location = new Point(15, 55);
            rdbPhongTrong.Name = "rdbPhongTrong";
            rdbPhongTrong.Size = new Size(133, 28);
            rdbPhongTrong.TabIndex = 2;
            rdbPhongTrong.TabStop = true;
            rdbPhongTrong.Text = "Phòng trống";
            rdbPhongTrong.UseVisualStyleBackColor = true;
            rdbPhongTrong.CheckedChanged += rdbPhongTrong_CheckedChanged;
            // 
            // LabelTrangThaiPhong
            // 
            LabelTrangThaiPhong.AutoSize = true;
            LabelTrangThaiPhong.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelTrangThaiPhong.ForeColor = Color.DarkSlateGray;
            LabelTrangThaiPhong.Location = new Point(12, 14);
            LabelTrangThaiPhong.Name = "LabelTrangThaiPhong";
            LabelTrangThaiPhong.Size = new Size(176, 28);
            LabelTrangThaiPhong.TabIndex = 1;
            LabelTrangThaiPhong.Text = "Trạng thái phòng";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(pictureBox1);
            panel5.Controls.Add(txtSearchMaPhong);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(dateTimePicker2);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(dtNgayChon);
            panel5.Controls.Add(btnDatPhong);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(270, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(870, 70);
            panel5.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(460, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // txtSearchMaPhong
            // 
            txtSearchMaPhong.Font = new Font("Segoe UI", 10F);
            txtSearchMaPhong.Location = new Point(496, 20);
            txtSearchMaPhong.Name = "txtSearchMaPhong";
            txtSearchMaPhong.PlaceholderText = "Nhập mã phòng...";
            txtSearchMaPhong.Size = new Size(150, 30);
            txtSearchMaPhong.TabIndex = 4;
            txtSearchMaPhong.TextChanged += txtSearchMaPhong_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(245, 8);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "Chọn giờ";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.Font = new Font("Segoe UI", 10F);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(245, 30);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(100, 30);
            dateTimePicker2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(15, 8);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 1;
            label3.Text = "Chọn ngày";
            // 
            // dtNgayChon
            // 
            dtNgayChon.Font = new Font("Segoe UI", 10F);
            dtNgayChon.Format = DateTimePickerFormat.Short;
            dtNgayChon.Location = new Point(15, 30);
            dtNgayChon.Name = "dtNgayChon";
            dtNgayChon.Size = new Size(200, 30);
            dtNgayChon.TabIndex = 0;
            dtNgayChon.ValueChanged += dtNgayChon_ValueChanged;
            // 
            // btnDatPhong
            // 
            btnDatPhong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDatPhong.BackColor = Color.SeaGreen;
            btnDatPhong.FlatAppearance.BorderSize = 0;
            btnDatPhong.FlatStyle = FlatStyle.Flat;
            btnDatPhong.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDatPhong.ForeColor = Color.White;
            btnDatPhong.Location = new Point(710, 15);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(140, 40);
            btnDatPhong.TabIndex = 3;
            btnDatPhong.Text = "Đặt phòng";
            btnDatPhong.UseVisualStyleBackColor = false;
            btnDatPhong.Click += btnDatPhong_Click;
            // 
            // dataGridViewPhong
            // 
            dataGridViewPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPhong.Dock = DockStyle.Fill;
            dataGridViewPhong.Location = new Point(270, 70);
            dataGridViewPhong.Name = "dataGridViewPhong";
            dataGridViewPhong.RowHeadersWidth = 51;
            dataGridViewPhong.RowTemplate.Height = 28;
            dataGridViewPhong.Size = new Size(870, 680);
            dataGridViewPhong.TabIndex = 4;
            // 
            // FormSoDoPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1140, 750);
            Controls.Add(dataGridViewPhong);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Name = "FormSoDoPhong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sơ đồ phòng";
            Load += FormSoDoPhong_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPhong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LabelTrangThaiPhong;
        private System.Windows.Forms.RadioButton rdbPhongDangSuaChua;
        private System.Windows.Forms.RadioButton rdbPhongDangThue;
        private System.Windows.Forms.RadioButton rdbPhongDaDat;
        private System.Windows.Forms.RadioButton rdbPhongTrong;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdbTatCaPhong;
        private System.Windows.Forms.RadioButton rdbPhongChuaDon;
        private System.Windows.Forms.RadioButton rdbPhongDaDonDep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdbPhongVipDoi;
        private System.Windows.Forms.RadioButton rdbPhongVipDon;
        private System.Windows.Forms.RadioButton rdbPhongThuongDoi;
        private System.Windows.Forms.RadioButton rdbPhongThuongDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbTatCaTrangThaiPhong;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearchMaPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtNgayChon;
        private System.Windows.Forms.RadioButton rdbTatCaLoaiPhong;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.DataGridView dataGridViewPhong;
    }
}
