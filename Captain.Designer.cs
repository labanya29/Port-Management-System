namespace Port_Management_System
{
    partial class CaptainForm
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
            this.CrewDetailsBtn = new System.Windows.Forms.Button();
            this.CargoDetailsBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.captain_panel = new System.Windows.Forms.Panel();
            this.CALogOutBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CrewDetailsBtn
            // 
            this.CrewDetailsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CrewDetailsBtn.Location = new System.Drawing.Point(0, 0);
            this.CrewDetailsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CrewDetailsBtn.Name = "CrewDetailsBtn";
            this.CrewDetailsBtn.Size = new System.Drawing.Size(177, 38);
            this.CrewDetailsBtn.TabIndex = 1;
            this.CrewDetailsBtn.Text = "Crew details";
            this.CrewDetailsBtn.UseVisualStyleBackColor = true;
            this.CrewDetailsBtn.Click += new System.EventHandler(this.CrewDetailsBtn_Click);
            // 
            // CargoDetailsBtn
            // 
            this.CargoDetailsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CargoDetailsBtn.Location = new System.Drawing.Point(0, 38);
            this.CargoDetailsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CargoDetailsBtn.Name = "CargoDetailsBtn";
            this.CargoDetailsBtn.Size = new System.Drawing.Size(177, 36);
            this.CargoDetailsBtn.TabIndex = 2;
            this.CargoDetailsBtn.Text = "Cargo Details";
            this.CargoDetailsBtn.UseVisualStyleBackColor = true;
            this.CargoDetailsBtn.Click += new System.EventHandler(this.CargoDetailsBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CALogOutBtn);
            this.panel1.Controls.Add(this.CargoDetailsBtn);
            this.panel1.Controls.Add(this.CrewDetailsBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 450);
            this.panel1.TabIndex = 4;
            // 
            // captain_panel
            // 
            this.captain_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.captain_panel.Location = new System.Drawing.Point(177, 0);
            this.captain_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.captain_panel.Name = "captain_panel";
            this.captain_panel.Size = new System.Drawing.Size(623, 450);
            this.captain_panel.TabIndex = 5;
            // 
            // CALogOutBtn
            // 
            this.CALogOutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CALogOutBtn.Location = new System.Drawing.Point(0, 427);
            this.CALogOutBtn.Name = "CALogOutBtn";
            this.CALogOutBtn.Size = new System.Drawing.Size(177, 23);
            this.CALogOutBtn.TabIndex = 3;
            this.CALogOutBtn.Text = "Log Out";
            this.CALogOutBtn.UseVisualStyleBackColor = true;
            this.CALogOutBtn.Click += new System.EventHandler(this.CALogOutBtn_Click);
            // 
            // CaptainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.captain_panel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CaptainForm";
            this.Text = "Captain";
            this.Load += new System.EventHandler(this.captain_from_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CrewDetailsBtn;
        private System.Windows.Forms.Button CargoDetailsBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel captain_panel;
        private System.Windows.Forms.Button CALogOutBtn;
    }
}