namespace QuanLyNhanVienTTCSN_Nhom9.View
{
    partial class SuaLuongFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuaLuongFrom));
            this.confirm = new System.Windows.Forms.Button();
            this.stiffSalaryTextBox = new System.Windows.Forms.TextBox();
            this.bonusTextBox = new System.Windows.Forms.TextBox();
            this.salaryAdvancesTextBox = new System.Windows.Forms.TextBox();
            this.allowancesTextBox = new System.Windows.Forms.TextBox();
            this.idEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(318, 406);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(86, 25);
            this.confirm.TabIndex = 20;
            this.confirm.Text = "Xác nhận";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // stiffSalaryTextBox
            // 
            this.stiffSalaryTextBox.Location = new System.Drawing.Point(162, 112);
            this.stiffSalaryTextBox.Name = "stiffSalaryTextBox";
            this.stiffSalaryTextBox.Size = new System.Drawing.Size(196, 22);
            this.stiffSalaryTextBox.TabIndex = 3;
            // 
            // bonusTextBox
            // 
            this.bonusTextBox.Location = new System.Drawing.Point(162, 168);
            this.bonusTextBox.Name = "bonusTextBox";
            this.bonusTextBox.Size = new System.Drawing.Size(196, 22);
            this.bonusTextBox.TabIndex = 4;
            // 
            // salaryAdvancesTextBox
            // 
            this.salaryAdvancesTextBox.Location = new System.Drawing.Point(162, 273);
            this.salaryAdvancesTextBox.Name = "salaryAdvancesTextBox";
            this.salaryAdvancesTextBox.Size = new System.Drawing.Size(196, 22);
            this.salaryAdvancesTextBox.TabIndex = 6;
            // 
            // allowancesTextBox
            // 
            this.allowancesTextBox.Location = new System.Drawing.Point(162, 223);
            this.allowancesTextBox.Name = "allowancesTextBox";
            this.allowancesTextBox.Size = new System.Drawing.Size(196, 22);
            this.allowancesTextBox.TabIndex = 5;
            // 
            // idEmployeeTextBox
            // 
            this.idEmployeeTextBox.Location = new System.Drawing.Point(162, 26);
            this.idEmployeeTextBox.Name = "idEmployeeTextBox";
            this.idEmployeeTextBox.ReadOnly = true;
            this.idEmployeeTextBox.Size = new System.Drawing.Size(196, 22);
            this.idEmployeeTextBox.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(162, 330);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 22);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tháng năm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ứng trước:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Phụ cấp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Lương thưởng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lương cứng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã nhân viên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Họ tên:";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(162, 68);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.ReadOnly = true;
            this.fullNameTextBox.Size = new System.Drawing.Size(194, 22);
            this.fullNameTextBox.TabIndex = 2;
            // 
            // SuaLuongFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 465);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.stiffSalaryTextBox);
            this.Controls.Add(this.bonusTextBox);
            this.Controls.Add(this.salaryAdvancesTextBox);
            this.Controls.Add(this.allowancesTextBox);
            this.Controls.Add(this.idEmployeeTextBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SuaLuongFrom";
            this.Text = "SuaLuongFrom";
            this.Load += new System.EventHandler(this.SuaLuongFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.TextBox stiffSalaryTextBox;
        private System.Windows.Forms.TextBox bonusTextBox;
        private System.Windows.Forms.TextBox salaryAdvancesTextBox;
        private System.Windows.Forms.TextBox allowancesTextBox;
        private System.Windows.Forms.TextBox idEmployeeTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fullNameTextBox;
    }
}