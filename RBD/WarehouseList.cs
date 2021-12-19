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
    public partial class WarehouseList : Form
    {
        private readonly IGenericService<Warehouse> _warehouseService;
        private readonly IServiceProvider _serviceProvider;

        public WarehouseList(IGenericService<Warehouse> warehouseService, IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _warehouseService = warehouseService;
            _serviceProvider = serviceProvider;

            warehousesView.DataSource = warehouseService.GetItems().ToList();
        }

        private void addNewWarehouse_Click(object sender, EventArgs e)
        {
            var warehouseForm = _serviceProvider.GetRequiredService<WarehouseEditor>();
            warehouseForm.Show();
        }

        private void warehousesView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            var currentValue = int.Parse(warehousesView[0, e.RowIndex].Value.ToString());


            var warehouseForm = _serviceProvider.GetRequiredService<WarehouseEditor>();
            warehouseForm.CurrentWarehouse = _warehouseService.GetItem(currentValue);
            warehouseForm.Show();
        }
    }
}
