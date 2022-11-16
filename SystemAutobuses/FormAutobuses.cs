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
    public partial class FormAutobuses : Form
    {
        private bool Editarse = false;
        N_Autobuses objNegocio = new N_Autobuses();
        private string idAutobus;
        E_Autobuses objEntidad = new E_Autobuses();
        public FormAutobuses()
        {
            InitializeComponent();
        }

        public void accionesTabla()
        {
            tablaAutobuses.Columns[0].Visible = false;
            tablaAutobuses.Columns[1].Visible = false;
            tablaAutobuses.Columns[2].Visible = false;
            tablaAutobuses.Columns[3].Visible = false;
            tablaAutobuses.Columns[4].Visible = false;
            tablaAutobuses.Columns[5].Visible = false;
            tablaAutobuses.Columns[6].Visible = false;
            tablaAutobuses.Columns[12].Visible = false;
            tablaAutobuses.Columns[13].Visible = false;
            tablaAutobuses.ClearSelection();
        }
        public void mostrarTable(string buscar)
        {
            tablaAutobuses.DataSource = objNegocio.ListandoAutobuses(buscar);
        }
        private void FormAutobuses_Load(object sender, EventArgs e)
        {
            mostrarTable("");
            accionesTabla();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (tablaAutobuses.SelectedRows.Count > 0)
            {
                objEntidad.Id_Autobus = Convert.ToInt32(tablaAutobuses.CurrentRow.Cells[6].Value.ToString());
                objNegocio.EliminandoAutobuses(objEntidad);

                MessageBox.Show("Se elimino correctamente", "Mensaje");
                mostrarTable("");
            }
            else
            {
                MessageBox.Show("Selecciona la fila que deseas eliminar");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (Editarse == false)
             {
                 try
                 {
                     objEntidad.Placa = txtPlaca.Text;
                     objEntidad.Marca = txtMarca.Text;
                     objEntidad.Modelo = txtModelo.Text;
                     objEntidad.Color = txtColor.Text;
                     objEntidad.Año = Int32.Parse(txtAño.Text);

                    objNegocio.InsertandoAutobuses(objEntidad);
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
                     objEntidad.Id_Autobus = Convert.ToInt32(idAutobus);
                     objEntidad.Placa = txtPlaca.Text;
                     objEntidad.Marca = txtMarca.Text;
                     objEntidad.Modelo = txtModelo.Text;
                     objEntidad.Color = txtColor.Text;
                     objEntidad.Año = Int32.Parse(txtAño.Text);


                    objNegocio.EditandoAutobuses(objEntidad);
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
        private void button2_Click(object sender, EventArgs e)
        {
            if (tablaAutobuses.SelectedRows.Count > 0)
            {
                Editarse = true;
                idAutobus = tablaAutobuses.CurrentRow.Cells[6].Value.ToString();
                txtMarca.Text = tablaAutobuses.CurrentRow.Cells[7].Value.ToString();
                txtModelo.Text = tablaAutobuses.CurrentRow.Cells[8].Value.ToString();
                txtPlaca.Text = tablaAutobuses.CurrentRow.Cells[9].Value.ToString();
                txtColor.Text = tablaAutobuses.CurrentRow.Cells[10].Value.ToString();
                txtAño.Text = tablaAutobuses.CurrentRow.Cells[11].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar", "Mensaje");
            }
        }

    }
}
