using Examen2.Models;
using Examen2.Views;
using Examen2.Views.HabilidadesViews;
using Examen2.Views.MisionesViews;

namespace Examen2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            frmGestionSuperheroes frm = new frmGestionSuperheroes();
            frm.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPoderes_Click(object sender, EventArgs e)
        {
            frmGestionHabilidades frm = new frmGestionHabilidades();
            frm.Show();
            this.Hide();
        }

        private void btnMisiones_Click(object sender, EventArgs e)
        {
            frmAsignarMision frm = new frmAsignarMision();
            frm.Show();
            this.Close();
        }
    }
}
