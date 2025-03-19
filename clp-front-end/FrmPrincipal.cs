using clp_front_end.src.clients;
using clp_front_end.src.models;
using clp_front_end.src.pages;
using clp_front_end.src.utils;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clp_front_end
{
    public partial class FrmPrincipal : Form
    {
        public WebSocketClient wsClient;
        private bool ClpEmulatorIsRunning = false;
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void buttonStartClpEmulator_Click(object sender, EventArgs e)
        {
            ClpEmulatorIsRunning = true;
            labelClpEmulatorStatusConexaoValue.Text = "Ativa";
            buttonEndClpEmulator.Enabled = true;
            buttonStartClpEmulator.Enabled = false;
            ClpEmulator.RunWorkerAsync();
            
        }
        private async void buttonEndClpEmulator_Click(object sender, EventArgs e)
        {
            ClpEmulator.CancelAsync();
            ClpEmulatorIsRunning = false;
            labelClpEmulatorStatusConexaoValue.Text = "Inativa";
            buttonEndClpEmulator.Enabled = false;
            buttonStartClpEmulator.Enabled = true;
            
            while (ClpEmulator.IsBusy)
            {
                await Task.Delay(100);
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.buttonEndClpEmulator.Enabled = false;
        }

        private async void ClpEmulator_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (ClpEmulator.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            wsClient = new WebSocketClient();

            wsClient.OnMessageReceived += async (message) =>
            {
                try
                {
                    var response = JsonConvert.DeserializeObject<WebSocketResponse<dynamic>>(message);
                    switch (response.Event)
                    {
                        case "clpEmulator":
                            ClpEmulatorEventModel.Get clpEmulatorData = JsonConvert.DeserializeObject<ClpEmulatorEventModel.Get>(response.Data.ToString());
                            this.Invoke((MethodInvoker)delegate
                            {
                                FrmNewContainer newContainerForm = new FrmNewContainer(clpEmulatorData.origin, clpEmulatorData.receivedDate, clpEmulatorData.weight);
                                newContainerForm.ShowDialog();
                            });
                            break;
                    }
                }
                catch (Exception ex)
                {
                    ServiceLogger.Log($"Erro ao processar mensagem: {ex.Message}", EventLogEntryType.Error);
                }
            };

            while (!ClpEmulator.CancellationPending)
            {
                await Task.Delay(100);
            }
            
            if (wsClient != null)
            {
                await wsClient.CloseConnection();
                wsClient = null;
            }
        }
    }
}
