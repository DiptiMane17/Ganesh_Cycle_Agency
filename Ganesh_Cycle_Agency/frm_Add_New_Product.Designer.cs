namespace Ganesh_Cycle_Agency
{
    partial class frm_Add_New_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_New_Product));
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.tb_Discription = new System.Windows.Forms.TextBox();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Stock_Quantity = new System.Windows.Forms.TextBox();
            this.tb_Purchase_Rate = new System.Windows.Forms.TextBox();
            this.tb_Sales_Rate = new System.Windows.Forms.TextBox();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.cmb_Distributor_Name = new System.Windows.Forms.ComboBox();
            this.cmb_Subcategory = new System.Windows.Forms.ComboBox();
            this.lbl_Stock_Quantity = new System.Windows.Forms.Label();
            this.lbl_Purchase_Rate = new System.Windows.Forms.Label();
            this.lbl_Sales_Rate = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Distributor_Name = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Subcategory = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Product_ID = new System.Windows.Forms.Label();
            this.lbl_Add_New_Product = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.Location = new System.Drawing.Point(34, 8);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(70, 64);
            this.btn_Back.TabIndex = 116;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Black;
            this.btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Image")));
            this.btn_Logout.Location = new System.Drawing.Point(1758, 12);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(79, 64);
            this.btn_Logout.TabIndex = 117;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // tb_Discription
            // 
            this.tb_Discription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Discription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Discription.Location = new System.Drawing.Point(1187, 594);
            this.tb_Discription.MaxLength = 50;
            this.tb_Discription.Multiline = true;
            this.tb_Discription.Name = "tb_Discription";
            this.tb_Discription.Size = new System.Drawing.Size(350, 98);
            this.tb_Discription.TabIndex = 101;
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Description.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.Location = new System.Drawing.Point(954, 617);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(167, 37);
            this.lbl_Description.TabIndex = 115;
            this.lbl_Description.Text = "Description";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.LightGray;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(1116, 769);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(226, 70);
            this.btn_Refresh.TabIndex = 103;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LightGray;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(481, 769);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(226, 70);
            this.btn_Save.TabIndex = 102;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // dtp_Date
            // 
            this.dtp_Date.CalendarFont = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dtp_Date.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(1187, 221);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(350, 34);
            this.dtp_Date.TabIndex = 97;
            // 
            // tb_Stock_Quantity
            // 
            this.tb_Stock_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Stock_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stock_Quantity.Location = new System.Drawing.Point(1185, 483);
            this.tb_Stock_Quantity.MaxLength = 10;
            this.tb_Stock_Quantity.Name = "tb_Stock_Quantity";
            this.tb_Stock_Quantity.Size = new System.Drawing.Size(350, 38);
            this.tb_Stock_Quantity.TabIndex = 100;
            this.tb_Stock_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Purchase_Rate
            // 
            this.tb_Purchase_Rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Purchase_Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purchase_Rate.Location = new System.Drawing.Point(1185, 404);
            this.tb_Purchase_Rate.MaxLength = 10;
            this.tb_Purchase_Rate.Name = "tb_Purchase_Rate";
            this.tb_Purchase_Rate.Size = new System.Drawing.Size(350, 38);
            this.tb_Purchase_Rate.TabIndex = 99;
            this.tb_Purchase_Rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Sales_Rate
            // 
            this.tb_Sales_Rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Sales_Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sales_Rate.Location = new System.Drawing.Point(1185, 309);
            this.tb_Sales_Rate.MaxLength = 10;
            this.tb_Sales_Rate.Name = "tb_Sales_Rate";
            this.tb_Sales_Rate.Size = new System.Drawing.Size(350, 38);
            this.tb_Sales_Rate.TabIndex = 98;
            this.tb_Sales_Rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Name.Location = new System.Drawing.Point(526, 510);
            this.tb_Product_Name.MaxLength = 20;
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(337, 38);
            this.tb_Product_Name.TabIndex = 95;
            this.tb_Product_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_TextDigit);
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Product_ID.Enabled = false;
            this.tb_Product_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_ID.Location = new System.Drawing.Point(526, 221);
            this.tb_Product_ID.MaxLength = 10;
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(337, 38);
            this.tb_Product_ID.TabIndex = 104;
            // 
            // cmb_Category
            // 
            this.cmb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(524, 311);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(337, 39);
            this.cmb_Category.TabIndex = 93;
            this.cmb_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_SelectedIndexChanged);
            // 
            // cmb_Distributor_Name
            // 
            this.cmb_Distributor_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Distributor_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Distributor_Name.FormattingEnabled = true;
            this.cmb_Distributor_Name.Location = new System.Drawing.Point(524, 615);
            this.cmb_Distributor_Name.Name = "cmb_Distributor_Name";
            this.cmb_Distributor_Name.Size = new System.Drawing.Size(337, 39);
            this.cmb_Distributor_Name.TabIndex = 96;
            // 
            // cmb_Subcategory
            // 
            this.cmb_Subcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Subcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Subcategory.FormattingEnabled = true;
            this.cmb_Subcategory.Location = new System.Drawing.Point(524, 404);
            this.cmb_Subcategory.Name = "cmb_Subcategory";
            this.cmb_Subcategory.Size = new System.Drawing.Size(337, 39);
            this.cmb_Subcategory.TabIndex = 94;
            // 
            // lbl_Stock_Quantity
            // 
            this.lbl_Stock_Quantity.AutoSize = true;
            this.lbl_Stock_Quantity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Stock_Quantity.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stock_Quantity.Location = new System.Drawing.Point(955, 486);
            this.lbl_Stock_Quantity.Name = "lbl_Stock_Quantity";
            this.lbl_Stock_Quantity.Size = new System.Drawing.Size(192, 34);
            this.lbl_Stock_Quantity.TabIndex = 114;
            this.lbl_Stock_Quantity.Text = "Stock Quantity";
            // 
            // lbl_Purchase_Rate
            // 
            this.lbl_Purchase_Rate.AutoSize = true;
            this.lbl_Purchase_Rate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Purchase_Rate.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Rate.Location = new System.Drawing.Point(955, 405);
            this.lbl_Purchase_Rate.Name = "lbl_Purchase_Rate";
            this.lbl_Purchase_Rate.Size = new System.Drawing.Size(184, 34);
            this.lbl_Purchase_Rate.TabIndex = 113;
            this.lbl_Purchase_Rate.Text = "Purchase Rate";
            // 
            // lbl_Sales_Rate
            // 
            this.lbl_Sales_Rate.AutoSize = true;
            this.lbl_Sales_Rate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Sales_Rate.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sales_Rate.Location = new System.Drawing.Point(955, 317);
            this.lbl_Sales_Rate.Name = "lbl_Sales_Rate";
            this.lbl_Sales_Rate.Size = new System.Drawing.Size(138, 34);
            this.lbl_Sales_Rate.TabIndex = 111;
            this.lbl_Sales_Rate.Text = "Sales Rate";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(960, 220);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(71, 34);
            this.lbl_Date.TabIndex = 112;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_Distributor_Name
            // 
            this.lbl_Distributor_Name.AutoSize = true;
            this.lbl_Distributor_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Distributor_Name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Distributor_Name.Location = new System.Drawing.Point(247, 614);
            this.lbl_Distributor_Name.Name = "lbl_Distributor_Name";
            this.lbl_Distributor_Name.Size = new System.Drawing.Size(222, 34);
            this.lbl_Distributor_Name.TabIndex = 107;
            this.lbl_Distributor_Name.Text = "Distributor Name";
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.Location = new System.Drawing.Point(249, 512);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(187, 34);
            this.lbl_Product_Name.TabIndex = 106;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // lbl_Subcategory
            // 
            this.lbl_Subcategory.AutoSize = true;
            this.lbl_Subcategory.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Subcategory.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subcategory.Location = new System.Drawing.Point(247, 409);
            this.lbl_Subcategory.Name = "lbl_Subcategory";
            this.lbl_Subcategory.Size = new System.Drawing.Size(162, 34);
            this.lbl_Subcategory.TabIndex = 105;
            this.lbl_Subcategory.Text = "Subcategory";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Category.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(247, 313);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(122, 34);
            this.lbl_Category.TabIndex = 110;
            this.lbl_Category.Text = "Category";
            // 
            // lbl_Product_ID
            // 
            this.lbl_Product_ID.AutoSize = true;
            this.lbl_Product_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Product_ID.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_ID.Location = new System.Drawing.Point(247, 225);
            this.lbl_Product_ID.Name = "lbl_Product_ID";
            this.lbl_Product_ID.Size = new System.Drawing.Size(147, 34);
            this.lbl_Product_ID.TabIndex = 109;
            this.lbl_Product_ID.Text = "Product ID";
            // 
            // lbl_Add_New_Product
            // 
            this.lbl_Add_New_Product.AutoSize = true;
            this.lbl_Add_New_Product.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Add_New_Product.Font = new System.Drawing.Font("Times New Roman", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Product.Location = new System.Drawing.Point(650, 47);
            this.lbl_Add_New_Product.Name = "lbl_Add_New_Product";
            this.lbl_Add_New_Product.Size = new System.Drawing.Size(522, 77);
            this.lbl_Add_New_Product.TabIndex = 108;
            this.lbl_Add_New_Product.Text = "Add New Product";
            // 
            // frm_Add_New_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1882, 953);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.tb_Discription);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.tb_Stock_Quantity);
            this.Controls.Add(this.tb_Purchase_Rate);
            this.Controls.Add(this.tb_Sales_Rate);
            this.Controls.Add(this.tb_Product_Name);
            this.Controls.Add(this.tb_Product_ID);
            this.Controls.Add(this.cmb_Category);
            this.Controls.Add(this.cmb_Distributor_Name);
            this.Controls.Add(this.cmb_Subcategory);
            this.Controls.Add(this.lbl_Stock_Quantity);
            this.Controls.Add(this.lbl_Purchase_Rate);
            this.Controls.Add(this.lbl_Sales_Rate);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Distributor_Name);
            this.Controls.Add(this.lbl_Product_Name);
            this.Controls.Add(this.lbl_Subcategory);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.lbl_Product_ID);
            this.Controls.Add(this.lbl_Add_New_Product);
            this.Name = "frm_Add_New_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Product";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_New_Product_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.TextBox tb_Discription;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.TextBox tb_Stock_Quantity;
        private System.Windows.Forms.TextBox tb_Purchase_Rate;
        private System.Windows.Forms.TextBox tb_Sales_Rate;
        private System.Windows.Forms.TextBox tb_Product_Name;
        private System.Windows.Forms.TextBox tb_Product_ID;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.ComboBox cmb_Distributor_Name;
        private System.Windows.Forms.ComboBox cmb_Subcategory;
        private System.Windows.Forms.Label lbl_Stock_Quantity;
        private System.Windows.Forms.Label lbl_Purchase_Rate;
        private System.Windows.Forms.Label lbl_Sales_Rate;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Distributor_Name;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_Subcategory;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Product_ID;
        private System.Windows.Forms.Label lbl_Add_New_Product;
    }
}