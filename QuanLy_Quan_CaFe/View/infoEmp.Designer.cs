namespace QuanLy_Quan_CaFe.View
{
    partial class infoEmp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtGT = new System.Windows.Forms.TextBox();
            this.txtNS = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Địa chỉ";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(155, 34);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(154, 20);
            this.txtTen.TabIndex = 1;
            // 
            // txtGT
            // 
            this.txtGT.Location = new System.Drawing.Point(155, 70);
            this.txtGT.Name = "txtGT";
            this.txtGT.Size = new System.Drawing.Size(154, 20);
            this.txtGT.TabIndex = 1;
            // 
            // txtNS
            // 
            this.txtNS.Location = new System.Drawing.Point(155, 104);
            this.txtNS.Name = "txtNS";
            this.txtNS.Size = new System.Drawing.Size(154, 20);
            this.txtNS.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(155, 138);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(154, 20);
            this.txtSDT.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Đồng ý";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(155, 172);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(154, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(155, 204);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(154, 82);
            this.txtDiachi.TabIndex = 3;
            this.txtDiachi.Text = "";
            // 
            // infoEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 339);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtNS);
            this.Controls.Add(this.txtGT);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "infoEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin nhân viên";
            this.Load += new System.EventHandler(this.infoEmp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtGT;
        private System.Windows.Forms.TextBox txtNS;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RichTextBox txtDiachi;
    }
}