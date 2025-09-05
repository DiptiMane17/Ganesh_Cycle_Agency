namespace Ganesh_Cycle_Agency
{
    partial class frm_View_All_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_View_All_Employee));
            this.dgv_View_Employee = new System.Windows.Forms.DataGridView();
            this.lbl_View_All_Employee = new System.Windows.Forms.Label();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.pnl_Search_Or_Update_Employee = new System.Windows.Forms.Panel();
            this.cmb_Search_By = new System.Windows.Forms.ComboBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_Registration_N0 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Employee)).BeginInit();
            this.pnl_Search_Or_Update_Employee.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_View_Employee
            // 
            this.dgv_View_Employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Employee.Location = new System.Drawing.Point(45, 303);
            this.dgv_View_Employee.Name = "dgv_View_Employee";
            this.dgv_View_Employee.RowTemplate.Height = 24;
            this.dgv_View_Employee.Size = new System.Drawing.Size(1743, 618);
            this.dgv_View_Employee.TabIndex = 74;
            // 
            // lbl_View_All_Employee
            // 
            this.lbl_View_All_Employee.AutoSize = true;
            this.lbl_View_All_Employee.Font = new System.Drawing.Font("Times New Roman", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_All_Employee.Location = new System.Drawing.Point(562, 21);
            this.lbl_View_All_Employee.Name = "lbl_View_All_Employee";
            this.lbl_View_All_Employee.Size = new System.Drawing.Size(559, 77);
            this.lbl_View_All_Employee.TabIndex = 72;
            this.lbl_View_All_Employee.Text = "View All Employee";
            // 
            // tb_Search
            // 
            this.tb_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Search.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Search.Location = new System.Drawing.Point(610, 27);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(331, 45);
            this.tb_Search.TabIndex = 76;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // pnl_Search_Or_Update_Employee
            // 
            this.pnl_Search_Or_Update_Employee.BackColor = System.Drawing.Color.LightGray;
            this.pnl_Search_Or_Update_Employee.Controls.Add(this.cmb_Search_By);
            this.pnl_Search_Or_Update_Employee.Controls.Add(this.tb_Search);
            this.pnl_Search_Or_Update_Employee.Controls.Add(this.btn_Refresh);
            this.pnl_Search_Or_Update_Employee.Controls.Add(this.lbl_Registration_N0);
            this.pnl_Search_Or_Update_Employee.Location = new System.Drawing.Point(45, 163);
            this.pnl_Search_Or_Update_Employee.Name = "pnl_Search_Or_Update_Employee";
            this.pnl_Search_Or_Update_Employee.Size = new System.Drawing.Size(1743, 108);
            this.pnl_Search_Or_Update_Employee.TabIndex = 73;
            // 
            // cmb_Search_By
            // 
            this.cmb_Search_By.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Search_By.FormattingEnabled = true;
            this.cmb_Search_By.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.cmb_Search_By.Location = new System.Drawing.Point(157, 25);
            this.cmb_Search_By.Name = "cmb_Search_By";
            this.cmb_Search_By.Size = new System.Drawing.Size(300, 45);
            this.cmb_Search_By.TabIndex = 78;
            this.cmb_Search_By.SelectedIndexChanged += new System.EventHandler(this.smb_Search_By_SelectedIndexChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(1208, 16);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(241, 68);
            this.btn_Refresh.TabIndex = 75;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // lbl_Registration_N0
            // 
            this.lbl_Registration_N0.AutoSize = true;
            this.lbl_Registration_N0.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Registration_N0.Location = new System.Drawing.Point(397, 38);
            this.lbl_Registration_N0.Name = "lbl_Registration_N0";
            this.lbl_Registration_N0.Size = new System.Drawing.Size(0, 34);
            this.lbl_Registration_N0.TabIndex = 74;
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Black;
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.Location = new System.Drawing.Point(45, 21);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(67, 59);
            this.btn_Back.TabIndex = 76;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Black;
            this.btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Image")));
            this.btn_Logout.Location = new System.Drawing.Point(1725, 21);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(75, 59);
            this.btn_Logout.TabIndex = 75;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // frm_View_All_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1882, 953);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.dgv_View_Employee);
            this.Controls.Add(this.lbl_View_All_Employee);
            this.Controls.Add(this.pnl_Search_Or_Update_Employee);
            this.Name = "frm_View_All_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_View_All_Employee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_View_All_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Employee)).EndInit();
            this.pnl_Search_Or_Update_Employee.ResumeLayout(false);
            this.pnl_Search_Or_Update_Employee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_View_Employee;
        private System.Windows.Forms.Label lbl_View_All_Employee;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Panel pnl_Search_Or_Update_Employee;
        private System.Windows.Forms.Label lbl_Registration_N0;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.ComboBox cmb_Search_By;
    }
}