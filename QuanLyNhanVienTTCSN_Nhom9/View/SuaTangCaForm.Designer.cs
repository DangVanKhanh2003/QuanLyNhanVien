namespace QuanLyNhanVienTTCSN_Nhom9.View
{
    partial class SuaTangCaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuaTangCaForm));
            this.confirmButton = new System.Windows.Forms.Button();
            this.idEmpTextBox = new System.Windows.Forms.TextBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.MonthYearPickTime = new System.Windows.Forms.DateTimePicker();
            this.timeOTUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timeOTUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(406, 195);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(122, 32);
            this.confirmButton.TabIndex = 20;
            this.confirmButton.Text = "Xác nhận";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // idEmpTextBox
            // 
            this.idEmpTextBox.Location = new System.Drawing.Point(171, 29);
            this.idEmpTextBox.Name = "idEmpTextBox";
            this.idEmpTextBox.Size = new System.Drawing.Size(325, 22);
            this.idEmpTextBox.TabIndex = 19;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Lễ",
            "Thường"});
            this.TypeComboBox.Location = new System.Drawing.Point(171, 152);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(325, 24);
            this.TypeComboBox.TabIndex = 18;
            this.TypeComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TypeComboBox_KeyPress);
            // 
            // MonthYearPickTime
            // 
            this.MonthYearPickTime.CustomFormat = "dd/MM/yyyy";
            this.MonthYearPickTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MonthYearPickTime.Location = new System.Drawing.Point(172, 110);
            this.MonthYearPickTime.Name = "MonthYearPickTime";
            this.MonthYearPickTime.Size = new System.Drawing.Size(324, 22);
            this.MonthYearPickTime.TabIndex = 17;
            this.MonthYearPickTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MonthYearPickTime_KeyPress);
            // 
            // timeOTUpDown
            // 
            this.timeOTUpDown.Location = new System.Drawing.Point(172, 68);
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
            this.timeOTUpDown.TabIndex = 16;
            this.timeOTUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeOTUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeOTUpDown_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Số tiếng tăng ca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã nhân viên:";
            // 
            // SuaTangCaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 242);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.idEmpTextBox);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.MonthYearPickTime);
            this.Controls.Add(this.timeOTUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SuaTangCaForm";
            this.Text = "SuaTangCaForm";
            this.Load += new System.EventHandler(this.SuaTangCaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timeOTUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox idEmpTextBox;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.DateTimePicker MonthYearPickTime;
        private System.Windows.Forms.NumericUpDown timeOTUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}