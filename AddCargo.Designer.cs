namespace Port_Management_System
{
    partial class AddCargo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CargoIdTb = new System.Windows.Forms.TextBox();
            this.TypeOfCargoTb = new System.Windows.Forms.TextBox();
            this.CargoQuantityTb = new System.Windows.Forms.TextBox();
            this.CargoNoTb = new System.Windows.Forms.TextBox();
            this.DestinationTb = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type of Cargo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destination :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cargo ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cargo No :";
            // 
            // CargoIdTb
            // 
            this.CargoIdTb.Location = new System.Drawing.Point(216, 59);
            this.CargoIdTb.Name = "CargoIdTb";
            this.CargoIdTb.Size = new System.Drawing.Size(100, 20);
            this.CargoIdTb.TabIndex = 10;
            // 
            // TypeOfCargoTb
            // 
            this.TypeOfCargoTb.Location = new System.Drawing.Point(216, 143);
            this.TypeOfCargoTb.Name = "TypeOfCargoTb";
            this.TypeOfCargoTb.Size = new System.Drawing.Size(100, 20);
            this.TypeOfCargoTb.TabIndex = 11;
            // 
            // CargoQuantityTb
            // 
            this.CargoQuantityTb.Location = new System.Drawing.Point(216, 190);
            this.CargoQuantityTb.Name = "CargoQuantityTb";
            this.CargoQuantityTb.Size = new System.Drawing.Size(100, 20);
            this.CargoQuantityTb.TabIndex = 12;
            // 
            // CargoNoTb
            // 
            this.CargoNoTb.Location = new System.Drawing.Point(216, 103);
            this.CargoNoTb.Name = "CargoNoTb";
            this.CargoNoTb.Size = new System.Drawing.Size(100, 20);
            this.CargoNoTb.TabIndex = 14;
            // 
            // DestinationTb
            // 
            this.DestinationTb.Location = new System.Drawing.Point(216, 228);
            this.DestinationTb.Name = "DestinationTb";
            this.DestinationTb.Size = new System.Drawing.Size(100, 20);
            this.DestinationTb.TabIndex = 15;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(240, 278);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(75, 23);
            this.RegisterBtn.TabIndex = 16;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // AddCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.DestinationTb);
            this.Controls.Add(this.CargoNoTb);
            this.Controls.Add(this.CargoQuantityTb);
            this.Controls.Add(this.TypeOfCargoTb);
            this.Controls.Add(this.CargoIdTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCargo";
            this.Size = new System.Drawing.Size(560, 344);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CargoIdTb;
        private System.Windows.Forms.TextBox TypeOfCargoTb;
        private System.Windows.Forms.TextBox CargoQuantityTb;
        private System.Windows.Forms.TextBox CargoNoTb;
        private System.Windows.Forms.TextBox DestinationTb;
        private System.Windows.Forms.Button RegisterBtn;
    }
}
