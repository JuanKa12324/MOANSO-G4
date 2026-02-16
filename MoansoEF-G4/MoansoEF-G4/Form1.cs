using Capa_Entidad;
using Capa_Logica;
using Capa_Datos;

namespace MoansoEF_G4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ListaMantenimiento();
            PlanMantenimiento.Enabled = false;
        }
        public void ListaMantenimiento()
        {
            dgvMantenimiento.DataSource = logMantenimiento.Instancia.ListaMantenimientos();

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            PlanMantenimiento.Enabled = true;
            LimpiarVariables();
            btnInsertar.Visible = true;
            btnModificar.Visible = false;
        }
        private void LimpiarVariables()
        {
            txtArea.Text = "";
            txtEquipo.Text = "";
            txtPrioridad.Text = "";
            txtTecnico.Text = "";
            txtEstado.Text = "";
            txtRecursos.Text = "";
            txtTipoDeMantenimiento.Text = "";
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                entMantenimiento Mant = new entMantenimiento();
                Mant.MantenimientoID=int.Parse(idMant.Text);
                Mant.EquipoID = int.Parse(txtEquipo.Text.Trim());
                Mant.EstadoID = int.Parse(txtEstado.Text.Trim());
                Mant.TipoMantenimientoID = int.Parse(txtTipoDeMantenimiento.Text.Trim());
                Mant.TecnicoID = int.Parse(txtTecnico.Text.Trim());
                Mant.PrioridadID = int.Parse(txtPrioridad.Text.Trim());

                logMantenimiento.Instancia.InsertarMantenimiento(Mant);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            PlanMantenimiento.Enabled = false;
            ListaMantenimiento();
        }
    }
}
