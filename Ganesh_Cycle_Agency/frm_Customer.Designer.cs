namespace Ganesh_Cycle_Agency
{
    partial class frm_Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Customer));
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Add_New_Custormer = new System.Windows.Forms.Button();
            this.btn_View_Customer_Details = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Black;
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.Location = new System.Drawing.Point(55, 22);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(67, 59);
            this.btn_Back.TabIndex = 14;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Black;
            this.btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Image")));
            this.btn_Logout.Location = new System.Drawing.Point(1733, 22);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(75, 59);
            this.btn_Logout.TabIndex = 13;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Add_New_Custormer
            // 
            this.btn_Add_New_Custormer.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add_New_Custormer.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Custormer.Location = new System.Drawing.Point(646, 243);
            this.btn_Add_New_Custormer.Name = "btn_Add_New_Custormer";
            this.btn_Add_New_Custormer.Size = new System.Drawing.Size(538, 111);
            this.btn_Add_New_Custormer.TabIndex = 11;
            this.btn_Add_New_Custormer.Text = "Add New Customer";
            this.btn_Add_New_Custormer.UseVisualStyleBackColor = false;
            this.btn_Add_New_Custormer.Click += new System.EventHandler(this.btn_Add_New_Custormer_Click);
            // 
            // btn_View_Customer_Details
            // 
            this.btn_View_Customer_Details.BackColor = System.Drawing.Color.Transparent;
            this.btn_View_Customer_Details.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_Customer_Details.Location = new System.Drawing.Point(646, 542);
            this.btn_View_Customer_Details.Name = "btn_View_Customer_Details";
            this.btn_View_Customer_Details.Size = new System.Drawing.Size(538, 111);
            this.btn_View_Customer_Details.TabIndex = 12;
            this.btn_View_Customer_Details.Text = "View Customer Details";
            this.btn_View_Customer_Details.UseVisualStyleBackColor = false;
            this.btn_View_Customer_Details.Click += new System.EventHandler(this.btn_View_Customer_Details_Click);
            // 
            // frm_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1882, 953);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Add_New_Custormer);
            this.Controls.Add(this.btn_View_Customer_Details);
            this.Name = "frm_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Add_New_Custormer;
        private System.Windows.Forms.Button btn_View_Customer_Details;
    }
}