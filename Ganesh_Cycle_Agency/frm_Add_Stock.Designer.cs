namespace Ganesh_Cycle_Agency
{
    partial class frm_Add_Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_Stock));
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Product_ID = new System.Windows.Forms.Label();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.cmb_Subcategory = new System.Windows.Forms.ComboBox();
            this.lbl_Subcategory = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_New_Stock_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_New_Stock_Quantity = new System.Windows.Forms.Label();
            this.tb_Current_Stock_Quantity = new System.Windows.Forms.TextBox();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.lbl_Current_Stock_Quantity = new System.Windows.Forms.Label();
            this.lbl_Add_Stock = new System.Windows.Forms.Label();
            this.pnl_Stock = new System.Windows.Forms.Panel();
            this.pnl_Stock.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Product_ID.Enabled = false;
            this.tb_Product_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_ID.Location = new System.Drawing.Point(1016, 166);
            this.tb_Product_ID.MaxLength = 10;
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(337, 38);
            this.tb_Product_ID.TabIndex = 47;
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.Location = new System.Drawing.Point(101, 170);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(187, 34);
            this.lbl_Product_Name.TabIndex = 43;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // lbl_Product_ID
            // 
            this.lbl_Product_ID.AutoSize = true;
            this.lbl_Product_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Product_ID.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_ID.Location = new System.Drawing.Point(795, 171);
            this.lbl_Product_ID.Name = "lbl_Product_ID";
            this.lbl_Product_ID.Size = new System.Drawing.Size(147, 34);
            this.lbl_Product_ID.TabIndex = 48;
            this.lbl_Product_ID.Text = "Product ID";
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(331, 169);
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(337, 39);
            this.cmb_Product_Name.TabIndex = 3;
            this.cmb_Product_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Product_Name_SelectedIndexChanged);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.Location = new System.Drawing.Point(61, 35);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(63, 60);
            this.btn_Back.TabIndex = 71;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // cmb_Subcategory
            // 
            this.cmb_Subcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Subcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Subcategory.FormattingEnabled = true;
            this.cmb_Subcategory.Location = new System.Drawing.Point(1016, 62);
            this.cmb_Subcategory.Name = "cmb_Subcategory";
            this.cmb_Subcategory.Size = new System.Drawing.Size(337, 39);
            this.cmb_Subcategory.TabIndex = 2;
            this.cmb_Subcategory.SelectedIndexChanged += new System.EventHandler(this.cmb_Subcategory_SelectedIndexChanged);
            // 
            // lbl_Subcategory
            // 
            this.lbl_Subcategory.AutoSize = true;
            this.lbl_Subcategory.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Subcategory.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subcategory.Location = new System.Drawing.Point(795, 62);
            this.lbl_Subcategory.Name = "lbl_Subcategory";
            this.lbl_Subcategory.Size = new System.Drawing.Size(162, 34);
            this.lbl_Subcategory.TabIndex = 42;
            this.lbl_Subcategory.Text = "Subcategory";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Category.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(101, 61);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(122, 34);
            this.lbl_Category.TabIndex = 44;
            this.lbl_Category.Text = "Category";
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Black;
            this.btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Image")));
            this.btn_Logout.Location = new System.Drawing.Point(1773, 35);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(58, 60);
            this.btn_Logout.TabIndex = 72;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(1172, 782);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(264, 64);
            this.btn_Refresh.TabIndex = 70;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Submit.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(521, 782);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(233, 64);
            this.btn_Submit.TabIndex = 69;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(1432, 182);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(215, 34);
            this.dtp_Date.TabIndex = 68;
            // 
            // tb_New_Stock_Quantity
            // 
            this.tb_New_Stock_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_New_Stock_Quantity.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_New_Stock_Quantity.Location = new System.Drawing.Point(1161, 634);
            this.tb_New_Stock_Quantity.MaxLength = 10;
            this.tb_New_Stock_Quantity.Name = "tb_New_Stock_Quantity";
            this.tb_New_Stock_Quantity.Size = new System.Drawing.Size(336, 39);
            this.tb_New_Stock_Quantity.TabIndex = 67;
            this.tb_New_Stock_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_New_Stock_Quantity
            // 
            this.lbl_New_Stock_Quantity.AutoSize = true;
            this.lbl_New_Stock_Quantity.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_New_Stock_Quantity.Location = new System.Drawing.Point(611, 634);
            this.lbl_New_Stock_Quantity.Name = "lbl_New_Stock_Quantity";
            this.lbl_New_Stock_Quantity.Size = new System.Drawing.Size(256, 34);
            this.lbl_New_Stock_Quantity.TabIndex = 74;
            this.lbl_New_Stock_Quantity.Text = "New Stock Quantity";
            // 
            // tb_Current_Stock_Quantity
            // 
            this.tb_Current_Stock_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Current_Stock_Quantity.Enabled = false;
            this.tb_Current_Stock_Quantity.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Current_Stock_Quantity.Location = new System.Drawing.Point(1161, 542);
            this.tb_Current_Stock_Quantity.MaxLength = 10;
            this.tb_Current_Stock_Quantity.Name = "tb_Current_Stock_Quantity";
            this.tb_Current_Stock_Quantity.Size = new System.Drawing.Size(336, 39);
            this.tb_Current_Stock_Quantity.TabIndex = 66;
            this.tb_Current_Stock_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // cmb_Category
            // 
            this.cmb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(331, 60);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(337, 39);
            this.cmb_Category.TabIndex = 1;
            this.cmb_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_SelectedIndexChanged);
            // 
            // lbl_Current_Stock_Quantity
            // 
            this.lbl_Current_Stock_Quantity.AutoSize = true;
            this.lbl_Current_Stock_Quantity.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Current_Stock_Quantity.Location = new System.Drawing.Point(611, 542);
            this.lbl_Current_Stock_Quantity.Name = "lbl_Current_Stock_Quantity";
            this.lbl_Current_Stock_Quantity.Size = new System.Drawing.Size(291, 34);
            this.lbl_Current_Stock_Quantity.TabIndex = 75;
            this.lbl_Current_Stock_Quantity.Text = "Current Stock Quantity";
            // 
            // lbl_Add_Stock
            // 
            this.lbl_Add_Stock.AutoSize = true;
            this.lbl_Add_Stock.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Add_Stock.Font = new System.Drawing.Font("Times New Roman", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Stock.Location = new System.Drawing.Point(785, 98);
            this.lbl_Add_Stock.Name = "lbl_Add_Stock";
            this.lbl_Add_Stock.Size = new System.Drawing.Size(320, 77);
            this.lbl_Add_Stock.TabIndex = 73;
            this.lbl_Add_Stock.Text = "Add Stock";
            // 
            // pnl_Stock
            // 
            this.pnl_Stock.BackColor = System.Drawing.Color.White;
            this.pnl_Stock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Stock.Controls.Add(this.tb_Product_ID);
            this.pnl_Stock.Controls.Add(this.lbl_Product_Name);
            this.pnl_Stock.Controls.Add(this.lbl_Product_ID);
            this.pnl_Stock.Controls.Add(this.cmb_Product_Name);
            this.pnl_Stock.Controls.Add(this.cmb_Subcategory);
            this.pnl_Stock.Controls.Add(this.lbl_Subcategory);
            this.pnl_Stock.Controls.Add(this.lbl_Category);
            this.pnl_Stock.Controls.Add(this.cmb_Category);
            this.pnl_Stock.Location = new System.Drawing.Point(254, 241);
            this.pnl_Stock.Name = "pnl_Stock";
            this.pnl_Stock.Size = new System.Drawing.Size(1393, 246);
            this.pnl_Stock.TabIndex = 65;
            // 
            // frm_Add_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1882, 953);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.tb_New_Stock_Quantity);
            this.Controls.Add(this.lbl_New_Stock_Quantity);
            this.Controls.Add(this.tb_Current_Stock_Quantity);
            this.Controls.Add(this.lbl_Current_Stock_Quantity);
            this.Controls.Add(this.lbl_Add_Stock);
            this.Controls.Add(this.pnl_Stock);
            this.Name = "frm_Add_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_Stock_Load);
            this.pnl_Stock.ResumeLayout(false);
            this.pnl_Stock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Product_ID;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_Product_ID;
        private System.Windows.Forms.ComboBox cmb_Product_Name;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.ComboBox cmb_Subcategory;
        private System.Windows.Forms.Label lbl_Subcategory;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.TextBox tb_New_Stock_Quantity;
        private System.Windows.Forms.Label lbl_New_Stock_Quantity;
        private System.Windows.Forms.TextBox tb_Current_Stock_Quantity;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.Label lbl_Current_Stock_Quantity;
        private System.Windows.Forms.Label lbl_Add_Stock;
        private System.Windows.Forms.Panel pnl_Stock;
    }
}