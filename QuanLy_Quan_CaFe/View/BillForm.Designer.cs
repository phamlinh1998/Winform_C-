namespace QuanLy_Quan_CaFe.View
{
    partial class BillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNV = new System.Windows.Forms.TextBox();
            this.nmSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lstOrder = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flTable = new System.Windows.Forms.FlowLayoutPanel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbKichco = new System.Windows.Forms.ComboBox();
            this.cbLsp = new System.Windows.Forms.ComboBox();
            this.cbTensp = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giớiThiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNV);
            this.panel1.Controls.Add(this.nmSoLuong);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.lstOrder);
            this.panel1.Controls.Add(this.flTable);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.cbKichco);
            this.panel1.Controls.Add(this.cbLsp);
            this.panel1.Controls.Add(this.cbTensp);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 527);
            this.panel1.TabIndex = 0;
            // 
            // txtNV
            // 
            this.txtNV.Location = new System.Drawing.Point(451, 267);
            this.txtNV.Name = "txtNV";
            this.txtNV.Size = new System.Drawing.Size(148, 20);
            this.txtNV.TabIndex = 14;
            // 
            // nmSoLuong
            // 
            this.nmSoLuong.Location = new System.Drawing.Point(285, 265);
            this.nmSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmSoLuong.Name = "nmSoLuong";
            this.nmSoLuong.Size = new System.Drawing.Size(54, 20);
            this.nmSoLuong.TabIndex = 13;
            this.nmSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Red;
            this.txtTotal.Location = new System.Drawing.Point(706, 384);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(127, 26);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(624, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tổng tiền";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(662, 426);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(109, 36);
            this.btnThanhToan.TabIndex = 8;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lstOrder
            // 
            this.lstOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader11,
            this.columnHeader12});
            this.lstOrder.FullRowSelect = true;
            this.lstOrder.GridLines = true;
            this.lstOrder.HideSelection = false;
            this.lstOrder.Location = new System.Drawing.Point(13, 357);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(605, 158);
            this.lstOrder.TabIndex = 10;
            this.lstOrder.UseCompatibleStateImageBehavior = false;
            this.lstOrder.View = System.Windows.Forms.View.Details;
            this.lstOrder.Click += new System.EventHandler(this.lstOrder_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã đơn hàng";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên sản phẩm";
            this.columnHeader3.Width = 144;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kích cỡ";
            this.columnHeader4.Width = 82;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số lượng";
            this.columnHeader5.Width = 82;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Đơn giá";
            this.columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Thành tiền";
            this.columnHeader12.Width = 111;
            // 
            // flTable
            // 
            this.flTable.AutoScroll = true;
            this.flTable.Location = new System.Drawing.Point(12, 36);
            this.flTable.Name = "flTable";
            this.flTable.Size = new System.Drawing.Size(821, 205);
            this.flTable.TabIndex = 9;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(618, 315);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(109, 36);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(490, 314);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 36);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbKichco
            // 
            this.cbKichco.FormattingEnabled = true;
            this.cbKichco.Location = new System.Drawing.Point(285, 300);
            this.cbKichco.Name = "cbKichco";
            this.cbKichco.Size = new System.Drawing.Size(100, 21);
            this.cbKichco.TabIndex = 6;
            // 
            // cbLsp
            // 
            this.cbLsp.FormattingEnabled = true;
            this.cbLsp.Location = new System.Drawing.Point(93, 261);
            this.cbLsp.Name = "cbLsp";
            this.cbLsp.Size = new System.Drawing.Size(100, 21);
            this.cbLsp.TabIndex = 6;
            this.cbLsp.SelectedIndexChanged += new System.EventHandler(this.cbLsp_SelectedIndexChanged);
            // 
            // cbTensp
            // 
            this.cbTensp.FormattingEnabled = true;
            this.cbTensp.Location = new System.Drawing.Point(93, 300);
            this.cbTensp.Name = "cbTensp";
            this.cbTensp.Size = new System.Drawing.Size(100, 21);
            this.cbTensp.TabIndex = 6;
            this.cbTensp.SelectedIndexChanged += new System.EventHandler(this.cbTensp_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kích Cỡ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Loại sản phẩm";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.giớiThiệuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tàiKhoảnToolStripMenuItem.Image")));
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thôngTinTàiKhoảnToolStripMenuItem.Image")));
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông Tin Tài Khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đổiMậtKhẩuToolStripMenuItem.Image")));
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật Khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đăngXuấtToolStripMenuItem.Image")));
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // giớiThiệuToolStripMenuItem
            // 
            this.giớiThiệuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("giớiThiệuToolStripMenuItem.Image")));
            this.giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
            this.giớiThiệuToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.giớiThiệuToolStripMenuItem.Text = "Giới Thiệu ";
            this.giớiThiệuToolStripMenuItem.Click += new System.EventHandler(this.giớiThiệuToolStripMenuItem_Click);
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 527);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BillForm_FormClosed);
            this.Load += new System.EventHandler(this.BillForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giớiThiệuToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbKichco;
        private System.Windows.Forms.ComboBox cbTensp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flTable;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.ListView lstOrder;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbLsp;
        private System.Windows.Forms.NumericUpDown nmSoLuong;
        private System.Windows.Forms.TextBox txtNV;
        private System.Windows.Forms.Label label6;
    }
}