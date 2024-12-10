
namespace BAL_S_AUTOMOTIVE_SHOP
{
    partial class frmDashboard
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
            this.btnDASH = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDASH
            // 
            this.btnDASH.Location = new System.Drawing.Point(75, 24);
            this.btnDASH.Name = "btnDASH";
            this.btnDASH.Size = new System.Drawing.Size(124, 26);
            this.btnDASH.TabIndex = 0;
            this.btnDASH.Text = "Dashboard";
            this.btnDASH.UseVisualStyleBackColor = true;
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(227, 24);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(124, 26);
            this.btnEmployees.TabIndex = 1;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(384, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 26);
            this.button3.TabIndex = 2;
            this.button3.Text = "Attendance";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(540, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 26);
            this.button4.TabIndex = 3;
            this.button4.Text = "Daily Rate";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(690, 24);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 26);
            this.button5.TabIndex = 4;
            this.button5.Text = "Payroll";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnDASH);
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDASH;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}