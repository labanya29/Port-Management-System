﻿namespace Port_Management_System
{
    partial class Deck_officer
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
            this.CrewDetailsBtn = new System.Windows.Forms.Button();
            this.AddCrew = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AddCrewPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CrewDetailsBtn);
            this.panel1.Controls.Add(this.AddCrew);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // CrewDetailsBtn
            // 
            this.CrewDetailsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CrewDetailsBtn.Location = new System.Drawing.Point(0, 46);
            this.CrewDetailsBtn.Name = "CrewDetailsBtn";
            this.CrewDetailsBtn.Size = new System.Drawing.Size(200, 23);
            this.CrewDetailsBtn.TabIndex = 2;
            this.CrewDetailsBtn.Text = "Crew Details";
            this.CrewDetailsBtn.UseVisualStyleBackColor = true;
            this.CrewDetailsBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddCrew
            // 
            this.AddCrew.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddCrew.Location = new System.Drawing.Point(0, 23);
            this.AddCrew.Name = "AddCrew";
            this.AddCrew.Size = new System.Drawing.Size(200, 23);
            this.AddCrew.TabIndex = 1;
            this.AddCrew.Text = "Add Crew";
            this.AddCrew.UseVisualStyleBackColor = true;
            this.AddCrew.Click += new System.EventHandler(this.add_crew_btn_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Vessel Details ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddCrewPanel
            // 
            this.AddCrewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddCrewPanel.Location = new System.Drawing.Point(200, 0);
            this.AddCrewPanel.Name = "AddCrewPanel";
            this.AddCrewPanel.Size = new System.Drawing.Size(600, 450);
            this.AddCrewPanel.TabIndex = 1;
            // 
            // Deck_officer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddCrewPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Deck_officer";
            this.Text = "Deck_officer";
            this.Load += new System.EventHandler(this.Deck_officer_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel AddCrewPanel;
        private System.Windows.Forms.Button CrewDetailsBtn;
        private System.Windows.Forms.Button AddCrew;
        private System.Windows.Forms.Button button1;
    }
}