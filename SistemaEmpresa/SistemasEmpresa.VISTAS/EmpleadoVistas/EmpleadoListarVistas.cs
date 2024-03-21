using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEmpresa.BSS;
namespace SistemasEmpresa.VISTAS.EmpleadoVistas
{
    public partial class EmpleadoListarVistas : Form
    {
        public EmpleadoListarVistas()
        {
            InitializeComponent();
        }
        EmpleadoBss bss = new EmpleadoBss();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EmpleadoListarVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarEmpleadoBss();
        }

        private void Agregar_btn_Click(object sender, EventArgs e)
        {
            EmpleadoInsertarVistas.IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void Editar_btn_Click(object sender, EventArgs e)
        {
            int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            EmpleadoEditarVistas fr = new EmpleadoEditarVistas(IdPersonaSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarEmpleadoBss();
            }
        }
        private void Eliminar_btn_Click(object sender, EventArgs e)
        {
            int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de eliminar esta persona", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarEmpleadobss(IdPersonaSeleccionada);
                dataGridView1.DataSource = bss.ListarEmpleadoBss();
            }
        }
    }
}
