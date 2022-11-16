using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAutobuses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void choferesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChoferes frmChofer = new FormChoferes();
            frmChofer.Show();
        }

        private void autobusesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAutobuses frmAutobus = new FormAutobuses();
            frmAutobus.Show();
        }

        private void rutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRutas frmRuta = new FormRutas();
            frmRuta.Show();
        }

        private void iniciarViajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIniciarViaje frmIniciarViaje = new FormIniciarViaje();
            frmIniciarViaje.Show();
        }

        private void finalizarViajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTerminarViaje frmTerminarViaje = new FormTerminarViaje();
            frmTerminarViaje.Show();
        }
    }
}
