using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessAcessLayer;

namespace WF_QuanNet
{
    public partial class NhanVienInFo : Form
    {
        string category;
        List<String> information;
        public NhanVienInFo(string category,List<String> In4 = null)
        {
            InitializeComponent();
            this.category = category;
            if (In4 != null)
            {
                this.information = In4;
            }
            if (category == "Add")
            {
                TxtMaNV.Enabled = false;
            }
            if (category == "Edit")
            {
                TxtMaNV.Enabled = false;
                TxtMaNV.Text = information[0];
                txtHoTen.Text = information[1];
                txtSDT.Text = information[2];
                txtDiaChi.Text = information[3];
                txtGioiTinh.Text = information[4];
                txtNgaySinh.Text = information[5];
            }



        }

        private void btnConfirmAddFood_Click(object sender, EventArgs e)
        {
            //return all text in the textbox
            string MaNV = TxtMaNV.Text;
            string Hoten = txtHoTen.Text;
            string SDT = txtSDT.Text;
            string DiaChi = txtDiaChi.Text;
            string GioiTinh = txtGioiTinh.Text;
            DateTime NgaySinh;
            //parste string to datetime
            string dateFormat = "dd/MM/yyyy";
            if (DateTime.TryParseExact(txtNgaySinh.Text, dateFormat, null, System.Globalization.DateTimeStyles.None, out NgaySinh))
            {
                if (category == "Add")
                {
                    DBNhanVien.ThemNhanVien( Hoten, SDT, DiaChi, GioiTinh, NgaySinh);
                    MessageBox.Show("Add successfully");
                    this.Close();

                }
                if (category == "Edit")
                {
                    DBNhanVien.SuaNhanVien(MaNV, Hoten, SDT, DiaChi, GioiTinh, NgaySinh);
                    MessageBox.Show("Edit successfully");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid date format. Please enter a date in the format dd/MM/yyyy.");
            }


        }
    }
}
