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
    public partial class frm_Add_Stock : Form
    {
        public frm_Add_Stock()
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
        void Category_Combo()
        {
            Con_Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;

            cmd.CommandText = "Select distinct(Category_Name) from Category_Details ";
            SqlDataReader Dr = cmd.ExecuteReader();

            while (Dr.Read())
            {
                cmb_Category.Items.Add(Dr.GetString(Dr.GetOrdinal("Category_Name")));

            }

            Con_Close();
        }
        void Subcategory_Combo()
        {
            Con_Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;

            cmd.CommandText = "SELECT DISTINCT Subcategory_Name FROM Subcategory_Details WHERE Category = @categoryName";
            cmd.Parameters.AddWithValue("@categoryName", cmb_Category.Text);


            SqlDataReader Dr = cmd.ExecuteReader();

            while (Dr.Read())
            {
                cmb_Subcategory.Items.Add(Dr.GetString(Dr.GetOrdinal("Subcategory_Name")));

            }

            Con_Close();
        }

        void Product_Combo()
        {
            Con_Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;

            cmd.CommandText = "SELECT DISTINCT Product_Name FROM Product_Details WHERE Category = @categoryName And Subcategory = @subcategoryName";

            cmd.Parameters.AddWithValue("@categoryName", cmb_Category.Text);
            cmd.Parameters.AddWithValue("@subcategoryName", cmb_Subcategory.Text);

            SqlDataReader Dr = cmd.ExecuteReader();

            while (Dr.Read())
            {
                cmb_Product_Name.Items.Add(Dr.GetString(Dr.GetOrdinal("Product_Name")));

            }

            Con_Close();
        }

        void Product_ID()
        {
            Con_Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            cmd.CommandText = "SELECT DISTINCT Product_ID FROM Product_Details WHERE Product_Name = @productName";

            cmd.Parameters.AddWithValue("@productName", cmb_Product_Name.Text);

            SqlDataReader Dr = cmd.ExecuteReader();

            if (Dr.Read())
            {
                tb_Product_ID.Text = (Dr["Product_ID"].ToString());
            }

            Con_Close();
        }
        void Current_Stock()
        {
            Con_Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            cmd.CommandText = "SELECT DISTINCT Stock_Quantity FROM Product_Details WHERE Product_Name = @productName";

            cmd.Parameters.AddWithValue("@productName", cmb_Product_Name.Text);

            SqlDataReader Dr = cmd.ExecuteReader();

            if (Dr.Read())
            {
                tb_Current_Stock_Quantity.Text = (Dr["Stock_Quantity"].ToString());
            }

            Con_Close();
        }
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
        void Clear_Controls()
        {
            tb_Product_ID.Clear();
            cmb_Category.SelectedIndex = -1;
            cmb_Subcategory.SelectedIndex = -1;
            cmb_Product_Name.SelectedIndex = -1;
            tb_New_Stock_Quantity.Clear();
            tb_Current_Stock_Quantity.Clear();
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Subcategory_Combo();
        }

        private void cmb_Subcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product_Combo();
        }

        private void cmb_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product_ID();
            Current_Stock();
        }

        private void frm_Add_Stock_Load(object sender, EventArgs e)
        {
            Category_Combo();
            Clear_Controls();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (cmb_Category.Text != "" && cmb_Subcategory.Text != "" && cmb_Product_Name.Text != "" && tb_Current_Stock_Quantity.Text != "" && tb_New_Stock_Quantity.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Con;
                cmd.CommandText = "Insert Into Stock_Details(Category, Subcategory, Product_Name, Product_ID, Current_Stock_Quantity,New_Stock_Quantity,Date)values(@CName,@SName,@PName,@PID,@CStock,@NStock,@Date)";
                cmd.Parameters.Add("CName", SqlDbType.NVarChar).Value = cmb_Category.Text;
                cmd.Parameters.Add("SName", SqlDbType.NVarChar).Value = cmb_Subcategory.Text;
                cmd.Parameters.Add("PName", SqlDbType.NVarChar).Value = cmb_Product_Name.Text;
                cmd.Parameters.Add("PID", SqlDbType.Int).Value = tb_Product_ID.Text;
                cmd.Parameters.Add("CStock", SqlDbType.Int).Value = tb_Current_Stock_Quantity.Text;
                cmd.Parameters.Add("NStock", SqlDbType.Int).Value = tb_New_Stock_Quantity.Text;
                cmd.Parameters.Add("Date", SqlDbType.Date).Value = dtp_Date.Value.Date;

                cmd.ExecuteNonQuery();
                // Update stock quantity in Product_Details table
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = Con;
                cmd1.CommandText = "UPDATE Product_Details SET Stock_Quantity = Stock_Quantity + @NStock WHERE Product_ID = @PID";
                cmd1.Parameters.Add("NStock", SqlDbType.Int).Value = tb_New_Stock_Quantity.Text;
                cmd1.Parameters.Add("PID", SqlDbType.Int).Value = tb_Product_ID.Text;

                cmd1.ExecuteNonQuery();


                MessageBox.Show("Record inserted successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("First fill all fields", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Product obj = new frm_Product();
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
