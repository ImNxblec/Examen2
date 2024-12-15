using Examen2.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2.Views.HabilidadesViews
{
    public partial class frmGestionHabilidades : Form
    {
        public int idHeroe { get; set; }

        public frmGestionHabilidades()
        {
            InitializeComponent();
            GlobalContext.contexto = new Examen2Context();
        }

        private void frmGestionHabilidades_Load(object sender, EventArgs e)
        {
            if (idHeroe != 0)
            {
                var objHeroe = GlobalContext.contexto.Superheroes.Find(idHeroe);
                if (objHeroe != null)
                {
                    txNombre.Text = objHeroe.Nombre;
                    txAlias.Text = objHeroe.Alias;

                    var habilidades = GlobalContext.contexto.Habilidades
                        .Where(h => h.IdSuperheroe == idHeroe)
                        .ToList();

                    if (habilidades.Any())
                    {
                        dgvHabilidades.DataSource = habilidades;

                        dgvHabilidades.Columns["idSuperheroeNavigation"].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Este superhéroe no tiene habilidades registradas.");
                        dgvHabilidades.DataSource = null;
                    }
                }
                else
                {
                    MessageBox.Show($"No existe el superhéroe con el ID {idHeroe}");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un héroe.");
                this.Close();
            }
        }

        private void CargarHabilidades()
        {
            var habilidades = GlobalContext.contexto.Habilidades
                .Where(h => h.IdSuperheroe == idHeroe)
                .ToList();
            dgvHabilidades.DataSource = habilidades;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarHabilidad formulario = new frmAgregarHabilidad
            {
                idHeroe = idHeroe, // Pasar el héroe seleccionado
                esModoEdicion = false // Modo añadir
            };
            if (formulario.ShowDialog() == DialogResult.OK)
            {
                CargarHabilidades(); // Recargar habilidades después de añadir
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvHabilidades.SelectedRows.Count > 0)
            {
                int idHabilidad = Convert.ToInt32(dgvHabilidades.CurrentRow.Cells["IdHabilidad"].Value);

                frmAgregarHabilidad formulario = new frmAgregarHabilidad
                {
                    idHeroe = idHeroe, // Pasar el héroe seleccionado
                    idHabilidad = idHabilidad, // Pasar la habilidad seleccionada
                    esModoEdicion = true // Modo edición
                };
                if (formulario.ShowDialog() == DialogResult.OK)
                {
                    CargarHabilidades(); // Recargar habilidades después de editar
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una habilidad para editar.");
            }
        }
    }
}
