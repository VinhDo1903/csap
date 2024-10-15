using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace btdc10_dịch_vụ_khám_chữa_răng_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnTinhtien.Enabled = false;
            txtTen.TextChanged += txtTen_TextChanged;
            chkCaovoi.CheckedChanged += chkCaovoi_CheckedChanged;
            chkTaytrang.CheckedChanged += chkTaytrang_CheckedChanged;
            chkChuphinhrang.CheckedChanged += chkChuphinhrang_CheckedChanged;
            numTramrang.ValueChanged += numTramrang_ValueChanged;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng chương trình không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtTen.Clear();
            txtTotal.Clear();
            chkCaovoi.Checked = false;
            chkChuphinhrang.Checked = false;
            chkTaytrang.Checked = false;
            numTramrang.Value = 0;
            btnTinhtien.Enabled = false;
        }

        private void btnTinhtien_Click(object sender, EventArgs e)
        {
            int total = 0;

        if (chkCaovoi.Checked)
            total += 100000;
        if (chkTaytrang.Checked)
            total += 1200000;
        if (chkChuphinhrang.Checked)
            total += 200000;
        if (numTramrang.Value > 0)
            total += 80000 * (int)numTramrang.Value;

        txtTotal.Text = total.ToString("C0"); 
    }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            KiemTraKichHoatTinhTien();


        }
        private void KiemTraKichHoatTinhTien()
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                btnTinhtien.Enabled = false;
                return;
            }

            if (chkCaovoi.Checked || chkTaytrang.Checked || chkChuphinhrang.Checked || ( numTramrang.Value > 0))
            {
                btnTinhtien.Enabled = true;
            }
            else
            {
                btnTinhtien.Enabled = false;
            }
        }

        private void chkCaovoi_CheckedChanged(object sender, EventArgs e)
        {
            KiemTraKichHoatTinhTien();

        }

        private void chkTaytrang_CheckedChanged(object sender, EventArgs e)
        {
            KiemTraKichHoatTinhTien();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chkChuphinhrang_CheckedChanged(object sender, EventArgs e)
        {
            KiemTraKichHoatTinhTien();

        }

        private void numTramrang_ValueChanged(object sender, EventArgs e)
        {
            KiemTraKichHoatTinhTien();

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // Thiết lập chuỗi kết nối đến cơ sở dữ liệu
            string connectionString = @"Data Source=DESKTOP-CH0BDIT;Initial Catalog=DentalServiceDB;Integrated Security=True;TrustServerCertificate=True";

            

            // Truy vấn SQL để lấy dữ liệu hóa đơn
            string query = @"SELECT h.MaHoaDon, k.TenKhachHang, k.SoDienThoai, d.TenDichVu, 
                     cthd.SoLuong, cthd.ThanhTien, h.TongTien, h.NgaySuDung
                     FROM HoaDon h
                     INNER JOIN KhachHang k ON h.MaKhachHang = k.MaKhachHang
                     INNER JOIN ChiTietHoaDon cthd ON h.MaHoaDon = cthd.MaHoaDon
                     INNER JOIN DichVu d ON cthd.MaDichVu = d.MaDichVu";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                // Nếu bạn muốn lấy dữ liệu cho mã hóa đơn cụ thể, thì bỏ comment dòng dưới
                // cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Hiển thị dữ liệu lên DataGridView
                dataGridView1.DataSource = dt;
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        }
    }

