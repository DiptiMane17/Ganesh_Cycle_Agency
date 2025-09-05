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
    public partial class frm_Employee : Form
    {
        public frm_Employee()
        {
            InitializeComponent();
        }

        private void btn_Add_New_Employee_Click(object sender, EventArgs e)
        {
            frm_Add_New_Employee obj = new frm_Add_New_Employee();
            obj.Show();
            this.Hide();
        }

        private void btn_Search_Or_Update_Employee_Details_Click(object sender, EventArgs e)
        {
            frm_Search_Or_Update_Employee obj = new frm_Search_Or_Update_Employee();
            obj.Show();
            this.Hide();
        }

        private void btn_View_All_Employees_Click(object sender, EventArgs e)
        {
            frm_View_All_Employee obj = new frm_View_All_Employee();
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
