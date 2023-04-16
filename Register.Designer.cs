
namespace Autolog
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.UserTxt = new System.Windows.Forms.TextBox();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.ConfirmPass = new System.Windows.Forms.Label();
            this.PassConfirmTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // UserTxt
            // 
            this.UserTxt.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTxt.Location = new System.Drawing.Point(229, 239);
            this.UserTxt.Name = "UserTxt";
            this.UserTxt.Size = new System.Drawing.Size(307, 29);
            this.UserTxt.TabIndex = 1;
            this.UserTxt.TextChanged += new System.EventHandler(this.UserTxt_TextChanged);
            // 
            // PassTxt
            // 
            this.PassTxt.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTxt.Location = new System.Drawing.Point(228, 324);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.Size = new System.Drawing.Size(307, 29);
            this.PassTxt.TabIndex = 2;
            this.PassTxt.TextChanged += new System.EventHandler(this.PassTxt_TextChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PasswordLabel.Location = new System.Drawing.Point(221, 280);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(146, 35);
            this.PasswordLabel.TabIndex = 11;
            this.PasswordLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UsernameLabel.Location = new System.Drawing.Point(222, 195);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(154, 35);
            this.UsernameLabel.TabIndex = 9;
            this.UsernameLabel.Text = "Username";
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterBtn.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RegisterBtn.Location = new System.Drawing.Point(460, 467);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(75, 29);
            this.RegisterBtn.TabIndex = 4;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            this.RegisterBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterBtn_KeyDown);
            // 
            // ConfirmPass
            // 
            this.ConfirmPass.AutoSize = true;
            this.ConfirmPass.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ConfirmPass.Location = new System.Drawing.Point(221, 371);
            this.ConfirmPass.Name = "ConfirmPass";
            this.ConfirmPass.Size = new System.Drawing.Size(266, 35);
            this.ConfirmPass.TabIndex = 16;
            this.ConfirmPass.Text = "Confirm Password";
            // 
            // PassConfirmTxt
            // 
            this.PassConfirmTxt.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassConfirmTxt.Location = new System.Drawing.Point(228, 415);
            this.PassConfirmTxt.Name = "PassConfirmTxt";
            this.PassConfirmTxt.Size = new System.Drawing.Size(307, 29);
            this.PassConfirmTxt.TabIndex = 3;
            this.PassConfirmTxt.TextChanged += new System.EventHandler(this.PassConfirmTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(225, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "Password must be at least 8 characters long and contain at least one number";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(199, 170);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 33);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConfirmPass);
            this.Controls.Add(this.PassConfirmTxt);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.UserTxt);
            this.Name = "Register";
            this.Size = new System.Drawing.Size(767, 834);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserTxt;
        private System.Windows.Forms.TextBox PassTxt;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Label ConfirmPass;
        private System.Windows.Forms.TextBox PassConfirmTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
