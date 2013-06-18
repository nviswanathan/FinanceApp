namespace FinanceApp
{
    partial class LoginForm
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
            this.controlspanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblerrormessage = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.controlspanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlspanel
            // 
            this.controlspanel.BackColor = System.Drawing.Color.Transparent;
            this.controlspanel.Controls.Add(this.groupBox1);
            this.controlspanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlspanel.Location = new System.Drawing.Point(0, 0);
            this.controlspanel.Name = "controlspanel";
            this.controlspanel.Size = new System.Drawing.Size(513, 266);
            this.controlspanel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblerrormessage);
            this.groupBox1.Controls.Add(this.btnlogin);
            this.groupBox1.Controls.Add(this.passwordlbl);
            this.groupBox1.Controls.Add(this.passwordtxt);
            this.groupBox1.Controls.Add(this.usernametxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log In";
            // 
            // lblerrormessage
            // 
            this.lblerrormessage.AutoSize = true;
            this.lblerrormessage.Location = new System.Drawing.Point(157, 141);
            this.lblerrormessage.Name = "lblerrormessage";
            this.lblerrormessage.Size = new System.Drawing.Size(0, 13);
            this.lblerrormessage.TabIndex = 5;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(160, 166);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Sign In";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Location = new System.Drawing.Point(82, 111);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(59, 13);
            this.passwordlbl.TabIndex = 3;
            this.passwordlbl.Text = "Passwrod :";
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(160, 108);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = 'o';
            this.passwordtxt.Size = new System.Drawing.Size(177, 20);
            this.passwordtxt.TabIndex = 2;
            this.passwordtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordtxt_KeyPress);
            // 
            // usernametxt
            // 
            this.usernametxt.BackColor = System.Drawing.Color.White;
            this.usernametxt.Location = new System.Drawing.Point(160, 63);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(177, 20);
            this.usernametxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name :";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 266);
            this.ControlBox = false;
            this.Controls.Add(this.controlspanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.controlspanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlspanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblerrormessage;
    }
}

