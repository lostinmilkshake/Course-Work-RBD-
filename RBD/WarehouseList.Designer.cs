namespace RBD
{
    partial class WarehouseList
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
            this.addNewWarehouse = new System.Windows.Forms.Button();
            this.warehousesView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesView)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewWarehouse
            // 
            this.addNewWarehouse.Location = new System.Drawing.Point(12, 10);
            this.addNewWarehouse.Name = "addNewWarehouse";
            this.addNewWarehouse.Size = new System.Drawing.Size(102, 23);
            this.addNewWarehouse.TabIndex = 5;
            this.addNewWarehouse.Text = "Add Warehouse";
            this.addNewWarehouse.UseVisualStyleBackColor = true;
            this.addNewWarehouse.Click += new System.EventHandler(this.addNewWarehouse_Click);
            // 
            // warehousesView
            // 
            this.warehousesView.AllowUserToAddRows = false;
            this.warehousesView.AllowUserToDeleteRows = false;
            this.warehousesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.warehousesView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.warehousesView.Location = new System.Drawing.Point(12, 39);
            this.warehousesView.Name = "warehousesView";
            this.warehousesView.RowTemplate.Height = 25;
            this.warehousesView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.warehousesView.Size = new System.Drawing.Size(776, 402);
            this.warehousesView.TabIndex = 4;
            this.warehousesView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.warehousesView_CellContentClick);
            this.warehousesView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.warehousesView_CellContentClick);
            // 
            // WarehouseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addNewWarehouse);
            this.Controls.Add(this.warehousesView);
            this.Name = "WarehouseList";
            this.Text = "WarehouseList";
            ((System.ComponentModel.ISupportInitialize)(this.warehousesView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNewWarehouse;
        private System.Windows.Forms.DataGridView warehousesView;
    }
}