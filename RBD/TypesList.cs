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
    public partial class TypesList : Form
    {
        private readonly IGenericService<Types> _typeService;
        private readonly IServiceProvider _serviceProvider;

        public TypesList(IGenericService<Types> typeService, IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _typeService = typeService;
            _serviceProvider = serviceProvider;

            typesView.DataSource = _typeService.GetItems().ToList();
        }

        private void addNewType_Click(object sender, EventArgs e)
        {
            var typeForm = _serviceProvider.GetRequiredService<TypesEditor>();
            typeForm.Show();
        }

        private void typesView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            var currentValue = int.Parse(typesView[0, e.RowIndex].Value.ToString());


            var typeForm = _serviceProvider.GetRequiredService<TypesEditor>();
            typeForm.CurrentType = _typeService.GetItem(currentValue);
            typeForm.Show();
        }
    }
}
