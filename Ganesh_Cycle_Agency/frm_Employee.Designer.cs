namespace Ganesh_Cycle_Agency
{
    partial class frm_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Employee));
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Add_New_Employee = new System.Windows.Forms.Button();
            this.btn_View_All_Employees = new System.Windows.Forms.Button();
            this.btn_Search_Or_Update_Employee_Details = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Black;
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.Location = new System.Drawing.Point(92, 38);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(67, 55);
            this.btn_Back.TabIndex = 15;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Black;
            this.btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Image")));
            this.btn_Logout.Location = new System.Drawing.Point(1753, 38);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(75, 55);
            this.btn_Logout.TabIndex = 14;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Add_New_Employee
            // 
            this.btn_Add_New_Employee.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Employee.Location = new System.Drawing.Point(648, 219);
            this.btn_Add_New_Employee.Name = "btn_Add_New_Employee";
            this.btn_Add_New_Employee.Size = new System.Drawing.Size(569, 124);
            this.btn_Add_New_Employee.TabIndex = 11;
            this.btn_Add_New_Employee.Text = "Add New Employee";
            this.btn_Add_New_Employee.UseVisualStyleBackColor = true;
            this.btn_Add_New_Employee.Click += new System.EventHandler(this.btn_Add_New_Employee_Click);
            // 
            // btn_View_All_Employees
            // 
            this.btn_View_All_Employees.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_All_Employees.Location = new System.Drawing.Point(648, 759);
            this.btn_View_All_Employees.Name = "btn_View_All_Employees";
            this.btn_View_All_Employees.Size = new System.Drawing.Size(569, 124);
            this.btn_View_All_Employees.TabIndex = 13;
            this.btn_View_All_Employees.Text = "View All Employees";
            this.btn_View_All_Employees.UseVisualStyleBackColor = true;
            this.btn_View_All_Employees.Click += new System.EventHandler(this.btn_View_All_Employees_Click);
            // 
            // btn_Search_Or_Update_Employee_Details
            // 
            this.btn_Search_Or_Update_Employee_Details.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Or_Update_Employee_Details.Location = new System.Drawing.Point(648, 490);
            this.btn_Search_Or_Update_Employee_Details.Name = "btn_Search_Or_Update_Employee_Details";
            this.btn_Search_Or_Update_Employee_Details.Size = new System.Drawing.Size(569, 124);
            this.btn_Search_Or_Update_Employee_Details.TabIndex = 12;
            this.btn_Search_Or_Update_Employee_Details.Text = "Search Or Update Employee Details";
            this.btn_Search_Or_Update_Employee_Details.UseVisualStyleBackColor = true;
            this.btn_Search_Or_Update_Employee_Details.Click += new System.EventHandler(this.btn_Search_Or_Update_Employee_Details_Click);
            // 
            // frm_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1882, 953);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Add_New_Employee);
            this.Controls.Add(this.btn_View_All_Employees);
            this.Controls.Add(this.btn_Search_Or_Update_Employee_Details);
            this.Name = "frm_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Add_New_Employee;
        private System.Windows.Forms.Button btn_View_All_Employees;
        private System.Windows.Forms.Button btn_Search_Or_Update_Employee_Details;
    }
}