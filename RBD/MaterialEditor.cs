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
    public partial class MaterialEditor : Form
    {
        private readonly IGenericService<Material> _materialSerice;
        private readonly IGenericService<Types> _typesService;
        private readonly IGenericService<MaterialCharacteristic> _materialCharacteristicService;

        public Material CurrentMaterial { get; set; }
        public MaterialCharacteristic CurrentMaterialCharacteristic { get; set; }

        public MaterialEditor(IGenericService<Material> materialSerice, IGenericService<MaterialCharacteristic> materialCharacteristicService, IGenericService<Types> typesService)
        {
            InitializeComponent();
            _materialSerice = materialSerice;
            _materialCharacteristicService = materialCharacteristicService;
            _typesService = typesService;

            typesBox.DataSource = _typesService.GetItems().ToList();
            typesBox.DisplayMember = "Name";
        }

        protected override void OnShown(EventArgs e)
        {
            if (CurrentMaterial != null)
            {
                nameBox.Text = CurrentMaterial.Name;
                descriptionBox.Text = CurrentMaterial.Description;
                CurrentMaterialCharacteristic = _materialCharacteristicService.GetItems(mc => mc.MaterialId == CurrentMaterial.Id).FirstOrDefault();
                strengthBox.Text = CurrentMaterialCharacteristic.Strength.ToString();
                densityBox.Text = CurrentMaterialCharacteristic.Density.ToString();
                porosityBox.Text = CurrentMaterialCharacteristic.Porosity.ToString();
                fireResistanceBox.Text = CurrentMaterialCharacteristic.FireReistance.ToString();
                waterResistanceBox.Text = CurrentMaterialCharacteristic.WaterReistance.ToString();
            }
            else
            {
                deleteButton.Visible = false;
            }

            base.OnShown(e);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var selectedType = typesBox.SelectedItem as Types;

            var newMaterial = new Material
            {
                Name = nameBox.Text,
                Description = descriptionBox.Text,
                MaterialTypeId = selectedType.Id,
            };

            var newMaterialCharacteristic = new MaterialCharacteristic
            {
                Strength = float.Parse(strengthBox.Text),
                Density = float.Parse(densityBox.Text),
                Porosity = float.Parse(porosityBox.Text),
                FireReistance = int.Parse(fireResistanceBox.Text),
                WaterReistance = int.Parse(waterResistanceBox.Text),
            };
            
            if (CurrentMaterial == null)
            {
                newMaterialCharacteristic.Material = newMaterial;
                _materialSerice.Create(newMaterial);
                _materialCharacteristicService.Create(newMaterialCharacteristic);
            }
            else
            {
                newMaterialCharacteristic.MaterialId = CurrentMaterial.Id;
                _materialSerice.Update(CurrentMaterial.Id, newMaterial);
                _materialCharacteristicService.Update(CurrentMaterialCharacteristic.Id, newMaterialCharacteristic);
            }

            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            _materialCharacteristicService.Delete(CurrentMaterialCharacteristic.Id);
            _materialSerice.Delete(CurrentMaterial.Id);
            
            Close();
        }
    }
}
