using Examen2.Context;
using Examen2.Models;
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
    public partial class frmAgregarHabilidad : Form
    {
        public int idHeroe { get; set; } // ID del héroe seleccionado
        public int? idHabilidad { get; set; } // ID de la habilidad (null si es una nueva habilidad)
        public bool esModoEdicion { get; set; } // True si estamos editando, False si estamos añadiendo
        public frmAgregarHabilidad()
        {
            InitializeComponent();
        }

        private void frmAgregarHabilidad_Load(object sender, EventArgs e)
        {
            if (idHeroe != 0)
            {
                // Obtener datos del superhéroe
                var objHeroe = GlobalContext.contexto.Superheroes.Find(idHeroe);
                if (objHeroe != null)
                {
                    // Mostrar datos del superhéroe
                    txNombre.Text = objHeroe.Nombre;
                    txAlias.Text = objHeroe.Alias;

                    if (esModoEdicion && idHabilidad.HasValue)
                    {
                        // Modo edición: cargar la habilidad específica
                        var habilidad = GlobalContext.contexto.Habilidades.Find(idHabilidad.Value);
                        if (habilidad != null)
                        {
                            txHabilidad.Text = habilidad.NombreHabilidad; // Campo para editar la habilidad
                        }
                    }
                    else
                    {
                        // Modo añadir: Limpiar el campo de habilidad
                        txHabilidad.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el superhéroe.");
                    this.Close();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txHabilidad.Text))
            {
                MessageBox.Show("Por favor, ingrese una habilidad.");
                return;
            }

            if (esModoEdicion && idHabilidad.HasValue)
            {
                // Editar habilidad
                var habilidad = GlobalContext.contexto.Habilidades.Find(idHabilidad.Value);
                if (habilidad != null)
                {
                    habilidad.NombreHabilidad = txHabilidad.Text;
                    GlobalContext.contexto.SaveChanges();
                    MessageBox.Show("Habilidad actualizada correctamente.");
                }
            }
            else
            {
                // Añadir nueva habilidad
                var nuevaHabilidad = new Habilidade
                {
                    NombreHabilidad = txHabilidad.Text,
                    Descripcion = txHabilidad.Text,
                    IdSuperheroe = idHeroe
                };
                GlobalContext.contexto.Habilidades.Add(nuevaHabilidad);
                GlobalContext.contexto.SaveChanges();
                MessageBox.Show("Habilidad añadida correctamente.");
            }

            this.DialogResult = DialogResult.OK; // Cerrar el formulario
        }
    }
}
