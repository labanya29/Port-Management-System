namespace Port_Management_System
{
    partial class CrewDetailsForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.CrewSearchBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.data_grid_view = new System.Windows.Forms.DataGridView();
            this.@ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.@Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.@Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.id_tb);
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.CrewSearchBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 103);
            this.panel1.TabIndex = 0;
            // 
            // id_tb
            // 
            this.id_tb.Location = new System.Drawing.Point(89, 39);
            this.id_tb.Margin = new System.Windows.Forms.Padding(4);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(363, 22);
            this.id_tb.TabIndex = 2;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(641, 37);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(100, 28);
            this.DeleteBtn.TabIndex = 1;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // CrewSearchBtn
            // 
            this.CrewSearchBtn.Location = new System.Drawing.Point(493, 37);
            this.CrewSearchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CrewSearchBtn.Name = "CrewSearchBtn";
            this.CrewSearchBtn.Size = new System.Drawing.Size(100, 28);
            this.CrewSearchBtn.TabIndex = 0;
            this.CrewSearchBtn.Text = "Search";
            this.CrewSearchBtn.UseVisualStyleBackColor = true;
            this.CrewSearchBtn.Click += new System.EventHandler(this.CrewSearchBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // data_grid_view
            // 
            this.data_grid_view.AllowUserToAddRows = false;
            this.data_grid_view.AllowUserToDeleteRows = false;
            this.data_grid_view.BackgroundColor = System.Drawing.Color.LightCyan;
            this.data_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.@ID,
            this.@Name,
            this.@Email});
            this.data_grid_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_grid_view.Location = new System.Drawing.Point(0, 103);
            this.data_grid_view.Name = "data_grid_view";
            this.data_grid_view.ReadOnly = true;
            this.data_grid_view.RowHeadersWidth = 51;
            this.data_grid_view.RowTemplate.Height = 24;
            this.data_grid_view.Size = new System.Drawing.Size(827, 340);
            this.data_grid_view.TabIndex = 1;
            this.data_grid_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_view_CellContentClick_1);
            // 
            // @ID
            // 
            this.@ID.HeaderText = "ID";
            this.@ID.MinimumWidth = 6;
            this.@ID.Name = "@ID";
            this.@ID.ReadOnly = true;
            this.@ID.Width = 125;
            // 
            // @Name
            // 
            this.@Name.HeaderText = "Name";
            this.@Name.MinimumWidth = 6;
            this.@Name.Name = "@Name";
            this.@Name.ReadOnly = true;
            this.@Name.Width = 125;
            // 
            // @Email
            // 
            this.@Email.HeaderText = "Email";
            this.@Email.MinimumWidth = 6;
            this.@Email.Name = "@Email";
            this.@Email.ReadOnly = true;
            this.@Email.Width = 125;
            // 
            // CrewDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.data_grid_view);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
          //  this.Name = "CrewDetailsForm";
            this.Size = new System.Drawing.Size(827, 443);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button CrewSearchBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView data_grid_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        //private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Name;
      //  private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        // private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        // private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        //private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}
