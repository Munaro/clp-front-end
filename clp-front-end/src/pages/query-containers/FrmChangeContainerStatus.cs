using clp_front_end.src.controllers;
using clp_front_end.src.models;
using System;
using System.Windows.Forms;

namespace clp_front_end.src.pages.query_containers
{
    public partial class FrmChangeContainerStatus : Form
    {
        private readonly int containerId;
        private readonly FrmConsultaContainer FrmConsultaContainerInstance;
        public FrmChangeContainerStatus(int containerId, FrmConsultaContainer frmConsultaContainerInstance)
        {
            InitializeComponent();
            this.containerId = containerId;
            this.FrmConsultaContainerInstance = frmConsultaContainerInstance;
            selectStatus.DisplayMember = "description";
            selectStatus.ValueMember = "id";
        }

        private async void LoadData()
        {
            ContainersControllerModel.GetData ContainerData = await ContainersController.GetData();

            selectStatus.DataSource = ContainerData.status;
            selectStatus.SelectedIndex = -1;
        }

        private void FrmChangeContainerStatus_Load(object sender, EventArgs e)
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
            if (selectStatus.Text == "")
            {
                MessageBox.Show("Informe o status", "Formulário Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var payload = new ContainersControllerModel.Update
                {
                    containerId = this.containerId,                    
                    statusId = (int)selectStatus.SelectedValue
                };

                await ContainersController.Update(payload);

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
