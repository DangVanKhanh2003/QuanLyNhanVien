namespace QuanLyNhanVienTTCSN_Nhom9.View
{
    partial class TimKiemNhanVienForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiemNhanVienForm));
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.genderCombobox = new System.Windows.Forms.ComboBox();
            this.dateJoinCompany = new System.Windows.Forms.DateTimePicker();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.identificationCardTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idEmpLable = new System.Windows.Forms.Label();
            this.idEmpTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // positionComboBox
            // 
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Location = new System.Drawing.Point(177, 435);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(232, 24);
            this.positionComboBox.TabIndex = 41;
            this.positionComboBox.Text = "Tất cả";
            this.positionComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.positionComboBox_KeyPress);
            // 
            // genderCombobox
            // 
            this.genderCombobox.FormattingEnabled = true;
            this.genderCombobox.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Tất cả"});
            this.genderCombobox.Location = new System.Drawing.Point(177, 395);
            this.genderCombobox.Name = "genderCombobox";
            this.genderCombobox.Size = new System.Drawing.Size(71, 24);
            this.genderCombobox.TabIndex = 40;
            this.genderCombobox.Text = "Tất cả";
            this.genderCombobox.SelectedIndexChanged += new System.EventHandler(this.genderCombobox_SelectedIndexChanged);
            this.genderCombobox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.genderCombobox_KeyPress);
            // 
            // dateJoinCompany
            // 
            this.dateJoinCompany.CustomFormat = "dd/MM/yyyy";
            this.dateJoinCompany.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateJoinCompany.Location = new System.Drawing.Point(177, 349);
            this.dateJoinCompany.Name = "dateJoinCompany";
            this.dateJoinCompany.ShowCheckBox = true;
            this.dateJoinCompany.Size = new System.Drawing.Size(236, 22);
            this.dateJoinCompany.TabIndex = 39;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.CustomFormat = "dd/MM/yyyy";
            this.dateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfBirth.Location = new System.Drawing.Point(177, 298);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.ShowCheckBox = true;
            this.dateOfBirth.Size = new System.Drawing.Size(236, 22);
            this.dateOfBirth.TabIndex = 38;
            this.dateOfBirth.ValueChanged += new System.EventHandler(this.dateOfBirth_ValueChanged);
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(177, 57);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(236, 22);
            this.fullNameTextBox.TabIndex = 37;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(177, 100);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(236, 22);
            this.addressTextBox.TabIndex = 36;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(177, 154);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(236, 22);
            this.phoneNumberTextBox.TabIndex = 35;
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(177, 251);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(236, 22);
            this.mailTextBox.TabIndex = 34;
            // 
            // identificationCardTextBox
            // 
            this.identificationCardTextBox.Location = new System.Drawing.Point(177, 200);
            this.identificationCardTextBox.Name = "identificationCardTextBox";
            this.identificationCardTextBox.Size = new System.Drawing.Size(236, 22);
            this.identificationCardTextBox.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 32;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 435);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "Chức vụ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Ngày vào công ty:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Căn cước công dân:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Địa chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Họ và tên:";
            // 
            // idEmpLable
            // 
            this.idEmpLable.AutoSize = true;
            this.idEmpLable.Location = new System.Drawing.Point(41, 22);
            this.idEmpLable.Name = "idEmpLable";
            this.idEmpLable.Size = new System.Drawing.Size(89, 16);
            this.idEmpLable.TabIndex = 42;
            this.idEmpLable.Text = "Mã nhân viên:";
            // 
            // idEmpTextBox
            // 
            this.idEmpTextBox.Location = new System.Drawing.Point(177, 19);
            this.idEmpTextBox.Name = "idEmpTextBox";
            this.idEmpTextBox.Size = new System.Drawing.Size(236, 22);
            this.idEmpTextBox.TabIndex = 43;
            // 
            // TimKiemNhanVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 540);
            this.Controls.Add(this.idEmpTextBox);
            this.Controls.Add(this.idEmpLable);
            this.Controls.Add(this.positionComboBox);
            this.Controls.Add(this.genderCombobox);
            this.Controls.Add(this.dateJoinCompany);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.identificationCardTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimKiemNhanVienForm";
            this.Text = "TimKiemNhanVienForm";
            this.Load += new System.EventHandler(this.TimKiemNhanVienForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox positionComboBox;
        private System.Windows.Forms.ComboBox genderCombobox;
        private System.Windows.Forms.DateTimePicker dateJoinCompany;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox identificationCardTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idEmpLable;
        private System.Windows.Forms.TextBox idEmpTextBox;
    }
}