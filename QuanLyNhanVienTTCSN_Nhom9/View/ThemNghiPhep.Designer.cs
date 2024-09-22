namespace QuanLyNhanVienTTCSN_Nhom9.View
{
    partial class ThemNghiPhep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemNghiPhep));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.idEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.fromDatePickTime = new System.Windows.Forms.DateTimePicker();
            this.toDatePickTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đến ngày:";
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(359, 259);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(87, 29);
            this.confirm.TabIndex = 3;
            this.confirm.Text = "Xác nhận";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // idEmployeeTextBox
            // 
            this.idEmployeeTextBox.Location = new System.Drawing.Point(158, 54);
            this.idEmployeeTextBox.Name = "idEmployeeTextBox";
            this.idEmployeeTextBox.Size = new System.Drawing.Size(237, 22);
            this.idEmployeeTextBox.TabIndex = 4;
            // 
            // fromDatePickTime
            // 
            this.fromDatePickTime.Location = new System.Drawing.Point(158, 104);
            this.fromDatePickTime.Name = "fromDatePickTime";
            this.fromDatePickTime.Size = new System.Drawing.Size(237, 22);
            this.fromDatePickTime.TabIndex = 5;
            this.fromDatePickTime.ValueChanged += new System.EventHandler(this.toDatePickTime_ValueChanged);
            // 
            // toDatePickTime
            // 
            this.toDatePickTime.Location = new System.Drawing.Point(158, 159);
            this.toDatePickTime.Name = "toDatePickTime";
            this.toDatePickTime.Size = new System.Drawing.Size(237, 22);
            this.toDatePickTime.TabIndex = 6;
            this.toDatePickTime.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // ThemNghiPhep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 300);
            this.Controls.Add(this.toDatePickTime);
            this.Controls.Add(this.fromDatePickTime);
            this.Controls.Add(this.idEmployeeTextBox);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemNghiPhep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemNghiPhep";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.TextBox idEmployeeTextBox;
        private System.Windows.Forms.DateTimePicker fromDatePickTime;
        private System.Windows.Forms.DateTimePicker toDatePickTime;
    }
}