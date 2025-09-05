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
    public partial class frm_Add_New_Product : Form
    {
        public frm_Add_New_Product()
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


        int Auto_Incr()
        {
            int cnt = 0;

            Con_Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;

            cmd.CommandText = "Select Count(*) From Product_Details";

            cnt = Convert.ToInt32(cmd.ExecuteScalar());

            if (cnt > 0)
            {
                cmd.CommandText = "Select Max(Product_ID) From Product_Details";
                cnt = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
            }
            else
            {
                cnt = 1001;
            }

            Con_Close();

            return cnt;
        }


        void Clear_Controls()
        {
            tb_Product_ID.Text = Convert.ToString(Auto_Incr());
            cmb_Category.SelectedIndex = -1;
            cmb_Subcategory.SelectedIndex = -1;
            tb_Product_Name.Clear();
            cmb_Distributor_Name.SelectedIndex = -1;
            dtp_Date.ResetText();
            tb_Sales_Rate.Clear();
            tb_Purchase_Rate.Clear();
            tb_Stock_Quantity.Clear();
            tb_Discription.Clear();

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
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;

            }
        }


        private void Only_TextDigit(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '@' && !char.IsControl(e.KeyChar) && (char.IsSymbol(e.KeyChar))))
            {
                e.Handled = true;

            }
        }
        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindCombo("Subcategory_Name", "Select Distinct(Subcategory_Name) From Subcategory_Details Where Category = '" + cmb_Category.Text + "'", cmb_Subcategory);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Product_ID.Text != "" && tb_Product_Name.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Con;
                cmd.CommandText = "Insert Into Product_Details(Product_ID, Category, Subcategory, Product_Name, Distributor_Name, Date, Sales_Rate, Purchase_Rate, Stock_Quantity, Description)values(@PID, @CName, @SName, @PName, @DName, @Date, @SRate, @PRate, @Stock, @Disc)";

                cmd.Parameters.Add("PID", SqlDbType.Int).Value = tb_Product_ID.Text;
                cmd.Parameters.Add("CName", SqlDbType.NVarChar).Value = cmb_Category.Text;
                cmd.Parameters.Add("SName", SqlDbType.NVarChar).Value = cmb_Subcategory.Text;
                cmd.Parameters.Add("PName", SqlDbType.NVarChar).Value = tb_Product_Name.Text;
                cmd.Parameters.Add("DName", SqlDbType.NVarChar).Value = cmb_Distributor_Name.Text;
                cmd.Parameters.Add("Date", SqlDbType.Date).Value = dtp_Date.Value.Date;
                cmd.Parameters.Add("SRate", SqlDbType.Money).Value = tb_Sales_Rate.Text;
                cmd.Parameters.Add("PRate", SqlDbType.Money).Value = tb_Purchase_Rate.Text;
                cmd.Parameters.Add("Stock", SqlDbType.Int).Value = tb_Stock_Quantity.Text;
                cmd.Parameters.Add("Disc", SqlDbType.NVarChar).Value = tb_Discription.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record inserted successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Clear_Controls();
            }
            else
            {
                MessageBox.Show("First fill all fields", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Con_Close();
        }

        private void frm_Add_New_Product_Load(object sender, EventArgs e)
        {
            BindCombo("Category", "Select Distinct(Category) From Subcategory_Details", cmb_Category);
            BindCombo("Distributor_Name", "Select Distinct(Distributor_Name) From Distributor_Details", cmb_Distributor_Name);
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
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}
