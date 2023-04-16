
namespace Autolog
{
    partial class AddAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccount));
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UserTxt = new System.Windows.Forms.TextBox();
            this.AddAcc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PasswordLabel.Location = new System.Drawing.Point(78, 215);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(146, 35);
            this.PasswordLabel.TabIndex = 15;
            this.PasswordLabel.Text = "Password";
            // 
            // PassTxt
            // 
            this.PassTxt.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTxt.Location = new System.Drawing.Point(85, 259);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.Size = new System.Drawing.Size(307, 29);
            this.PassTxt.TabIndex = 13;
            this.PassTxt.TextChanged += new System.EventHandler(this.PassTxt_TextChanged);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UsernameLabel.Location = new System.Drawing.Point(79, 130);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(154, 35);
            this.UsernameLabel.TabIndex = 14;
            this.UsernameLabel.Text = "Username";
            // 
            // UserTxt
            // 
            this.UserTxt.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTxt.Location = new System.Drawing.Point(86, 174);
            this.UserTxt.Name = "UserTxt";
            this.UserTxt.Size = new System.Drawing.Size(307, 29);
            this.UserTxt.TabIndex = 12;
            this.UserTxt.TextChanged += new System.EventHandler(this.UserTxt_TextChanged);
            // 
            // AddAcc
            // 
            this.AddAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddAcc.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddAcc.Location = new System.Drawing.Point(283, 306);
            this.AddAcc.Name = "AddAcc";
            this.AddAcc.Size = new System.Drawing.Size(109, 29);
            this.AddAcc.TabIndex = 16;
            this.AddAcc.Text = "Add Account";
            this.AddAcc.UseVisualStyleBackColor = true;
            this.AddAcc.Click += new System.EventHandler(this.AddAcc_Click);
            this.AddAcc.Enter += new System.EventHandler(this.AddAcc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 35);
            this.label1.TabIndex = 17;
            this.label1.Text = "Add Account";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(59, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 33);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddAcc);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.UserTxt);
            this.Name = "AddAccount";
            this.Size = new System.Drawing.Size(475, 470);
            this.Load += new System.EventHandler(this.AddAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PassTxt;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox UserTxt;
        private System.Windows.Forms.Button AddAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
