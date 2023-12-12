using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futbolv2ej.models
{
    internal class Partido
    {
        public int Idpartido { get; set; }
        public string Fechapartido { get; set; }
        public int GolesEquipoL { get; set; }
        public int GolesEquipoV { get; set; }
        public string Resultadofinal { get; set; }
        public int IdEquipolocalF { get; set; }
        public int IdEquipovisitanteF { get; set; }


        public Partido()
        {
        }

        public Partido( string fechapartido, int idEquipolocalF, int idEquipovisitanteF)
        {
            
            Fechapartido = fechapartido;
            IdEquipolocalF = idEquipolocalF;
            IdEquipovisitanteF = idEquipovisitanteF;
        }
        public Partido(int idpartido, string fechapartido, int idEquipolocalF, int idEquipovisitanteF)
        {
            Idpartido = idpartido;
            Fechapartido = fechapartido;
            IdEquipolocalF = idEquipolocalF;
            IdEquipovisitanteF = idEquipovisitanteF;
        }

        public Partido(int idpartido_, string fechapartido_, int golesEquipoL_, int golesEquipoV_, string resultadofinal_, int idEquipolocalF_, int idEquipovisitanteF_)
        {
            this.Idpartido = idpartido_;
            this.Fechapartido = fechapartido_;
            this.GolesEquipoL = golesEquipoL_;
            this.GolesEquipoV = golesEquipoV_;
            this.Resultadofinal = resultadofinal_;
            this.IdEquipolocalF = idEquipolocalF_;
            this.IdEquipovisitanteF = idEquipovisitanteF_;
        }

        
    }
}
