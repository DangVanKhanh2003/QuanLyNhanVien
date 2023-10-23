namespace QuanLyNhanVienTTCSN_Nhom9.View
{
    partial class TimKiemNghiPhep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiemNghiPhep));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numberDateOnLeave = new System.Windows.Forms.NumericUpDown();
            this.idEmployee = new System.Windows.Forms.TextBox();
            this.Position = new System.Windows.Forms.ComboBox();
            this.department = new System.Windows.Forms.ComboBox();
            this.confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberDateOnLeave)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số ngày nghỉ trong tháng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chức vụ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phòng ban:";
            // 
            // numberDateOnLeave
            // 
            this.numberDateOnLeave.Location = new System.Drawing.Point(228, 79);
            this.numberDateOnLeave.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numberDateOnLeave.Name = "numberDateOnLeave";
            this.numberDateOnLeave.Size = new System.Drawing.Size(112, 22);
            this.numberDateOnLeave.TabIndex = 4;
            this.numberDateOnLeave.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // idEmployee
            // 
            this.idEmployee.Location = new System.Drawing.Point(224, 33);
            this.idEmployee.Name = "idEmployee";
            this.idEmployee.Size = new System.Drawing.Size(188, 22);
            this.idEmployee.TabIndex = 5;
            // 
            // Position
            // 
            this.Position.FormattingEnabled = true;
            this.Position.Location = new System.Drawing.Point(228, 125);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(183, 24);
            this.Position.TabIndex = 6;
            // 
            // department
            // 
            this.department.FormattingEnabled = true;
            this.department.Location = new System.Drawing.Point(229, 166);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(183, 24);
            this.department.TabIndex = 7;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(339, 211);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(91, 29);
            this.confirm.TabIndex = 8;
            this.confirm.Text = "Xác nhận";
            this.confirm.UseVisualStyleBackColor = true;
            // 
            // TimKiemNghiPhep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 252);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.department);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.idEmployee);
            this.Controls.Add(this.numberDateOnLeave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimKiemNghiPhep";
            this.Text = "TimKiemNghiPhep";
            ((System.ComponentModel.ISupportInitialize)(this.numberDateOnLeave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numberDateOnLeave;
        private System.Windows.Forms.TextBox idEmployee;
        private System.Windows.Forms.ComboBox Position;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.Button confirm;
    }
}