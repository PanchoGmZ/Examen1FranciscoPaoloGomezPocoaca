using SistemaEmpresa.BSS;
using SistemaEmpresa.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasEmpresa.VISTAS.EmpleadoVistas
{
    public partial class EmpleadoInsertarVistas : Form
    {
        public EmpleadoInsertarVistas()
        {
            InitializeComponent();
        }
        EmpleadoBss bss = new EmpleadoBss();
        PersonaBss bsspersona = new PersonaBss();
        public static int IdPersonaSeleccionada = 0;
        private void Guardar_btn_Click(object sender, EventArgs e)
        {
            Personas personas = new Personas();
            Empleados empleados = new Empleados();
            personas.Nombre = txt_Nombre.Text;
            personas.Apellido = txt_Apellido.Text;
            empleados.Puesto = txt_Puesto.Text;
            empleados.FechaContrato = Convert.ToDateTime(txt_fecha.Text);
            bss.InsertarEmpleadoBss(empleados);
            bsspersona.InsertarPersonaBss(personas);
            MessageBox.Show("Guardado exitosamente");
        }
    }
}
