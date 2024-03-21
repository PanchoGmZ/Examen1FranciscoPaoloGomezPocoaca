using SistemaEmpresa.BSS;
using SistemaEmpresa.Modelos;
using SistemasEmpresa.VISTAS.PersonaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasEmpresa.VISTAS.EmpleadoVistas
{
    public partial class EmpleadoEditarVistas : Form
    {
        int idx = 0;
        Empleados empleados = new Empleados();
        EmpleadoBss bss = new EmpleadoBss();
        public EmpleadoEditarVistas(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void EmpleadoEditarVistas_Load(object sender, EventArgs e)
        {
            empleados = bss.ObtenerIdBss(idx);
            txt_IdPersona.Text = empleados.IdPersona.ToString();
            txt_Puesto.Text = empleados.Puesto;
            txt_DateTime.Text = empleados.FechaContrato.ToString();
            txt_Salario.Text = empleados.Salario;
        }

        private void Guardar_btn_Click(object sender, EventArgs e)
        {
            empleados.IdPersona = IdPersonaSeleccionada;
            empleados.Puesto = txt_Puesto.Text;
            empleados.FechaContrato = Convert.ToDateTime(txt_DateTime.Text);
            empleados.Salario = txt_Salario.Text;
            bss.EditarEmpleadoBss(empleados);
            MessageBox.Show("Se actualizo correctamente");
        }
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bsspersona = new PersonaBss();

        private void Seleccionar_btn_Click(object sender, EventArgs e)
        {
            PersonaListarVistas fr = new PersonaListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Personas persona = bsspersona.ObtenerIdBss(IdPersonaSeleccionada);
                txt_IdPersona.Text = persona.Nombre + " " + persona.Apellido;
            }
        }
    }
}
