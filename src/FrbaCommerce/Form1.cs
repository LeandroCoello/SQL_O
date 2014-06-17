﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Login;
using FrbaCommerce.Registro_de_Usuario;


namespace FrbaCommerce
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrbaCommerce.Login.Form1 logearse = new FrbaCommerce.Login.Form1();
            this.Hide();
            logearse.ShowDialog();
            this.Show();
            
        }

        private void btnRegistracion_Click(object sender, EventArgs e)
        {
            FrbaCommerce.Registro_de_Usuario.Form1 registracion = new FrbaCommerce.Registro_de_Usuario.Form1();
            this.Hide();
            registracion.ShowDialog();
            this.Show();
            
        }
    }

}