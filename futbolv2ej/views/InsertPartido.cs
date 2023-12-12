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
        List<Equipo> listD;
        public InsertPartido()
        {
            InitializeComponent();
        }

        private void LoadEquipos(object sender, EventArgs e)
        {
            ControllerPartido objc = new ControllerPartido();
            listD = objc.ConsultarEquipos();
            for (int i = 0; i < listD.Count; i++)
            {
                comboBox1.Items.Add(listD[i].NombreE);
                comboBox2.Items.Add(listD[i].NombreE);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selected1 = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            string selected2 = this.comboBox1.GetItemText(this.comboBox2.SelectedItem);
            int idLocal=0;
            int idVisitante= 0;
            for (int i = 0; i < listD.Count; i++)
            {
                if (selected1.Equals(listD[i].NombreE))
                {
                    idLocal = listD[i].Ideqiupo;
                }
                if (selected2.Equals(listD[i].NombreE))
                {
                    idVisitante = listD[i].Ideqiupo;
                }
            }

            //Realizar el insert en partido

            //MessageBox.Show("ID Local "+ idLocal + " ID Visitante "+ idVisitante);
        }
    }
}
