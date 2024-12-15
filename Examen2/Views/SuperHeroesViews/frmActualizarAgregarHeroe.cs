using Examen2.Context;
using Examen2.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Examen2.Views.SuperHeroesViews
{
    public partial class frmActualizarAgregarHeroe : Form
    {
        public int idHeroe = 0;
        public frmActualizarAgregarHeroe()
        {
            InitializeComponent();
            GlobalContext.contexto = new Examen2Context();
        }

        private void frmActualizarAgregarHeroe_Load(object sender, EventArgs e)
        {
            if (idHeroe != 0)
            {
                var objHeroe = GlobalContext.contexto.Superheroes.Find(idHeroe);
                if (objHeroe != null)
                {
                    txId.Text += objHeroe.IdSuperheroe.ToString();
                    txNombre.Text = objHeroe.Nombre;
                    txAlias.Text = objHeroe.Alias;
                    txOrigen.Text = objHeroe.Origen;
                    txNivelPoder.Text = objHeroe.NivelPoder.ToString();
                }
                else
                {
                    MessageBox.Show($"No existe el registro {idHeroe}");
                    this.Close();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (idHeroe == 0)
            {
                if (validaciones())
                {
                    Superhero superhero = new Superhero();
                    superhero.Nombre = txNombre.Text;
                    superhero.Alias = txAlias.Text;
                    superhero.Origen = txOrigen.Text;
                    superhero.NivelPoder = int.Parse(txNivelPoder.Text);
                    superhero.Estado = "A";

                    GlobalContext.contexto.Superheroes.Add(superhero);
                    GlobalContext.contexto.SaveChanges();
                    txId.Text = superhero.IdSuperheroe.ToString();
                    MessageBox.Show($"Heroe #{superhero.IdSuperheroe}. Agregado con existo!.");
                    this.Close();
                }
                else { }
            }
            else
            {
                if (validaciones())
                {
                    var objHeroe = GlobalContext.contexto.Superheroes.Find(idHeroe);
                    objHeroe.Nombre = txNivelPoder.Text;
                    objHeroe.Alias = txAlias.Text;
                    objHeroe.Origen = txOrigen.Text;
                    objHeroe.NivelPoder = int.Parse(txNivelPoder.Text);
                    GlobalContext.contexto.SaveChanges();
                    MessageBox.Show($"Heroe {objHeroe.IdSuperheroe}. Actualizado con existo!.");
                }
                else { }
            }
            this.Close();
        }

        private bool validaciones()
        {
            bool respuesta = true;

            // Validar que el campo Nombre no esté vacío
            if (string.IsNullOrWhiteSpace(txNombre.Text))
            {
                MessageBox.Show("Debe llenar el campo nombre");
                txNombre.Focus();
                respuesta = false;
            }

            // Validar que el campo Alias no esté vacío
            if (string.IsNullOrWhiteSpace(txAlias.Text))
            {
                MessageBox.Show("Debe llenar el campo alias");
                txAlias.Focus();
                respuesta = false;
            }
            else
            {
                // Validar si el alias ya existe en la base de datos (ignorando mayúsculas/minúsculas)
                int contador = GlobalContext.contexto.Superheroes
                    .Where(x => x.Alias.Equals(txAlias.Text) && x.Estado != "I")
                    .Count();

                if (contador > 0)
                {
                    MessageBox.Show("El alias ya existe");
                    txAlias.Focus();
                    respuesta = false;
                }
            }

            // Validar que el campo Origen no esté vacío
            if (string.IsNullOrWhiteSpace(txOrigen.Text))
            {
                MessageBox.Show("Debe llenar el campo origen");
                txOrigen.Focus();
                respuesta = false;
            }

            // Validar que el campo Nivel de Poder no esté vacío
            if (string.IsNullOrWhiteSpace(txNivelPoder.Text))
            {
                MessageBox.Show("Debe llenar el campo nivel de poder");
                txNivelPoder.Focus();
                respuesta = false;
            }
            // Validar que el Nivel de Poder sea un número positivo
            else if (!int.TryParse(txNivelPoder.Text, out int nivelPoder) || nivelPoder < 0)
            {
                MessageBox.Show("El nivel de poder debe ser un número positivo.");
                txNivelPoder.Focus();
                respuesta = false;
            }
            // Validar que el nivel de poder no sea demasiado alto (opcional, si tienes un límite)
            else if (nivelPoder > 100) // Puedes modificar el límite según tu lógica
            {
                MessageBox.Show("El nivel de poder no puede ser superior a 100.");
                txNivelPoder.Focus();
                respuesta = false;
            }

            // Validar que el nombre no contenga caracteres especiales (opcional)
            if (txNombre.Text.Any(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c)))
            {
                MessageBox.Show("El nombre no debe contener caracteres especiales.");
                txNombre.Focus();
                respuesta = false;
            }

            return respuesta;
        }

    }
}




