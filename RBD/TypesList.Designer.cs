namespace RBD
{
    partial class TypesList
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
            this.addNewType = new System.Windows.Forms.Button();
            this.typesView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.typesView)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewType
            // 
            this.addNewType.Location = new System.Drawing.Point(12, 12);
            this.addNewType.Name = "addNewType";
            this.addNewType.Size = new System.Drawing.Size(102, 23);
            this.addNewType.TabIndex = 3;
            this.addNewType.Text = "Add Type";
            this.addNewType.UseVisualStyleBackColor = true;
            this.addNewType.Click += new System.EventHandler(this.addNewType_Click);
            // 
            // typesView
            // 
            this.typesView.AllowUserToAddRows = false;
            this.typesView.AllowUserToDeleteRows = false;
            this.typesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typesView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.typesView.Location = new System.Drawing.Point(12, 41);
            this.typesView.Name = "typesView";
            this.typesView.RowTemplate.Height = 25;
            this.typesView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.typesView.Size = new System.Drawing.Size(776, 402);
            this.typesView.TabIndex = 2;
            this.typesView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.typesView_CellContentClick);
            this.typesView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.typesView_CellContentClick);
            // 
            // TypesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 458);
            this.Controls.Add(this.addNewType);
            this.Controls.Add(this.typesView);
            this.Name = "TypesList";
            this.Text = "TypesList";
            ((System.ComponentModel.ISupportInitialize)(this.typesView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNewType;
        private System.Windows.Forms.DataGridView typesView;
    }
}