using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NGUYEN_VU_NHAT_MINH_24810320314_BAI_TAP_4_6
{
    public partial class Form1 : Form
    {
        // 1. Khởi tạo BindingList và BindingSource làm trung gian Data Binding 2 chiều
        private BindingList<Student> studentList = new BindingList<Student>();
        private BindingSource studentBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboGioiTinh.SelectedIndex = 0;

            // Nạp dữ liệu mẫu ban đầu
            studentList.Add(new Student("SV01", "Nguyễn Vũ Nhật Minh", 20, "Nam", ""));
            studentList.Add(new Student("SV02", "Trần Thị Thu Hà", 19, "Nữ", ""));
            studentList.Add(new Student("SV03", "Lê Hoàng Nam", 21, "Nam", ""));

            // Gán BindingList vào BindingSource
            studentBindingSource.DataSource = studentList;

            // Gán BindingSource vào DataGridView
            dgvStudents.DataSource = studentBindingSource;

            // Thiết lập Data Binding 2 chiều
            ThietLapDataBinding2Chieu();

            // Cài đặt tiêu đề các cột trên DataGridView
            CaiDatTieuDeDgv();

            // Lắng nghe sự kiện chuyển dòng chọn trên BindingSource để hiển thị ảnh Avatar
            studentBindingSource.CurrentChanged += StudentBindingSource_CurrentChanged;
            StudentBindingSource_CurrentChanged(null, null);
        }

        // Cấu hình BindingSource 2 chiều qua phương thức DataBindings.Add
        private void ThietLapDataBinding2Chieu()
        {
            txtMaSV.DataBindings.Add("Text", studentBindingSource, "StudentId", true, DataSourceUpdateMode.OnPropertyChanged);
            txtHoTen.DataBindings.Add("Text", studentBindingSource, "FullName", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTuoi.DataBindings.Add("Text", studentBindingSource, "Age", true, DataSourceUpdateMode.OnPropertyChanged);
            cboGioiTinh.DataBindings.Add("SelectedItem", studentBindingSource, "Gender", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void CaiDatTieuDeDgv()
        {
            if (dgvStudents.Columns["StudentId"] != null) dgvStudents.Columns["StudentId"].HeaderText = "Mã SV";
            if (dgvStudents.Columns["FullName"] != null) dgvStudents.Columns["FullName"].HeaderText = "Họ và Tên";
            if (dgvStudents.Columns["Age"] != null) dgvStudents.Columns["Age"].HeaderText = "Tuổi";
            if (dgvStudents.Columns["Gender"] != null) dgvStudents.Columns["Gender"].HeaderText = "Giới tính";
            if (dgvStudents.Columns["AvatarPath"] != null) dgvStudents.Columns["AvatarPath"].HeaderText = "Đường dẫn ảnh";
        }

        // Tự động cập nhật PictureBox khi chọn dòng khác trên DataGridView
        private void StudentBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (studentBindingSource.Current is Student currentStudent)
            {
                HienThiAvatar(currentStudent.AvatarPath);
            }
            else
            {
                picAvatar.Image = null;
            }
        }

        private void HienThiAvatar(string path)
        {
            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                try
                {
                    picAvatar.Image = Image.FromFile(path);
                }
                catch
                {
                    picAvatar.Image = null;
                }
            }
            else
            {
                picAvatar.Image = null;
            }
        }

        // 2. Chọn file ảnh Avatar bằng OpenFileDialog
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            if (studentBindingSource.Current is Student currentStudent)
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "Chọn ảnh đại diện cho sinh viên";
                    ofd.Filter = "Tệp hình ảnh (*.jpg; *.png; *.bmp)|*.jpg;*.png;*.bmp|All Files (*.*)|*.*";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        currentStudent.AvatarPath = ofd.FileName;
                        HienThiAvatar(ofd.FileName);
                        studentBindingSource.ResetCurrentItem();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên trong danh sách trước khi gắn ảnh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 3. Nút THÊM SINH VIÊN
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();

            if (string.IsNullOrWhiteSpace(maSV))
            {
                MessageBox.Show("Vui lòng nhập Mã sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.Focus();
                return;
            }

            // Kiểm tra trùng Mã SV
            if (studentList.Any(s => s.StudentId.Equals(maSV, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã sinh viên này đã tồn tại trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int.TryParse(txtTuoi.Text.Trim(), out int tuoi);

            Student newStudent = new Student(
                maSV,
                txtHoTen.Text.Trim(),
                tuoi,
                cboGioiTinh.SelectedItem != null ? cboGioiTinh.SelectedItem.ToString() : "Nam",
                ""
            );

            studentList.Add(newStudent);
            studentBindingSource.MoveLast();

            MessageBox.Show($"Thêm thành công sinh viên [{newStudent.FullName}]!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 4. Nút CẤP NHẬT SINH VIÊN
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            studentBindingSource.EndEdit();
            studentBindingSource.ResetCurrentItem();
            MessageBox.Show("Đã cập nhật thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 5. Nút XÓA SINH VIÊN
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (studentBindingSource.Current is Student currentStudent)
            {
                DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa sinh viên [{currentStudent.FullName}] (Mã: {currentStudent.StudentId})?",
                                                  "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    studentBindingSource.RemoveCurrent();
                    MessageBox.Show("Đã xóa sinh viên khỏi danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Danh sách sinh viên đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 6. XUẤT FILE CSV BẰNG SAVEFILEDIALOG & STREAMWRITER (UTF-8)
        private void btnXuatCSV_Click(object sender, EventArgs e)
        {
            if (studentList.Count == 0)
            {
                MessageBox.Show("Danh sách sinh viên trống, không thể xuất file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Xuất danh sách sinh viên ra file CSV";
                sfd.Filter = "CSV File (*.csv)|*.csv|Text File (*.txt)|*.txt";
                sfd.FileName = $"DanhSachSinhVien_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                        {
                            sw.WriteLine("Mã SV,Họ và Tên,Tuổi,Giới tính,Đường dẫn Avatar");

                            foreach (var st in studentList)
                            {
                                string line = $"\"{st.StudentId}\",\"{st.FullName}\",{st.Age},\"{st.Gender}\",\"{st.AvatarPath}\"";
                                sw.WriteLine(line);
                            }
                        }

                        MessageBox.Show($"Xuất dữ liệu ra file CSV thành công!\nĐường dẫn: {sfd.FileName}",
                                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi ghi file: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}