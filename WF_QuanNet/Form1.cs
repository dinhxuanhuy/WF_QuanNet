using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_QuanNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            var realadmin = false;
            if (txtusername.Text == "admin" && txtpassword.Text == "admin")
            {
                label2.Text = "Login Success";
                label3.Text = "Welcome to QuanNet";
                realadmin = true;
            }
            else
            {
                txtpassword.Text = "";
            }
            //change text colour lable
            label2.ForeColor = Color.Green;
            label3.ForeColor = Color.Green;
            label2.Visible = true;
            label3.Visible = true;
            if (realadmin)
            {


            }

        }
    }
}
