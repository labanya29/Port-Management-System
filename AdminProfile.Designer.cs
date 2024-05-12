namespace Port_Management_System
{
    partial class AdminProfile
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
            this.email_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phone_number_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // email_tb
            // 
            this.email_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email_tb.Location = new System.Drawing.Point(102, 201);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(222, 20);
            this.email_tb.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Email";
            // 
            // phone_number_tb
            // 
            this.phone_number_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phone_number_tb.Location = new System.Drawing.Point(102, 158);
            this.phone_number_tb.Name = "phone_number_tb";
            this.phone_number_tb.Size = new System.Drawing.Size(222, 20);
            this.phone_number_tb.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Phone Number";
            // 
            // name_tb
            // 
            this.name_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name_tb.Location = new System.Drawing.Point(102, 111);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(222, 20);
            this.name_tb.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name";
            // 
            // id_tb
            // 
            this.id_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.id_tb.Enabled = false;
            this.id_tb.Location = new System.Drawing.Point(102, 57);
            this.id_tb.Name = "id_tb";
            this.id_tb.ReadOnly = true;
            this.id_tb.Size = new System.Drawing.Size(222, 20);
            this.id_tb.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(3, 3);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 25;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // AdminProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phone_number_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.label1);
            this.Name = "AdminProfile";
            this.Size = new System.Drawing.Size(399, 244);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phone_number_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_btn;
    }
}
