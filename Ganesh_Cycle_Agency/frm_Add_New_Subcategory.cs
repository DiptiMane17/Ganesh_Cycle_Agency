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
    public partial class frm_Add_New_Subcategory : Form
    {
        public frm_Add_New_Subcategory()
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

        void Clear_Controls()
        {
            tb_Subcategory_ID.Clear();
            tb_Subcategory_ID.Text = Convert.ToString(Auto_Incr());
            tb_Subcategory_Name.Clear();
            cmb_Category_Name.SelectedIndex= -1;
        }

        int Auto_Incr()
        {
            int cnt = 0;
            Con_Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            cmd.CommandText = "Select Count(*) From Subcategory_Details";

            cnt = Convert.ToInt32(cmd.ExecuteScalar());

            if (cnt > 0)
            {
                cmd.CommandText = "Select Max(Subcategory_ID) From Subcategory_Details";
                cnt = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
            }
            else
            {
                cnt = 101;
            }
            Con_Close();
            return cnt;
        }
        void Bind_Comb(string Col_Name, string T_Name, ComboBox cmb)
        {
            Con_Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            cmd.CommandText = "SELECT DISTINCT " + Col_Name + " FROM " + T_Name;
            SqlDataReader Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                cmb.Items.Add(Dr.GetString(Dr.GetOrdinal(Col_Name)));
            }
            Con_Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Subcategory_ID.Text != ""  && tb_Subcategory_Name.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Con;
                cmd.CommandText = "Insert Into Subcategory_Details(Category, Subcategory_ID, Subcategory_Name)values(@CName, @SID, @SName )";

                
                cmd.Parameters.Add("CName", SqlDbType.VarChar).Value = cmb_Category_Name.Text;
                cmd.Parameters.Add("SID", SqlDbType.Int).Value = tb_Subcategory_ID.Text;
                cmd.Parameters.Add("SName", SqlDbType.NVarChar).Value = tb_Subcategory_Name.Text;


                cmd.ExecuteNonQuery();

                MessageBox.Show("Record inserted successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Clear_Controls();
            }
            else
            {
                MessageBox.Show("First fill all fields", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Clear_Controls();
            Con_Close();
        }

        private void frm_Add_New_Subcategory_Load(object sender, EventArgs e)
        {
            Auto_Incr();
            Bind_Comb("Category_Name", "Category_Details", cmb_Category_Name);
            Clear_Controls();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Product obj = new frm_Product();
            obj.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Product obj = new frm_Product();
            obj.Show();
            this.Hide();
        }
        
    }
}
