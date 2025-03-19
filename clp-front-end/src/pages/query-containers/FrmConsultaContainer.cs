using clp_front_end.src.controllers;
using clp_front_end.src.models;
using clp_front_end.src.pages.query_containers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clp_front_end.src.pages
{
    public partial class FrmConsultaContainer: Form
    {
        public FrmConsultaContainer()
        {
            InitializeComponent();
        }

        public async void LoadData()
        {
            try
            {
                ContainersControllerModel.Get[] containers = await ContainersController.Get();

                dataGridContainers.DataSource = containers;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao enviar requisição: {ex.Message}!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmConsultaContainer_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void buttonEditStatus_Click(object sender, EventArgs e)
        {
            if (dataGridContainers.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridContainers.SelectedCells[0].RowIndex;
                int selectedContainerId = (int)dataGridContainers.Rows[rowIndex].Cells["internalId"].Value;

                new FrmChangeContainerStatus(selectedContainerId, this).ShowDialog();                
            }
            else
            {
                MessageBox.Show("Selecione um container primeiro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonEditLocation_Click(object sender, EventArgs e)
        {
            if (dataGridContainers.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridContainers.SelectedCells[0].RowIndex;
                int selectedContainerId = (int)dataGridContainers.Rows[rowIndex].Cells["internalId"].Value;

                new FrmChangeContainerPosition(selectedContainerId, this).ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um container primeiro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
