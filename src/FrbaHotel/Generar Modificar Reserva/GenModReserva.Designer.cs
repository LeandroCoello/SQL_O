﻿namespace FrbaHotel.Generar_Modificar_Reserva
{
    partial class GenModReserva
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFecSist = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFecIng = new System.Windows.Forms.TextBox();
            this.txtFecEgr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Sistema";
            // 
            // txtFecSist
            // 
            this.txtFecSist.Enabled = false;
            this.txtFecSist.Location = new System.Drawing.Point(93, 31);
            this.txtFecSist.Name = "txtFecSist";
            this.txtFecSist.Size = new System.Drawing.Size(74, 20);
            this.txtFecSist.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Ingreso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Egreso:";
            // 
            // txtFecIng
            // 
            this.txtFecIng.Location = new System.Drawing.Point(95, 77);
            this.txtFecIng.Name = "txtFecIng";
            this.txtFecIng.Size = new System.Drawing.Size(100, 20);
            this.txtFecIng.TabIndex = 4;
            // 
            // txtFecEgr
            // 
            this.txtFecEgr.Location = new System.Drawing.Point(95, 104);
            this.txtFecEgr.Name = "txtFecEgr";
            this.txtFecEgr.Size = new System.Drawing.Size(100, 20);
            this.txtFecEgr.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ingrese las fechas en formato DD/MM/AAAA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tipo Habitación:";
            // 
            // GenModReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFecEgr);
            this.Controls.Add(this.txtFecIng);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFecSist);
            this.Controls.Add(this.label1);
            this.Name = "GenModReserva";
            this.Text = "Generar Modificar Reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFecSist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFecIng;
        private System.Windows.Forms.TextBox txtFecEgr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}