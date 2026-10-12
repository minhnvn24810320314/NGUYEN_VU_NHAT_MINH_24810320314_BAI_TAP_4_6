namespace NGUYEN_VU_NHAT_MINH_24810320314_BAI_TAP_4_6
{
    partial class Form1
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
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtTuoi = new System.Windows.Forms.TextBox();
            this.lblTuoi = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnXuatCSV = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();

            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.grpChucNang.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();

            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.btnChonAnh);
            this.grpThongTin.Controls.Add(this.picAvatar);
            this.grpThongTin.Controls.Add(this.cboGioiTinh);
            this.grpThongTin.Controls.Add(this.lblGioiTinh);
            this.grpThongTin.Controls.Add(this.txtTuoi);
            this.grpThongTin.Controls.Add(this.lblTuoi);
            this.grpThongTin.Controls.Add(this.txtHoTen);
            this.grpThongTin.Controls.Add(this.lblHoTen);
            this.grpThongTin.Controls.Add(this.txtMaSV);
            this.grpThongTin.Controls.Add(this.lblMaSV);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.Location = new System.Drawing.Point(12, 12);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(350, 260);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin sinh viên";

            // lblMaSV & txtMaSV
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaSV.Location = new System.Drawing.Point(15, 30);
            this.lblMaSV.Text = "Mã sinh viên:";
            this.txtMaSV.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMaSV.Location = new System.Drawing.Point(100, 25);
            this.txtMaSV.Size = new System.Drawing.Size(110, 24);

            // lblHoTen & txtHoTen
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHoTen.Location = new System.Drawing.Point(15, 70);
            this.lblHoTen.Text = "Họ và tên:";
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtHoTen.Location = new System.Drawing.Point(100, 65);
            this.txtHoTen.Size = new System.Drawing.Size(110, 24);

            // lblTuoi & txtTuoi
            this.lblTuoi.AutoSize = true;
            this.lblTuoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTuoi.Location = new System.Drawing.Point(15, 110);
            this.lblTuoi.Text = "Tuổi:";
            this.txtTuoi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTuoi.Location = new System.Drawing.Point(100, 105);
            this.txtTuoi.Size = new System.Drawing.Size(110, 24);

            // lblGioiTinh & cboGioiTinh
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGioiTinh.Location = new System.Drawing.Point(15, 150);
            this.lblGioiTinh.Text = "Giới tính:";
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            this.cboGioiTinh.Location = new System.Drawing.Point(100, 145);
            this.cboGioiTinh.Size = new System.Drawing.Size(110, 25);

            // picAvatar & btnChonAnh
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Location = new System.Drawing.Point(225, 25);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(110, 145);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabStop = false;

            this.btnChonAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnChonAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonAnh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnChonAnh.ForeColor = System.Drawing.Color.White;
            this.btnChonAnh.Location = new System.Drawing.Point(225, 180);
            this.btnChonAnh.Size = new System.Drawing.Size(110, 30);
            this.btnChonAnh.Text = "Chọn ảnh...";
            this.btnChonAnh.UseVisualStyleBackColor = false;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);

            // 
            // grpChucNang
            // 
            this.grpChucNang.Controls.Add(this.btnXuatCSV);
            this.grpChucNang.Controls.Add(this.btnXoa);
            this.grpChucNang.Controls.Add(this.btnCapNhat);
            this.grpChucNang.Controls.Add(this.btnThem);
            this.grpChucNang.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpChucNang.Location = new System.Drawing.Point(12, 280);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(350, 155);
            this.grpChucNang.TabIndex = 1;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Thao tác chức năng";

            // btnThem
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(15, 30);
            this.btnThem.Size = new System.Drawing.Size(150, 35);
            this.btnThem.Text = "Thêm Sinh Viên";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // btnCapNhat
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhat.Location = new System.Drawing.Point(185, 30);
            this.btnCapNhat.Size = new System.Drawing.Size(150, 35);
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);

            // btnXoa
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(15, 80);
            this.btnXoa.Size = new System.Drawing.Size(150, 35);
            this.btnXoa.Text = "Xóa Sinh Viên";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // btnXuatCSV
            this.btnXuatCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnXuatCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatCSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXuatCSV.ForeColor = System.Drawing.Color.White;
            this.btnXuatCSV.Location = new System.Drawing.Point(185, 80);
            this.btnXuatCSV.Size = new System.Drawing.Size(150, 35);
            this.btnXuatCSV.Text = "Xuất File CSV";
            this.btnXuatCSV.UseVisualStyleBackColor = false;
            this.btnXuatCSV.Click += new System.EventHandler(this.btnXuatCSV_Click);

            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.dgvStudents);
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpDanhSach.Location = new System.Drawing.Point(375, 12);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(510, 423);
            this.grpDanhSach.TabIndex = 2;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách sinh viên (Data Binding 2 chiều)";

            // dgvStudents
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudents.Location = new System.Drawing.Point(3, 20);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(504, 400);
            this.dgvStudents.TabIndex = 0;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(897, 447);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.grpThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Sinh viên với BindingSource & File CSV - NGUYỄN VŨ NHẬT MINH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.grpChucNang.ResumeLayout(false);
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblTuoi;
        private System.Windows.Forms.TextBox txtTuoi;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXuatCSV;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvStudents;
    }
}