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
    public partial class frm_Add_New_Customer : Form
    {
        public frm_Add_New_Customer()
        {
            InitializeComponent();
        }
        int pCnt = 1;
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

            cmd.CommandText = "Select Count(*) From Customer_Details";

            cnt = Convert.ToInt32(cmd.ExecuteScalar());

            if (cnt > 0)
            {
                cmd.CommandText = "Select Max(Customer_ID) From Customer_Details";
                cnt = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
            }
            else
            {
                cnt = 4001;
            }

            Con_Close();

            return cnt;
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

        void UPrice()
        {
            Con_Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            cmd.CommandText = "SELECT DISTINCT Sales_Rate FROM Product_Details WHERE Product_Name = @productName";

            cmd.Parameters.AddWithValue("@productName", cmb_Product_Name.Text);

            SqlDataReader Dr = cmd.ExecuteReader();

            if (Dr.Read())
            {
                tb_Unit_Price.Text = (Dr["Sales_Rate"].ToString());
            }
            tb_Quantity.Enabled = true;
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
        void Clear_Controls()
        {
            tb_Customer_ID.Text = Convert.ToString(Auto_Incr());
            tb_Customer_Name.Clear();
            tb_Mobile_No.Clear();
            tb_Address.Clear();
            cmb_Category.SelectedIndex = -1;
            cmb_Subcategory.SelectedIndex = -1;
            cmb_Product_Name.SelectedIndex = -1;
            tb_Unit_Price.Clear();
            tb_Quantity.Text = "0";
            tb_Price.Text = "0";
            tb_Total_Price.Text = "0";
            tb_Discount.Text = "0";
            tb_Total_Bill.Text = "0";
            dgv_Purchase_Details.Rows.Clear();
        }

        private void frm_Add_New_Customer_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            BindCombo("Category", "Select Distinct(Category) From Subcategory_Details", cmb_Category);
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Subcategory.Items.Clear();
            BindCombo("Subcategory_Name", "Select Distinct(Subcategory_Name) From Subcategory_Details Where Category = '" + cmb_Category.Text + "'", cmb_Subcategory);
        }

        private void cmb_Subcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Product_Name.Items.Clear();
            BindCombo("Product_Name", "Select Distinct(Product_Name) From Product_Details Where Subcategory = '" + cmb_Subcategory.Text + "'", cmb_Product_Name);
        }

        private void cmb_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            UPrice();
        }

        private void tb_Quantity_TextChanged(object sender, EventArgs e)
        {
            
            if (tb_Quantity.Text != "" && tb_Unit_Price.Text != "")
            {

                tb_Price.Text = Convert.ToString(Convert.ToDouble(tb_Unit_Price.Text) * Convert.ToDouble(tb_Quantity.Text));
            }
        }

        private void tb_Discount_TextChanged(object sender, EventArgs e)
        {
            if (tb_Total_Price.Text != "" && tb_Discount.Text != "")
            {

                tb_Total_Bill.Text = Convert.ToString(Convert.ToDouble(tb_Total_Price.Text) - Convert.ToDouble(tb_Discount.Text));
            }
        }

        private void tb_Address_TextChanged(object sender, EventArgs e)
        {
            pnl_Purchase_Details.Enabled = true;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int Flag = 0;
            int RowCnt = dgv_Purchase_Details.RowCount;

            for (int i = 0; i < RowCnt; i++)
            {
                if ((Convert.ToString(dgv_Purchase_Details.Rows[i].Cells[1].Value) == cmb_Category.Text) && (Convert.ToString(dgv_Purchase_Details.Rows[i].Cells[2].Value) == cmb_Subcategory.Text) && (Convert.ToString(dgv_Purchase_Details.Rows[i].Cells[3].Value) == cmb_Product_Name.Text))
                {
                    double Qty = Convert.ToDouble(dgv_Purchase_Details.Rows[i].Cells[5].Value) + Convert.ToDouble(tb_Quantity.Text);
                    double Price = Convert.ToDouble(dgv_Purchase_Details.Rows[i].Cells[6].Value) + Convert.ToDouble(tb_Total_Price.Text);

                    dgv_Purchase_Details.Rows[i].Cells[5].Value = Qty;
                    dgv_Purchase_Details.Rows[i].Cells[6].Value = Price;

                    double price = (Convert.ToDouble(tb_Price.Text) + Convert.ToDouble(tb_Total_Price.Text));
                    tb_Total_Price.Text = Convert.ToString(price);
                    Flag = 1;
                    break;
                }
            }
            
            if (cmb_Product_Name.Text != "" && Convert.ToInt32(tb_Quantity.Text) > 0 && Flag != 1)
            {
                dgv_Purchase_Details.Rows.Add(pCnt, cmb_Category.Text, cmb_Subcategory.Text, cmb_Product_Name.Text, tb_Unit_Price.Text, tb_Quantity.Text, tb_Price.Text);
                pCnt++;

                double price = (Convert.ToDouble(tb_Price.Text) + Convert.ToDouble(tb_Total_Price.Text));
                tb_Total_Price.Text = Convert.ToString(price);

            }
            cmb_Category.SelectedIndex = -1;
            cmb_Subcategory.SelectedIndex = -1;
            cmb_Product_Name.SelectedIndex = -1;
            tb_Unit_Price.Clear();
            tb_Quantity.Text = "0";
            tb_Price.Text = "0";

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Customer_ID.Text != "" && tb_Customer_Name.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Con;
                cmd.CommandText = "Insert Into Customer_Details(Customer_ID, Customer_Name, Mobile_No,Address,Total_Price,Discount,Total_Bill,Date)values(@CID,@CName,@MNo,@Address,@TotPrice,@Discount,@TotBill,@Date)";

                cmd.Parameters.Add("CID", SqlDbType.Int).Value = tb_Customer_ID.Text;
                cmd.Parameters.Add("CName", SqlDbType.VarChar).Value = tb_Customer_Name.Text;
                cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                cmd.Parameters.Add("Address", SqlDbType.NVarChar).Value = tb_Address.Text;
                cmd.Parameters.Add("TotPrice", SqlDbType.Money).Value = tb_Total_Price.Text;
                cmd.Parameters.Add("Discount", SqlDbType.Money).Value = tb_Discount.Text;
                cmd.Parameters.Add("TotBill", SqlDbType.Money).Value = tb_Total_Bill.Text;
                cmd.Parameters.Add("Date", SqlDbType.Date).Value = dtp_Date.Value.Date;

                cmd.ExecuteNonQuery();

                for (int i = 0; i <= dgv_Purchase_Details.Rows.Count - 1; i++)
                {
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = Con;

                    cmd2.CommandText = "INSERT INTO Purchase_Details (Customer_ID, Category, Subcategory, Product_Name, Unit_Price, Quantity, Price) VALUES (@CID,@Category,@SCategory,@Product, @UPrice, @Quantity, @Price )";
                    cmd2.Parameters.Add("CID", SqlDbType.Int).Value = tb_Customer_ID.Text;
                    cmd2.Parameters.Add("Category", SqlDbType.NVarChar).Value = dgv_Purchase_Details.Rows[i].Cells[1].Value;
                    cmd2.Parameters.Add("SCategory", SqlDbType.NVarChar).Value = dgv_Purchase_Details.Rows[i].Cells[2].Value;
                    cmd2.Parameters.Add("Product", SqlDbType.NVarChar).Value = dgv_Purchase_Details.Rows[i].Cells[3].Value;
                    cmd2.Parameters.Add("UPrice", SqlDbType.Money).Value = dgv_Purchase_Details.Rows[i].Cells[4].Value;
                    cmd2.Parameters.Add("Quantity", SqlDbType.Int).Value = dgv_Purchase_Details.Rows[i].Cells[5].Value;
                    cmd2.Parameters.Add("Price", SqlDbType.Money).Value = dgv_Purchase_Details.Rows[i].Cells[6].Value;

                    cmd2.ExecuteNonQuery();
                    cmd2.Dispose();

                    int Saled_Quantity = Convert.ToInt32(dgv_Purchase_Details.Rows[i].Cells[5].Value);
                    int PC_Stock = 0;
                    int ID = 0;
                    int New_Stock = 0;

                    cmd2.CommandText = "Select Product_Id, Stock_Quantity From Product_Details where Category = '" + dgv_Purchase_Details.Rows[i].Cells[1].Value + "' And SubCategory = '" + dgv_Purchase_Details.Rows[i].Cells[2].Value + "' And Product_Name = '" + dgv_Purchase_Details.Rows[i].Cells[3].Value + "'";
                    cmd2.Connection = Con;
                    SqlDataReader obj = cmd2.ExecuteReader();
                    if (obj.Read())
                    {
                        ID = Convert.ToInt32(obj["Product_ID"].ToString());
                        PC_Stock = Convert.ToInt32(obj["Stock_Quantity"].ToString());

                    }
                    New_Stock = PC_Stock - Saled_Quantity;
                    obj.Close();
                    cmd2.Dispose();
                    cmd2.Connection = Con;
                    SqlDataAdapter sda = new SqlDataAdapter("Update Product_Details set Stock_Quantity ="+New_Stock+ "where Product_ID = "+ ID+"",Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                }
                    MessageBox.Show("Record inserted successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_Controls();
            }
            else
            {

                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear_Controls();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            dgv_Purchase_Details.Rows.Clear();
            tb_Total_Price.Clear();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
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
    }
}
