
namespace Autolog
{
    partial class LOLUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOLUC));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveAcc = new System.Windows.Forms.Button();
            this.AddAcc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.addAccount1 = new Autolog.AddAccount();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(132, 569);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(131, 23);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Stay Logged In";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Location = new System.Drawing.Point(68, 229);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(259, 32);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Black;
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(158, 534);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 29);
            this.LoginBtn.TabIndex = 15;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 35);
            this.label1.TabIndex = 16;
            this.label1.Text = "Accounts";
            // 
            // RemoveAcc
            // 
            this.RemoveAcc.BackColor = System.Drawing.Color.Black;
            this.RemoveAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveAcc.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveAcc.ForeColor = System.Drawing.Color.White;
            this.RemoveAcc.Location = new System.Drawing.Point(68, 267);
            this.RemoveAcc.Name = "RemoveAcc";
            this.RemoveAcc.Size = new System.Drawing.Size(140, 29);
            this.RemoveAcc.TabIndex = 17;
            this.RemoveAcc.Text = "Remove Account";
            this.RemoveAcc.UseVisualStyleBackColor = false;
            this.RemoveAcc.Click += new System.EventHandler(this.RemoveAcc_Click);
            // 
            // AddAcc
            // 
            this.AddAcc.BackColor = System.Drawing.Color.Black;
            this.AddAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddAcc.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAcc.ForeColor = System.Drawing.Color.White;
            this.AddAcc.Location = new System.Drawing.Point(215, 267);
            this.AddAcc.Name = "AddAcc";
            this.AddAcc.Size = new System.Drawing.Size(113, 29);
            this.AddAcc.TabIndex = 16;
            this.AddAcc.Text = "Add Account";
            this.AddAcc.UseVisualStyleBackColor = false;
            this.AddAcc.Click += new System.EventHandler(this.AddAcc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(299, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(53, 144);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 33);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // addAccount1
            // 
            this.addAccount1.Location = new System.Drawing.Point(-24, 98);
            this.addAccount1.Name = "addAccount1";
            this.addAccount1.Size = new System.Drawing.Size(400, 654);
            this.addAccount1.TabIndex = 18;
            // 
            // LOLUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addAccount1);
            this.Controls.Add(this.AddAcc);
            this.Controls.Add(this.RemoveAcc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "LOLUC";
            this.Size = new System.Drawing.Size(400, 834);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveAcc;
        private System.Windows.Forms.Button AddAcc;
        private AddAccount addAccount1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
