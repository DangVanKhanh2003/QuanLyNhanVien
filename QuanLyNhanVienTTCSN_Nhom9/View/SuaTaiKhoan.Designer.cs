namespace QuanLyNhanVienTTCSN_Nhom9.View
{
    partial class SuaTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuaTaiKhoan));
            this.typeAccComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Comfirm = new System.Windows.Forms.Button();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.idEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // typeAccComboBox
            // 
            this.typeAccComboBox.FormattingEnabled = true;
            this.typeAccComboBox.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.typeAccComboBox.Location = new System.Drawing.Point(153, 156);
            this.typeAccComboBox.Name = "typeAccComboBox";
            this.typeAccComboBox.Size = new System.Drawing.Size(265, 24);
            this.typeAccComboBox.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Loại tài khoản:";
            // 
            // Comfirm
            // 
            this.Comfirm.Location = new System.Drawing.Point(378, 211);
            this.Comfirm.Name = "Comfirm";
            this.Comfirm.Size = new System.Drawing.Size(81, 27);
            this.Comfirm.TabIndex = 29;
            this.Comfirm.Text = "Xác nhận";
            this.Comfirm.UseVisualStyleBackColor = true;
            this.Comfirm.Click += new System.EventHandler(this.Comfirm_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(153, 104);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.ReadOnly = true;
            this.userNameTextBox.Size = new System.Drawing.Size(265, 22);
            this.userNameTextBox.TabIndex = 26;
            // 
            // idEmployeeTextBox
            // 
            this.idEmployeeTextBox.Location = new System.Drawing.Point(153, 12);
            this.idEmployeeTextBox.Name = "idEmployeeTextBox";
            this.idEmployeeTextBox.ReadOnly = true;
            this.idEmployeeTextBox.Size = new System.Drawing.Size(265, 22);
            this.idEmployeeTextBox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã nhân viên:";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(153, 58);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.ReadOnly = true;
            this.fullNameTextBox.Size = new System.Drawing.Size(265, 22);
            this.fullNameTextBox.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Họ tên:";
            // 
            // SuaTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 259);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.typeAccComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Comfirm);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.idEmployeeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SuaTaiKhoan";
            this.Text = "SuaTaiKhoan";
            this.Load += new System.EventHandler(this.SuaTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typeAccComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Comfirm;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox idEmployeeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label label4;
    }
}