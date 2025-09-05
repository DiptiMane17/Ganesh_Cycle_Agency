namespace Ganesh_Cycle_Agency
{
    partial class frm_Add_New_Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_New_Category));
            this.pnl_Category = new System.Windows.Forms.Panel();
            this.lbl_Add_New_Category = new System.Windows.Forms.Label();
            this.lbl_Category_ID = new System.Windows.Forms.Label();
            this.tb_Category_Name = new System.Windows.Forms.TextBox();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Category_ID = new System.Windows.Forms.TextBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.pnl_Category.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Category
            // 
            this.pnl_Category.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Category.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Category.Controls.Add(this.lbl_Add_New_Category);
            this.pnl_Category.Controls.Add(this.lbl_Category_ID);
            this.pnl_Category.Controls.Add(this.tb_Category_Name);
            this.pnl_Category.Controls.Add(this.lbl_Category_Name);
            this.pnl_Category.Controls.Add(this.btn_Save);
            this.pnl_Category.Controls.Add(this.tb_Category_ID);
            this.pnl_Category.Location = new System.Drawing.Point(418, 153);
            this.pnl_Category.Name = "pnl_Category";
            this.pnl_Category.Size = new System.Drawing.Size(1033, 624);
            this.pnl_Category.TabIndex = 7;
            // 
            // lbl_Add_New_Category
            // 
            this.lbl_Add_New_Category.AutoSize = true;
            this.lbl_Add_New_Category.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Add_New_Category.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Category.Location = new System.Drawing.Point(267, 49);
            this.lbl_Add_New_Category.Name = "lbl_Add_New_Category";
            this.lbl_Add_New_Category.Size = new System.Drawing.Size(492, 68);
            this.lbl_Add_New_Category.TabIndex = 0;
            this.lbl_Add_New_Category.Text = "Add New Category";
            // 
            // lbl_Category_ID
            // 
            this.lbl_Category_ID.AutoSize = true;
            this.lbl_Category_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Category_ID.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category_ID.Location = new System.Drawing.Point(171, 232);
            this.lbl_Category_ID.Name = "lbl_Category_ID";
            this.lbl_Category_ID.Size = new System.Drawing.Size(179, 37);
            this.lbl_Category_ID.TabIndex = 1;
            this.lbl_Category_ID.Text = "Category ID";
            // 
            // tb_Category_Name
            // 
            this.tb_Category_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Category_Name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Category_Name.Location = new System.Drawing.Point(579, 371);
            this.tb_Category_Name.MaxLength = 20;
            this.tb_Category_Name.Name = "tb_Category_Name";
            this.tb_Category_Name.Size = new System.Drawing.Size(313, 42);
            this.tb_Category_Name.TabIndex = 2;
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category_Name.Location = new System.Drawing.Point(171, 375);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(222, 37);
            this.lbl_Category_Name.TabIndex = 1;
            this.lbl_Category_Name.Text = "Category Name";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Silver;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(375, 502);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(196, 61);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Category_ID
            // 
            this.tb_Category_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Category_ID.Enabled = false;
            this.tb_Category_ID.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Category_ID.Location = new System.Drawing.Point(579, 228);
            this.tb_Category_ID.MaxLength = 10;
            this.tb_Category_ID.Name = "tb_Category_ID";
            this.tb_Category_ID.Size = new System.Drawing.Size(313, 42);
            this.tb_Category_ID.TabIndex = 1;
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.Location = new System.Drawing.Point(65, 35);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(63, 54);
            this.btn_Back.TabIndex = 124;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Black;
            this.btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Image")));
            this.btn_Logout.Location = new System.Drawing.Point(1753, 32);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(79, 57);
            this.btn_Logout.TabIndex = 125;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // frm_Add_New_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1882, 953);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.pnl_Category);
            this.Name = "frm_Add_New_Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Category";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_New_Category_Load);
            this.pnl_Category.ResumeLayout(false);
            this.pnl_Category.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Category;
        private System.Windows.Forms.Label lbl_Add_New_Category;
        private System.Windows.Forms.Label lbl_Category_ID;
        private System.Windows.Forms.TextBox tb_Category_Name;
        private System.Windows.Forms.Label lbl_Category_Name;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Category_ID;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Logout;
    }
}