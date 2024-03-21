using SistemaEmpresa.DAL;
using SistemaEmpresa.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpresa.BSS
{
    public class EmpleadoBss
    {
        EmpleadoDAL dal = new EmpleadoDAL();
        public DataTable ListarEmpleadoBss()
        {
            return dal.ListarEmpleadoDal();
        }

        public void InsertarEmpleadoBss(Empleados empleado)
        {
            dal.InsertarEmpleadoDal(empleado);
        }
        public Empleados ObtenerIdBss (int id)
        {
            return dal.ObtenerEmpleadoId(id);
        }
        public void EditarEmpleadoBss (Empleados empleado)
        {
            dal.EditarEmpleadoDal(empleado);
        }
        public void EliminarEmpleadobss (int id)
        {
            dal.EliminarEmpleadoDal (id);
        }
     
    }
}
