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
    public partial class TypesEditor : Form
    {
        public Types CurrentType { get; set; }
        private readonly IGenericService<Types> _typesService;

        public TypesEditor(IGenericService<Types> typesService)
        {
            InitializeComponent();

            _typesService = typesService;
        }

        protected override void OnShown(EventArgs e)
        {
            if (CurrentType != null)
            {
                nameBox.Text = CurrentType.Name;
                descriptionBox.Text = CurrentType.Description;
            }
            else
            {
                deleteButton.Visible = false;
            }

            base.OnShown(e);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var newType = new Types
            {
                Description = descriptionBox.Text,
                Name = nameBox.Text
            };

            if (CurrentType == null)
            {
                _typesService.Create(newType);
            }
            else
            {
                _typesService.Update(CurrentType.Id, newType);
            }

            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            _typesService.Delete(CurrentType.Id);

            Close();
        }
    }
}
