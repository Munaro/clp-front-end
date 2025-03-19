namespace clp_front_end.src.pages.query_containers
{
    partial class FrmChangeContainerStatus
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
            this.label1 = new System.Windows.Forms.Label();
            this.selectStatus = new System.Windows.Forms.ComboBox();
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
            this.panelActions.TabIndex = 2;
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Status";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // selectStatus
            // 
            this.selectStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectStatus.FormattingEnabled = true;
            this.selectStatus.Location = new System.Drawing.Point(12, 26);
            this.selectStatus.Name = "selectStatus";
            this.selectStatus.Size = new System.Drawing.Size(330, 21);
            this.selectStatus.TabIndex = 12;
            // 
            // FrmChangeContainerStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 107);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectStatus);
            this.Controls.Add(this.panelActions);
            this.Name = "FrmChangeContainerStatus";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Container | Alterar Status";
            this.Load += new System.EventHandler(this.FrmChangeContainerStatus_Load);
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectStatus;
    }
}