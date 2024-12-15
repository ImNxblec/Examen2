using Examen2.Context;
using Examen2.Models;
using Examen2.Views.HabilidadesViews;
using Examen2.Views.MisionesViews;
using Examen2.Views.SuperHeroesViews;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Examen2.Views
{
    public partial class frmGestionSuperheroes : Form
    {
        public frmGestionSuperheroes()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void frmGestionSuperheroes_Load(object sender, EventArgs e)
        {
            var listaHeroes = GlobalContext.contexto.Superheroes.ToList();
            grdSuperheroe.DataSource = listaHeroes;

            grdSuperheroe.Columns["Habilidades"].Visible = false;
            grdSuperheroe.Columns["Misiones"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmActualizarAgregarHeroe formulario = new frmActualizarAgregarHeroe();
            formulario.ShowDialog();
            var listaUsuarios = GlobalContext.contexto.Superheroes.ToList();
            grdSuperheroe.DataSource = listaUsuarios;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (grdSuperheroe.RowCount <= 0)
            {
                MessageBox.Show("No existen datos");
                return;
            }
            else
            {
                int id = Convert.ToInt32(grdSuperheroe.CurrentRow.Cells[0].Value);
                frmActualizarAgregarHeroe formulario = new frmActualizarAgregarHeroe();
                formulario.idHeroe = id;
                formulario.ShowDialog();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdSuperheroe.RowCount <= 0)
            {
                MessageBox.Show("No existen datos para eliminar.");
                return;
            }
            int idHeroe = Convert.ToInt32(grdSuperheroe.CurrentRow.Cells[0].Value);
            var objSuperHeroe = GlobalContext.contexto.Superheroes.Find(idHeroe);
            if (objSuperHeroe != null)
            {
                // Confirmación antes de eliminar
                var confirmResult = MessageBox.Show(
                    $"¿Estás seguro de eliminar al heroe {objSuperHeroe.Nombre}?",
                    "Confirmación de eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmResult == DialogResult.Yes)
                {
                    // Cambiar estado a "I" para marcarlo como inactivo
                    objSuperHeroe.Estado = "I";
                    GlobalContext.contexto.SaveChanges();
                    MessageBox.Show($"Heroe {objSuperHeroe.Nombre} con el id #{objSuperHeroe.IdSuperheroe} eliminado correctamente (estado cambiado a 'I').");

                    // Actualizar la lista en la grilla
                    grdSuperheroe.DataSource = GlobalContext.contexto.Superheroes.ToList();
                }
                else
                {
                    MessageBox.Show($"El heroe con ID {idHeroe} no existe.");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBox1.Text.ToLower();

            var heroesFiltrados = GlobalContext.contexto.Superheroes
                .Where(p => p.IdSuperheroe.ToString().Contains(filtro) ||
                            p.Nombre.ToLower().Contains(filtro) ||
                            p.Origen.ToLower().Contains(filtro) ||
                            p.NivelPoder.ToString().Contains(filtro) ||
                            p.Alias.ToLower().Contains(filtro) ||
                            p.Estado.ToLower().Contains(filtro))
                .ToList();

            grdSuperheroe.DataSource = heroesFiltrados;
        }

        private void btnPoderes_Click(object sender, EventArgs e)
        {
            if (grdSuperheroe.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(grdSuperheroe.CurrentRow.Cells[0].Value);

                frmGestionHabilidades formulario = new frmGestionHabilidades();

                formulario.idHeroe = id;

                formulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un superhéroe de la lista.");
            }
        }

        private void btnMisiones_Click(object sender, EventArgs e)
        {
            if (grdSuperheroe.SelectedRows.Count > 0)
            {
                // Obtener el ID del héroe seleccionado
                int idHeroe = Convert.ToInt32(grdSuperheroe.CurrentRow.Cells["IdSuperheroe"].Value);

                // Crear instancia del formulario de misiones
                frmAsignarMision formulario = new frmAsignarMision
                {
                    idHeroe = idHeroe
                };

                // Abrir el formulario
                formulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un héroe para asignar misiones.");
            }
        }
    }
}


