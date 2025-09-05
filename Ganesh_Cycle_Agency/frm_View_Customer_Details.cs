using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ganesh_Cycle_Agency
{
    public partial class frm_View_Customer_Details : Form
    {
        public frm_View_Customer_Details()
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
        void Bind_Grid(string Query )
        {
            Con_Open();
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_Customer_Details.DataSource = dt;
            Con_Close();
        }

        void Bind_Grid1(DateTime fromDate, DateTime toDate)
        {
            Con_Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customer_Details WHERE Date >= @FromDate AND Date <= @ToDate ORDER BY Date", Con);
            cmd.Parameters.Add("@FromDate", SqlDbType.Date).Value = fromDate;
            cmd.Parameters.Add("@ToDate", SqlDbType.Date).Value = toDate;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_Customer_Details.DataSource = dt;
            Con_Close();
        }
        void Clear_Controls()
        {
            dtp_From_Date.ResetText();
            dtp_To_Date.ResetText();
        }

        private void frm_View_Customer_Details_Load(object sender, EventArgs e)
        {
            Bind_Grid("Select * from Customer_Details");

        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Customer obj = new frm_Customer();
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Bind_Grid1(dtp_From_Date.Value.Date, dtp_To_Date.Value.Date);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            Bind_Grid("Select * from Customer_Details");
        }

        private void lbl_View_Customer_Details_Click(object sender, EventArgs e)
        {

        }

    }
}
