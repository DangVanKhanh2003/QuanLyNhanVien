namespace QuanLyNhanVienTTCSN_Nhom9.View
{
    partial class NhapMaLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapMaLuong));
            this.label1 = new System.Windows.Forms.Label();
            this.idEmpTextBox = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã nhân viên:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // idEmpTextBox
            // 
            this.idEmpTextBox.Location = new System.Drawing.Point(135, 54);
            this.idEmpTextBox.Name = "idEmpTextBox";
            this.idEmpTextBox.Size = new System.Drawing.Size(231, 22);
            this.idEmpTextBox.TabIndex = 4;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(278, 123);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(90, 28);
            this.confirm.TabIndex = 3;
            this.confirm.Text = "Xác nhận";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click_1);
            // 
            // NhapMaLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 161);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idEmpTextBox);
            this.Controls.Add(this.confirm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NhapMaLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập mã nhân viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idEmpTextBox;
        private System.Windows.Forms.Button confirm;
    }
}