namespace Ganesh_Cycle_Agency
{
    partial class frm_Distributor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Distributor));
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Add_New_Distributor = new System.Windows.Forms.Button();
            this.btn_View_All_Distributors = new System.Windows.Forms.Button();
            this.btn_Search_Or_Update_Distributor_Details = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Black;
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.Location = new System.Drawing.Point(66, 23);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(74, 64);
            this.btn_Back.TabIndex = 14;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Black;
            this.btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Image")));
            this.btn_Logout.Location = new System.Drawing.Point(1776, 23);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(74, 64);
            this.btn_Logout.TabIndex = 13;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Add_New_Distributor
            // 
            this.btn_Add_New_Distributor.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Distributor.Location = new System.Drawing.Point(641, 178);
            this.btn_Add_New_Distributor.Name = "btn_Add_New_Distributor";
            this.btn_Add_New_Distributor.Size = new System.Drawing.Size(599, 105);
            this.btn_Add_New_Distributor.TabIndex = 10;
            this.btn_Add_New_Distributor.Text = "Add New Distributor";
            this.btn_Add_New_Distributor.UseVisualStyleBackColor = true;
            this.btn_Add_New_Distributor.Click += new System.EventHandler(this.btn_Add_New_Distributor_Click);
            // 
            // btn_View_All_Distributors
            // 
            this.btn_View_All_Distributors.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_All_Distributors.Location = new System.Drawing.Point(632, 643);
            this.btn_View_All_Distributors.Name = "btn_View_All_Distributors";
            this.btn_View_All_Distributors.Size = new System.Drawing.Size(599, 105);
            this.btn_View_All_Distributors.TabIndex = 12;
            this.btn_View_All_Distributors.Text = "View All Distributors";
            this.btn_View_All_Distributors.UseVisualStyleBackColor = true;
            this.btn_View_All_Distributors.Click += new System.EventHandler(this.btn_View_All_Distributors_Click);
            // 
            // btn_Search_Or_Update_Distributor_Details
            // 
            this.btn_Search_Or_Update_Distributor_Details.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Or_Update_Distributor_Details.Location = new System.Drawing.Point(632, 398);
            this.btn_Search_Or_Update_Distributor_Details.Name = "btn_Search_Or_Update_Distributor_Details";
            this.btn_Search_Or_Update_Distributor_Details.Size = new System.Drawing.Size(599, 105);
            this.btn_Search_Or_Update_Distributor_Details.TabIndex = 11;
            this.btn_Search_Or_Update_Distributor_Details.Text = "Search Or Update Distributor Details";
            this.btn_Search_Or_Update_Distributor_Details.UseVisualStyleBackColor = true;
            this.btn_Search_Or_Update_Distributor_Details.Click += new System.EventHandler(this.btn_Search_Or_Update_Distributor_Details_Click);
            // 
            // frm_Distributor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1882, 853);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Add_New_Distributor);
            this.Controls.Add(this.btn_View_All_Distributors);
            this.Controls.Add(this.btn_Search_Or_Update_Distributor_Details);
            this.Name = "frm_Distributor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distributor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Add_New_Distributor;
        private System.Windows.Forms.Button btn_View_All_Distributors;
        private System.Windows.Forms.Button btn_Search_Or_Update_Distributor_Details;
    }
}