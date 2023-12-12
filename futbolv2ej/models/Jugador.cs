using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futbolv2ej.models
{
    internal class Jugador
    {
        public int Idjugador { get; set; }
        public string Nombre1j { get; set; }
        public string Nombre2j { get; set; }
        public string Apellido1j { get; set; }
        public string Apellido2j { get; set; }
        public int EquipoContrato { get; set; }
        public string FechaContrato { get; set; }

        public Jugador()
        {
        }

        public Jugador(string nombre1j, string apellido1j, int equipoContrato, string fechaContrato)
        {
            
            Nombre1j = nombre1j;
            Apellido1j = apellido1j;
            EquipoContrato = equipoContrato;
            FechaContrato = fechaContrato;
        }

        public Jugador(int idjugador, string nombre1j, string apellido1j, int equipoContrato, string fechaContrato)
        {
            Idjugador = idjugador;
            Nombre1j = nombre1j;
            Apellido1j = apellido1j;
            EquipoContrato = equipoContrato;
            FechaContrato = fechaContrato;
        }

        public Jugador(int idjugador_, string nombre1j_, string nombre2j_, string apellido1j_, string apellido2j_, int equipoContrato_, string fechaContrato_)
        {
            this.Idjugador = idjugador_;
            this.Nombre1j = nombre1j_;
            this.Nombre2j = nombre2j_;
            this.Apellido1j = apellido1j_;
            this.Apellido2j = apellido2j_;
            this.EquipoContrato = equipoContrato_;
            this.FechaContrato = fechaContrato_;
        }

        
    }
}
