namespace QuanLy_Quan_CaFe.View
{
    partial class Order
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaDH = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.dtgvDH = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnIndh = new System.Windows.Forms.Button();
            this.lbNgay = new System.Windows.Forms.Label();
            this.lbMadh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMaDH);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dtpNgay);
            this.panel1.Controls.Add(this.dtgvDH);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnIndh);
            this.panel1.Controls.Add(this.lbNgay);
            this.panel1.Controls.Add(this.lbMadh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 414);
            this.panel1.TabIndex = 0;
            // 
            // txtMaDH
            // 
            this.txtMaDH.Location = new System.Drawing.Point(151, 100);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.Size = new System.Drawing.Size(150, 20);
            this.txtMaDH.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã đơn hàng",
            "Ngày"});
            this.comboBox1.Location = new System.Drawing.Point(47, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(264, 24);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "---------------Tìm kiếm đơn hàng----------";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtpNgay
            // 
            this.dtpNgay.CustomFormat = "yyyy-MM-dd";
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.Location = new System.Drawing.Point(151, 143);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(113, 20);
            this.dtpNgay.TabIndex = 11;
            this.dtpNgay.Value = new System.DateTime(2020, 10, 12, 0, 0, 0, 0);
            // 
            // dtgvDH
            // 
            this.dtgvDH.AllowUserToAddRows = false;
            this.dtgvDH.AllowUserToDeleteRows = false;
            this.dtgvDH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDH.Location = new System.Drawing.Point(12, 190);
            this.dtgvDH.Name = "dtgvDH";
            this.dtgvDH.ReadOnly = true;
            this.dtgvDH.RowHeadersVisible = false;
            this.dtgvDH.Size = new System.Drawing.Size(740, 184);
            this.dtgvDH.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Làm mới";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnIndh
            // 
            this.btnIndh.Location = new System.Drawing.Point(490, 138);
            this.btnIndh.Name = "btnIndh";
            this.btnIndh.Size = new System.Drawing.Size(133, 34);
            this.btnIndh.TabIndex = 5;
            this.btnIndh.Text = "In Đơn hàng";
            this.btnIndh.UseVisualStyleBackColor = true;
            this.btnIndh.Click += new System.EventHandler(this.btnIndh_Click);
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgay.Location = new System.Drawing.Point(44, 143);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(45, 16);
            this.lbNgay.TabIndex = 2;
            this.lbNgay.Text = "Ngày";
            // 
            // lbMadh
            // 
            this.lbMadh.AutoSize = true;
            this.lbMadh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMadh.Location = new System.Drawing.Point(44, 104);
            this.lbMadh.Name = "lbMadh";
            this.lbMadh.Size = new System.Drawing.Size(101, 16);
            this.lbMadh.TabIndex = 1;
            this.lbMadh.Text = "Mã đơn hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lịch Sử Đơn Hàng";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 414);
            this.Controls.Add(this.panel1);
            this.Name = "Order";
            this.Text = "Quản lý đơn hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Order_FormClosed);
            this.Load += new System.EventHandler(this.Order_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.Label lbMadh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvDH;
        private System.Windows.Forms.Button btnIndh;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.TextBox txtMaDH;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}