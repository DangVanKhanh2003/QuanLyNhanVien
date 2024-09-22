namespace QuanLyNhanVienTTCSN_Nhom9.View
{
    partial class ChiTietQuanLyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietQuanLyForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tableOT = new System.Windows.Forms.DataGridView();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewLeave = new System.Windows.Forms.DataGridView();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.dateTimePicker13 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.tableSal = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableOT)).BeginInit();
            this.tabPage14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeave)).BeginInit();
            this.tabPage13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableSal)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage13);
            this.tabControl1.Controls.Add(this.tabPage14);
            this.tabControl1.Controls.Add(this.tabPage15);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(945, 536);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage15
            // 
            this.tabPage15.Controls.Add(this.tableOT);
            this.tabPage15.Controls.Add(this.dateTimePicker1);
            this.tabPage15.Location = new System.Drawing.Point(4, 25);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Size = new System.Drawing.Size(937, 507);
            this.tabPage15.TabIndex = 2;
            this.tabPage15.Text = "Tăng Ca";
            this.tabPage15.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(2, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 22);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker16_ValueChanged);
            // 
            // tableOT
            // 
            this.tableOT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableOT.Location = new System.Drawing.Point(0, 37);
            this.tableOT.Name = "tableOT";
            this.tableOT.RowHeadersWidth = 51;
            this.tableOT.RowTemplate.Height = 24;
            this.tableOT.Size = new System.Drawing.Size(937, 469);
            this.tableOT.TabIndex = 10;
            // 
            // tabPage14
            // 
            this.tabPage14.Controls.Add(this.dataGridViewLeave);
            this.tabPage14.Controls.Add(this.dateTimePicker2);
            this.tabPage14.Location = new System.Drawing.Point(4, 25);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage14.Size = new System.Drawing.Size(937, 507);
            this.tabPage14.TabIndex = 1;
            this.tabPage14.Text = "Nghỉ Phép";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(2, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(130, 22);
            this.dateTimePicker2.TabIndex = 9;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker15_ValueChanged);
            // 
            // dataGridViewLeave
            // 
            this.dataGridViewLeave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeave.Location = new System.Drawing.Point(0, 37);
            this.dataGridViewLeave.Name = "dataGridViewLeave";
            this.dataGridViewLeave.RowHeadersWidth = 51;
            this.dataGridViewLeave.RowTemplate.Height = 24;
            this.dataGridViewLeave.Size = new System.Drawing.Size(937, 469);
            this.dataGridViewLeave.TabIndex = 10;
            this.dataGridViewLeave.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView7_CellContentClick);
            // 
            // tabPage13
            // 
            this.tabPage13.Controls.Add(this.tableSal);
            this.tabPage13.Controls.Add(this.dateTimePicker3);
            this.tabPage13.Controls.Add(this.dateTimePicker13);
            this.tabPage13.Location = new System.Drawing.Point(4, 25);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage13.Size = new System.Drawing.Size(937, 507);
            this.tabPage13.TabIndex = 0;
            this.tabPage13.Text = "Lương";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker13
            // 
            this.dateTimePicker13.CustomFormat = "MM/yyyy";
            this.dateTimePicker13.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker13.Location = new System.Drawing.Point(-63, -44);
            this.dateTimePicker13.Name = "dateTimePicker13";
            this.dateTimePicker13.Size = new System.Drawing.Size(130, 22);
            this.dateTimePicker13.TabIndex = 5;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "MM/yyyy";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(5, 0);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(130, 22);
            this.dateTimePicker3.TabIndex = 7;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker14_ValueChanged);
            // 
            // tableSal
            // 
            this.tableSal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableSal.Location = new System.Drawing.Point(3, 37);
            this.tableSal.Name = "tableSal";
            this.tableSal.RowHeadersWidth = 51;
            this.tableSal.RowTemplate.Height = 24;
            this.tableSal.Size = new System.Drawing.Size(937, 469);
            this.tableSal.TabIndex = 8;
            // 
            // ChiTietQuanLyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 535);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChiTietQuanLyForm";
            this.Text = "ChiTietQuanLyForm";
            this.Load += new System.EventHandler(this.ChiTietQuanLyForm_Load);
            this.SizeChanged += new System.EventHandler(this.ChiTietQuanLyForm_SizeChanged);
            this.Resize += new System.EventHandler(this.ChiTietQuanLyForm_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableOT)).EndInit();
            this.tabPage14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeave)).EndInit();
            this.tabPage13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableSal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage13;
        private System.Windows.Forms.DataGridView tableSal;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker13;
        private System.Windows.Forms.TabPage tabPage14;
        private System.Windows.Forms.DataGridView dataGridViewLeave;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TabPage tabPage15;
        private System.Windows.Forms.DataGridView tableOT;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}