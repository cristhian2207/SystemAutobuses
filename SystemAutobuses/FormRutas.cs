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
    public partial class FormRutas : Form
    {
        private bool Editarse = false;
        N_Autobuses objNegocio = new N_Autobuses();
        private string idRuta;
        E_Autobuses objEntidad = new E_Autobuses();
        public FormRutas()
        {
            InitializeComponent();
        }
        public void accionesTabla()
        {
            tablaRutas.Columns[0].Visible = false;
            tablaRutas.Columns[1].Visible = false;
            tablaRutas.Columns[2].Visible = false;
            tablaRutas.Columns[3].Visible = false;
            tablaRutas.Columns[4].Visible = false;
            tablaRutas.Columns[5].Visible = false;
            tablaRutas.Columns[6].Visible = false;
            tablaRutas.Columns[7].Visible = false;
            tablaRutas.Columns[8].Visible = false;
            tablaRutas.Columns[9].Visible = false;
            tablaRutas.Columns[10].Visible = false;
            tablaRutas.Columns[11].Visible = false;
            tablaRutas.ClearSelection();
        }
        public void mostrarTable(string buscar)
        {
            tablaRutas.DataSource = objNegocio.ListandoRutas(buscar);
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (Editarse == false)
            {
                try
                {
                    objEntidad.Nombre_Ruta = txtRuta.Text;
              
                    objNegocio.InsertandoRutas(objEntidad);
                    MessageBox.Show("Se guardo el registro", "Mensaje");
                    mostrarTable("");

                }
                catch (Exception E)
                {
                    MessageBox.Show("No se pudo guardar el registro" + E, "Mensaje");
                }

            }
            if (Editarse == true)
            {
                try
                {
                    objEntidad.Id_Rutas = Convert.ToInt32(idRuta);
                    objEntidad.Nombre_Ruta = txtRuta.Text;

                    objNegocio.EditandoRutas(objEntidad);
                    MessageBox.Show("Se editó el registro", "Mensaje");
                    mostrarTable("");
                    Editarse = false;
                }
                catch (Exception E)
                {
                    MessageBox.Show("No se pudo guardar el registro" + E, "Mensaje");
                }
            }
        }

        private void FormRutas_Load(object sender, EventArgs e)
        {
            mostrarTable("");
            accionesTabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tablaRutas.SelectedRows.Count > 0)
            {
                objEntidad.Id_Rutas = Convert.ToInt32(tablaRutas.CurrentRow.Cells[12].Value.ToString());
                objNegocio.EliminandoRutas(objEntidad);

                MessageBox.Show("Se elimino correctamente", "Mensaje");
                mostrarTable("");
            }
            else
            {
                MessageBox.Show("Selecciona la fila que deseas eliminar");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tablaRutas.SelectedRows.Count > 0)
            {
                Editarse = true;
                idRuta = tablaRutas.CurrentRow.Cells[12].Value.ToString();
                txtRuta.Text = tablaRutas.CurrentRow.Cells[13].Value.ToString();

            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar", "Mensaje");
            }
        }
    }
}
