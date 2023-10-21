using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi03_02
{
    public partial class Form1 : Form
    {
        private string stt;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHT.Text.Length.Equals(0))
                {
                    throw new Exception("Họ tên sinh viên không để rỗng");

                }
                //Lấy thông tin
                string hoten = txtHT.Text;
                string masv =txtMSV.Text;
                string ngaysinh = txtNS.Text;
                string gioitinh = (rbNam.Checked) ? "Nam" : "Nữ";
                string sothich = null;
                if (chbDulich.Checked)
                {
                }
                sothich += "Du Lich";
                if (chbThethao.Checked)
                {
                    sothich += "Thể Thao";
                }
                if (chbMuasam.Checked)
                {
                    sothich += "Mua Sắm";
                }
                if (sothich != null)
                {
                    sothich = " Sở thích: " + sothich;

                }
                if (txtMSV.MaxLength == 8 && txtMSV.SelectionStart("21"))
                {
                    // Mã sinh viên hợp lệ
                    // Thực hiện các thao tác cần thiết ở đây
                }
                else
                {
                    // Mã sinh viên không hợp lệ, hiển thị thông báo lỗi
                    MessageBox.Show("Mã sinh viên không hợp lệ. Mã sinh viên phải bắt đầu bằng '21' và có đúng 8 ký tự.");
                }

                //Xuất thông tin ra TextBox txtDanhSach
                txtDanhsach.Text += stt + "MSV:"+ masv+ ". Họ tên: " + hoten + "Ngày sinh:" + ngaysinh + "Giới tính: " + gioitinh + sothich + "\r\n";
 
            }
            catch (Exception ex)
            {
               lb1Thongbao.Text = ex.Message;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtDanhsach.Text = "";
        }
    }
}