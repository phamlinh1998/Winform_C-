namespace QuanLy_Quan_CaFe.View
{
    partial class PassChangeEmpp
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
            this.txtPassCu = new System.Windows.Forms.TextBox();
            this.txtRePass = new System.Windows.Forms.TextBox();
            this.txtPassMoi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // txtPassCu
            // 
            this.txtPassCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassCu.Location = new System.Drawing.Point(192, 46);
            this.txtPassCu.Name = "txtPassCu";
            this.txtPassCu.PasswordChar = '*';
            this.txtPassCu.Size = new System.Drawing.Size(184, 22);
            this.txtPassCu.TabIndex = 1;
            // 
            // txtRePass
            // 
            this.txtRePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRePass.Location = new System.Drawing.Point(192, 132);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.PasswordChar = '*';
            this.txtRePass.Size = new System.Drawing.Size(184, 22);
            this.txtRePass.TabIndex = 1;
            // 
            // txtPassMoi
            // 
            this.txtPassMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassMoi.Location = new System.Drawing.Point(192, 84);
            this.txtPassMoi.Name = "txtPassMoi";
            this.txtPassMoi.PasswordChar = '*';
            this.txtPassMoi.Size = new System.Drawing.Size(184, 22);
            this.txtPassMoi.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Đồng ý";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PassChangeEmpp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 237);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPassMoi);
            this.Controls.Add(this.txtRePass);
            this.Controls.Add(this.txtPassCu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PassChangeEmpp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu nhân viên";
            this.Load += new System.EventHandler(this.PassChangeEmpp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassCu;
        private System.Windows.Forms.TextBox txtRePass;
        private System.Windows.Forms.TextBox txtPassMoi;
        private System.Windows.Forms.Button button1;
    }
}