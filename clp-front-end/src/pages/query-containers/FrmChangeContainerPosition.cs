using clp_front_end.src.controllers;
using clp_front_end.src.models;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace clp_front_end.src.pages.query_containers
{
    public partial class FrmChangeContainerPosition: Form
    {
        private readonly int containerId;
        private readonly FrmConsultaContainer FrmConsultaContainerInstance;
        public FrmChangeContainerPosition(int containerId, FrmConsultaContainer frmConsultaContainerInstance)
        {
            InitializeComponent();
            this.containerId = containerId;
            this.FrmConsultaContainerInstance = frmConsultaContainerInstance;
            selectLocation.DisplayMember = "DisplayText";
            selectLocation.ValueMember = "id";
            
        }
        private async void LoadData()
        {
            LocationsControllerModel.Get[] locations = await LocationsController.Get();            

            selectLocation.DataSource = locations;
            selectLocation.SelectedIndex = -1;            
        }
        private void FrmChangeContainerPosition_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private async void buttonConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                var payload = new MovementsControllerModel.ChangePosition
                {
                    containerId = this.containerId,
                    toLocationId = selectLocation.Text != "" ? (int?)selectLocation.SelectedValue : null
                };                

                await MovementsController.ChangePosition(payload);
                FrmConsultaContainerInstance.LoadData();
                Close();
                Dispose();
            }
            catch (Exception ex)
            {                
                MessageBox.Show($"Falha ao enviar requisição: {ex.Message}!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
