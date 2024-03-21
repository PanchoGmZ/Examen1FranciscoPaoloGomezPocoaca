using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpresa.Modelos
{
    public class Empleados
    {
        public int IdEmpleado {  get; set; }
        public int IdPersona { get; set; }
        public string Puesto { get; set; }
        public DateTime FechaContrato { get; set; }
        public string Salario { get; set;}
    }
}
