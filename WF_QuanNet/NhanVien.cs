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
            dgvNhanVien.AutoGenerateColumns = false;
            var dtNhanVien = new DataTable();
            dtNhanVien.Clear();
            DataSet dataSet = new DBNhanVien().LayDsNhanVien();
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
    }
}
