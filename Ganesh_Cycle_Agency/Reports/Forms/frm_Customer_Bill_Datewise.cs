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
    public partial class frm_Customer_Bill_Datewise : Form
    {
        public frm_Customer_Bill_Datewise()
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
        void Bind_Report(DateTime Start, DateTime End)
        {
            Con_Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("sp_Customer_Bill_Datewise",Con);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@SDate",Start);
            sqlDa.SelectCommand.Parameters.AddWithValue("@EDate",End);

            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            Con_Close();

            Ganesh_Cycle_Agency.Reports.cr_Customer_Bill_Datewise cr_Cust = new Ganesh_Cycle_Agency.Reports.cr_Customer_Bill_Datewise();
            cr_Cust.Database.Tables["sp_Customer_Bill_Datewise"].SetDataSource(dtbl);
            crv_Customer_Bill_Datewise.ReportSource = null;

            crv_Customer_Bill_Datewise.ReportSource = cr_Cust;
        }
        private void frm_Customer_Bill_Datewise_Load(object sender, EventArgs e)
        {
            dtp_From_Date.Value = new DateTime(System.DateTime.Today.Year, System.DateTime.Today.Month, 1);
            Bind_Report(dtp_From_Date.Value.Date, dtp_To_Date.Value.Date);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Bind_Report(dtp_From_Date.Value.Date, dtp_To_Date.Value.Date);
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
