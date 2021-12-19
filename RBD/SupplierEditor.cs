using RBD.BusinesLogic;
using RBD.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RBD
{
    public partial class SupplierEditor : Form
    {
        public Supplier CurrentSupplier { get; set; }
        private IGenericService<Supplier> _supplierService;

        public SupplierEditor(IGenericService<Supplier> supplierService)
        {
            InitializeComponent();
            _supplierService = supplierService;
        }

        protected override void OnShown(EventArgs e)
        {
            if (CurrentSupplier != null)
            {
                nameBox.Text = CurrentSupplier.Name;
                addressBox.Text = CurrentSupplier.Address;
                emailBox.Text = CurrentSupplier.Email;
                phoneNumberBox.Text = CurrentSupplier.PhoneNumber;
            }
            else
            {
                deleteButton.Visible = false;
            }

            base.OnShown(e);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var newSupplier = new Supplier
            {
                Name = nameBox.Text,
                Address = addressBox.Text,
                Email = emailBox.Text,
                PhoneNumber = phoneNumberBox.Text
            };

            if (CurrentSupplier == null)
            {
                _supplierService.Create(newSupplier);
            }
            else
            {
                _supplierService.Update(CurrentSupplier.Id, newSupplier);
            }

            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            _supplierService.Delete(CurrentSupplier.Id);

            Close();
        }
    }
}
