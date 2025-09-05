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
    public partial class frm_Reports : Form
    {
        public frm_Reports()
        {
            InitializeComponent();
        }

        private void btn_Customer_Report_Click(object sender, EventArgs e)
        {
            Ganesh_Cycle_Agency.Reports.Forms.frm_Customer_Bill_Datewise obj = new Ganesh_Cycle_Agency.Reports.Forms.frm_Customer_Bill_Datewise();
            obj.Show();
            this.Hide();
        }

        private void btn_Product_Reports_Click(object sender, EventArgs e)
        {
            Ganesh_Cycle_Agency.Reports.Forms.frm_Product_Report_Namewise obj = new Ganesh_Cycle_Agency.Reports.Forms.frm_Product_Report_Namewise();
            obj.Show();
            this.Hide();
        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            Ganesh_Cycle_Agency.Reports.Forms.frm_Stock_Reports_ID obj = new Ganesh_Cycle_Agency.Reports.Forms.frm_Stock_Reports_ID();
            obj.Show();
            this.Hide();
        }

        private void btn_Distributor_Reports_Click(object sender, EventArgs e)
        {
            Ganesh_Cycle_Agency.Reports.Forms.frm_Distributor_Reports_Name obj = new Ganesh_Cycle_Agency.Reports.Forms.frm_Distributor_Reports_Name();
            obj.Show();
            this.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Menu obj = new frm_Menu();
            obj.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }

        private void btn_Customer_Report_Namewise_Click(object sender, EventArgs e)
        {
            Ganesh_Cycle_Agency.Reports.Forms.frm_Customer_bill_Name obj = new Ganesh_Cycle_Agency.Reports.Forms.frm_Customer_bill_Name();
            obj.Show();
            this.Hide();
        }
    }
}
