namespace QuanLyNhanVienTTCSN_Nhom9.View
{
    partial class SapXepNghiPhepForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SapXepNghiPhepForm));
            this.ascTotalOnLeave = new System.Windows.Forms.RadioButton();
            this.descTotalOnLeave = new System.Windows.Forms.RadioButton();
            this.ascFullName = new System.Windows.Forms.RadioButton();
            this.descFullName = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ascTotalOnLeave
            // 
            this.ascTotalOnLeave.AutoSize = true;
            this.ascTotalOnLeave.Location = new System.Drawing.Point(40, 36);
            this.ascTotalOnLeave.Name = "ascTotalOnLeave";
            this.ascTotalOnLeave.Size = new System.Drawing.Size(310, 20);
            this.ascTotalOnLeave.TabIndex = 0;
            this.ascTotalOnLeave.TabStop = true;
            this.ascTotalOnLeave.Text = "Sắp xếp theo số tăng dần ngày nghỉ trong tháng";
            this.ascTotalOnLeave.UseVisualStyleBackColor = true;
            // 
            // descTotalOnLeave
            // 
            this.descTotalOnLeave.AutoSize = true;
            this.descTotalOnLeave.Location = new System.Drawing.Point(40, 83);
            this.descTotalOnLeave.Name = "descTotalOnLeave";
            this.descTotalOnLeave.Size = new System.Drawing.Size(314, 20);
            this.descTotalOnLeave.TabIndex = 1;
            this.descTotalOnLeave.TabStop = true;
            this.descTotalOnLeave.Text = "Sắp xếp giảm dần theo só ngày nghỉ trong tháng";
            this.descTotalOnLeave.UseVisualStyleBackColor = true;
            // 
            // ascFullName
            // 
            this.ascFullName.AutoSize = true;
            this.ascFullName.Location = new System.Drawing.Point(40, 133);
            this.ascFullName.Name = "ascFullName";
            this.ascFullName.Size = new System.Drawing.Size(201, 20);
            this.ascFullName.TabIndex = 2;
            this.ascFullName.TabStop = true;
            this.ascFullName.Text = "Sắp xếp tăng dần theo họ tên";
            this.ascFullName.UseVisualStyleBackColor = true;
            this.ascFullName.CheckedChanged += new System.EventHandler(this.ascFullName_CheckedChanged);
            // 
            // descFullName
            // 
            this.descFullName.AutoSize = true;
            this.descFullName.Location = new System.Drawing.Point(40, 177);
            this.descFullName.Name = "descFullName";
            this.descFullName.Size = new System.Drawing.Size(205, 20);
            this.descFullName.TabIndex = 3;
            this.descFullName.TabStop = true;
            this.descFullName.Text = "Sắp xêp giảm dần theo họ tên";
            this.descFullName.UseVisualStyleBackColor = true;
            this.descFullName.CheckedChanged += new System.EventHandler(this.descFullName_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SapXepNghiPhepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 264);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.descFullName);
            this.Controls.Add(this.ascFullName);
            this.Controls.Add(this.descTotalOnLeave);
            this.Controls.Add(this.ascTotalOnLeave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SapXepNghiPhepForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SapXepNghiPhepForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ascTotalOnLeave;
        private System.Windows.Forms.RadioButton descTotalOnLeave;
        private System.Windows.Forms.RadioButton ascFullName;
        private System.Windows.Forms.RadioButton descFullName;
        private System.Windows.Forms.Button button1;
    }
}