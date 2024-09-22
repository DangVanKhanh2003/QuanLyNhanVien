namespace QuanLyNhanVienTTCSN_Nhom9.View
{
    partial class TimKiemTangCaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiemTangCaForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idOTTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timeOTUpDown = new System.Windows.Forms.NumericUpDown();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.PositionComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.DepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.MonthYearPickTime = new System.Windows.Forms.DateTimePicker();
            this.confirmButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.idEmpTextBox = new System.Windows.Forms.TextBox();
            this.checkTimeOT = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.timeOTUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tăng ca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "số giờ tăng ca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại tăng ca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tháng năm:";
            // 
            // idOTTextBox
            // 
            this.idOTTextBox.Location = new System.Drawing.Point(170, 36);
            this.idOTTextBox.Name = "idOTTextBox";
            this.idOTTextBox.Size = new System.Drawing.Size(325, 22);
            this.idOTTextBox.TabIndex = 1;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(170, 119);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(325, 22);
            this.FullNameTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chức vụ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Phòng ban:";
            // 
            // timeOTUpDown
            // 
            this.timeOTUpDown.Location = new System.Drawing.Point(170, 162);
            this.timeOTUpDown.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.timeOTUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeOTUpDown.Name = "timeOTUpDown";
            this.timeOTUpDown.Size = new System.Drawing.Size(324, 22);
            this.timeOTUpDown.TabIndex = 2;
            this.timeOTUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeOTUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.timeOTUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeOTUpDown_KeyPress);
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Tất cả",
            "Lễ",
            "Thường"});
            this.TypeComboBox.Location = new System.Drawing.Point(169, 210);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(325, 24);
            this.TypeComboBox.TabIndex = 3;
            this.TypeComboBox.Text = "Tất cả";
            this.TypeComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TypeComboBox_KeyPress);
            // 
            // PositionComboBox
            // 
            this.PositionComboBox.FormattingEnabled = true;
            this.PositionComboBox.Location = new System.Drawing.Point(169, 290);
            this.PositionComboBox.Name = "PositionComboBox";
            this.PositionComboBox.Size = new System.Drawing.Size(325, 24);
            this.PositionComboBox.TabIndex = 3;
            this.PositionComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.PositionComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PositionComboBox_KeyPress);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(170, 336);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(325, 24);
            this.comboBox3.TabIndex = 3;
            // 
            // DepartmentComboBox
            // 
            this.DepartmentComboBox.FormattingEnabled = true;
            this.DepartmentComboBox.Location = new System.Drawing.Point(169, 335);
            this.DepartmentComboBox.Name = "DepartmentComboBox";
            this.DepartmentComboBox.Size = new System.Drawing.Size(325, 24);
            this.DepartmentComboBox.TabIndex = 3;
            this.DepartmentComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            this.DepartmentComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DepartmentComboBox_KeyPress);
            // 
            // MonthYearPickTime
            // 
            this.MonthYearPickTime.CustomFormat = "MM/yyyy";
            this.MonthYearPickTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MonthYearPickTime.Location = new System.Drawing.Point(168, 253);
            this.MonthYearPickTime.Name = "MonthYearPickTime";
            this.MonthYearPickTime.Size = new System.Drawing.Size(326, 22);
            this.MonthYearPickTime.TabIndex = 4;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(409, 398);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(122, 32);
            this.confirmButton.TabIndex = 5;
            this.confirmButton.Text = "Xác nhận";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã nhân viên:";
            // 
            // idEmpTextBox
            // 
            this.idEmpTextBox.Location = new System.Drawing.Point(169, 79);
            this.idEmpTextBox.Name = "idEmpTextBox";
            this.idEmpTextBox.Size = new System.Drawing.Size(325, 22);
            this.idEmpTextBox.TabIndex = 1;
            // 
            // checkTimeOT
            // 
            this.checkTimeOT.AutoSize = true;
            this.checkTimeOT.Location = new System.Drawing.Point(500, 165);
            this.checkTimeOT.Name = "checkTimeOT";
            this.checkTimeOT.Size = new System.Drawing.Size(18, 17);
            this.checkTimeOT.TabIndex = 6;
            this.checkTimeOT.UseVisualStyleBackColor = true;
            this.checkTimeOT.CheckedChanged += new System.EventHandler(this.checkTimeOT_CheckedChanged);
            // 
            // TimKiemTangCaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 457);
            this.Controls.Add(this.checkTimeOT);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.MonthYearPickTime);
            this.Controls.Add(this.DepartmentComboBox);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.PositionComboBox);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.timeOTUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idEmpTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idOTTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimKiemTangCaForm";
            this.Text = "TimKiemTangCaForm";
            this.Load += new System.EventHandler(this.TimKiemTangCaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timeOTUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idOTTextBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown timeOTUpDown;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.ComboBox PositionComboBox;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox DepartmentComboBox;
        private System.Windows.Forms.DateTimePicker MonthYearPickTime;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox idEmpTextBox;
        private System.Windows.Forms.CheckBox checkTimeOT;
    }
}