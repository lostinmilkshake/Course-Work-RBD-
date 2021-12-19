using Microsoft.Extensions.DependencyInjection;
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
    public partial class SupplierList : Form
    {
        private readonly IGenericService<Supplier> _supplierService;
        private readonly IServiceProvider _serviceProvider;

        public SupplierList(IGenericService<Supplier> supplierService, IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _supplierService = supplierService;
            _serviceProvider = serviceProvider;

            suppliersView.DataSource = _supplierService.GetItems().ToList();
        }

        private void addNewSupplier_Click(object sender, EventArgs e)
        {
            var supplierForm = _serviceProvider.GetRequiredService<SupplierEditor>();
            supplierForm.Show();
        }

        private void suppliersView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            var currentValue = int.Parse(suppliersView[0, e.RowIndex].Value.ToString());


            var supplierForm = _serviceProvider.GetRequiredService<SupplierEditor>();
            supplierForm.CurrentSupplier = _supplierService.GetItem(currentValue);
            supplierForm.Show();
        }
    }
}
