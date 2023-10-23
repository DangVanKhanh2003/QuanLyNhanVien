namespace QuanLyNhanVienTTCSN_Nhom9.View
{
    partial class TimKiemTK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiemTK));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IdEmployee = new System.Windows.Forms.TextBox();
            this.fullName = new System.Windows.Forms.TextBox();
            this.department = new System.Windows.Forms.ComboBox();
            this.position = new System.Windows.Forms.ComboBox();
            this.typeAccount = new System.Windows.Forms.ComboBox();
            this.confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phòng ban:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chức vụ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loại tài khoản:";
            // 
            // IdEmployee
            // 
            this.IdEmployee.Location = new System.Drawing.Point(182, 27);
            this.IdEmployee.Name = "IdEmployee";
            this.IdEmployee.Size = new System.Drawing.Size(202, 22);
            this.IdEmployee.TabIndex = 5;
            // 
            // fullName
            // 
            this.fullName.Location = new System.Drawing.Point(182, 61);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(202, 22);
            this.fullName.TabIndex = 6;
            // 
            // department
            // 
            this.department.FormattingEnabled = true;
            this.department.Location = new System.Drawing.Point(182, 101);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(202, 24);
            this.department.TabIndex = 7;
            // 
            // position
            // 
            this.position.FormattingEnabled = true;
            this.position.Location = new System.Drawing.Point(182, 143);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(202, 24);
            this.position.TabIndex = 8;
            // 
            // typeAccount
            // 
            this.typeAccount.FormattingEnabled = true;
            this.typeAccount.Location = new System.Drawing.Point(182, 190);
            this.typeAccount.Name = "typeAccount";
            this.typeAccount.Size = new System.Drawing.Size(202, 24);
            this.typeAccount.TabIndex = 9;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(334, 249);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(80, 27);
            this.confirm.TabIndex = 10;
            this.confirm.Text = "Xác nhận";
            this.confirm.UseVisualStyleBackColor = true;
            // 
            // TimKiemTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 288);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.typeAccount);
            this.Controls.Add(this.position);
            this.Controls.Add(this.department);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.IdEmployee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimKiemTK";
            this.Text = "TimKiemTK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IdEmployee;
        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.ComboBox position;
        private System.Windows.Forms.ComboBox typeAccount;
        private System.Windows.Forms.Button confirm;
    }
}