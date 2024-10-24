namespace form_dang_nhap
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttondangnhap = new Button();
            buttonthoat = new Button();
            checkBox1 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            txtname = new TextBox();
            txtpass = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // buttondangnhap
            // 
            buttondangnhap.Location = new Point(211, 298);
            buttondangnhap.Name = "buttondangnhap";
            buttondangnhap.Size = new Size(94, 29);
            buttondangnhap.TabIndex = 0;
            buttondangnhap.Text = "Đăng nhập";
            buttondangnhap.UseVisualStyleBackColor = true;
            buttondangnhap.Click += button1_Click;
            // 
            // buttonthoat
            // 
            buttonthoat.Location = new Point(413, 298);
            buttonthoat.Name = "buttonthoat";
            buttonthoat.Size = new Size(94, 29);
            buttonthoat.TabIndex = 1;
            buttonthoat.Text = "Thoát";
            buttonthoat.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(246, 219);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(124, 24);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Nhớ mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 103);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 3;
            label1.Text = "Tên đăng nhập ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 166);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu ";
            
            // 
            // txtname
            // 
            txtname.Location = new Point(243, 103);
            txtname.Name = "txtname";
            txtname.Size = new Size(291, 27);
            txtname.TabIndex = 5;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(243, 158);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(291, 27);
            txtpass.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(328, 39);
            label3.Name = "label3";
            label3.Size = new Size(121, 28);
            label3.TabIndex = 7;
            label3.Text = "Đăng nhập ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(txtpass);
            Controls.Add(txtname);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(buttonthoat);
            Controls.Add(buttondangnhap);
            Name = "Form1";
            Text = "Form1";
            
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttondangnhap;
        private Button buttonthoat;
        private CheckBox checkBox1;
        private Label label1;
        private Label label2;
        private TextBox txtname;
        private TextBox txtpass;
        private Label label3;
    }
}
