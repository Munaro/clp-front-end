namespace clp_front_end.src.pages.query_containers
{
    partial class FrmChangeContainerPosition
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
            this.panelActions = new System.Windows.Forms.Panel();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.labelLocation = new System.Windows.Forms.Label();
            this.selectLocation = new System.Windows.Forms.ComboBox();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.buttonCancelar);
            this.panelActions.Controls.Add(this.buttonConfirmar);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActions.Location = new System.Drawing.Point(0, 63);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(354, 44);
            this.panelActions.TabIndex = 1;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Image = global::clp_front_end.Properties.Resources.close_cancel_16x16;
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(186, 9);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Image = global::clp_front_end.Properties.Resources.check_confirm_16x16;
            this.buttonConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfirmar.Location = new System.Drawing.Point(267, 9);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmar.TabIndex = 3;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // labelLocation
            // 
            this.labelLocation.Location = new System.Drawing.Point(12, 9);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(330, 13);
            this.labelLocation.TabIndex = 15;
            this.labelLocation.Text = "Localização";
            this.labelLocation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // selectLocation
            // 
            this.selectLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectLocation.FormattingEnabled = true;
            this.selectLocation.Location = new System.Drawing.Point(12, 26);
            this.selectLocation.Name = "selectLocation";
            this.selectLocation.Size = new System.Drawing.Size(330, 21);
            this.selectLocation.TabIndex = 14;
            // 
            // FrmChangeContainerPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 107);
            this.ControlBox = false;
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.selectLocation);
            this.Controls.Add(this.panelActions);
            this.Name = "FrmChangeContainerPosition";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Container | Alterar Localização";
            this.Load += new System.EventHandler(this.FrmChangeContainerPosition_Load);
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.ComboBox selectLocation;
    }
}