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
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddCargo = new System.Windows.Forms.Button();
            this.CargoDetails = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CargoDetails);
            this.panel1.Controls.Add(this.AddCargo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 450);
            this.panel2.TabIndex = 1;
            // 
            // AddCargo
            // 
            this.AddCargo.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddCargo.Location = new System.Drawing.Point(0, 0);
            this.AddCargo.Name = "AddCargo";
            this.AddCargo.Size = new System.Drawing.Size(200, 23);
            this.AddCargo.TabIndex = 0;
            this.AddCargo.Text = "Add Cargo";
            this.AddCargo.UseVisualStyleBackColor = true;
            // 
            // CargoDetails
            // 
            this.CargoDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.CargoDetails.Location = new System.Drawing.Point(0, 23);
            this.CargoDetails.Name = "CargoDetails";
            this.CargoDetails.Size = new System.Drawing.Size(200, 23);
            this.CargoDetails.TabIndex = 1;
            this.CargoDetails.Text = "Cargo Details";
            this.CargoDetails.UseVisualStyleBackColor = true;
            // 
            // Cargo_Inspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Panel panel2;
    }
}