﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku_GUI
{
    public partial class FrmEditEmpleado : Form
    {
        Empleado empleadoIns;
        public FrmEditEmpleado(Empleado empleado)
        {
            InitializeComponent();
            empleadoIns = empleado;
        }

        private void FrmEditEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
