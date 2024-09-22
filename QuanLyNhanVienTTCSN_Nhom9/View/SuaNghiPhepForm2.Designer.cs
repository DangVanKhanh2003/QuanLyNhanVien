namespace QuanLyNhanVienTTCSN_Nhom9.View
{
    partial class SuaNghiPhepForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuaNghiPhepForm2));
            this.toDatePickTime = new System.Windows.Forms.DateTimePicker();
            this.fromDatePickTime = new System.Windows.Forms.DateTimePicker();
            this.idEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // toDatePickTime
            // 
            this.toDatePickTime.CustomFormat = "dd/MM/yyyy";
            this.toDatePickTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDatePickTime.Location = new System.Drawing.Point(125, 163);
            this.toDatePickTime.Name = "toDatePickTime";
            this.toDatePickTime.Size = new System.Drawing.Size(237, 22);
            this.toDatePickTime.TabIndex = 13;
            // 
            // fromDatePickTime
            // 
            this.fromDatePickTime.CustomFormat = "dd/MM/yyyy";
            this.fromDatePickTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDatePickTime.Location = new System.Drawing.Point(125, 108);
            this.fromDatePickTime.Name = "fromDatePickTime";
            this.fromDatePickTime.Size = new System.Drawing.Size(237, 22);
            this.fromDatePickTime.TabIndex = 12;
            // 
            // idEmployeeTextBox
            // 
            this.idEmployeeTextBox.Location = new System.Drawing.Point(125, 23);
            this.idEmployeeTextBox.Name = "idEmployeeTextBox";
            this.idEmployeeTextBox.ReadOnly = true;
            this.idEmployeeTextBox.Size = new System.Drawing.Size(237, 22);
            this.idEmployeeTextBox.TabIndex = 11;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(331, 206);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(87, 29);
            this.confirm.TabIndex = 10;
            this.confirm.Text = "Xác nhận";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Đến ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Từ ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Họ tên:";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(125, 65);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.ReadOnly = true;
            this.fullNameTextBox.Size = new System.Drawing.Size(235, 22);
            this.fullNameTextBox.TabIndex = 15;
            // 
            // SuaNghiPhepForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 247);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toDatePickTime);
            this.Controls.Add(this.fromDatePickTime);
            this.Controls.Add(this.idEmployeeTextBox);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SuaNghiPhepForm2";
            this.Text = "SuaNghiPhepForm2";
            this.Load += new System.EventHandler(this.SuaNghiPhepForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker toDatePickTime;
        private System.Windows.Forms.DateTimePicker fromDatePickTime;
        private System.Windows.Forms.TextBox idEmployeeTextBox;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fullNameTextBox;
    }
}