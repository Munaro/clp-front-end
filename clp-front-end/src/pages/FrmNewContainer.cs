using clp_front_end.src.controllers;
using clp_front_end.src.models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace clp_front_end.src.pages
{
    public partial class FrmNewContainer : Form
    {
        private LocationsControllerModel.Get[] AvailableLocations;
        private readonly string receivedDate;
        public FrmNewContainer(string origin, string receivedDate, float weight)
        {
            InitializeComponent();
            txtOrigin.Text = origin;
            txtOrigin.Enabled = false;

            txtReceivedDate.Text = DateTime.TryParse(receivedDate, out DateTime dt) ? dt.ToString("dd/MM/yyyy 'às' HH:mm:ss") : "Data inválida";
            txtReceivedDate.Enabled = false;
            this.receivedDate = receivedDate;

            txtWeight.Text = weight.ToString();
            txtWeight.Enabled = false;

            selectStatus.DisplayMember = "description";
            selectStatus.ValueMember = "id";

            selectLocation.DisplayMember = "DisplayText";
            selectLocation.ValueMember = "id";
        }

        private async void LoadData()
        {
            ContainersControllerModel.GetData ContainerData = await ContainersController.GetData();
            AvailableLocations = await LocationsController.Get(true);

            selectStatus.DataSource = ContainerData.status;
            selectStatus.SelectedIndex = -1;

            selectLocation.DataSource = AvailableLocations;
            selectLocation.SelectedIndex = -1;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void FrmNewContainer_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (selectStatus.Text == "")
            {
                MessageBox.Show("Informe o status", "Formulário Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectLocation.Text == "")
            {
                MessageBox.Show("Informe a localização", "Formulário Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedLocationId = (int)selectLocation.SelectedValue;

            LocationsControllerModel.Get selectedLocation = AvailableLocations.FirstOrDefault(loc => loc.id == selectedLocationId);

            if (!float.TryParse(txtWeight.Text, out float weight))
            {
                MessageBox.Show("Peso inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (weight > selectedLocation.maxCapacity)
            {
                MessageBox.Show($"O peso informado ({weight}) não corresponde ao da localização ({selectedLocation.maxCapacity})!",
                                "Peso Divergente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Guid uuid = Guid.NewGuid();
            string parsedUuid = uuid.ToString().Replace("-", "").ToUpper();
            var payload = new ContainersControllerModel.Create
            {
                origin = txtOrigin.Text,
                receivedDate = receivedDate,
                weight = weight,
                locationId = selectedLocationId,
                statusId = (int)selectStatus.SelectedValue,
                uuid = parsedUuid,
                uniqueIdentifier = receivedDate.Substring(0, 10).Replace("-", "") + "-" + txtOrigin.Text + "-" + parsedUuid
            };
            try
            {
                await ContainersController.Create(payload);
                this.Close();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao enviar requisição: {ex.Message}!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ;
        }
    }
}
