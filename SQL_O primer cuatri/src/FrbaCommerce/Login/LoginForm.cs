﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Registro_de_Usuario;
using FrbaCommerce.Sistema;


namespace FrbaCommerce.Login
{
    public partial class LoginForm : Form
    {
        string passHasheada;
        int contadorDeIntentos = 0;
        private Inicio inicio;
        private UsuarioLogueado userLog;
        private List<string> roles = new List<string>();
        public LoginForm(SQLConnector connection)
        {
            InitializeComponent();
            inicio = new Inicio(connection);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtContraseña.Text == "")
            {
                MessageBox.Show("Por favor complete los campos de usuario y contraseña");
                return;
            }


            if (contadorDeIntentos < 3)
            {
                try
                {
                   userLog =  inicio.login(txtUsuario.Text, txtContraseña.Text);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
               roles = userLog.conseguirRoles();
                     if (roles.Count() > 1)
                         {
                           Form2EleccionRol levantarEleccionRol = new Form2EleccionRol(roles);
                         }
                     else {
                           Menu_Principal.Form1MenuPrincipal levantarMenu = new FrbaCommerce.Menu_Principal.Form1MenuPrincipal(roles.First());
                      }
            }
            else
            {
                MessageBox.Show("Se ha alcanazo el maximo de intentos de login, usuario inhabilitado");
                btnAceptar.Enabled = false;
            }
        }
    }
}
