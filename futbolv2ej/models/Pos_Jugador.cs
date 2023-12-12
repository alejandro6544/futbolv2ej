using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futbolv2ej.models
{
    internal class Pos_Jugador
    {
        public int Idpos_jugador { get; set; }
        public int IdjugadorF { get; set; }
        public int IdposF { get; set; }

        public Pos_Jugador(int idjugadorF, int idposF)
        {
            IdjugadorF = idjugadorF;
            IdposF = idposF;
        }

        public Pos_Jugador(int idpos_jugador_, int idjugadorF_, int idposF_)
        {
            this.Idpos_jugador = idpos_jugador_;
            this.IdjugadorF = idjugadorF_;
            this.IdposF = idposF_;
        }
    }
}
