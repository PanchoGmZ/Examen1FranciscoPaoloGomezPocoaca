using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using SistemaEmpresa.Modelos;
namespace SistemasVentas.DAL
{
    public class PersonaDal
    {
        public DataTable ListarPersonasDal()
        {
            string consulta = "select * from persona";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarPersonaDal(Personas persona)
        {
            string consulta = "insert into persona values('" + persona.Nombre + "'," +
                                                         "'" + persona.Apellido + "'," + "'Activo')";
            conexion.Ejecutar(consulta);
        }

        public Personas ObtenerPersonaId(int id)
        {
            string consulta = "select * from persona where idpersona=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Personas persona = new Personas();
            if (tabla.Rows.Count > 0)
            {
                persona.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                persona.Nombre = tabla.Rows[0]["nombre"].ToString();
                persona.Apellido = tabla.Rows[0]["apellido"].ToString();
                persona.Estado = tabla.Rows[0]["estado"].ToString();

            }
            return persona;
        }

    }


}