using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using EjemploBDMysql.model;

namespace futbolv2ej.models
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class Equipo
    {
        ConnectionDAtaBase objConection = new ConnectionDAtaBase();

        public int Ideqiupo { get; set; }
        public string NombreE { get; set; }

        public Equipo()
        {
        }

        public Equipo( string nombreE_)
        {
            
            this.NombreE = nombreE_;
        }
        public Equipo(int ideqiupo_, string nombreE_)
        {
            this.Ideqiupo = ideqiupo_;
            this.NombreE = nombreE_;
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
        internal List<Equipo> ConsultarEquipo(string sql)
        {
            List<Equipo> listD = new List<Equipo>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, objConection.DataSource());
                objConection.ConnectOpened();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int idE = reader.GetInt32(0);
                        string nameE = reader.GetString(1);
                        listD.Add(new Equipo(idE, nameE));
                    }
                }


            }
            catch (Exception w)
            {
                Console.WriteLine("ERROOOOOOR " + w.Message);
                objConection.ConnectClosed();
            }
            finally
            {
                objConection.ConnectClosed();
            }


            return listD;
        }
    }
}
