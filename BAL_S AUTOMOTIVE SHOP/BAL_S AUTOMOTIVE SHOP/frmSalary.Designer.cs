
namespace BAL_S_AUTOMOTIVE_SHOP
{
    partial class frmSalary
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
            this.txtbSALARY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEMPID = new System.Windows.Forms.ComboBox();
            this.txtbNAME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPAYROLL = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPAYROLL = new System.Windows.Forms.Button();
            this.btnDAILYRATE = new System.Windows.Forms.Button();
            this.btnATTENDANCE = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnDASH = new System.Windows.Forms.Button();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.cmbDATE = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPAYROLL)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbSALARY
            // 
            this.txtbSALARY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSALARY.Location = new System.Drawing.Point(704, 124);
            this.txtbSALARY.Name = "txtbSALARY";
            this.txtbSALARY.Size = new System.Drawing.Size(126, 26);
            this.txtbSALARY.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(700, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 60;
            this.label4.Text = "Total Salary";
            // 
            // cmbEMPID
            // 
            this.cmbEMPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEMPID.FormattingEnabled = true;
            this.cmbEMPID.Location = new System.Drawing.Point(140, 122);
            this.cmbEMPID.Name = "cmbEMPID";
            this.cmbEMPID.Size = new System.Drawing.Size(149, 28);
            this.cmbEMPID.TabIndex = 58;
            // 
            // txtbNAME
            // 
            this.txtbNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNAME.Location = new System.Drawing.Point(305, 122);
            this.txtbNAME.Name = "txtbNAME";
            this.txtbNAME.Size = new System.Drawing.Size(198, 26);
            this.txtbNAME.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Employee ID:";
            // 
            // dgvPAYROLL
            // 
            this.dgvPAYROLL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPAYROLL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvPAYROLL.Location = new System.Drawing.Point(140, 243);
            this.dgvPAYROLL.Name = "dgvPAYROLL";
            this.dgvPAYROLL.Size = new System.Drawing.Size(808, 296);
            this.dgvPAYROLL.TabIndex = 67;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "empID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "empName";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "empDate";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "empTotalSalary";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "SSS";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "PAG IBIG ";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Philhealth";
            this.Column7.Name = "Column7";
            // 
            // btnPAYROLL
            // 
            this.btnPAYROLL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPAYROLL.Location = new System.Drawing.Point(756, 22);
            this.btnPAYROLL.Name = "btnPAYROLL";
            this.btnPAYROLL.Size = new System.Drawing.Size(125, 37);
            this.btnPAYROLL.TabIndex = 72;
            this.btnPAYROLL.Text = "Payroll";
            this.btnPAYROLL.UseVisualStyleBackColor = true;
            // 
            // btnDAILYRATE
            // 
            this.btnDAILYRATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDAILYRATE.Location = new System.Drawing.Point(606, 22);
            this.btnDAILYRATE.Name = "btnDAILYRATE";
            this.btnDAILYRATE.Size = new System.Drawing.Size(122, 37);
            this.btnDAILYRATE.TabIndex = 71;
            this.btnDAILYRATE.Text = "Daily Rate";
            this.btnDAILYRATE.UseVisualStyleBackColor = true;
            // 
            // btnATTENDANCE
            // 
            this.btnATTENDANCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnATTENDANCE.Location = new System.Drawing.Point(450, 22);
            this.btnATTENDANCE.Name = "btnATTENDANCE";
            this.btnATTENDANCE.Size = new System.Drawing.Size(127, 37);
            this.btnATTENDANCE.TabIndex = 70;
            this.btnATTENDANCE.Text = "Attendance";
            this.btnATTENDANCE.UseVisualStyleBackColor = true;
            // 
            // btnEmployees
            // 
            this.btnEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.Location = new System.Drawing.Point(293, 22);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(134, 37);
            this.btnEmployees.TabIndex = 69;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            // 
            // btnDASH
            // 
            this.btnDASH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDASH.Location = new System.Drawing.Point(141, 22);
            this.btnDASH.Name = "btnDASH";
            this.btnDASH.Size = new System.Drawing.Size(123, 37);
            this.btnDASH.TabIndex = 68;
            this.btnDASH.Text = "Dashboard";
            this.btnDASH.UseVisualStyleBackColor = true;
            // 
            // btnSAVE
            // 
            this.btnSAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAVE.Location = new System.Drawing.Point(646, 192);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(82, 32);
            this.btnSAVE.TabIndex = 75;
            this.btnSAVE.Text = "Save";
            this.btnSAVE.UseVisualStyleBackColor = true;
            // 
            // btnDELETE
            // 
            this.btnDELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELETE.Location = new System.Drawing.Point(470, 192);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(82, 32);
            this.btnDELETE.TabIndex = 74;
            this.btnDELETE.Text = "Delete";
            this.btnDELETE.UseVisualStyleBackColor = true;
            // 
            // btnEDIT
            // 
            this.btnEDIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEDIT.Location = new System.Drawing.Point(317, 192);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(82, 32);
            this.btnEDIT.TabIndex = 73;
            this.btnEDIT.Text = "Edit";
            this.btnEDIT.UseVisualStyleBackColor = true;
            // 
            // cmbDATE
            // 
            this.cmbDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDATE.FormattingEnabled = true;
            this.cmbDATE.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbDATE.Location = new System.Drawing.Point(527, 120);
            this.cmbDATE.Name = "cmbDATE";
            this.cmbDATE.Size = new System.Drawing.Size(149, 28);
            this.cmbDATE.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(524, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "Date: ";
            // 
            // frmSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 551);
            this.Controls.Add(this.cmbDATE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSAVE);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.btnEDIT);
            this.Controls.Add(this.btnPAYROLL);
            this.Controls.Add(this.btnDAILYRATE);
            this.Controls.Add(this.btnATTENDANCE);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnDASH);
            this.Controls.Add(this.dgvPAYROLL);
            this.Controls.Add(this.txtbSALARY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEMPID);
            this.Controls.Add(this.txtbNAME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSalary";
            this.Text = "frmSalary";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPAYROLL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbSALARY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEMPID;
        private System.Windows.Forms.TextBox txtbNAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPAYROLL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnPAYROLL;
        private System.Windows.Forms.Button btnDAILYRATE;
        private System.Windows.Forms.Button btnATTENDANCE;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnDASH;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.ComboBox cmbDATE;
        private System.Windows.Forms.Label label3;
    }
}