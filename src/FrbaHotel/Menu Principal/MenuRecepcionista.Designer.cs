﻿namespace FrbaHotel.Menu_Principal
{
    partial class MenuRecepcionista
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
            this.btnGENRESER = new System.Windows.Forms.Button();
            this.btnCancelReser = new System.Windows.Forms.Button();
            this.btnRegEst = new System.Windows.Forms.Button();
            this.btnRegConsu = new System.Windows.Forms.Button();
            this.btnFacPub = new System.Windows.Forms.Button();
            this.btnListEsta = new System.Windows.Forms.Button();
            this.btnABMCliente = new System.Windows.Forms.Button();
            this.btnModReser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGENRESER
            // 
            this.btnGENRESER.Enabled = false;
            this.btnGENRESER.Location = new System.Drawing.Point(12, 12);
            this.btnGENRESER.Name = "btnGENRESER";
            this.btnGENRESER.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGENRESER.Size = new System.Drawing.Size(109, 51);
            this.btnGENRESER.TabIndex = 0;
            this.btnGENRESER.Text = "Generar reserva";
            this.btnGENRESER.UseVisualStyleBackColor = true;
            this.btnGENRESER.Click += new System.EventHandler(this.btnGENRESER_Click);
            // 
            // btnCancelReser
            // 
            this.btnCancelReser.Enabled = false;
            this.btnCancelReser.Location = new System.Drawing.Point(127, 12);
            this.btnCancelReser.Name = "btnCancelReser";
            this.btnCancelReser.Size = new System.Drawing.Size(109, 51);
            this.btnCancelReser.TabIndex = 1;
            this.btnCancelReser.Text = "Cancelar Reserva";
            this.btnCancelReser.UseVisualStyleBackColor = true;
            this.btnCancelReser.Click += new System.EventHandler(this.btnCancelReser_Click);
            // 
            // btnRegEst
            // 
            this.btnRegEst.Location = new System.Drawing.Point(242, 13);
            this.btnRegEst.Name = "btnRegEst";
            this.btnRegEst.Size = new System.Drawing.Size(109, 50);
            this.btnRegEst.TabIndex = 2;
            this.btnRegEst.Text = "Registrar Estadia";
            this.btnRegEst.UseVisualStyleBackColor = true;
            this.btnRegEst.Click += new System.EventHandler(this.btnRegEst_Click);
            // 
            // btnRegConsu
            // 
            this.btnRegConsu.Enabled = false;
            this.btnRegConsu.Location = new System.Drawing.Point(12, 126);
            this.btnRegConsu.Name = "btnRegConsu";
            this.btnRegConsu.Size = new System.Drawing.Size(109, 51);
            this.btnRegConsu.TabIndex = 3;
            this.btnRegConsu.Text = "Registrar Consumibles";
            this.btnRegConsu.UseVisualStyleBackColor = true;
            this.btnRegConsu.Click += new System.EventHandler(this.btnRegConsu_Click);
            // 
            // btnFacPub
            // 
            this.btnFacPub.Enabled = false;
            this.btnFacPub.Location = new System.Drawing.Point(127, 69);
            this.btnFacPub.Name = "btnFacPub";
            this.btnFacPub.Size = new System.Drawing.Size(109, 51);
            this.btnFacPub.TabIndex = 4;
            this.btnFacPub.Text = "Emitir Factura";
            this.btnFacPub.UseVisualStyleBackColor = true;
            this.btnFacPub.Click += new System.EventHandler(this.btnFacPub_Click);
            // 
            // btnListEsta
            // 
            this.btnListEsta.Location = new System.Drawing.Point(242, 69);
            this.btnListEsta.Name = "btnListEsta";
            this.btnListEsta.Size = new System.Drawing.Size(109, 51);
            this.btnListEsta.TabIndex = 5;
            this.btnListEsta.Text = "Listado Estadistico";
            this.btnListEsta.UseVisualStyleBackColor = true;
            this.btnListEsta.Click += new System.EventHandler(this.btnListEsta_Click);
            // 
            // btnABMCliente
            // 
            this.btnABMCliente.Location = new System.Drawing.Point(127, 126);
            this.btnABMCliente.Name = "btnABMCliente";
            this.btnABMCliente.Size = new System.Drawing.Size(109, 51);
            this.btnABMCliente.TabIndex = 6;
            this.btnABMCliente.Text = "ABM Cliente";
            this.btnABMCliente.UseVisualStyleBackColor = true;
            this.btnABMCliente.Click += new System.EventHandler(this.btnABMCliente_Click);
            // 
            // btnModReser
            // 
            this.btnModReser.Enabled = false;
            this.btnModReser.Location = new System.Drawing.Point(12, 69);
            this.btnModReser.Name = "btnModReser";
            this.btnModReser.Size = new System.Drawing.Size(109, 51);
            this.btnModReser.TabIndex = 7;
            this.btnModReser.Text = "Modificar Reserva";
            this.btnModReser.UseVisualStyleBackColor = true;
            this.btnModReser.Click += new System.EventHandler(this.btnModReser_Click);
            // 
            // MenuRecepcionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 196);
            this.Controls.Add(this.btnModReser);
            this.Controls.Add(this.btnABMCliente);
            this.Controls.Add(this.btnListEsta);
            this.Controls.Add(this.btnFacPub);
            this.Controls.Add(this.btnRegConsu);
            this.Controls.Add(this.btnRegEst);
            this.Controls.Add(this.btnCancelReser);
            this.Controls.Add(this.btnGENRESER);
            this.Name = "MenuRecepcionista";
            this.Text = "Recepcionista";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGENRESER;
        private System.Windows.Forms.Button btnCancelReser;
        private System.Windows.Forms.Button btnRegEst;
        private System.Windows.Forms.Button btnRegConsu;
        private System.Windows.Forms.Button btnFacPub;
        private System.Windows.Forms.Button btnListEsta;
        private System.Windows.Forms.Button btnABMCliente;
        private System.Windows.Forms.Button btnModReser;
    }
}