namespace Port_Management_System
{
    partial class Schedule_list
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
            this.vassel_name = new System.Windows.Forms.Label();
            this.imo_number = new System.Windows.Forms.Label();
            this.departure_time = new System.Windows.Forms.Label();
            this.next_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vassel_name
            // 
            this.vassel_name.AutoSize = true;
            this.vassel_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vassel_name.Location = new System.Drawing.Point(12, 22);
            this.vassel_name.Name = "vassel_name";
            this.vassel_name.Size = new System.Drawing.Size(119, 20);
            this.vassel_name.TabIndex = 0;
            this.vassel_name.Text = "Vassel Name:";
            // 
            // imo_number
            // 
            this.imo_number.AutoSize = true;
            this.imo_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imo_number.Location = new System.Drawing.Point(8, 67);
            this.imo_number.Name = "imo_number";
            this.imo_number.Size = new System.Drawing.Size(114, 20);
            this.imo_number.TabIndex = 1;
            this.imo_number.Text = "IMO Number:";
            // 
            // departure_time
            // 
            this.departure_time.AutoSize = true;
            this.departure_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departure_time.Location = new System.Drawing.Point(7, 107);
            this.departure_time.Name = "departure_time";
            this.departure_time.Size = new System.Drawing.Size(145, 20);
            this.departure_time.TabIndex = 2;
            this.departure_time.Text = "Departure TIme: ";
            // 
            // next_button
            // 
            this.next_button.Location = new System.Drawing.Point(286, 53);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(45, 44);
            this.next_button.TabIndex = 3;
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // Schedule_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.departure_time);
            this.Controls.Add(this.imo_number);
            this.Controls.Add(this.vassel_name);
            this.Name = "Schedule_list";
            this.Size = new System.Drawing.Size(334, 141);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vassel_name;
        private System.Windows.Forms.Label imo_number;
        private System.Windows.Forms.Label departure_time;
        private System.Windows.Forms.Button next_button;
    }
}
