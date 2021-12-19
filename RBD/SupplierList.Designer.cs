namespace RBD
{
    partial class SupplierList
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
            this.addNewSupplier = new System.Windows.Forms.Button();
            this.suppliersView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersView)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewSupplier
            // 
            this.addNewSupplier.Location = new System.Drawing.Point(12, 10);
            this.addNewSupplier.Name = "addNewSupplier";
            this.addNewSupplier.Size = new System.Drawing.Size(102, 23);
            this.addNewSupplier.TabIndex = 5;
            this.addNewSupplier.Text = "Add Supplier";
            this.addNewSupplier.UseVisualStyleBackColor = true;
            this.addNewSupplier.Click += new System.EventHandler(this.addNewSupplier_Click);
            // 
            // suppliersView
            // 
            this.suppliersView.AllowUserToAddRows = false;
            this.suppliersView.AllowUserToDeleteRows = false;
            this.suppliersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.suppliersView.Location = new System.Drawing.Point(12, 39);
            this.suppliersView.Name = "suppliersView";
            this.suppliersView.RowTemplate.Height = 25;
            this.suppliersView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.suppliersView.Size = new System.Drawing.Size(776, 402);
            this.suppliersView.TabIndex = 4;
            this.suppliersView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.suppliersView_CellContentClick);
            this.suppliersView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.suppliersView_CellContentClick);
            this.suppliersView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.suppliersView_CellContentClick);
            // 
            // SupplierList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addNewSupplier);
            this.Controls.Add(this.suppliersView);
            this.Name = "SupplierList";
            this.Text = "SupplierList";
            ((System.ComponentModel.ISupportInitialize)(this.suppliersView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNewSupplier;
        private System.Windows.Forms.DataGridView suppliersView;
    }
}