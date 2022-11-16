using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;


namespace SystemAutobuses
{
    public partial class FormTerminarViaje : Form
    {
        N_Autobuses objNegocio = new N_Autobuses();
        private string idViaje;
        C_IniciarViaje objEntidad = new C_IniciarViaje();
        public FormTerminarViaje()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (tablaTerminarViaje.SelectedRows.Count > 0)
            {
                objEntidad.Id_Viaje = Convert.ToInt32(tablaTerminarViaje.CurrentRow.Cells[0].Value.ToString());
                objEntidad.Chofer = tablaTerminarViaje.CurrentRow.Cells[1].Value.ToString();
                objEntidad.Autobus = tablaTerminarViaje.CurrentRow.Cells[2].Value.ToString();
                objEntidad.Ruta = tablaTerminarViaje.CurrentRow.Cells[3].Value.ToString();

                objNegocio.DisponibleChoferV(objEntidad);
                objNegocio.DisponibleAutobusV(objEntidad);
                objNegocio.DisponibleRutaV(objEntidad);
                objNegocio.FinalizandoViaje(objEntidad);
 
                MessageBox.Show("Se eliminó el viaje", "Mensaje");
                mostrarTable("");
            }
            else
            {
                MessageBox.Show("Seleccione una fila", "Mensaje");
            }
        }
        public void mostrarTable(string buscar)
        {
            tablaTerminarViaje.DataSource = objNegocio.ListandoViajes(buscar);
        }
        public void accionesTabla()
        {
            tablaTerminarViaje.Columns[0].Visible = false;
            tablaTerminarViaje.ClearSelection();
        }

        private void FormTerminarViaje_Load(object sender, EventArgs e)
        {
            mostrarTable("");
        }

        private void tablaTerminarViaje_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idViaje = tablaTerminarViaje.Rows[tablaTerminarViaje.CurrentRow.Index].Cells[0].Value.ToString();
        }
    }
}
