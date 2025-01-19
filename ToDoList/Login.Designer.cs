﻿namespace ToDoList
{
    partial class Login
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
            LoginLabel = new Label();
            LoginButton = new Button();
            PasswordLabel = new Label();
            PasswordText = new TextBox();
            UsernameLabel = new Label();
            UsernameText = new TextBox();
            RegisterButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Segoe UI", 10F);
            LoginLabel.Location = new Point(13, 9);
            LoginLabel.Margin = new Padding(4, 0, 4, 0);
            LoginLabel.MinimumSize = new Size(129, 0);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(129, 19);
            LoginLabel.TabIndex = 11;
            LoginLabel.Text = "Login";
            // 
            // LoginButton
            // 
            LoginButton.Font = new Font("Segoe UI", 12F);
            LoginButton.Location = new Point(15, 235);
            LoginButton.Margin = new Padding(4);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(267, 34);
            LoginButton.TabIndex = 10;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += button1_Click_1;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 10F);
            PasswordLabel.Location = new Point(15, 139);
            PasswordLabel.Margin = new Padding(4, 0, 4, 0);
            PasswordLabel.MinimumSize = new Size(129, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(129, 19);
            PasswordLabel.TabIndex = 9;
            PasswordLabel.Text = "Enter password";
            // 
            // PasswordText
            // 
            PasswordText.BackColor = SystemColors.Window;
            PasswordText.Font = new Font("Segoe UI", 12F);
            PasswordText.Location = new Point(15, 178);
            PasswordText.Margin = new Padding(4);
            PasswordText.MaxLength = 50;
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(264, 29);
            PasswordText.TabIndex = 8;
            PasswordText.UseSystemPasswordChar = true;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI", 10F);
            UsernameLabel.Location = new Point(15, 50);
            UsernameLabel.Margin = new Padding(4, 0, 4, 0);
            UsernameLabel.MinimumSize = new Size(129, 0);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(129, 19);
            UsernameLabel.TabIndex = 7;
            UsernameLabel.Text = "Enter username";
            // 
            // UsernameText
            // 
            UsernameText.BackColor = SystemColors.Window;
            UsernameText.Font = new Font("Segoe UI", 12F);
            UsernameText.Location = new Point(15, 90);
            UsernameText.Margin = new Padding(4);
            UsernameText.MaxLength = 50;
            UsernameText.Name = "UsernameText";
            UsernameText.Size = new Size(264, 29);
            UsernameText.TabIndex = 6;
            // 
            // RegisterButton
            // 
            RegisterButton.Font = new Font("Segoe UI", 12F);
            RegisterButton.Location = new Point(15, 288);
            RegisterButton.Margin = new Padding(4);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(267, 34);
            RegisterButton.TabIndex = 12;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += button2_Click;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Segoe UI", 12F);
            ExitButton.Location = new Point(15, 341);
            ExitButton.Margin = new Padding(4);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(267, 34);
            ExitButton.TabIndex = 13;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += button3_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 556);
            Controls.Add(ExitButton);
            Controls.Add(RegisterButton);
            Controls.Add(LoginLabel);
            Controls.Add(LoginButton);
            Controls.Add(PasswordLabel);
            Controls.Add(PasswordText);
            Controls.Add(UsernameLabel);
            Controls.Add(UsernameText);
            Name = "Login";
            Text = "Login";
            FormClosing += Login_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoginLabel;
        private Button LoginButton;
        private Label PasswordLabel;
        private TextBox PasswordText;
        private Label UsernameLabel;
        private TextBox UsernameText;
        private Button RegisterButton;
        private Button ExitButton;
    }
}