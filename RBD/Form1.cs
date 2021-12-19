using Microsoft.EntityFrameworkCore;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBD
{
    public partial class Form1 : Form
    {
        private readonly DbContext dbContext;
        private readonly IGenericService<Material> _materialService;
        private readonly IServiceProvider _serviceProvider;
        public Form1(DbContext context, IGenericService<Material> materialService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            dbContext = context;

            dbContext.Database.EnsureCreated();
            
            _materialService = materialService;
            _serviceProvider = serviceProvider;
            
            materialsView.DataSource = materialService.GetItems().ToList();
        }

        private void addNewMaterial_Click(object sender, EventArgs e)
        {
            var materialForm = _serviceProvider.GetRequiredService<MaterialEditor>();
            materialForm.Show();
        }

        private void materialsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            var currentValue = int.Parse(materialsView[0, e.RowIndex].Value.ToString());

            
            var materialForm = _serviceProvider.GetRequiredService<MaterialEditor>();
            materialForm.CurrentMaterial = _materialService.GetItem(currentValue);
            materialForm.Show();
        }

        private void warehouseButton_Click(object sender, EventArgs e)
        {
            var warehouseForm = _serviceProvider.GetRequiredService<WarehouseList>();
            warehouseForm.Show();
        }

        private void supplierButton_Click(object sender, EventArgs e)
        {
            var supplierForm = _serviceProvider.GetRequiredService<SupplierList>();
            supplierForm.Show();
        }

        private void typesButton_Click(object sender, EventArgs e)
        {
            var typeForm = _serviceProvider.GetRequiredService<TypesList>();
            typeForm.Show();
        }
    }
}
