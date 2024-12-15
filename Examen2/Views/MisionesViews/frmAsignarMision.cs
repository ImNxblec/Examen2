using Examen2.Context;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Examen2.Views.MisionesViews
{
    public partial class frmAsignarMision : Form
    {
        public int idHeroe { get; set; }

        public frmAsignarMision()
        {
            InitializeComponent();
        }

        private void frmAsignarMision_Load(object sender, EventArgs e)
        {
            CargarDatosHeroe();
            CargarMisiones();
            CargarEstados();
        }

        private void CargarDatosHeroe()
        {
            var heroe = GlobalContext.contexto.Superheroes.Find(idHeroe);
            if (heroe != null)
            {
                txNombre.Text = heroe.Nombre;
                txAlias.Text = heroe.Alias;
                txPoder.Text = heroe.NivelPoder.ToString(); // Mostrar el nivel de poder
            }
            else
            {
                MessageBox.Show("No se encontró información del héroe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void CargarMisiones(string filtroBusqueda = "", string filtroEstado = "")
        {
            var misiones = GlobalContext.contexto.Misiones
                .Where(m => m.IdSuperheroe == idHeroe &&
                            (string.IsNullOrEmpty(filtroBusqueda) ||
                             m.NombreMision.Contains(filtroBusqueda) ||
                             m.Descripcion.Contains(filtroBusqueda)) &&
                            (string.IsNullOrEmpty(filtroEstado) || m.Estado == filtroEstado))
                .Select(m => new
                {
                    m.IdMision,
                    m.NombreMision,
                    m.Descripcion,
                    m.Estado
                })
                .ToList();

            dgvMisiones.DataSource = misiones;
        }

        private void CargarEstados()
        {
            cbEstado.Items.Clear();
            cbEstado.Items.AddRange(new string[] { "Asignada", "En progreso", "Completada" });
            cbEstado.SelectedIndex = -1; // Sin selección inicial
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filtroBusqueda = textBox1.Text.Trim();
            string filtroEstado = cbEstado.SelectedItem?.ToString();
            CargarMisiones(filtroBusqueda, filtroEstado);
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtroBusqueda = textBox1.Text.Trim();
            string filtroEstado = cbEstado.SelectedItem?.ToString();
            CargarMisiones(filtroBusqueda, filtroEstado);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarMision formulario = new frmAgregarMision
            {
                idHeroe = idHeroe,
                esModoEdicion = false // Modo añadir
            };
            if (formulario.ShowDialog() == DialogResult.OK)
            {
                CargarMisiones();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvMisiones.SelectedRows.Count > 0)
            {
                int idMision = Convert.ToInt32(dgvMisiones.CurrentRow.Cells["IdMision"].Value);

                frmAgregarMision formulario = new frmAgregarMision
                {
                    idHeroe = idHeroe,
                    idMision = idMision,
                    esModoEdicion = true // Modo edición
                };
                if (formulario.ShowDialog() == DialogResult.OK)
                {
                    CargarMisiones();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una misión para editar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
