namespace DMS_070_Exercices
{
    partial class Exo070
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
            this.grid_Customers = new System.Windows.Forms.DataGridView();
            this.btn_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Customers)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_Customers
            // 
            this.grid_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Customers.Location = new System.Drawing.Point(25, 39);
            this.grid_Customers.Name = "grid_Customers";
            this.grid_Customers.Size = new System.Drawing.Size(583, 426);
            this.grid_Customers.TabIndex = 0;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(264, 498);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // Exo070
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 549);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.grid_Customers);
            this.Name = "Exo070";
            this.Text = "Exo070";
            ((System.ComponentModel.ISupportInitialize)(this.grid_Customers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_Customers;
        private System.Windows.Forms.Button btn_Update;
    }
}