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
    public partial class FormIniciarViaje : Form
    {
        N_Autobuses objNegocio = new N_Autobuses();
        private string idViaje;
        C_IniciarViaje objEntidad = new C_IniciarViaje();
        public FormIniciarViaje()
        {
            InitializeComponent();
        }

        private void FormIniciarViaje_Load(object sender, EventArgs e)
        {
            comboBoxChofer.DataSource = objNegocio.ComboBox_Chofer();
            comboBoxChofer.DisplayMember = "Nombre";
            comboBoxChofer.ValueMember = "Nombre";
            comboBoxChofer.SelectedIndex = -1;

            comboBoxAutobus.DataSource = objNegocio.ComboBox_Autobus();
            comboBoxAutobus.DisplayMember = "Placa";
            comboBoxAutobus.ValueMember = "Placa";
            comboBoxAutobus.SelectedIndex = -1;

            comboBoxRuta.DataSource = objNegocio.ComboBox_Ruta();
            comboBoxRuta.DisplayMember = "Ruta";
            comboBoxRuta.ValueMember = "Ruta";
            comboBoxRuta.SelectedIndex = -1;
            mostrarTable("");
        }
        public void mostrarTable(string buscar)
        {
            tablaIniciarViaje.DataSource = objNegocio.ListandoViajes(buscar);
        }
        public void accionesTabla()
        {
            tablaIniciarViaje.Columns[0].Visible = false;
            tablaIniciarViaje.ClearSelection();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            objEntidad.Chofer = comboBoxChofer.Text.ToUpper();
            objEntidad.Autobus = comboBoxAutobus.Text.ToUpper();
            objEntidad.Ruta = comboBoxRuta.Text.ToUpper();

            objNegocio.InsertandoViajes(objEntidad);
            objNegocio.DisponibleChofer(objEntidad);
            objNegocio.DisponibleAutobus(objEntidad);
            objNegocio.DisponibleRuta(objEntidad);
            Limpiar();
            MessageBox.Show("Se guardo el viaje", "Mensaje");
            mostrarTable("");
        }

        public void Limpiar()
        {
            comboBoxChofer.Text = "";
            comboBoxAutobus.Text = "";
            comboBoxRuta.Text = "";
        }

    }
}
