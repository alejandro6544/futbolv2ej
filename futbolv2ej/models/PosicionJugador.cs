using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futbolv2ej.models
{
    internal class PosicionJugador
    {
        public int Idposj { get; set; }
        public string Nombrepos { get; set; }

        public PosicionJugador(string nombrepos)
        {
            Nombrepos = nombrepos;
        }

        public PosicionJugador(int idposj_, string nombrepos_)
        {
            this.Idposj = idposj_;
            this.Nombrepos = nombrepos_;
        }
    }
}
