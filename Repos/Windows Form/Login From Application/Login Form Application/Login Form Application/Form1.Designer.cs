namespace Login_Form_Application
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            text_password = new TextBox();
            text_username = new TextBox();
            txt_login = new Button();
            txt_clear = new Button();
            txt_exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(301, 52);
            label1.Name = "label1";
            label1.Size = new Size(119, 28);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(158, 115);
            label2.Name = "label2";
            label2.Size = new Size(106, 30);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(158, 161);
            label3.Name = "label3";
            label3.Size = new Size(99, 30);
            label3.TabIndex = 2;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // text_password
            // 
            text_password.Location = new Point(286, 168);
            text_password.Name = "text_password";
            text_password.Size = new Size(187, 23);
            text_password.TabIndex = 3;
            text_password.TextChanged += textBox1_TextChanged;
            // 
            // text_username
            // 
            text_username.Location = new Point(286, 122);
            text_username.Name = "text_username";
            text_username.Size = new Size(187, 23);
            text_username.TabIndex = 4;
            // 
            // txt_login
            // 
            txt_login.Location = new Point(398, 218);
            txt_login.Name = "txt_login";
            txt_login.Size = new Size(75, 23);
            txt_login.TabIndex = 5;
            txt_login.Text = "Login";
            txt_login.UseVisualStyleBackColor = true;
            txt_login.Click += button1_Click;
            // 
            // txt_clear
            // 
            txt_clear.Location = new Point(286, 218);
            txt_clear.Name = "txt_clear";
            txt_clear.Size = new Size(75, 23);
            txt_clear.TabIndex = 6;
            txt_clear.Text = "Clear";
            txt_clear.UseVisualStyleBackColor = true;
            txt_clear.Click += txt_clear_Click;
            // 
            // txt_exit
            // 
            txt_exit.Location = new Point(189, 283);
            txt_exit.Name = "txt_exit";
            txt_exit.Size = new Size(75, 23);
            txt_exit.TabIndex = 7;
            txt_exit.Text = "Exit";
            txt_exit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 356);
            Controls.Add(txt_exit);
            Controls.Add(txt_clear);
            Controls.Add(txt_login);
            Controls.Add(text_username);
            Controls.Add(text_password);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox text_password;
        private TextBox text_username;
        private Button txt_login;
        private Button txt_clear;
        private Button txt_exit;
    }
}