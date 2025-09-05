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
    public partial class frm_Product : Form
    {
        public frm_Product()
        {
            InitializeComponent();
        }

        private void btn_Add_New_Category_Click(object sender, EventArgs e)
        {
            frm_Add_New_Category obj = new frm_Add_New_Category();
            obj.Show();
            this.Hide();
        }

        private void btn_Add_New_Subcategory_Click(object sender, EventArgs e)
        {
            frm_Add_New_Subcategory obj = new frm_Add_New_Subcategory();
            obj.Show();
            this.Hide();
        }

        private void btn_Add_New_Product_Click(object sender, EventArgs e)
        {
            frm_Add_New_Product obj = new frm_Add_New_Product();
            obj.Show();
            this.Hide();
        }

        private void btn_Add_Stock_Click(object sender, EventArgs e)
        {
            frm_Add_Stock obj = new frm_Add_Stock();
            obj.Show();
            this.Hide();
        }

        private void btn_View_Stock_Details_Click(object sender, EventArgs e)
        {
            frm_View_Stock_Details obj = new frm_View_Stock_Details();
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
