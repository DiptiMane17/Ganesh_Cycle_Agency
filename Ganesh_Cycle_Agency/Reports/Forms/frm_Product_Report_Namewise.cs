using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ganesh_Cycle_Agency.Reports.Forms
{
    public partial class frm_Product_Report_Namewise : Form
    {
        public frm_Product_Report_Namewise()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Ganesh_Cycle_Agency_DB;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }
       
        void Bind_Report(string id)
        {
            Con_Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("sp_Product_Report_Namewise",Con);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Cat", id);

            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            Con_Close();

            Ganesh_Cycle_Agency.Reports.cr_Product_Report_Namewise cr_Cust = new Ganesh_Cycle_Agency.Reports.cr_Product_Report_Namewise();
            cr_Cust.Database.Tables["sp_Product_Report_Namewise"].SetDataSource(dtbl);
            crv_Product_Report_Name.ReportSource = null;

            crv_Product_Report_Name.ReportSource = cr_Cust;
        }

        
        private void btn_Search_Click(object sender, EventArgs e)
        {
            Bind_Report(tb_Product_ID.Text);
        }

        private void frm_Product_Report_Namewise_Load(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Reports obj = new frm_Reports();
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
