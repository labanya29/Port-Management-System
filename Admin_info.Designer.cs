namespace Port_Management_System
{
    partial class Admin_info
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.delete_button = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.data_grid_view = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.data_grid_view, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1006, 599);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.id_tb);
            this.panel1.Controls.Add(this.delete_button);
            this.panel1.Controls.Add(this.search_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 94);
            this.panel1.TabIndex = 0;
            // 
            // id_tb
            // 
            this.id_tb.Location = new System.Drawing.Point(239, 42);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(310, 22);
            this.id_tb.TabIndex = 2;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(743, 32);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(78, 33);
            this.delete_button.TabIndex = 1;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(615, 30);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(101, 37);
            this.search_btn.TabIndex = 0;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // data_grid_view
            // 
            this.data_grid_view.AllowUserToAddRows = false;
            this.data_grid_view.AllowUserToDeleteRows = false;
            this.data_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_grid_view.Location = new System.Drawing.Point(3, 103);
            this.data_grid_view.Name = "data_grid_view";
            this.data_grid_view.ReadOnly = true;
            this.data_grid_view.RowHeadersWidth = 51;
            this.data_grid_view.RowTemplate.Height = 24;
            this.data_grid_view.Size = new System.Drawing.Size(1000, 493);
            this.data_grid_view.TabIndex = 1;
            this.data_grid_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Admin_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Admin_info";
            this.Size = new System.Drawing.Size(1006, 599);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.DataGridView data_grid_view;
    }
}