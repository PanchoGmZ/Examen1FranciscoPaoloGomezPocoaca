using SistemaEmpresa.Modelos;
using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpresa.BSS
{
    public class PersonaBss
    {
        PersonaDal dal = new PersonaDal();
        public DataTable ListarPersonaBss()
        {
            return dal.ListarPersonasDal();
        }

        public void InsertarPersonaBss(Personas persona)
        {
            dal.InsertarPersonaDal(persona);
        }
        public Personas ObtenerIdBss(int id)
        {
            return dal.ObtenerPersonaId(id);
        }

    }
}
