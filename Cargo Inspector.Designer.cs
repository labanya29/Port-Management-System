namespace Port_Management_System
{
    partial class Cargo_Inspector
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
            this.CargoInspectorPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CiLogOutBtn = new System.Windows.Forms.Button();
            this.CargoDetails = new System.Windows.Forms.Button();
            this.AddCargo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CargoInspectorPanel
            // 
            this.CargoInspectorPanel.BackgroundImage = global::Port_Management_System.Properties.Resources.container_ships_zeymarine_blog;
            this.CargoInspectorPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CargoInspectorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CargoInspectorPanel.Location = new System.Drawing.Point(267, 0);
            this.CargoInspectorPanel.Margin = new System.Windows.Forms.Padding(4);
            this.CargoInspectorPanel.Name = "CargoInspectorPanel";
            this.CargoInspectorPanel.Size = new System.Drawing.Size(800, 554);
            this.CargoInspectorPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.BackgroundImage = global::Port_Management_System.Properties.Resources._360_F_108317062_Xkwb5KmLXWuvaufcHGV65oEpDunmmwcA1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.CiLogOutBtn);
            this.panel1.Controls.Add(this.CargoDetails);
            this.panel1.Controls.Add(this.AddCargo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 554);
            this.panel1.TabIndex = 0;
            // 
            // CiLogOutBtn
            // 
            this.CiLogOutBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CiLogOutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CiLogOutBtn.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CiLogOutBtn.Location = new System.Drawing.Point(0, 531);
            this.CiLogOutBtn.Name = "CiLogOutBtn";
            this.CiLogOutBtn.Size = new System.Drawing.Size(267, 23);
            this.CiLogOutBtn.TabIndex = 2;
            this.CiLogOutBtn.Text = "Log Out";
            this.CiLogOutBtn.UseVisualStyleBackColor = false;
            this.CiLogOutBtn.Click += new System.EventHandler(this.CiLogOutBtn_Click);
            // 
            // CargoDetails
            // 
            this.CargoDetails.BackColor = System.Drawing.Color.SkyBlue;
            this.CargoDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.CargoDetails.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargoDetails.Location = new System.Drawing.Point(0, 28);
            this.CargoDetails.Margin = new System.Windows.Forms.Padding(4);
            this.CargoDetails.Name = "CargoDetails";
            this.CargoDetails.Size = new System.Drawing.Size(267, 28);
            this.CargoDetails.TabIndex = 1;
            this.CargoDetails.Text = "Cargo Details";
            this.CargoDetails.UseVisualStyleBackColor = false;
            this.CargoDetails.Click += new System.EventHandler(this.CargoDetails_Click);
            // 
            // AddCargo
            // 
            this.AddCargo.BackColor = System.Drawing.Color.SkyBlue;
            this.AddCargo.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddCargo.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCargo.Location = new System.Drawing.Point(0, 0);
            this.AddCargo.Margin = new System.Windows.Forms.Padding(4);
            this.AddCargo.Name = "AddCargo";
            this.AddCargo.Size = new System.Drawing.Size(267, 28);
            this.AddCargo.TabIndex = 0;
            this.AddCargo.Text = "Add Cargo";
            this.AddCargo.UseVisualStyleBackColor = false;
            this.AddCargo.Click += new System.EventHandler(this.AddCargo_Click);
            // 
            // Cargo_Inspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.CargoInspectorPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cargo_Inspector";
            this.Text = "Cargo_Inspector";
            this.Load += new System.EventHandler(this.Cargo_Inspector_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CargoDetails;
        private System.Windows.Forms.Button AddCargo;
        private System.Windows.Forms.Panel CargoInspectorPanel;
        private System.Windows.Forms.Button CiLogOutBtn;
    }
}