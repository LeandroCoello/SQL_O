﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Sistema;

namespace FrbaHotel.Login
{
    public partial class EleccionHotel : Form
    {
        UsuarioLogueado userLog;
        string rolSeleccionado;
        public EleccionHotel(string selected,UsuarioLogueado usuario)
        {
            InitializeComponent();
            rolSeleccionado = selected;
            userLog = usuario;
            foreach(var hotelId in userLog.conseguirHotelesId())
            {
                cBHoteles.Items.Add(hotelId);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cBHoteles.SelectedIndex == -1) { MessageBox.Show("Por favor elija un hotel"); }
            else {
                userLog.setHotelAsignado(cBHoteles.SelectedText);
                Menu_Principal.CargaMenu cargarMenu = new FrbaHotel.Menu_Principal.CargaMenu(rolSeleccionado,userLog);
                this.Close();
            }
        }

    }
}
