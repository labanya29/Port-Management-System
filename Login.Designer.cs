namespace Port_Management_System
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
            this.login_button = new System.Windows.Forms.Button();
            this.id_tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.AdminSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.SteelBlue;
            this.login_button.Location = new System.Drawing.Point(694, 211);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // id_tbx
            // 
            this.id_tbx.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.id_tbx.Location = new System.Drawing.Point(585, 107);
            this.id_tbx.Name = "id_tbx";
            this.id_tbx.Size = new System.Drawing.Size(197, 20);
            this.id_tbx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(508, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "USER ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(508, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PASSWORD";
            // 
            // password_tb
            // 
            this.password_tb.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.password_tb.Location = new System.Drawing.Point(585, 159);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(197, 20);
            this.password_tb.TabIndex = 4;
            // 
            // AdminSignUp
            // 
            this.AdminSignUp.Location = new System.Drawing.Point(569, 211);
            this.AdminSignUp.Name = "AdminSignUp";
            this.AdminSignUp.Size = new System.Drawing.Size(101, 23);
            this.AdminSignUp.TabIndex = 5;
            this.AdminSignUp.Text = "Admin Sign up";
            this.AdminSignUp.UseVisualStyleBackColor = true;
            this.AdminSignUp.Click += new System.EventHandler(this.AdminSignUp_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Port_Management_System.Properties.Resources.Log_in;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdminSignUp);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_tbx);
            this.Controls.Add(this.login_button);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Login";
            this.Text = "LOGIN PAGE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox id_tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Button AdminSignUp;
    }
}

