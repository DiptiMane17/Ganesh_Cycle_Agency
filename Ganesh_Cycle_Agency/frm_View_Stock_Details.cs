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
    public partial class frm_View_Stock_Details : Form
    {
        public frm_View_Stock_Details()
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


        void BindCombo(string Col_Name, string Query, ComboBox Cmb)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();
            SqlDataReader Dr;

            Cmd.Connection = Con;
            Cmd.CommandText = Query;
            Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                Cmb.Items.Add(Dr.GetString(Dr.GetOrdinal(Col_Name)));
            }

            Cmd.Dispose();
            Dr.Close();
            Con_Close();
        }

        void Bind_Grid(string Query)
        {
            Con_Open();

            dgv_View_Stock_Details.DataSource = "";

            SqlDataAdapter SDA = new SqlDataAdapter(Query, Con);
            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_View_Stock_Details.DataSource = dt;

            Con_Close();
        }

        private void cmb_Category_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindCombo("Subcategory_Name", "Select Distinct(Subcategory_Name) From Subcategory_Details Where Category = '" + cmb_Category_Name.Text + "'", cmb_Subcategory_Name);
            Bind_Grid("Select * From Product_Details where Category = '" + cmb_Category_Name.Text + "' ");
        }

        private void cmb_Subcategory_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindCombo("Product_Name", "Select Distinct(Product_Name) From Product_Details Where Category = '" + cmb_Category_Name.Text + "' And Subcategory= '" + cmb_Subcategory_Name.Text + "'", cmb_Product_Name);
            Bind_Grid("Select * From Product_Details where Category = '" + cmb_Category_Name.Text + "' And Subcategory = '" + cmb_Subcategory_Name.Text + "' ");
        }

        private void frm_View_Stock_Details_Load(object sender, EventArgs e)
        {
            BindCombo("Category_Name", "Select Distinct(Category_Name) From Category_Details", cmb_Category_Name);
            Bind_Grid("Select * From Product_Details");
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Product obj = new frm_Product();
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

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cmb_Category_Name.SelectedIndex= -1;
            cmb_Subcategory_Name.SelectedIndex = -1;
            cmb_Product_Name.SelectedIndex = -1;
            Bind_Grid("Select * From Product_Details");
        }

        private void cmb_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bind_Grid("Select * From Product_Details where Category = '" + cmb_Category_Name.Text + "' And Subcategory = '" + cmb_Subcategory_Name.Text + "' And Product_Name = '" + cmb_Product_Name.Text + "' ");
        }


    }
}
