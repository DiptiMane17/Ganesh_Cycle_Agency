namespace Ganesh_Cycle_Agency
{
    partial class frm_Add_New_Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_New_Customer));
            this.btn_Add = new System.Windows.Forms.Button();
            this.dgv_Purchase_Details = new System.Windows.Forms.DataGridView();
            this.Sr_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Add_New_Customer = new System.Windows.Forms.Label();
            this.cmb_Subcategory = new System.Windows.Forms.ComboBox();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_Bill_Details = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.tb_Total_Bill = new System.Windows.Forms.TextBox();
            this.pnl_Bill_Details = new System.Windows.Forms.Panel();
            this.tb_Discount = new System.Windows.Forms.TextBox();
            this.tb_Total_Price = new System.Windows.Forms.TextBox();
            this.lbl_Total_Bill = new System.Windows.Forms.Label();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.lbl_Total_Price = new System.Windows.Forms.Label();
            this.lbl_Purchase_Details = new System.Windows.Forms.Label();
            this.lbl_Customer_Details = new System.Windows.Forms.Label();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Customer_Name = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.tb_Customer_ID = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.pnl_Customer_Detials = new System.Windows.Forms.Panel();
            this.lbl_Customer_Name = new System.Windows.Forms.Label();
            this.lbl_Customer_ID = new System.Windows.Forms.Label();
            this.tb_Unit_Price = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Unit_Price = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Subcategory = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.pnl_Purchase_Details = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Purchase_Details)).BeginInit();
            this.pnl_Bill_Details.SuspendLayout();
            this.pnl_Customer_Detials.SuspendLayout();
            this.pnl_Purchase_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(906, 303);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(185, 50);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dgv_Purchase_Details
            // 
            this.dgv_Purchase_Details.AllowUserToAddRows = false;
            this.dgv_Purchase_Details.AllowUserToDeleteRows = false;
            this.dgv_Purchase_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Purchase_Details.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_Purchase_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Purchase_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Purchase_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sr_No,
            this.Category,
            this.Subcategory,
            this.Product_Name,
            this.Unit_Price,
            this.Quantity,
            this.Price});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Purchase_Details.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Purchase_Details.Location = new System.Drawing.Point(825, 14);
            this.dgv_Purchase_Details.Name = "dgv_Purchase_Details";
            this.dgv_Purchase_Details.ReadOnly = true;
            this.dgv_Purchase_Details.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgv_Purchase_Details.RowTemplate.Height = 24;
            this.dgv_Purchase_Details.Size = new System.Drawing.Size(713, 274);
            this.dgv_Purchase_Details.TabIndex = 28;
            // 
            // Sr_No
            // 
            this.Sr_No.FillWeight = 68.73249F;
            this.Sr_No.HeaderText = "Sr.No";
            this.Sr_No.Name = "Sr_No";
            this.Sr_No.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.FillWeight = 101.3804F;
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Subcategory
            // 
            this.Subcategory.FillWeight = 124.3655F;
            this.Subcategory.HeaderText = "Subcategory";
            this.Subcategory.Name = "Subcategory";
            this.Subcategory.ReadOnly = true;
            // 
            // Product_Name
            // 
            this.Product_Name.FillWeight = 101.3804F;
            this.Product_Name.HeaderText = "Product";
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            // 
            // Unit_Price
            // 
            this.Unit_Price.Name = "Unit_Price";
            this.Unit_Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 101.3804F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.FillWeight = 101.3804F;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(330, 133);
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(317, 34);
            this.cmb_Product_Name.TabIndex = 6;
            this.cmb_Product_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Product_Name_SelectedIndexChanged);
            // 
            // lbl_Add_New_Customer
            // 
            this.lbl_Add_New_Customer.AutoSize = true;
            this.lbl_Add_New_Customer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Add_New_Customer.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Customer.ForeColor = System.Drawing.Color.Black;
            this.lbl_Add_New_Customer.Location = new System.Drawing.Point(804, 39);
            this.lbl_Add_New_Customer.Name = "lbl_Add_New_Customer";
            this.lbl_Add_New_Customer.Size = new System.Drawing.Size(424, 57);
            this.lbl_Add_New_Customer.TabIndex = 41;
            this.lbl_Add_New_Customer.Text = "Add New Customer";
            // 
            // cmb_Subcategory
            // 
            this.cmb_Subcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Subcategory.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Subcategory.FormattingEnabled = true;
            this.cmb_Subcategory.Location = new System.Drawing.Point(330, 75);
            this.cmb_Subcategory.Name = "cmb_Subcategory";
            this.cmb_Subcategory.Size = new System.Drawing.Size(317, 34);
            this.cmb_Subcategory.TabIndex = 5;
            this.cmb_Subcategory.SelectedIndexChanged += new System.EventHandler(this.cmb_Subcategory_SelectedIndexChanged);
            // 
            // cmb_Category
            // 
            this.cmb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(330, 23);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(317, 34);
            this.cmb_Category.TabIndex = 4;
            this.cmb_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_SelectedIndexChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Gray;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(1167, 849);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(185, 59);
            this.btn_Refresh.TabIndex = 12;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // tb_Price
            // 
            this.tb_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Price.Enabled = false;
            this.tb_Price.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(330, 318);
            this.tb_Price.MaxLength = 10;
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(317, 34);
            this.tb_Price.TabIndex = 26;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Gray;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(660, 849);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(185, 59);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Quantity.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantity.Location = new System.Drawing.Point(330, 258);
            this.tb_Quantity.MaxLength = 10;
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(317, 34);
            this.tb_Quantity.TabIndex = 7;
            this.tb_Quantity.TextChanged += new System.EventHandler(this.tb_Quantity_TextChanged);
            this.tb_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Bill_Details
            // 
            this.lbl_Bill_Details.AutoSize = true;
            this.lbl_Bill_Details.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bill_Details.Location = new System.Drawing.Point(182, 721);
            this.lbl_Bill_Details.Name = "lbl_Bill_Details";
            this.lbl_Bill_Details.Size = new System.Drawing.Size(129, 25);
            this.lbl_Bill_Details.TabIndex = 47;
            this.lbl_Bill_Details.Text = "Bill Details";
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Clear.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(1229, 303);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(185, 50);
            this.btn_Clear.TabIndex = 9;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // tb_Total_Bill
            // 
            this.tb_Total_Bill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Total_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Bill.Location = new System.Drawing.Point(1082, 16);
            this.tb_Total_Bill.MaxLength = 10;
            this.tb_Total_Bill.Name = "tb_Total_Bill";
            this.tb_Total_Bill.Size = new System.Drawing.Size(196, 38);
            this.tb_Total_Bill.TabIndex = 27;
            // 
            // pnl_Bill_Details
            // 
            this.pnl_Bill_Details.BackColor = System.Drawing.Color.LightGray;
            this.pnl_Bill_Details.Controls.Add(this.tb_Total_Bill);
            this.pnl_Bill_Details.Controls.Add(this.tb_Discount);
            this.pnl_Bill_Details.Controls.Add(this.tb_Total_Price);
            this.pnl_Bill_Details.Controls.Add(this.lbl_Total_Bill);
            this.pnl_Bill_Details.Controls.Add(this.lbl_Discount);
            this.pnl_Bill_Details.Controls.Add(this.lbl_Total_Price);
            this.pnl_Bill_Details.Location = new System.Drawing.Point(187, 760);
            this.pnl_Bill_Details.Name = "pnl_Bill_Details";
            this.pnl_Bill_Details.Size = new System.Drawing.Size(1581, 66);
            this.pnl_Bill_Details.TabIndex = 46;
            // 
            // tb_Discount
            // 
            this.tb_Discount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Discount.Location = new System.Drawing.Point(654, 12);
            this.tb_Discount.MaxLength = 10;
            this.tb_Discount.Name = "tb_Discount";
            this.tb_Discount.Size = new System.Drawing.Size(196, 38);
            this.tb_Discount.TabIndex = 10;
            this.tb_Discount.TextChanged += new System.EventHandler(this.tb_Discount_TextChanged);
            this.tb_Discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Total_Price
            // 
            this.tb_Total_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Total_Price.Enabled = false;
            this.tb_Total_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Price.Location = new System.Drawing.Point(237, 16);
            this.tb_Total_Price.MaxLength = 10;
            this.tb_Total_Price.Name = "tb_Total_Price";
            this.tb_Total_Price.Size = new System.Drawing.Size(196, 38);
            this.tb_Total_Price.TabIndex = 27;
            // 
            // lbl_Total_Bill
            // 
            this.lbl_Total_Bill.AutoSize = true;
            this.lbl_Total_Bill.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Bill.Location = new System.Drawing.Point(917, 16);
            this.lbl_Total_Bill.Name = "lbl_Total_Bill";
            this.lbl_Total_Bill.Size = new System.Drawing.Size(124, 34);
            this.lbl_Total_Bill.TabIndex = 23;
            this.lbl_Total_Bill.Text = "Total Bill";
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount.Location = new System.Drawing.Point(497, 16);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(121, 34);
            this.lbl_Discount.TabIndex = 22;
            this.lbl_Discount.Text = "Discount";
            // 
            // lbl_Total_Price
            // 
            this.lbl_Total_Price.AutoSize = true;
            this.lbl_Total_Price.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Price.Location = new System.Drawing.Point(19, 16);
            this.lbl_Total_Price.Name = "lbl_Total_Price";
            this.lbl_Total_Price.Size = new System.Drawing.Size(143, 34);
            this.lbl_Total_Price.TabIndex = 21;
            this.lbl_Total_Price.Text = "Total Price";
            // 
            // lbl_Purchase_Details
            // 
            this.lbl_Purchase_Details.AutoSize = true;
            this.lbl_Purchase_Details.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Details.Location = new System.Drawing.Point(171, 269);
            this.lbl_Purchase_Details.Name = "lbl_Purchase_Details";
            this.lbl_Purchase_Details.Size = new System.Drawing.Size(178, 25);
            this.lbl_Purchase_Details.TabIndex = 45;
            this.lbl_Purchase_Details.Text = "Purchase Details";
            // 
            // lbl_Customer_Details
            // 
            this.lbl_Customer_Details.AutoSize = true;
            this.lbl_Customer_Details.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Details.Location = new System.Drawing.Point(172, 91);
            this.lbl_Customer_Details.Name = "lbl_Customer_Details";
            this.lbl_Customer_Details.Size = new System.Drawing.Size(177, 25);
            this.lbl_Customer_Details.TabIndex = 44;
            this.lbl_Customer_Details.Text = "Customer Details";
            // 
            // tb_Address
            // 
            this.tb_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(1082, 64);
            this.tb_Address.MaxLength = 100;
            this.tb_Address.Multiline = true;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(392, 69);
            this.tb_Address.TabIndex = 3;
            this.tb_Address.TextChanged += new System.EventHandler(this.tb_Address_TextChanged);
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(1082, 7);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(392, 38);
            this.tb_Mobile_No.TabIndex = 2;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Customer_Name
            // 
            this.tb_Customer_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Customer_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_Name.Location = new System.Drawing.Point(339, 74);
            this.tb_Customer_Name.MaxLength = 20;
            this.tb_Customer_Name.Name = "tb_Customer_Name";
            this.tb_Customer_Name.Size = new System.Drawing.Size(317, 38);
            this.tb_Customer_Name.TabIndex = 1;
            this.tb_Customer_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Address.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(858, 74);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(105, 33);
            this.lbl_Address.TabIndex = 22;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(112, 259);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(112, 33);
            this.lbl_Quantity.TabIndex = 24;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // tb_Customer_ID
            // 
            this.tb_Customer_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Customer_ID.Enabled = false;
            this.tb_Customer_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_ID.Location = new System.Drawing.Point(339, 17);
            this.tb_Customer_ID.MaxLength = 10;
            this.tb_Customer_ID.Name = "tb_Customer_ID";
            this.tb_Customer_ID.Size = new System.Drawing.Size(317, 38);
            this.tb_Customer_ID.TabIndex = 23;
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.Location = new System.Drawing.Point(858, 17);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(137, 33);
            this.lbl_Mobile_No.TabIndex = 21;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // pnl_Customer_Detials
            // 
            this.pnl_Customer_Detials.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_Customer_Detials.Controls.Add(this.tb_Address);
            this.pnl_Customer_Detials.Controls.Add(this.tb_Mobile_No);
            this.pnl_Customer_Detials.Controls.Add(this.tb_Customer_Name);
            this.pnl_Customer_Detials.Controls.Add(this.tb_Customer_ID);
            this.pnl_Customer_Detials.Controls.Add(this.lbl_Address);
            this.pnl_Customer_Detials.Controls.Add(this.lbl_Mobile_No);
            this.pnl_Customer_Detials.Controls.Add(this.lbl_Customer_Name);
            this.pnl_Customer_Detials.Controls.Add(this.lbl_Customer_ID);
            this.pnl_Customer_Detials.Location = new System.Drawing.Point(175, 119);
            this.pnl_Customer_Detials.Name = "pnl_Customer_Detials";
            this.pnl_Customer_Detials.Size = new System.Drawing.Size(1581, 147);
            this.pnl_Customer_Detials.TabIndex = 42;
            // 
            // lbl_Customer_Name
            // 
            this.lbl_Customer_Name.AutoSize = true;
            this.lbl_Customer_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Customer_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Name.Location = new System.Drawing.Point(108, 79);
            this.lbl_Customer_Name.Name = "lbl_Customer_Name";
            this.lbl_Customer_Name.Size = new System.Drawing.Size(193, 33);
            this.lbl_Customer_Name.TabIndex = 20;
            this.lbl_Customer_Name.Text = "Customer Name";
            // 
            // lbl_Customer_ID
            // 
            this.lbl_Customer_ID.AutoSize = true;
            this.lbl_Customer_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Customer_ID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_ID.Location = new System.Drawing.Point(108, 27);
            this.lbl_Customer_ID.Name = "lbl_Customer_ID";
            this.lbl_Customer_ID.Size = new System.Drawing.Size(157, 33);
            this.lbl_Customer_ID.TabIndex = 19;
            this.lbl_Customer_ID.Text = "Customer ID";
            // 
            // tb_Unit_Price
            // 
            this.tb_Unit_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Unit_Price.Enabled = false;
            this.tb_Unit_Price.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Unit_Price.Location = new System.Drawing.Point(330, 197);
            this.tb_Unit_Price.MaxLength = 10;
            this.tb_Unit_Price.Name = "tb_Unit_Price";
            this.tb_Unit_Price.Size = new System.Drawing.Size(317, 34);
            this.tb_Unit_Price.TabIndex = 26;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(112, 319);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(72, 33);
            this.lbl_Price.TabIndex = 25;
            this.lbl_Price.Text = "Price";
            // 
            // lbl_Unit_Price
            // 
            this.lbl_Unit_Price.AutoSize = true;
            this.lbl_Unit_Price.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit_Price.Location = new System.Drawing.Point(112, 198);
            this.lbl_Unit_Price.Name = "lbl_Unit_Price";
            this.lbl_Unit_Price.Size = new System.Drawing.Size(128, 33);
            this.lbl_Unit_Price.TabIndex = 23;
            this.lbl_Unit_Price.Text = "Unit Price";
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.Location = new System.Drawing.Point(112, 134);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(173, 33);
            this.lbl_Product_Name.TabIndex = 22;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // lbl_Subcategory
            // 
            this.lbl_Subcategory.AutoSize = true;
            this.lbl_Subcategory.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subcategory.Location = new System.Drawing.Point(112, 76);
            this.lbl_Subcategory.Name = "lbl_Subcategory";
            this.lbl_Subcategory.Size = new System.Drawing.Size(152, 33);
            this.lbl_Subcategory.TabIndex = 21;
            this.lbl_Subcategory.Text = "Subcategory";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(112, 23);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(115, 33);
            this.lbl_Category.TabIndex = 20;
            this.lbl_Category.Text = "Category";
            // 
            // dtp_Date
            // 
            this.dtp_Date.AllowDrop = true;
            this.dtp_Date.CalendarFont = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(1509, 60);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(141, 34);
            this.dtp_Date.TabIndex = 13;
            // 
            // pnl_Purchase_Details
            // 
            this.pnl_Purchase_Details.BackColor = System.Drawing.Color.LightGray;
            this.pnl_Purchase_Details.Controls.Add(this.btn_Clear);
            this.pnl_Purchase_Details.Controls.Add(this.btn_Add);
            this.pnl_Purchase_Details.Controls.Add(this.dgv_Purchase_Details);
            this.pnl_Purchase_Details.Controls.Add(this.cmb_Product_Name);
            this.pnl_Purchase_Details.Controls.Add(this.cmb_Subcategory);
            this.pnl_Purchase_Details.Controls.Add(this.cmb_Category);
            this.pnl_Purchase_Details.Controls.Add(this.tb_Price);
            this.pnl_Purchase_Details.Controls.Add(this.tb_Quantity);
            this.pnl_Purchase_Details.Controls.Add(this.tb_Unit_Price);
            this.pnl_Purchase_Details.Controls.Add(this.lbl_Price);
            this.pnl_Purchase_Details.Controls.Add(this.lbl_Quantity);
            this.pnl_Purchase_Details.Controls.Add(this.lbl_Unit_Price);
            this.pnl_Purchase_Details.Controls.Add(this.lbl_Product_Name);
            this.pnl_Purchase_Details.Controls.Add(this.lbl_Subcategory);
            this.pnl_Purchase_Details.Controls.Add(this.lbl_Category);
            this.pnl_Purchase_Details.Enabled = false;
            this.pnl_Purchase_Details.Location = new System.Drawing.Point(175, 304);
            this.pnl_Purchase_Details.Name = "pnl_Purchase_Details";
            this.pnl_Purchase_Details.Size = new System.Drawing.Size(1576, 389);
            this.pnl_Purchase_Details.TabIndex = 43;
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Black;
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.Location = new System.Drawing.Point(33, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(67, 59);
            this.btn_Back.TabIndex = 49;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Black;
            this.btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Image")));
            this.btn_Logout.Location = new System.Drawing.Point(1778, 25);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(75, 59);
            this.btn_Logout.TabIndex = 48;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // frm_Add_New_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1882, 953);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_Add_New_Customer);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_Bill_Details);
            this.Controls.Add(this.pnl_Bill_Details);
            this.Controls.Add(this.lbl_Purchase_Details);
            this.Controls.Add(this.lbl_Customer_Details);
            this.Controls.Add(this.pnl_Customer_Detials);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.pnl_Purchase_Details);
            this.Name = "frm_Add_New_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Customer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_New_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Purchase_Details)).EndInit();
            this.pnl_Bill_Details.ResumeLayout(false);
            this.pnl_Bill_Details.PerformLayout();
            this.pnl_Customer_Detials.ResumeLayout(false);
            this.pnl_Customer_Detials.PerformLayout();
            this.pnl_Purchase_Details.ResumeLayout(false);
            this.pnl_Purchase_Details.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dgv_Purchase_Details;
        private System.Windows.Forms.ComboBox cmb_Product_Name;
        private System.Windows.Forms.Label lbl_Add_New_Customer;
        private System.Windows.Forms.ComboBox cmb_Subcategory;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.Label lbl_Bill_Details;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TextBox tb_Total_Bill;
        private System.Windows.Forms.Panel pnl_Bill_Details;
        private System.Windows.Forms.TextBox tb_Discount;
        private System.Windows.Forms.TextBox tb_Total_Price;
        private System.Windows.Forms.Label lbl_Total_Bill;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.Label lbl_Total_Price;
        private System.Windows.Forms.Label lbl_Purchase_Details;
        private System.Windows.Forms.Label lbl_Customer_Details;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_Customer_Name;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.TextBox tb_Customer_ID;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Panel pnl_Customer_Detials;
        private System.Windows.Forms.Label lbl_Customer_Name;
        private System.Windows.Forms.Label lbl_Customer_ID;
        private System.Windows.Forms.TextBox tb_Unit_Price;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Unit_Price;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_Subcategory;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Panel pnl_Purchase_Details;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sr_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Logout;
    }
}