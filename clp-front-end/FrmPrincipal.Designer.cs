namespace clp_front_end
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxClpEmulator = new System.Windows.Forms.GroupBox();
            this.labelClpEmulatorStatusConexaoValue = new System.Windows.Forms.Label();
            this.buttonStartClpEmulator = new System.Windows.Forms.Button();
            this.labelClpEmulatorStatusConexao = new System.Windows.Forms.Label();
            this.buttonEndClpEmulator = new System.Windows.Forms.Button();
            this.backgroundImage = new System.Windows.Forms.PictureBox();
            this.ClpEmulator = new System.ComponentModel.BackgroundWorker();
            this.groupBoxClpEmulator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxClpEmulator
            // 
            this.groupBoxClpEmulator.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxClpEmulator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBoxClpEmulator.Controls.Add(this.labelClpEmulatorStatusConexaoValue);
            this.groupBoxClpEmulator.Controls.Add(this.buttonStartClpEmulator);
            this.groupBoxClpEmulator.Controls.Add(this.labelClpEmulatorStatusConexao);
            this.groupBoxClpEmulator.Controls.Add(this.buttonEndClpEmulator);
            this.groupBoxClpEmulator.ForeColor = System.Drawing.Color.Black;
            this.groupBoxClpEmulator.Location = new System.Drawing.Point(12, 12);
            this.groupBoxClpEmulator.Name = "groupBoxClpEmulator";
            this.groupBoxClpEmulator.Size = new System.Drawing.Size(246, 85);
            this.groupBoxClpEmulator.TabIndex = 1;
            this.groupBoxClpEmulator.TabStop = false;
            this.groupBoxClpEmulator.Text = "Emulador de CLP";
            // 
            // labelClpEmulatorStatusConexaoValue
            // 
            this.labelClpEmulatorStatusConexaoValue.AutoSize = true;
            this.labelClpEmulatorStatusConexaoValue.Location = new System.Drawing.Point(169, 29);
            this.labelClpEmulatorStatusConexaoValue.Name = "labelClpEmulatorStatusConexaoValue";
            this.labelClpEmulatorStatusConexaoValue.Size = new System.Drawing.Size(39, 13);
            this.labelClpEmulatorStatusConexaoValue.TabIndex = 5;
            this.labelClpEmulatorStatusConexaoValue.Text = "Inativa";
            // 
            // buttonStartClpEmulator
            // 
            this.buttonStartClpEmulator.Image = global::clp_front_end.Properties.Resources.check_confirm_16x16;
            this.buttonStartClpEmulator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStartClpEmulator.Location = new System.Drawing.Point(6, 19);
            this.buttonStartClpEmulator.Name = "buttonStartClpEmulator";
            this.buttonStartClpEmulator.Size = new System.Drawing.Size(75, 23);
            this.buttonStartClpEmulator.TabIndex = 2;
            this.buttonStartClpEmulator.Text = "Iniciar";
            this.buttonStartClpEmulator.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStartClpEmulator.UseVisualStyleBackColor = true;
            this.buttonStartClpEmulator.Click += new System.EventHandler(this.buttonStartClpEmulator_Click);
            // 
            // labelClpEmulatorStatusConexao
            // 
            this.labelClpEmulatorStatusConexao.AutoSize = true;
            this.labelClpEmulatorStatusConexao.Location = new System.Drawing.Point(143, 16);
            this.labelClpEmulatorStatusConexao.Name = "labelClpEmulatorStatusConexao";
            this.labelClpEmulatorStatusConexao.Size = new System.Drawing.Size(97, 13);
            this.labelClpEmulatorStatusConexao.TabIndex = 4;
            this.labelClpEmulatorStatusConexao.Text = "Status da Conexão";
            // 
            // buttonEndClpEmulator
            // 
            this.buttonEndClpEmulator.Image = global::clp_front_end.Properties.Resources.close_cancel_16x16;
            this.buttonEndClpEmulator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEndClpEmulator.Location = new System.Drawing.Point(6, 48);
            this.buttonEndClpEmulator.Name = "buttonEndClpEmulator";
            this.buttonEndClpEmulator.Size = new System.Drawing.Size(75, 23);
            this.buttonEndClpEmulator.TabIndex = 1;
            this.buttonEndClpEmulator.Text = "Encerrar";
            this.buttonEndClpEmulator.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEndClpEmulator.UseVisualStyleBackColor = true;
            this.buttonEndClpEmulator.Click += new System.EventHandler(this.buttonEndClpEmulator_Click);
            // 
            // backgroundImage
            // 
            this.backgroundImage.Image = global::clp_front_end.Properties.Resources.vrc_opacity_20;
            this.backgroundImage.Location = new System.Drawing.Point(88, 103);
            this.backgroundImage.Name = "backgroundImage";
            this.backgroundImage.Size = new System.Drawing.Size(711, 257);
            this.backgroundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backgroundImage.TabIndex = 2;
            this.backgroundImage.TabStop = false;
            // 
            // ClpEmulator
            // 
            this.ClpEmulator.WorkerSupportsCancellation = true;
            this.ClpEmulator.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ClpEmulator_DoWork);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.groupBoxClpEmulator);
            this.Controls.Add(this.backgroundImage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLP FRONT-END";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.groupBoxClpEmulator.ResumeLayout(false);
            this.groupBoxClpEmulator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonEndClpEmulator;
        private System.Windows.Forms.Button buttonStartClpEmulator;
        private System.Windows.Forms.Label labelClpEmulatorStatusConexao;
        private System.Windows.Forms.Label labelClpEmulatorStatusConexaoValue;
        private System.Windows.Forms.GroupBox groupBoxClpEmulator;
        private System.Windows.Forms.PictureBox backgroundImage;
        private System.ComponentModel.BackgroundWorker ClpEmulator;
    }
}

