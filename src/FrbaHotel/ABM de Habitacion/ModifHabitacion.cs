﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Sistema;

namespace FrbaHotel.ABM_de_Habitacion
{
    public partial class ModifHabitacion : Form
    {
        SQLConnector conexion;
        public ModifHabitacion(SQLConnector conec)
        {
            InitializeComponent();
            conexion = conec;
        }
    }
}
