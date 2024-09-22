namespace QuanLyNhanVienTTCSN_Nhom9.View
{
    partial class TimKiemTaiKhoanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiemTaiKhoanForm));
            this.Comfirm = new System.Windows.Forms.Button();
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.idEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.deparmentComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Comfirm
            // 
            this.Comfirm.Location = new System.Drawing.Point(360, 281);
            this.Comfirm.Name = "Comfirm";
            this.Comfirm.Size = new System.Drawing.Size(81, 27);
            this.Comfirm.TabIndex = 17;
            this.Comfirm.Text = "Xác nhận";
            this.Comfirm.UseVisualStyleBackColor = true;
            this.Comfirm.Click += new System.EventHandler(this.Comfirm_Click);
            // 
            // positionComboBox
            // 
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Location = new System.Drawing.Point(149, 221);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(265, 24);
            this.positionComboBox.TabIndex = 5;
            this.positionComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.positionComboBox_KeyPress);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(149, 64);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(265, 22);
            this.userNameTextBox.TabIndex = 2;
            // 
            // idEmployeeTextBox
            // 
            this.idEmployeeTextBox.Location = new System.Drawing.Point(149, 10);
            this.idEmployeeTextBox.Name = "idEmployeeTextBox";
            this.idEmployeeTextBox.Size = new System.Drawing.Size(265, 22);
            this.idEmployeeTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Chức vụ:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên đăng nhập:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Phòng ban:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Họ tên:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(149, 112);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(265, 22);
            this.FullNameTextBox.TabIndex = 3;
            // 
            // deparmentComboBox
            // 
            this.deparmentComboBox.FormattingEnabled = true;
            this.deparmentComboBox.Location = new System.Drawing.Point(149, 168);
            this.deparmentComboBox.Name = "deparmentComboBox";
            this.deparmentComboBox.Size = new System.Drawing.Size(265, 24);
            this.deparmentComboBox.TabIndex = 4;
            this.deparmentComboBox.SelectedIndexChanged += new System.EventHandler(this.deparmentComboBox_SelectedIndexChanged);
            this.deparmentComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deparmentComboBox_KeyPress);
            // 
            // TimKiemTaiKhoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 336);
            this.Controls.Add(this.deparmentComboBox);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Comfirm);
            this.Controls.Add(this.positionComboBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.idEmployeeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimKiemTaiKhoanForm";
            this.Text = "TimKiemTaiKhoanForm";
            this.Load += new System.EventHandler(this.TimKiemTaiKhoanForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Comfirm;
        private System.Windows.Forms.ComboBox positionComboBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox idEmployeeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.ComboBox deparmentComboBox;
    }
}