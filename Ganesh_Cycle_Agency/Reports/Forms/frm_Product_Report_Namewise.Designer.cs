namespace Ganesh_Cycle_Agency.Reports.Forms
{
    partial class frm_Product_Report_Namewise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Product_Report_Namewise));
            this.lbl_Product_ID = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.crv_Product_Report_Name = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.lbl_Ganesh_Cycle_Agency = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Product_ID
            // 
            this.lbl_Product_ID.AutoSize = true;
            this.lbl_Product_ID.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_ID.Location = new System.Drawing.Point(116, 157);
            this.lbl_Product_ID.Name = "lbl_Product_ID";
            this.lbl_Product_ID.Size = new System.Drawing.Size(161, 37);
            this.lbl_Product_ID.TabIndex = 1;
            this.lbl_Product_ID.Text = "Product ID";
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(785, 138);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(162, 56);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // crv_Product_Report_Name
            // 
            this.crv_Product_Report_Name.ActiveViewIndex = -1;
            this.crv_Product_Report_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Product_Report_Name.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Product_Report_Name.Location = new System.Drawing.Point(58, 234);
            this.crv_Product_Report_Name.Name = "crv_Product_Report_Name";
            this.crv_Product_Report_Name.Size = new System.Drawing.Size(1796, 707);
            this.crv_Product_Report_Name.TabIndex = 3;
            this.crv_Product_Report_Name.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Product_ID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_ID.Location = new System.Drawing.Point(382, 156);
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(275, 34);
            this.tb_Product_ID.TabIndex = 4;
            // 
            // lbl_Ganesh_Cycle_Agency
            // 
            this.lbl_Ganesh_Cycle_Agency.AutoSize = true;
            this.lbl_Ganesh_Cycle_Agency.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ganesh_Cycle_Agency.Location = new System.Drawing.Point(670, 22);
            this.lbl_Ganesh_Cycle_Agency.Name = "lbl_Ganesh_Cycle_Agency";
            this.lbl_Ganesh_Cycle_Agency.Size = new System.Drawing.Size(557, 68);
            this.lbl_Ganesh_Cycle_Agency.TabIndex = 5;
            this.lbl_Ganesh_Cycle_Agency.Text = "Ganesh Cycle Agency";
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Black;
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.Location = new System.Drawing.Point(58, 22);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(67, 55);
            this.btn_Back.TabIndex = 21;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Black;
            this.btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Image")));
            this.btn_Logout.Location = new System.Drawing.Point(1719, 22);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(75, 55);
            this.btn_Logout.TabIndex = 20;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // frm_Product_Report_Namewise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1882, 953);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_Ganesh_Cycle_Agency);
            this.Controls.Add(this.tb_Product_ID);
            this.Controls.Add(this.crv_Product_Report_Name);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lbl_Product_ID);
            this.Name = "frm_Product_Report_Namewise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Report ID";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Product_Report_Namewise_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Product_ID;
        private System.Windows.Forms.Button btn_Search;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Product_Report_Name;
        private System.Windows.Forms.TextBox tb_Product_ID;
        private System.Windows.Forms.Label lbl_Ganesh_Cycle_Agency;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Logout;
    }
}