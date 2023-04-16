
namespace Autolog
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserTxt = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.register1 = new Autolog.Register();
            this.serverChange1 = new Autolog.serverChange();
            this.SuspendLayout();
            // 
            // UserTxt
            // 
            this.UserTxt.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTxt.Location = new System.Drawing.Point(233, 254);
            this.UserTxt.Name = "UserTxt";
            this.UserTxt.Size = new System.Drawing.Size(307, 29);
            this.UserTxt.TabIndex = 0;
            this.UserTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.UserTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.Black;
            this.UsernameLabel.Location = new System.Drawing.Point(226, 210);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(154, 35);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username";
            this.UsernameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.Black;
            this.PasswordLabel.Location = new System.Drawing.Point(225, 295);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(146, 35);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password";
            // 
            // PassTxt
            // 
            this.PassTxt.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTxt.Location = new System.Drawing.Point(232, 339);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.PasswordChar = '*';
            this.PassTxt.Size = new System.Drawing.Size(307, 29);
            this.PassTxt.TabIndex = 2;
            this.PassTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.PassTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LoginBtn.Location = new System.Drawing.Point(233, 403);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 29);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.button1_Click);
            this.LoginBtn.Enter += new System.EventHandler(this.button1_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterBtn.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RegisterBtn.Location = new System.Drawing.Point(465, 403);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(75, 29);
            this.RegisterBtn.TabIndex = 7;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(231, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Back to Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // register1
            // 
            this.register1.Location = new System.Drawing.Point(3, 452);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(767, 834);
            this.register1.TabIndex = 8;
            // 
            // serverChange1
            // 
            this.serverChange1.Location = new System.Drawing.Point(-16, 0);
            this.serverChange1.Name = "serverChange1";
            this.serverChange1.Size = new System.Drawing.Size(767, 834);
            this.serverChange1.TabIndex = 16;
            this.serverChange1.Load += new System.EventHandler(this.serverChange1_Load);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.serverChange1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.register1);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.UserTxt);
            this.Controls.Add(this.UsernameLabel);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(751, 795);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserControl1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserTxt;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PassTxt;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button RegisterBtn;
        private Register register1;
        private System.Windows.Forms.Button button1;
        private serverChange serverChange1;
    }
}
