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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
            Load();

        }
        private void Load()
        {
            //make MaNV become index of the datagridview
            dgvNhanVien.ForeColor = Color.Black;
            dgvNhanVien.AutoGenerateColumns = false;
            var dtNhanVien = new DataTable();
            dtNhanVien.Clear();
            DataSet dataSet =  DBNhanVien.LayDsNhanVien();
            if (dataSet != null && dataSet.Tables.Count > 0)
            {
                dtNhanVien = dataSet.Tables[0];
                dgvNhanVien.DataSource = dtNhanVien;
            }
            else
            {
                MessageBox.Show("Lỗi load dữ liệu");
                dgvNhanVien.DataSource = null;
            }
            

            // hiện toàn bộ dữ liệu


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVienInFo nhanVienInFo = new NhanVienInFo("Add");
            nhanVienInFo.ShowDialog();

            Load();


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Load();

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvNhanVien.SelectedRows[0];
                List<String> In4 = new List<string>();
                In4.Add(row.Cells["MaNV"].Value.ToString());
                In4.Add(row.Cells["HoTen"].Value.ToString());
                In4.Add(row.Cells["SDT"].Value.ToString());
                In4.Add(row.Cells["DiaChi"].Value.ToString());
                In4.Add(row.Cells["GioiTinh"].Value.ToString());
                In4.Add(row.Cells["NgaySinh"].Value.ToString());
                NhanVienInFo nhanVienInFo = new NhanVienInFo("Edit", In4);
                nhanVienInFo.ShowDialog();
                Load();
            }
            else
            {
                MessageBox.Show("Chọn 1 nhân viên để sửa");
            }

        }
    }
}
