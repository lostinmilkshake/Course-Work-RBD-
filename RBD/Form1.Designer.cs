namespace RBD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialsView = new System.Windows.Forms.DataGridView();
            this.addNewMaterial = new System.Windows.Forms.Button();
            this.warehouseButton = new System.Windows.Forms.Button();
            this.supplierButton = new System.Windows.Forms.Button();
            this.typesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.materialsView)).BeginInit();
            this.SuspendLayout();
            // 
            // materialsView
            // 
            this.materialsView.AllowUserToAddRows = false;
            this.materialsView.AllowUserToDeleteRows = false;
            this.materialsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialsView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.materialsView.Location = new System.Drawing.Point(12, 36);
            this.materialsView.Name = "materialsView";
            this.materialsView.RowTemplate.Height = 25;
            this.materialsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.materialsView.Size = new System.Drawing.Size(605, 402);
            this.materialsView.TabIndex = 0;
            this.materialsView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.materialsView_CellContentClick);
            this.materialsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.materialsView_CellContentClick);
            // 
            // addNewMaterial
            // 
            this.addNewMaterial.Location = new System.Drawing.Point(12, 7);
            this.addNewMaterial.Name = "addNewMaterial";
            this.addNewMaterial.Size = new System.Drawing.Size(102, 23);
            this.addNewMaterial.TabIndex = 1;
            this.addNewMaterial.Text = "Add Material";
            this.addNewMaterial.UseVisualStyleBackColor = true;
            this.addNewMaterial.Click += new System.EventHandler(this.addNewMaterial_Click);
            // 
            // warehouseButton
            // 
            this.warehouseButton.Location = new System.Drawing.Point(634, 36);
            this.warehouseButton.Name = "warehouseButton";
            this.warehouseButton.Size = new System.Drawing.Size(94, 23);
            this.warehouseButton.TabIndex = 2;
            this.warehouseButton.Text = "Warehouses";
            this.warehouseButton.UseVisualStyleBackColor = true;
            this.warehouseButton.Click += new System.EventHandler(this.warehouseButton_Click);
            // 
            // supplierButton
            // 
            this.supplierButton.Location = new System.Drawing.Point(634, 65);
            this.supplierButton.Name = "supplierButton";
            this.supplierButton.Size = new System.Drawing.Size(94, 23);
            this.supplierButton.TabIndex = 3;
            this.supplierButton.Text = "Suppliers";
            this.supplierButton.UseVisualStyleBackColor = true;
            this.supplierButton.Click += new System.EventHandler(this.supplierButton_Click);
            // 
            // typesButton
            // 
            this.typesButton.Location = new System.Drawing.Point(634, 94);
            this.typesButton.Name = "typesButton";
            this.typesButton.Size = new System.Drawing.Size(94, 23);
            this.typesButton.TabIndex = 4;
            this.typesButton.Text = "Types";
            this.typesButton.UseVisualStyleBackColor = true;
            this.typesButton.Click += new System.EventHandler(this.typesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.typesButton);
            this.Controls.Add(this.supplierButton);
            this.Controls.Add(this.warehouseButton);
            this.Controls.Add(this.addNewMaterial);
            this.Controls.Add(this.materialsView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.materialsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView materialsView;
        private System.Windows.Forms.Button addNewMaterial;
        private System.Windows.Forms.Button warehouseButton;
        private System.Windows.Forms.Button supplierButton;
        private System.Windows.Forms.Button typesButton;
    }
}
