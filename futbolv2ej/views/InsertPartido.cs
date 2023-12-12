using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using futbolv2ej.controller;
using futbolv2ej.models;

namespace futbolv2ej.views
{
    public partial class InsertPartido : Form
    {
        public InsertPartido()
        {
            InitializeComponent();
        }

        private void LoadEquipos(object sender, EventArgs e)
        {
            ControllerPartido objc = new ControllerPartido();
            List<Equipo> listD = objc.ConsultarEquipos();
            for (int i = 0; i < listD.Count; i++)
            {
                comboBox1.Items.Add(listD[i].NombreE);
                comboBox2.Items.Add(listD[i].NombreE);
            }
        }
    }
}
