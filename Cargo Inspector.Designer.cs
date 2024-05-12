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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CargoDetails = new System.Windows.Forms.Button();
            this.AddCargo = new System.Windows.Forms.Button();
            this.CargoInspectorPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CargoDetails);
            this.panel1.Controls.Add(this.AddCargo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 554);
            this.panel1.TabIndex = 0;
            // 
            // CargoDetails
            // 
            this.CargoDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.CargoDetails.Location = new System.Drawing.Point(0, 28);
            this.CargoDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CargoDetails.Name = "CargoDetails";
            this.CargoDetails.Size = new System.Drawing.Size(267, 28);
            this.CargoDetails.TabIndex = 1;
            this.CargoDetails.Text = "Cargo Details";
            this.CargoDetails.UseVisualStyleBackColor = true;
            // 
            // AddCargo
            // 
            this.AddCargo.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddCargo.Location = new System.Drawing.Point(0, 0);
            this.AddCargo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddCargo.Name = "AddCargo";
            this.AddCargo.Size = new System.Drawing.Size(267, 28);
            this.AddCargo.TabIndex = 0;
            this.AddCargo.Text = "Add Cargo";
            this.AddCargo.UseVisualStyleBackColor = true;
            this.AddCargo.Click += new System.EventHandler(this.AddCargo_Click);
            // 
            // CargoInspectorPanel
            // 
            this.CargoInspectorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CargoInspectorPanel.Location = new System.Drawing.Point(267, 0);
            this.CargoInspectorPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CargoInspectorPanel.Name = "CargoInspectorPanel";
            this.CargoInspectorPanel.Size = new System.Drawing.Size(800, 554);
            this.CargoInspectorPanel.TabIndex = 1;
            // 
            // Cargo_Inspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.CargoInspectorPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}