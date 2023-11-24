using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class mecanicos : personas
    {
        SqlConnection con = Connection.conexion();
        private string especialidad;
        private string experiencia;

        public mecanicos(string nombre, string apellido, string cedula, string especialidad, string experiencia) : base(nombre, apellido, cedula)
        {
            this.especialidad = especialidad;
            this.experiencia = experiencia;
        }

        public mecanicos()
        {
        }

        public string Especialidad{ get => especialidad; set => especialidad = value; }

        public string Experiencia{ get => experiencia; set => experiencia = value; }

        public void agregarMecanicos(string nombre, string apellido, string cedula, string especialidad, string experiencia)
        {
            con.Open();
            string query = "INSERT INTO mecanicos (Nombre, Apellido, Cedula, Especialidad, Experiencia) VALUES (@Nombre, @Apellido, @Cedula, @Especialidad, @Experiencia)";
            SqlCommand comando = new SqlCommand(query, con);
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Apellido", apellido);
            comando.Parameters.AddWithValue("@Cedula", cedula);
            comando.Parameters.AddWithValue("@Especialidad", especialidad);
            comando.Parameters.AddWithValue("@Experiencia", experiencia);
            comando.ExecuteNonQuery();
            con.Close();
        }
    }
}
