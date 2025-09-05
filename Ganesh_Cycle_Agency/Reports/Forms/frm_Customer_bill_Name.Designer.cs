namespace Ganesh_Cycle_Agency.Reports.Forms
{
    partial class frm_Customer_bill_Name
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Customer_bill_Name));
            this.crv_Customer_Bill_Name = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lbl_Customer_Name = new System.Windows.Forms.Label();
            this.tb_Customer_Name = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Ganesh_Cycle_Agency = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crv_Customer_Bill_Name
            // 
            this.crv_Customer_Bill_Name.ActiveViewIndex = -1;
            this.crv_Customer_Bill_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Customer_Bill_Name.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Customer_Bill_Name.Location = new System.Drawing.Point(-3, 190);
            this.crv_Customer_Bill_Name.Name = "crv_Customer_Bill_Name";
            this.crv_Customer_Bill_Name.Size = new System.Drawing.Size(1885, 767);
            this.crv_Customer_Bill_Name.TabIndex = 0;
            this.crv_Customer_Bill_Name.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // lbl_Customer_Name
            // 
            this.lbl_Customer_Name.AutoSize = true;
            this.lbl_Customer_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Name.Location = new System.Drawing.Point(18, 132);
            this.lbl_Customer_Name.Name = "lbl_Customer_Name";
            this.lbl_Customer_Name.Size = new System.Drawing.Size(193, 33);
            this.lbl_Customer_Name.TabIndex = 1;
            this.lbl_Customer_Name.Text = "Customer Name";
            // 
            // tb_Customer_Name
            // 
            this.tb_Customer_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Customer_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_Name.Location = new System.Drawing.Point(354, 142);
            this.tb_Customer_Name.Name = "tb_Customer_Name";
            this.tb_Customer_Name.Size = new System.Drawing.Size(275, 34);
            this.tb_Customer_Name.TabIndex = 2;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(906, 132);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(176, 52);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_Ganesh_Cycle_Agency
            // 
            this.lbl_Ganesh_Cycle_Agency.AutoSize = true;
            this.lbl_Ganesh_Cycle_Agency.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ganesh_Cycle_Agency.Location = new System.Drawing.Point(674, 9);
            this.lbl_Ganesh_Cycle_Agency.Name = "lbl_Ganesh_Cycle_Agency";
            this.lbl_Ganesh_Cycle_Agency.Size = new System.Drawing.Size(557, 68);
            this.lbl_Ganesh_Cycle_Agency.TabIndex = 6;
            this.lbl_Ganesh_Cycle_Agency.Text = "Ganesh Cycle Agency";
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Black;
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.Location = new System.Drawing.Point(57, 27);
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
            this.btn_Logout.Location = new System.Drawing.Point(1718, 27);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(75, 55);
            this.btn_Logout.TabIndex = 20;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // frm_Customer_bill_Name
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
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Customer_Name);
            this.Controls.Add(this.lbl_Customer_Name);
            this.Controls.Add(this.crv_Customer_Bill_Name);
            this.Name = "frm_Customer_bill_Name";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer bill Name";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Customer_bill_Name_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Customer_Bill_Name;
        private System.Windows.Forms.Label lbl_Customer_Name;
        private System.Windows.Forms.TextBox tb_Customer_Name;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_Ganesh_Cycle_Agency;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Logout;
    }
}