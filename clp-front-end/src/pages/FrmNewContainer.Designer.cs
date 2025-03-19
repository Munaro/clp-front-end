namespace clp_front_end.src.pages
{
    partial class FrmNewContainer
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
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.txtReceivedDate = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.labelOrigin = new System.Windows.Forms.Label();
            this.labelReceivedDate = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.selectStatus = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panelActions.Location = new System.Drawing.Point(0, 231);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(354, 44);
            this.panelActions.TabIndex = 0;
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
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(12, 25);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(330, 20);
            this.txtOrigin.TabIndex = 1;
            // 
            // txtReceivedDate
            // 
            this.txtReceivedDate.Location = new System.Drawing.Point(12, 64);
            this.txtReceivedDate.Name = "txtReceivedDate";
            this.txtReceivedDate.Size = new System.Drawing.Size(330, 20);
            this.txtReceivedDate.TabIndex = 2;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(12, 103);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(330, 20);
            this.txtWeight.TabIndex = 3;
            // 
            // labelOrigin
            // 
            this.labelOrigin.Location = new System.Drawing.Point(12, 9);
            this.labelOrigin.Name = "labelOrigin";
            this.labelOrigin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelOrigin.Size = new System.Drawing.Size(330, 13);
            this.labelOrigin.TabIndex = 6;
            this.labelOrigin.Text = "Origem";
            this.labelOrigin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelReceivedDate
            // 
            this.labelReceivedDate.Location = new System.Drawing.Point(12, 48);
            this.labelReceivedDate.Name = "labelReceivedDate";
            this.labelReceivedDate.Size = new System.Drawing.Size(330, 13);
            this.labelReceivedDate.TabIndex = 7;
            this.labelReceivedDate.Text = "Data";
            this.labelReceivedDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelWeight
            // 
            this.labelWeight.Location = new System.Drawing.Point(12, 87);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(330, 13);
            this.labelWeight.TabIndex = 8;
            this.labelWeight.Text = "Peso";
            this.labelWeight.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // selectStatus
            // 
            this.selectStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectStatus.FormattingEnabled = true;
            this.selectStatus.Location = new System.Drawing.Point(12, 148);
            this.selectStatus.Name = "selectStatus";
            this.selectStatus.Size = new System.Drawing.Size(330, 21);
            this.selectStatus.TabIndex = 9;
            // 
            // labelStatus
            // 
            this.labelStatus.Location = new System.Drawing.Point(12, 132);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(330, 13);
            this.labelStatus.TabIndex = 10;
            this.labelStatus.Text = "Status";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Status";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelLocation
            // 
            this.labelLocation.Location = new System.Drawing.Point(12, 172);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(330, 13);
            this.labelLocation.TabIndex = 13;
            this.labelLocation.Text = "Localização";
            this.labelLocation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // selectLocation
            // 
            this.selectLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectLocation.FormattingEnabled = true;
            this.selectLocation.Location = new System.Drawing.Point(12, 189);
            this.selectLocation.Name = "selectLocation";
            this.selectLocation.Size = new System.Drawing.Size(330, 21);
            this.selectLocation.TabIndex = 12;
            // 
            // FrmNewContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(354, 275);
            this.ControlBox = false;
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.selectLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.selectStatus);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelReceivedDate);
            this.Controls.Add(this.labelOrigin);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtReceivedDate);
            this.Controls.Add(this.txtOrigin);
            this.Controls.Add(this.panelActions);
            this.Name = "FrmNewContainer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Container";
            this.Load += new System.EventHandler(this.FrmNewContainer_Load);
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.TextBox txtReceivedDate;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label labelOrigin;
        private System.Windows.Forms.Label labelReceivedDate;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.ComboBox selectStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.ComboBox selectLocation;
    }
}