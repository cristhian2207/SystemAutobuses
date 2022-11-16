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
    public partial class FormChoferes : Form
    {
        private bool Editarse = false;
        N_Autobuses objNegocio = new N_Autobuses();
        private string idChofer;
        E_Autobuses objEntidad = new E_Autobuses();

        public FormChoferes()
        {
                InitializeComponent();
        }

            public void accionesTabla()
            {
                tablaChoferes.Columns[0].Visible = false;
                tablaChoferes.Columns[5].Visible = false;
                tablaChoferes.Columns[6].Visible = false;
                tablaChoferes.Columns[7].Visible = false;
                tablaChoferes.Columns[8].Visible = false;
                tablaChoferes.Columns[9].Visible = false;
                tablaChoferes.Columns[10].Visible = false;
                tablaChoferes.Columns[11].Visible = false;
                tablaChoferes.Columns[12].Visible = false;
                tablaChoferes.Columns[13].Visible = false;
                tablaChoferes.ClearSelection();
            }
            public void mostrarTable(string buscar)
            {
                tablaChoferes.DataSource = objNegocio.ListandoChoferes(buscar);
            }

           

        private void button1_Click(object sender, EventArgs e)
        {
            if (Editarse == false)
            {
                try
                {
                    objEntidad.Nombre = txtNombreChofer.Text;
                    objEntidad.Apellido = txtApellidoChofer.Text;
                    objEntidad.Fecha_De_Nacimiento = DateTime.Parse(txtFechaChofer.Text);
                    objEntidad.Cedula = txtCedula.Text;

                    objNegocio.InsertandoChoferes(objEntidad);
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
                    objEntidad.Id_Chofer = Convert.ToInt32(idChofer);
                    objEntidad.Nombre = txtNombreChofer.Text;
                    objEntidad.Apellido = txtApellidoChofer.Text;
                    objEntidad.Cedula = txtCedula.Text;
                    objEntidad.Fecha_De_Nacimiento = DateTime.Parse(txtFechaChofer.Text);


                    objNegocio.EditandoChoferes(objEntidad);
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

        private void FormChoferes_Load(object sender, EventArgs e)
        {
            mostrarTable("");
            accionesTabla();
        }

        private void txtNombreChofer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoChofer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFechaChofer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (tablaChoferes.SelectedRows.Count > 0)
            {
                Editarse = true;
                idChofer = tablaChoferes.CurrentRow.Cells[0].Value.ToString();
                txtNombreChofer.Text = tablaChoferes.CurrentRow.Cells[1].Value.ToString();
                txtApellidoChofer.Text = tablaChoferes.CurrentRow.Cells[2].Value.ToString();
                txtFechaChofer.Text = tablaChoferes.CurrentRow.Cells[3].Value.ToString();
                txtCedula.Text = tablaChoferes.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar", "Mensaje");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tablaChoferes.SelectedRows.Count > 0)
            {
                objEntidad.Id_Chofer = Convert.ToInt32(tablaChoferes.CurrentRow.Cells[0].Value.ToString());
                objNegocio.EliminandoChoferes(objEntidad);

                MessageBox.Show("Se elimino correctamente", "Mensaje");
                mostrarTable("");
            }
            else
            {
                MessageBox.Show("Selecciona la fila que deseas eliminar");
            }
        }
    }
}
