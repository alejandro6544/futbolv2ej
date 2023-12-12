using futbolv2ej.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace futbolv2ej.controller
{
    internal class ControllerPartido
    {
        public List<Equipo> ConsultarEquipos()
        {
            List<Equipo> LEquipos;
            Equipo objD = new Equipo();
            string sql = "select * from equipo";
            LEquipos = objD.ConsultarEquipo(sql);
            return LEquipos;
        }
    }
}
