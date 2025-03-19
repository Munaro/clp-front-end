namespace clp_front_end.src.pages
{
    partial class FrmConsultaContainer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaContainer));
            this.panelActions = new System.Windows.Forms.Panel();
            this.buttonEditStatus = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonEditLocation = new System.Windows.Forms.Button();
            this.dataGridContainers = new System.Windows.Forms.DataGridView();
            this.internalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.containerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.containerWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storedZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storedStreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storedPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContainers)).BeginInit();
            this.SuspendLayout();
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.buttonEditStatus);
            this.panelActions.Controls.Add(this.buttonFechar);
            this.panelActions.Controls.Add(this.buttonEditLocation);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActions.Location = new System.Drawing.Point(0, 406);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(800, 44);
            this.panelActions.TabIndex = 0;
            // 
            // buttonEditStatus
            // 
            this.buttonEditStatus.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditStatus.Image")));
            this.buttonEditStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditStatus.Location = new System.Drawing.Point(687, 9);
            this.buttonEditStatus.Name = "buttonEditStatus";
            this.buttonEditStatus.Size = new System.Drawing.Size(101, 23);
            this.buttonEditStatus.TabIndex = 7;
            this.buttonEditStatus.Text = "Editar Status";
            this.buttonEditStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEditStatus.UseVisualStyleBackColor = true;
            this.buttonEditStatus.Click += new System.EventHandler(this.buttonEditStatus_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Image = global::clp_front_end.Properties.Resources.close_cancel_16x16;
            this.buttonFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFechar.Location = new System.Drawing.Point(473, 9);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(101, 23);
            this.buttonFechar.TabIndex = 6;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonEditLocation
            // 
            this.buttonEditLocation.Image = global::clp_front_end.Properties.Resources.location_16x16;
            this.buttonEditLocation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditLocation.Location = new System.Drawing.Point(580, 9);
            this.buttonEditLocation.Name = "buttonEditLocation";
            this.buttonEditLocation.Size = new System.Drawing.Size(101, 23);
            this.buttonEditLocation.TabIndex = 5;
            this.buttonEditLocation.Text = "Editar Posição";
            this.buttonEditLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEditLocation.UseVisualStyleBackColor = true;
            this.buttonEditLocation.Click += new System.EventHandler(this.buttonEditLocation_Click);
            // 
            // dataGridContainers
            // 
            this.dataGridContainers.AllowUserToAddRows = false;
            this.dataGridContainers.AllowUserToDeleteRows = false;
            this.dataGridContainers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridContainers.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridContainers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridContainers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.internalId,
            this.containerId,
            this.receivedDate,
            this.containerWeight,
            this.status,
            this.storedZone,
            this.storedStreet,
            this.storedColumn,
            this.storedPosition});
            this.dataGridContainers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridContainers.GridColor = System.Drawing.Color.Snow;
            this.dataGridContainers.Location = new System.Drawing.Point(0, 0);
            this.dataGridContainers.Name = "dataGridContainers";
            this.dataGridContainers.ReadOnly = true;
            this.dataGridContainers.Size = new System.Drawing.Size(800, 406);
            this.dataGridContainers.TabIndex = 1;
            // 
            // internalId
            // 
            this.internalId.DataPropertyName = "internalId";
            this.internalId.Frozen = true;
            this.internalId.HeaderText = "id";
            this.internalId.Name = "internalId";
            this.internalId.ReadOnly = true;
            this.internalId.Visible = false;
            // 
            // containerId
            // 
            this.containerId.DataPropertyName = "containerId";
            this.containerId.Frozen = true;
            this.containerId.HeaderText = "Identificador";
            this.containerId.Name = "containerId";
            this.containerId.ReadOnly = true;
            this.containerId.Width = 90;
            // 
            // receivedDate
            // 
            this.receivedDate.DataPropertyName = "receivedDate";
            this.receivedDate.Frozen = true;
            this.receivedDate.HeaderText = "Recebido Em";
            this.receivedDate.Name = "receivedDate";
            this.receivedDate.ReadOnly = true;
            this.receivedDate.Width = 96;
            // 
            // containerWeight
            // 
            this.containerWeight.DataPropertyName = "containerWeight";
            this.containerWeight.Frozen = true;
            this.containerWeight.HeaderText = "Peso";
            this.containerWeight.Name = "containerWeight";
            this.containerWeight.ReadOnly = true;
            this.containerWeight.Width = 56;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.Frozen = true;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 62;
            // 
            // storedZone
            // 
            this.storedZone.DataPropertyName = "storedZone";
            this.storedZone.Frozen = true;
            this.storedZone.HeaderText = "Zona";
            this.storedZone.Name = "storedZone";
            this.storedZone.ReadOnly = true;
            this.storedZone.Width = 57;
            // 
            // storedStreet
            // 
            this.storedStreet.DataPropertyName = "storedStreet";
            this.storedStreet.Frozen = true;
            this.storedStreet.HeaderText = "Rua";
            this.storedStreet.Name = "storedStreet";
            this.storedStreet.ReadOnly = true;
            this.storedStreet.Width = 52;
            // 
            // storedColumn
            // 
            this.storedColumn.DataPropertyName = "storedColumn";
            this.storedColumn.Frozen = true;
            this.storedColumn.HeaderText = "Coluna";
            this.storedColumn.Name = "storedColumn";
            this.storedColumn.ReadOnly = true;
            this.storedColumn.Width = 65;
            // 
            // storedPosition
            // 
            this.storedPosition.DataPropertyName = "storedPosition";
            this.storedPosition.Frozen = true;
            this.storedPosition.HeaderText = "Posição";
            this.storedPosition.Name = "storedPosition";
            this.storedPosition.ReadOnly = true;
            this.storedPosition.Width = 70;
            // 
            // FrmConsultaContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridContainers);
            this.Controls.Add(this.panelActions);
            this.Name = "FrmConsultaContainer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Containers";
            this.Load += new System.EventHandler(this.FrmConsultaContainer_Load);
            this.panelActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContainers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.DataGridView dataGridContainers;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonEditLocation;
        private System.Windows.Forms.Button buttonEditStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn internalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn containerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn containerWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn storedZone;
        private System.Windows.Forms.DataGridViewTextBoxColumn storedStreet;
        private System.Windows.Forms.DataGridViewTextBoxColumn storedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storedPosition;
    }
}