using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ganesh_Cycle_Agency
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }
        private Form tooltipForm;

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            frm_Customer obj = new frm_Customer();
            obj.Show();
            this.Hide();
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            frm_Product obj = new frm_Product();
            obj.Show();
            this.Hide();
        }

        private void btn_Distributor_Click(object sender, EventArgs e)
        {
            frm_Distributor obj = new frm_Distributor();
            obj.Show();
            this.Hide();
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            frm_Employee obj = new frm_Employee();
            obj.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure You Want to Logout ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                frm_Login obj = new frm_Login();
                obj.Show();
                this.Hide();
            }
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            frm_Menu obj = new frm_Menu();
            obj.Show();
            this.Hide();
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            frm_Reports obj = new frm_Reports();
            obj.Show();
            this.Hide();
        }

        private void btn_Home_Clicke(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(btn_Home, "Menu");

            tooltipForm = new Form
            {
                FormBorderStyle = FormBorderStyle.None,
                ShowInTaskbar = false,
                StartPosition = FormStartPosition.Manual,
                AutoSize = false,  // Set AutoSize to false to manually control the size
                Size = new Size(200, 100),  // Set the initial size of the tooltip
                TopMost = true,
                Visible = false
            };
        }

        private void btn_Customer_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip2 = new ToolTip();
            toolTip2.SetToolTip(btn_Customer, "Customer Details");
        }

        private void btn_Product_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip3 = new ToolTip();
            toolTip3.SetToolTip(btn_Product, "Product Details");
        }

        private void btn_Distributor_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip4 = new ToolTip();
            toolTip4.SetToolTip(btn_Distributor, "Distributor Details");
        }

        private void btn_Employee_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip5 = new ToolTip();
            toolTip5.SetToolTip(btn_Employee, "Employee Details");
        }

        private void btn_Reports_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip6 = new ToolTip();
            toolTip6.SetToolTip(btn_Reports, "All Reports");
        }

    }
}
