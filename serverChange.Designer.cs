
namespace Autolog
{
    partial class serverChange
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
            this.label1 = new System.Windows.Forms.Label();
            this.serverAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.serverUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.serverPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.serverDatabase = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.serverPort = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(233, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change SQL Server";
            // 
            // serverAddress
            // 
            this.serverAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverAddress.Location = new System.Drawing.Point(268, 236);
            this.serverAddress.Name = "serverAddress";
            this.serverAddress.Size = new System.Drawing.Size(269, 26);
            this.serverAddress.TabIndex = 8;
            this.serverAddress.TextChanged += new System.EventHandler(this.serverAddress_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(95, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Server Address:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(265, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "For a local server enter \"localhost\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(265, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(96, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Server Username:";
            // 
            // serverUsername
            // 
            this.serverUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverUsername.Location = new System.Drawing.Point(268, 399);
            this.serverUsername.Name = "serverUsername";
            this.serverUsername.Size = new System.Drawing.Size(269, 26);
            this.serverUsername.TabIndex = 11;
            this.serverUsername.TextChanged += new System.EventHandler(this.serverUsername_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(95, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Server Password:";
            // 
            // serverPassword
            // 
            this.serverPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverPassword.Location = new System.Drawing.Point(268, 447);
            this.serverPassword.Name = "serverPassword";
            this.serverPassword.Size = new System.Drawing.Size(269, 26);
            this.serverPassword.TabIndex = 14;
            this.serverPassword.TextChanged += new System.EventHandler(this.serverPassword_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(95, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Server Database:";
            // 
            // serverDatabase
            // 
            this.serverDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverDatabase.Location = new System.Drawing.Point(268, 296);
            this.serverDatabase.Name = "serverDatabase";
            this.serverDatabase.Size = new System.Drawing.Size(269, 26);
            this.serverDatabase.TabIndex = 17;
            this.serverDatabase.TextChanged += new System.EventHandler(this.serverDatabase_TextChanged);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LoginBtn.Location = new System.Drawing.Point(320, 492);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(160, 29);
            this.LoginBtn.TabIndex = 19;
            this.LoginBtn.Text = "Save Server Settings";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(95, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Server Port:";
            // 
            // serverPort
            // 
            this.serverPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverPort.Location = new System.Drawing.Point(268, 341);
            this.serverPort.Name = "serverPort";
            this.serverPort.Size = new System.Drawing.Size(269, 26);
            this.serverPort.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(265, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Default port number is 3306";
            // 
            // serverChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.serverPort);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.serverDatabase);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.serverPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.serverUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serverAddress);
            this.Controls.Add(this.label1);
            this.Name = "serverChange";
            this.Size = new System.Drawing.Size(767, 834);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serverAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox serverUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox serverPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox serverDatabase;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox serverPort;
        private System.Windows.Forms.Label label8;
    }
}
