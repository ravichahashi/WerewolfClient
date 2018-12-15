namespace WerewolfClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TbLogin = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.TBServer = new System.Windows.Forms.TextBox();
            this.BtnSignUp = new System.Windows.Forms.PictureBox();
            this.BtnSignIn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSignUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSignIn)).BeginInit();
            this.SuspendLayout();
            // 
            // TbLogin
            // 
            this.TbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(51)))), ((int)(((byte)(48)))));
            this.TbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbLogin.ForeColor = System.Drawing.Color.White;
            this.TbLogin.Location = new System.Drawing.Point(786, 376);
            this.TbLogin.Name = "TbLogin";
            this.TbLogin.Size = new System.Drawing.Size(229, 22);
            this.TbLogin.TabIndex = 2;
            // 
            // TbPassword
            // 
            this.TbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(51)))), ((int)(((byte)(48)))));
            this.TbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPassword.ForeColor = System.Drawing.Color.White;
            this.TbPassword.Location = new System.Drawing.Point(786, 464);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '*';
            this.TbPassword.Size = new System.Drawing.Size(229, 22);
            this.TbPassword.TabIndex = 3;
            // 
            // TBServer
            // 
            this.TBServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(52)))), ((int)(((byte)(49)))));
            this.TBServer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBServer.ForeColor = System.Drawing.Color.White;
            this.TBServer.Location = new System.Drawing.Point(846, 626);
            this.TBServer.Name = "TBServer";
            this.TBServer.Size = new System.Drawing.Size(156, 13);
            this.TBServer.TabIndex = 8;
            this.TBServer.Text = "http://localhost:2343/werewolf/";
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.BtnSignUp.Image = ((System.Drawing.Image)(resources.GetObject("BtnSignUp.Image")));
            this.BtnSignUp.Location = new System.Drawing.Point(961, 503);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(54, 23);
            this.BtnSignUp.TabIndex = 9;
            this.BtnSignUp.TabStop = false;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click_1);
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.BackColor = System.Drawing.Color.Transparent;
            this.BtnSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSignIn.BackgroundImage")));
            this.BtnSignIn.Location = new System.Drawing.Point(882, 532);
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.Size = new System.Drawing.Size(144, 50);
            this.BtnSignIn.TabIndex = 10;
            this.BtnSignIn.TabStop = false;
            this.BtnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.BtnSignIn);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.TBServer);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbLogin);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.BtnSignUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSignIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbLogin;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.TextBox TBServer;
        private System.Windows.Forms.PictureBox BtnSignUp;
        private System.Windows.Forms.PictureBox BtnSignIn;
    }
}