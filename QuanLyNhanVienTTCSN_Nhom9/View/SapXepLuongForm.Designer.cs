namespace QuanLyNhanVienTTCSN_Nhom9.View
{
    partial class SapXepLuongForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SapXepLuongForm));
            this.ascFullName = new System.Windows.Forms.RadioButton();
            this.descFullName = new System.Windows.Forms.RadioButton();
            this.ascTotalSalary = new System.Windows.Forms.RadioButton();
            this.descTotalSalary = new System.Windows.Forms.RadioButton();
            this.ascBonus = new System.Windows.Forms.RadioButton();
            this.descBonus = new System.Windows.Forms.RadioButton();
            this.ascStiffSalary = new System.Windows.Forms.RadioButton();
            this.descStiffSalary = new System.Windows.Forms.RadioButton();
            this.confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ascFullName
            // 
            this.ascFullName.AutoSize = true;
            this.ascFullName.Location = new System.Drawing.Point(41, 33);
            this.ascFullName.Name = "ascFullName";
            this.ascFullName.Size = new System.Drawing.Size(201, 20);
            this.ascFullName.TabIndex = 0;
            this.ascFullName.TabStop = true;
            this.ascFullName.Text = "Sắp xếp tăng dần theo họ tên";
            this.ascFullName.UseVisualStyleBackColor = true;
            // 
            // descFullName
            // 
            this.descFullName.AutoSize = true;
            this.descFullName.Location = new System.Drawing.Point(306, 33);
            this.descFullName.Name = "descFullName";
            this.descFullName.Size = new System.Drawing.Size(205, 20);
            this.descFullName.TabIndex = 1;
            this.descFullName.TabStop = true;
            this.descFullName.Text = "Sắp xếp giảm dần theo họ tên";
            this.descFullName.UseVisualStyleBackColor = true;
            // 
            // ascTotalSalary
            // 
            this.ascTotalSalary.AutoSize = true;
            this.ascTotalSalary.Location = new System.Drawing.Point(41, 90);
            this.ascTotalSalary.Name = "ascTotalSalary";
            this.ascTotalSalary.Size = new System.Drawing.Size(227, 20);
            this.ascTotalSalary.TabIndex = 2;
            this.ascTotalSalary.TabStop = true;
            this.ascTotalSalary.Text = "Sắp xếp tăng dần theo tổng lương";
            this.ascTotalSalary.UseVisualStyleBackColor = true;
            // 
            // descTotalSalary
            // 
            this.descTotalSalary.AutoSize = true;
            this.descTotalSalary.Location = new System.Drawing.Point(306, 90);
            this.descTotalSalary.Name = "descTotalSalary";
            this.descTotalSalary.Size = new System.Drawing.Size(231, 20);
            this.descTotalSalary.TabIndex = 3;
            this.descTotalSalary.TabStop = true;
            this.descTotalSalary.Text = "Sắp xếp giảm dần theo tổng lương";
            this.descTotalSalary.UseVisualStyleBackColor = true;
            // 
            // ascBonus
            // 
            this.ascBonus.AutoSize = true;
            this.ascBonus.Location = new System.Drawing.Point(41, 154);
            this.ascBonus.Name = "ascBonus";
            this.ascBonus.Size = new System.Drawing.Size(241, 20);
            this.ascBonus.TabIndex = 4;
            this.ascBonus.TabStop = true;
            this.ascBonus.Text = "Sắp xếp tăng dần theo lương thưởng";
            this.ascBonus.UseVisualStyleBackColor = true;
            // 
            // descBonus
            // 
            this.descBonus.AutoSize = true;
            this.descBonus.Location = new System.Drawing.Point(306, 154);
            this.descBonus.Name = "descBonus";
            this.descBonus.Size = new System.Drawing.Size(245, 20);
            this.descBonus.TabIndex = 5;
            this.descBonus.TabStop = true;
            this.descBonus.Text = "Sắp xếp giảm dần theo lương thưởng";
            this.descBonus.UseVisualStyleBackColor = true;
            // 
            // ascStiffSalary
            // 
            this.ascStiffSalary.AutoSize = true;
            this.ascStiffSalary.Location = new System.Drawing.Point(41, 225);
            this.ascStiffSalary.Name = "ascStiffSalary";
            this.ascStiffSalary.Size = new System.Drawing.Size(230, 20);
            this.ascStiffSalary.TabIndex = 6;
            this.ascStiffSalary.TabStop = true;
            this.ascStiffSalary.Text = "Sắp xếp tăng dần theo lương cứng";
            this.ascStiffSalary.UseVisualStyleBackColor = true;
            // 
            // descStiffSalary
            // 
            this.descStiffSalary.AutoSize = true;
            this.descStiffSalary.Location = new System.Drawing.Point(306, 225);
            this.descStiffSalary.Name = "descStiffSalary";
            this.descStiffSalary.Size = new System.Drawing.Size(234, 20);
            this.descStiffSalary.TabIndex = 7;
            this.descStiffSalary.TabStop = true;
            this.descStiffSalary.Text = "Sắp xếp giảm dần theo lương cứng";
            this.descStiffSalary.UseVisualStyleBackColor = true;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(506, 291);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(84, 23);
            this.confirm.TabIndex = 8;
            this.confirm.Text = "Xác nhận";
            this.confirm.UseVisualStyleBackColor = true;
            // 
            // SapXepLuongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 322);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.descStiffSalary);
            this.Controls.Add(this.ascStiffSalary);
            this.Controls.Add(this.descBonus);
            this.Controls.Add(this.ascBonus);
            this.Controls.Add(this.descTotalSalary);
            this.Controls.Add(this.ascTotalSalary);
            this.Controls.Add(this.descFullName);
            this.Controls.Add(this.ascFullName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SapXepLuongForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SapXepLuongForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ascFullName;
        private System.Windows.Forms.RadioButton descFullName;
        private System.Windows.Forms.RadioButton ascTotalSalary;
        private System.Windows.Forms.RadioButton descTotalSalary;
        private System.Windows.Forms.RadioButton ascBonus;
        private System.Windows.Forms.RadioButton descBonus;
        private System.Windows.Forms.RadioButton ascStiffSalary;
        private System.Windows.Forms.RadioButton descStiffSalary;
        private System.Windows.Forms.Button confirm;
    }
}