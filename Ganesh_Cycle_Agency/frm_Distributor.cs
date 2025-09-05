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
    public partial class frm_Distributor : Form
    {
        public frm_Distributor()
        {
            InitializeComponent();
        }

        private void btn_Add_New_Distributor_Click(object sender, EventArgs e)
        {
            frm_Add_New_Distributor obj = new frm_Add_New_Distributor();
            obj.Show();
            this.Hide();
        }

        private void btn_Search_Or_Update_Distributor_Details_Click(object sender, EventArgs e)
        {
            frm_Search_Or_Update_Distributor obj = new frm_Search_Or_Update_Distributor();
            obj.Show();
            this.Hide();
        }

        private void btn_View_All_Distributors_Click(object sender, EventArgs e)
        {
            frm_View_All_Distributor obj = new frm_View_All_Distributor();
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
    }
}
