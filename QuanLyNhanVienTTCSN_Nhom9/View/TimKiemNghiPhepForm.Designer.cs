namespace QuanLyNhanVienTTCSN_Nhom9.View
{
    partial class TimKiemNghiPhepForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiemNghiPhepForm));
            this.monthPicke = new System.Windows.Forms.DateTimePicker();
            this.idEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fullNameTexBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.positionComBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // monthPicke
            // 
            this.monthPicke.CustomFormat = "MM/yyyy";
            this.monthPicke.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.monthPicke.Location = new System.Drawing.Point(135, 150);
            this.monthPicke.Name = "monthPicke";
            this.monthPicke.Size = new System.Drawing.Size(173, 22);
            this.monthPicke.TabIndex = 12;
            this.monthPicke.ValueChanged += new System.EventHandler(this.toDatePickTime_ValueChanged);
            // 
            // idEmployeeTextBox
            // 
            this.idEmployeeTextBox.Location = new System.Drawing.Point(135, 18);
            this.idEmployeeTextBox.Name = "idEmployeeTextBox";
            this.idEmployeeTextBox.Size = new System.Drawing.Size(173, 22);
            this.idEmployeeTextBox.TabIndex = 11;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(249, 217);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(87, 29);
            this.confirm.TabIndex = 10;
            this.confirm.Text = "Xác nhận";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tháng năm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Họ tên:";
            // 
            // fullNameTexBox
            // 
            this.fullNameTexBox.Location = new System.Drawing.Point(134, 68);
            this.fullNameTexBox.Name = "fullNameTexBox";
            this.fullNameTexBox.Size = new System.Drawing.Size(173, 22);
            this.fullNameTexBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Chức vụ:";
            // 
            // positionComBox
            // 
            this.positionComBox.FormattingEnabled = true;
            this.positionComBox.Location = new System.Drawing.Point(134, 114);
            this.positionComBox.Name = "positionComBox";
            this.positionComBox.Size = new System.Drawing.Size(172, 24);
            this.positionComBox.TabIndex = 16;
            this.positionComBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.positionComBox_KeyPress);
            // 
            // TimKiemNghiPhepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 256);
            this.Controls.Add(this.positionComBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fullNameTexBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthPicke);
            this.Controls.Add(this.idEmployeeTextBox);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimKiemNghiPhepForm";
            this.Text = "TimKiemNghiPhepForm";
            this.Load += new System.EventHandler(this.TimKiemNghiPhepForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker monthPicke;
        private System.Windows.Forms.TextBox idEmployeeTextBox;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fullNameTexBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox positionComBox;
    }
}