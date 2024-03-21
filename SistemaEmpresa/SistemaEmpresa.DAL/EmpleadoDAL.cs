using DAL;
using SistemaEmpresa.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpresa.DAL
{
    public class EmpleadoDAL
    {
        public DataTable ListarEmpleadoDal()
        {
            string consulta = "select * from empleados";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarEmpleadoDal(Empleados empleado)
        {
            string consulta = "insert into empleados values('" + empleado.Puesto + "'," +
                                                         "'" + empleado.FechaContrato + "'," +
                                                         "'" + empleado.Salario + "'," +
                                                         "')";
            conexion.Ejecutar(consulta);
        }

        public Empleados ObtenerEmpleadoId(int id)
        {
            string consulta = "select * from empleados where idempleado=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Empleados empleado = new Empleados();
            if (tabla.Rows.Count > 0)
            {
                empleado.IdEmpleado = Convert.ToInt32(tabla.Rows[0]["idempleado"]);
                empleado.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);             
                empleado.Puesto = tabla.Rows[0]["puesto"].ToString();
                empleado.FechaContrato = Convert.ToDateTime(tabla.Rows[0]["fechacontratatacion"]);
                empleado.Salario = tabla.Rows[0]["salario"].ToString();


            }
            return empleado;
        }

        public void EditarEmpleadoDal(Empleados empleado)
        {
            string consulta = "update empleado set puesto='" + empleado.Puesto + "'," +
                                                 "fechacontrato='" + empleado.FechaContrato.ToString("yyyy-MM-dd HH:mm:ss") + "' " +
                                                 "salario='" + empleado.Salario + "'," +
                               "where idempleado=" + empleado.IdEmpleado;
            conexion.Ejecutar(consulta);
        }

        public void EliminarEmpleadoDal(int id)
        {
            string consulta = "delete from empleado where idempleado=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}

