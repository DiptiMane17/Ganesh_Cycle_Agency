namespace Ganesh_Cycle_Agency
{
    partial class frm_View_Stock_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_View_Stock_Details));
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_View_Stock_Details = new System.Windows.Forms.Label();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Stock_Details = new System.Windows.Forms.Label();
            this.cmb_Subcategory_Name = new System.Windows.Forms.ComboBox();
            this.cmb_Category_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.pnl_View_Stock_Details = new System.Windows.Forms.Panel();
            this.lbl_Subcategory_Name = new System.Windows.Forms.Label();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.dgv_View_Stock_Details = new System.Windows.Forms.DataGridView();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.pnl_View_Stock_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Stock_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(970, 68);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(226, 70);
            this.btn_Refresh.TabIndex = 45;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // lbl_View_Stock_Details
            // 
            this.lbl_View_Stock_Details.AutoSize = true;
            this.lbl_View_Stock_Details.BackColor = System.Drawing.Color.Transparent;
            this.lbl_View_Stock_Details.Font = new System.Drawing.Font("Times New Roman", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Stock_Details.Location = new System.Drawing.Point(719, 35);
            this.lbl_View_Stock_Details.Name = "lbl_View_Stock_Details";
            this.lbl_View_Stock_Details.Size = new System.Drawing.Size(553, 77);
            this.lbl_View_Stock_Details.TabIndex = 47;
            this.lbl_View_Stock_Details.Text = "View Stock Details";
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(444, 171);
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(431, 39);
            this.cmb_Product_Name.TabIndex = 42;
            this.cmb_Product_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Product_Name_SelectedIndexChanged);
            // 
            // lbl_Stock_Details
            // 
            this.lbl_Stock_Details.AutoSize = true;
            this.lbl_Stock_Details.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stock_Details.Location = new System.Drawing.Point(83, 434);
            this.lbl_Stock_Details.Name = "lbl_Stock_Details";
            this.lbl_Stock_Details.Size = new System.Drawing.Size(171, 34);
            this.lbl_Stock_Details.TabIndex = 49;
            this.lbl_Stock_Details.Text = "Stock Details";
            // 
            // cmb_Subcategory_Name
            // 
            this.cmb_Subcategory_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Subcategory_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Subcategory_Name.FormattingEnabled = true;
            this.cmb_Subcategory_Name.Location = new System.Drawing.Point(444, 99);
            this.cmb_Subcategory_Name.Name = "cmb_Subcategory_Name";
            this.cmb_Subcategory_Name.Size = new System.Drawing.Size(431, 39);
            this.cmb_Subcategory_Name.TabIndex = 42;
            this.cmb_Subcategory_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Subcategory_Name_SelectedIndexChanged);
            // 
            // cmb_Category_Name
            // 
            this.cmb_Category_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category_Name.FormattingEnabled = true;
            this.cmb_Category_Name.Location = new System.Drawing.Point(444, 19);
            this.cmb_Category_Name.Name = "cmb_Category_Name";
            this.cmb_Category_Name.Size = new System.Drawing.Size(431, 39);
            this.cmb_Category_Name.TabIndex = 42;
            this.cmb_Category_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_Name_SelectedIndexChanged);
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.Location = new System.Drawing.Point(56, 176);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(187, 34);
            this.lbl_Product_Name.TabIndex = 41;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // pnl_View_Stock_Details
            // 
            this.pnl_View_Stock_Details.BackColor = System.Drawing.Color.Transparent;
            this.pnl_View_Stock_Details.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_View_Stock_Details.Controls.Add(this.btn_Refresh);
            this.pnl_View_Stock_Details.Controls.Add(this.cmb_Product_Name);
            this.pnl_View_Stock_Details.Controls.Add(this.cmb_Subcategory_Name);
            this.pnl_View_Stock_Details.Controls.Add(this.cmb_Category_Name);
            this.pnl_View_Stock_Details.Controls.Add(this.lbl_Product_Name);
            this.pnl_View_Stock_Details.Controls.Add(this.lbl_Subcategory_Name);
            this.pnl_View_Stock_Details.Controls.Add(this.lbl_Category_Name);
            this.pnl_View_Stock_Details.Location = new System.Drawing.Point(89, 176);
            this.pnl_View_Stock_Details.Name = "pnl_View_Stock_Details";
            this.pnl_View_Stock_Details.Size = new System.Drawing.Size(1695, 253);
            this.pnl_View_Stock_Details.TabIndex = 48;
            // 
            // lbl_Subcategory_Name
            // 
            this.lbl_Subcategory_Name.AutoSize = true;
            this.lbl_Subcategory_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Subcategory_Name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subcategory_Name.Location = new System.Drawing.Point(56, 99);
            this.lbl_Subcategory_Name.Name = "lbl_Subcategory_Name";
            this.lbl_Subcategory_Name.Size = new System.Drawing.Size(241, 34);
            this.lbl_Subcategory_Name.TabIndex = 40;
            this.lbl_Subcategory_Name.Text = "Subcategory Name";
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category_Name.Location = new System.Drawing.Point(56, 21);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(201, 34);
            this.lbl_Category_Name.TabIndex = 39;
            this.lbl_Category_Name.Text = "Category Name";
            // 
            // dgv_View_Stock_Details
            // 
            this.dgv_View_Stock_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Stock_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Stock_Details.Location = new System.Drawing.Point(89, 471);
            this.dgv_View_Stock_Details.Name = "dgv_View_Stock_Details";
            this.dgv_View_Stock_Details.RowTemplate.Height = 24;
            this.dgv_View_Stock_Details.Size = new System.Drawing.Size(1695, 449);
            this.dgv_View_Stock_Details.TabIndex = 50;
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Black;
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.Location = new System.Drawing.Point(32, 22);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(67, 59);
            this.btn_Back.TabIndex = 78;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Black;
            this.btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Image")));
            this.btn_Logout.Location = new System.Drawing.Point(1738, 12);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(75, 59);
            this.btn_Logout.TabIndex = 77;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // frm_View_Stock_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1882, 953);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_View_Stock_Details);
            this.Controls.Add(this.lbl_Stock_Details);
            this.Controls.Add(this.pnl_View_Stock_Details);
            this.Controls.Add(this.dgv_View_Stock_Details);
            this.Name = "frm_View_Stock_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm View Stock Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_View_Stock_Details_Load);
            this.pnl_View_Stock_Details.ResumeLayout(false);
            this.pnl_View_Stock_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Stock_Details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label lbl_View_Stock_Details;
        private System.Windows.Forms.ComboBox cmb_Product_Name;
        private System.Windows.Forms.Label lbl_Stock_Details;
        private System.Windows.Forms.ComboBox cmb_Subcategory_Name;
        private System.Windows.Forms.ComboBox cmb_Category_Name;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Panel pnl_View_Stock_Details;
        private System.Windows.Forms.Label lbl_Subcategory_Name;
        private System.Windows.Forms.Label lbl_Category_Name;
        private System.Windows.Forms.DataGridView dgv_View_Stock_Details;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Logout;
    }
}