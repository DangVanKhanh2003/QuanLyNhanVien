namespace QuanLyNhanVienTTCSN_Nhom9.View
{
    partial class SapXepNVForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SapXepNVForm));
            this.ascByFullName = new System.Windows.Forms.RadioButton();
            this.descBirthDate = new System.Windows.Forms.RadioButton();
            this.ascBirthDate = new System.Windows.Forms.RadioButton();
            this.descJoinCompanyDate = new System.Windows.Forms.RadioButton();
            this.ascJoinCompanyDate = new System.Windows.Forms.RadioButton();
            this.descByFullName = new System.Windows.Forms.RadioButton();
            this.confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ascByFullName
            // 
            this.ascByFullName.AutoSize = true;
            this.ascByFullName.Location = new System.Drawing.Point(53, 50);
            this.ascByFullName.Name = "ascByFullName";
            this.ascByFullName.Size = new System.Drawing.Size(183, 20);
            this.ascByFullName.TabIndex = 0;
            this.ascByFullName.TabStop = true;
            this.ascByFullName.Text = "Sắp xếp tăng dần theo tên";
            this.ascByFullName.UseVisualStyleBackColor = true;
            // 
            // descBirthDate
            // 
            this.descBirthDate.AutoSize = true;
            this.descBirthDate.Location = new System.Drawing.Point(381, 116);
            this.descBirthDate.Name = "descBirthDate";
            this.descBirthDate.Size = new System.Drawing.Size(187, 20);
            this.descBirthDate.TabIndex = 1;
            this.descBirthDate.TabStop = true;
            this.descBirthDate.Text = "Sắp xếp giảm dần theo tên";
            this.descBirthDate.UseVisualStyleBackColor = true;
            // 
            // ascBirthDate
            // 
            this.ascBirthDate.AutoSize = true;
            this.ascBirthDate.Location = new System.Drawing.Point(53, 116);
            this.ascBirthDate.Name = "ascBirthDate";
            this.ascBirthDate.Size = new System.Drawing.Size(222, 20);
            this.ascBirthDate.TabIndex = 2;
            this.ascBirthDate.TabStop = true;
            this.ascBirthDate.Text = "Sắp xếp tăng dần theo ngay sinh";
            this.ascBirthDate.UseVisualStyleBackColor = true;
            // 
            // descJoinCompanyDate
            // 
            this.descJoinCompanyDate.AutoSize = true;
            this.descJoinCompanyDate.Location = new System.Drawing.Point(381, 195);
            this.descJoinCompanyDate.Name = "descJoinCompanyDate";
            this.descJoinCompanyDate.Size = new System.Drawing.Size(226, 20);
            this.descJoinCompanyDate.TabIndex = 3;
            this.descJoinCompanyDate.TabStop = true;
            this.descJoinCompanyDate.Text = "Sắp xếp giảm dần theo ngay sinh";
            this.descJoinCompanyDate.UseVisualStyleBackColor = true;
            this.descJoinCompanyDate.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // ascJoinCompanyDate
            // 
            this.ascJoinCompanyDate.AutoSize = true;
            this.ascJoinCompanyDate.Location = new System.Drawing.Point(53, 195);
            this.ascJoinCompanyDate.Name = "ascJoinCompanyDate";
            this.ascJoinCompanyDate.Size = new System.Drawing.Size(267, 20);
            this.ascJoinCompanyDate.TabIndex = 4;
            this.ascJoinCompanyDate.TabStop = true;
            this.ascJoinCompanyDate.Text = "Sắp xếp tăng dần theo ngày vào công ty";
            this.ascJoinCompanyDate.UseVisualStyleBackColor = true;
            // 
            // descByFullName
            // 
            this.descByFullName.AutoSize = true;
            this.descByFullName.Location = new System.Drawing.Point(381, 50);
            this.descByFullName.Name = "descByFullName";
            this.descByFullName.Size = new System.Drawing.Size(271, 20);
            this.descByFullName.TabIndex = 5;
            this.descByFullName.TabStop = true;
            this.descByFullName.Text = "Sắp xếp giảm dần theo ngày vào công ty";
            this.descByFullName.UseVisualStyleBackColor = true;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(573, 257);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(95, 27);
            this.confirm.TabIndex = 6;
            this.confirm.Text = "Xác nhận";
            this.confirm.UseVisualStyleBackColor = true;
            // 
            // SapXepNVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 301);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.descByFullName);
            this.Controls.Add(this.ascJoinCompanyDate);
            this.Controls.Add(this.descJoinCompanyDate);
            this.Controls.Add(this.ascBirthDate);
            this.Controls.Add(this.descBirthDate);
            this.Controls.Add(this.ascByFullName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SapXepNVForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SapXepForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ascByFullName;
        private System.Windows.Forms.RadioButton descBirthDate;
        private System.Windows.Forms.RadioButton ascBirthDate;
        private System.Windows.Forms.RadioButton descJoinCompanyDate;
        private System.Windows.Forms.RadioButton ascJoinCompanyDate;
        private System.Windows.Forms.RadioButton descByFullName;
        private System.Windows.Forms.Button confirm;
    }
}