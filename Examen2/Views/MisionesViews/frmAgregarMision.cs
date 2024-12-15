using Examen2.Context;
using Examen2.Models;
using System;
using System.Windows.Forms;

namespace Examen2.Views.MisionesViews
{
    public partial class frmAgregarMision : Form
    {
        public int idHeroe { get; set; }
        public int? idMision { get; set; }
        public bool esModoEdicion { get; set; }

        public frmAgregarMision()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar selección de estado
                string estadoSeleccionado = comboBox1.SelectedItem?.ToString();
                if (string.IsNullOrWhiteSpace(estadoSeleccionado))
                {
                    MessageBox.Show("Debe seleccionar un estado para la misión.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar nivel de poder del héroe si el estado es 'Completada'
                int nivelPoderHeroe = ObtenerPoderHeroe();
                if (estadoSeleccionado == "Completada" && nivelPoderHeroe < 50)
                {
                    MessageBox.Show("El superhéroe debe tener un nivel de poder de al menos 50 para completar esta misión.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar campos obligatorios
                if (string.IsNullOrWhiteSpace(txMision.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Debe completar todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (idMision == 0 || !esModoEdicion)
                {
                    // Crear nueva misión
                    Misione nuevaMision = new Misione
                    {
                        IdSuperheroe = idHeroe,
                        NombreMision = txMision.Text.Trim(),
                        Descripcion = txtDescripcion.Text.Trim(),
                        Estado = estadoSeleccionado
                    };

                    GlobalContext.contexto.Misiones.Add(nuevaMision);
                    GlobalContext.contexto.SaveChanges();
                    MessageBox.Show("Misión agregada exitosamente.");
                }
                else
                {
                    // Editar misión existente
                    var mision = GlobalContext.contexto.Misiones.Find(idMision);
                    if (mision != null)
                    {
                        mision.NombreMision = txMision.Text.Trim();
                        mision.Descripcion = txtDescripcion.Text.Trim();
                        mision.Estado = estadoSeleccionado;
                        GlobalContext.contexto.SaveChanges();
                        MessageBox.Show("Misión actualizada exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la misión para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void frmAgregarMision_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Asignada", "En progreso", "Completada" });

            if (idHeroe != 0)
            {
                var heroe = GlobalContext.contexto.Superheroes.Find(idHeroe);
                if (heroe != null)
                {
                    txNombre.Text = heroe.Nombre;
                    txAlias.Text = heroe.Alias;
                    txPoder.Text = heroe.NivelPoder.ToString();

                    if (esModoEdicion && idMision.HasValue)
                    {
                        var mision = GlobalContext.contexto.Misiones.Find(idMision.Value);
                        if (mision != null)
                        {
                            txMision.Text = mision.NombreMision;
                            txtDescripcion.Text = mision.Descripcion;
                            comboBox1.SelectedItem = mision.Estado;
                        }
                    }
                    else
                    {
                        txMision.Text = string.Empty;
                        txtDescripcion.Text = string.Empty;
                        comboBox1.SelectedIndex = -1;
                    }
                }
            }
        }

        private int ObtenerPoderHeroe()
        {
            var heroe = GlobalContext.contexto.Superheroes.Find(idHeroe);
            return heroe?.NivelPoder ?? 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}


