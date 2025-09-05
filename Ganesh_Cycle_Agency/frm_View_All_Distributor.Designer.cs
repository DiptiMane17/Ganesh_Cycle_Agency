namespace Ganesh_Cycle_Agency
{
    partial class frm_View_All_Distributor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_View_All_Distributor));
            this.pnl_Search_Or_Update = new System.Windows.Forms.Panel();
            this.cmb_Search_By = new System.Windows.Forms.ComboBox();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_View_All_Distributors = new System.Windows.Forms.Label();
            this.dgv_View_All_Distributors = new System.Windows.Forms.DataGridView();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.pnl_Search_Or_Update.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Distributors)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Search_Or_Update
            // 
            this.pnl_Search_Or_Update.BackColor = System.Drawing.Color.LightGray;
            this.pnl_Search_Or_Update.Controls.Add(this.cmb_Search_By);
            this.pnl_Search_Or_Update.Controls.Add(this.tb_Search);
            this.pnl_Search_Or_Update.Controls.Add(this.btn_Refresh);
            this.pnl_Search_Or_Update.Location = new System.Drawing.Point(154, 142);
            this.pnl_Search_Or_Update.Name = "pnl_Search_Or_Update";
            this.pnl_Search_Or_Update.Size = new System.Drawing.Size(1632, 78);
            this.pnl_Search_Or_Update.TabIndex = 54;
            // 
            // cmb_Search_By
            // 
            this.cmb_Search_By.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Search_By.FormattingEnabled = true;
            this.cmb_Search_By.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.cmb_Search_By.Location = new System.Drawing.Point(104, 14);
            this.cmb_Search_By.Name = "cmb_Search_By";
            this.cmb_Search_By.Size = new System.Drawing.Size(300, 45);
            this.cmb_Search_By.TabIndex = 82;
            this.cmb_Search_By.SelectedIndexChanged += new System.EventHandler(this.cmb_Search_By_SelectedIndexChanged);
            // 
            // tb_Search
            // 
            this.tb_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Search.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Search.Location = new System.Drawing.Point(695, 15);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(331, 45);
            this.tb_Search.TabIndex = 80;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(1287, 5);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(241, 68);
            this.btn_Refresh.TabIndex = 79;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // lbl_View_All_Distributors
            // 
            this.lbl_View_All_Distributors.AutoSize = true;
            this.lbl_View_All_Distributors.Font = new System.Drawing.Font("Times New Roman", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_All_Distributors.Location = new System.Drawing.Point(722, 29);
            this.lbl_View_All_Distributors.Name = "lbl_View_All_Distributors";
            this.lbl_View_All_Distributors.Size = new System.Drawing.Size(613, 77);
            this.lbl_View_All_Distributors.TabIndex = 55;
            this.lbl_View_All_Distributors.Text = "View All Distributors";
            // 
            // dgv_View_All_Distributors
            // 
            this.dgv_View_All_Distributors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_All_Distributors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_All_Distributors.Location = new System.Drawing.Point(154, 255);
            this.dgv_View_All_Distributors.Name = "dgv_View_All_Distributors";
            this.dgv_View_All_Distributors.RowTemplate.Height = 24;
            this.dgv_View_All_Distributors.Size = new System.Drawing.Size(1632, 648);
            this.dgv_View_All_Distributors.TabIndex = 5;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Black;
            this.btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Image")));
            this.btn_Logout.Location = new System.Drawing.Point(1775, 16);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(68, 59);
            this.btn_Logout.TabIndex = 141;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.Location = new System.Drawing.Point(56, 29);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(63, 59);
            this.btn_Back.TabIndex = 140;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // frm_View_All_Distributor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1882, 953);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.pnl_Search_Or_Update);
            this.Controls.Add(this.lbl_View_All_Distributors);
            this.Controls.Add(this.dgv_View_All_Distributors);
            this.Name = "frm_View_All_Distributor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm View All Distributor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_View_All_Distributor_Load);
            this.pnl_Search_Or_Update.ResumeLayout(false);
            this.pnl_Search_Or_Update.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Distributors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Search_Or_Update;
        private System.Windows.Forms.Label lbl_View_All_Distributors;
        private System.Windows.Forms.DataGridView dgv_View_All_Distributors;
        private System.Windows.Forms.ComboBox cmb_Search_By;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Back;
    }
}