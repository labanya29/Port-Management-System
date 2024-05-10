
namespace Port_Management_System
{
    partial class AdminForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.admin_panel = new System.Windows.Forms.Panel();
            this.delete_admin_button = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.profile_pictureBox = new System.Windows.Forms.PictureBox();
            this.schedule_btn = new System.Windows.Forms.Button();
            this.add_sub_panel = new System.Windows.Forms.Panel();
            this.add_vessel_btn = new System.Windows.Forms.Button();
            this.add_cargo_inspactor_btn = new System.Windows.Forms.Button();
            this.deck_officer_btn = new System.Windows.Forms.Button();
            this.captain_add_btn = new System.Windows.Forms.Button();
            this.new_admin_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.delete_sub_panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_pictureBox)).BeginInit();
            this.add_sub_panel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.delete_sub_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.admin_panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(158, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 554);
            this.panel1.TabIndex = 0;
            // 
            // admin_panel
            // 
            this.admin_panel.BackgroundImage = global::Port_Management_System.Properties.Resources._2ND;
            this.admin_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.admin_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admin_panel.Location = new System.Drawing.Point(0, 0);
            this.admin_panel.Margin = new System.Windows.Forms.Padding(4);
            this.admin_panel.Name = "admin_panel";
            this.admin_panel.Size = new System.Drawing.Size(909, 554);
            this.admin_panel.TabIndex = 1;
            // 
            // delete_admin_button
            // 
            this.delete_admin_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.delete_admin_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_admin_button.Location = new System.Drawing.Point(0, 168);
            this.delete_admin_button.Margin = new System.Windows.Forms.Padding(0);
            this.delete_admin_button.Name = "delete_admin_button";
            this.delete_admin_button.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.delete_admin_button.Size = new System.Drawing.Size(137, 42);
            this.delete_admin_button.TabIndex = 5;
            this.delete_admin_button.Text = "Delete Admin";
            this.delete_admin_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete_admin_button.UseVisualStyleBackColor = true;
            this.delete_admin_button.Click += new System.EventHandler(this.delete_admin_button_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout_btn.Location = new System.Drawing.Point(0, 627);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(4);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(137, 49);
            this.logout_btn.TabIndex = 3;
            this.logout_btn.Text = "Log Out";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // profile_pictureBox
            // 
            this.profile_pictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.profile_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.profile_pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.profile_pictureBox.Name = "profile_pictureBox";
            this.profile_pictureBox.Size = new System.Drawing.Size(137, 79);
            this.profile_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.profile_pictureBox.TabIndex = 2;
            this.profile_pictureBox.TabStop = false;
            this.profile_pictureBox.Click += new System.EventHandler(this.profile_pictureBox_Click);
            // 
            // schedule_btn
            // 
            this.schedule_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.schedule_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.schedule_btn.Location = new System.Drawing.Point(0, 332);
            this.schedule_btn.Margin = new System.Windows.Forms.Padding(0);
            this.schedule_btn.Name = "schedule_btn";
            this.schedule_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.schedule_btn.Size = new System.Drawing.Size(137, 42);
            this.schedule_btn.TabIndex = 1;
            this.schedule_btn.Text = "Schedule";
            this.schedule_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.schedule_btn.UseVisualStyleBackColor = true;
            this.schedule_btn.Click += new System.EventHandler(this.schedule_btn_Click);
            // 
            // add_sub_panel
            // 
            this.add_sub_panel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.add_sub_panel.Controls.Add(this.add_vessel_btn);
            this.add_sub_panel.Controls.Add(this.add_cargo_inspactor_btn);
            this.add_sub_panel.Controls.Add(this.deck_officer_btn);
            this.add_sub_panel.Controls.Add(this.captain_add_btn);
            this.add_sub_panel.Controls.Add(this.new_admin_btn);
            this.add_sub_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.add_sub_panel.Location = new System.Drawing.Point(0, 121);
            this.add_sub_panel.Name = "add_sub_panel";
            this.add_sub_panel.Size = new System.Drawing.Size(137, 211);
            this.add_sub_panel.TabIndex = 6;
            this.add_sub_panel.Visible = false;
            // 
            // add_vessel_btn
            // 
            this.add_vessel_btn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.add_vessel_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.add_vessel_btn.FlatAppearance.BorderSize = 0;
            this.add_vessel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_vessel_btn.Location = new System.Drawing.Point(0, 168);
            this.add_vessel_btn.Margin = new System.Windows.Forms.Padding(0);
            this.add_vessel_btn.Name = "add_vessel_btn";
            this.add_vessel_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.add_vessel_btn.Size = new System.Drawing.Size(137, 42);
            this.add_vessel_btn.TabIndex = 8;
            this.add_vessel_btn.Text = "Vessel";
            this.add_vessel_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_vessel_btn.UseVisualStyleBackColor = false;
            // 
            // add_cargo_inspactor_btn
            // 
            this.add_cargo_inspactor_btn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.add_cargo_inspactor_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.add_cargo_inspactor_btn.FlatAppearance.BorderSize = 0;
            this.add_cargo_inspactor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_cargo_inspactor_btn.Location = new System.Drawing.Point(0, 126);
            this.add_cargo_inspactor_btn.Margin = new System.Windows.Forms.Padding(0);
            this.add_cargo_inspactor_btn.Name = "add_cargo_inspactor_btn";
            this.add_cargo_inspactor_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.add_cargo_inspactor_btn.Size = new System.Drawing.Size(137, 42);
            this.add_cargo_inspactor_btn.TabIndex = 7;
            this.add_cargo_inspactor_btn.Text = "Cargo Inspactor";
            this.add_cargo_inspactor_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_cargo_inspactor_btn.UseVisualStyleBackColor = false;
            // 
            // deck_officer_btn
            // 
            this.deck_officer_btn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.deck_officer_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.deck_officer_btn.FlatAppearance.BorderSize = 0;
            this.deck_officer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deck_officer_btn.Location = new System.Drawing.Point(0, 84);
            this.deck_officer_btn.Margin = new System.Windows.Forms.Padding(0);
            this.deck_officer_btn.Name = "deck_officer_btn";
            this.deck_officer_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.deck_officer_btn.Size = new System.Drawing.Size(137, 42);
            this.deck_officer_btn.TabIndex = 6;
            this.deck_officer_btn.Text = "Deck Officer";
            this.deck_officer_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deck_officer_btn.UseVisualStyleBackColor = false;
            // 
            // captain_add_btn
            // 
            this.captain_add_btn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.captain_add_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.captain_add_btn.FlatAppearance.BorderSize = 0;
            this.captain_add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.captain_add_btn.Location = new System.Drawing.Point(0, 42);
            this.captain_add_btn.Margin = new System.Windows.Forms.Padding(0);
            this.captain_add_btn.Name = "captain_add_btn";
            this.captain_add_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.captain_add_btn.Size = new System.Drawing.Size(137, 42);
            this.captain_add_btn.TabIndex = 5;
            this.captain_add_btn.Text = "Captain";
            this.captain_add_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.captain_add_btn.UseVisualStyleBackColor = false;
            this.captain_add_btn.Click += new System.EventHandler(this.captain_add_btn_Click);
            // 
            // new_admin_btn
            // 
            this.new_admin_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.new_admin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.new_admin_btn.Location = new System.Drawing.Point(0, 0);
            this.new_admin_btn.Margin = new System.Windows.Forms.Padding(0);
            this.new_admin_btn.Name = "new_admin_btn";
            this.new_admin_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.new_admin_btn.Size = new System.Drawing.Size(137, 42);
            this.new_admin_btn.TabIndex = 4;
            this.new_admin_btn.Text = "Admin";
            this.new_admin_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.new_admin_btn.UseVisualStyleBackColor = true;
            this.new_admin_btn.Click += new System.EventHandler(this.new_admin_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_btn.Location = new System.Drawing.Point(0, 79);
            this.add_btn.Margin = new System.Windows.Forms.Padding(0);
            this.add_btn.Name = "add_btn";
            this.add_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.add_btn.Size = new System.Drawing.Size(137, 42);
            this.add_btn.TabIndex = 6;
            this.add_btn.Text = "ADD";
            this.add_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.logout_btn);
            this.panel3.Controls.Add(this.delete_sub_panel);
            this.panel3.Controls.Add(this.delete_btn);
            this.panel3.Controls.Add(this.schedule_btn);
            this.panel3.Controls.Add(this.add_sub_panel);
            this.panel3.Controls.Add(this.add_btn);
            this.panel3.Controls.Add(this.profile_pictureBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 554);
            this.panel3.TabIndex = 7;
            // 
            // delete_sub_panel
            // 
            this.delete_sub_panel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.delete_sub_panel.Controls.Add(this.delete_admin_button);
            this.delete_sub_panel.Controls.Add(this.button1);
            this.delete_sub_panel.Controls.Add(this.button2);
            this.delete_sub_panel.Controls.Add(this.button3);
            this.delete_sub_panel.Controls.Add(this.button4);
            this.delete_sub_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.delete_sub_panel.Location = new System.Drawing.Point(0, 416);
            this.delete_sub_panel.Name = "delete_sub_panel";
            this.delete_sub_panel.Size = new System.Drawing.Size(137, 211);
            this.delete_sub_panel.TabIndex = 7;
            this.delete_sub_panel.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(0, 126);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(137, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Vessel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(0, 84);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(137, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cargo Inspactor";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(0, 42);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(137, 42);
            this.button3.TabIndex = 6;
            this.button3.Text = "Deck Officer";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(137, 42);
            this.button4.TabIndex = 5;
            this.button4.Text = "Captain";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // delete_btn
            // 
            this.delete_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_btn.Location = new System.Drawing.Point(0, 374);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(0);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.delete_btn.Size = new System.Drawing.Size(137, 42);
            this.delete_btn.TabIndex = 4;
            this.delete_btn.Text = "Delete";
            this.delete_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profile_pictureBox)).EndInit();
            this.add_sub_panel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.delete_sub_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.PictureBox profile_pictureBox;
        private System.Windows.Forms.Button schedule_btn;
        private System.Windows.Forms.Panel admin_panel;
        private System.Windows.Forms.Button delete_admin_button;
        private System.Windows.Forms.Panel add_sub_panel;
        private System.Windows.Forms.Button new_admin_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button captain_add_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button add_cargo_inspactor_btn;
        private System.Windows.Forms.Button deck_officer_btn;
        private System.Windows.Forms.Button add_vessel_btn;
        private System.Windows.Forms.Panel delete_sub_panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button delete_btn;
    }




}
