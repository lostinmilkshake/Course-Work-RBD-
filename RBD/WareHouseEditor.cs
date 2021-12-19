using RBD.BusinesLogic;
using RBD.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RBD
{
    public partial class WarehouseEditor : Form
    {
        public Warehouse CurrentWarehouse { get; set; }
        private IGenericService<Warehouse> _warehouseService;
        private IGenericService<Supplier> _supplierService;
        private IGenericService<Material> _materialService;

        public WarehouseEditor(IGenericService<Warehouse> warehouseService, IGenericService<Supplier> supplierService, IGenericService<Material> materialService)
        {
            InitializeComponent();

            _warehouseService = warehouseService;
            _supplierService = supplierService;
            _materialService = materialService;
        }

        protected override void OnShown(EventArgs e)
        {
            matterialBox.DataSource = _materialService.GetItems().ToList();
            matterialBox.DisplayMember = "Name";

            supplierBox.DataSource = _supplierService.GetItems().ToList();
            supplierBox.DisplayMember = "Name";

            if (CurrentWarehouse != null)
            {
                ammountBox.Text = CurrentWarehouse.Ammount.ToString();
                isAvailableBox.Checked = CurrentWarehouse.IsAvailable;
            }
            else
            {
                deleteButton.Visible = false;
            }

            base.OnShown(e);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var selectedMaterial = matterialBox.SelectedItem as Material;
            var selectedSupplier = supplierBox.SelectedItem as Supplier;

            var newWarehouse = new Warehouse
            {
                Ammount = int.Parse(ammountBox.Text),
                IsAvailable = isAvailableBox.Checked,
                SupplierId = selectedSupplier.Id,
                MaterialId = selectedMaterial.Id
            };

            if (CurrentWarehouse == null)
            {
                _warehouseService.Create(newWarehouse);
            }
            else
            {
                _warehouseService.Update(CurrentWarehouse.Id, newWarehouse);
            }

            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            _warehouseService.Delete(CurrentWarehouse.Id);

            Close();
        }
    }
}
