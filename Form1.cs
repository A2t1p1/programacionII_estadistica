using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programacionII_estadistica
{
    public partial class Form1 : Form
    {
        Estadistica Objestadistica = new Estadistica();

        public Form1()
        {
            InitializeComponent();
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            //split divide una cadena en base a un delimitador(patron) y devuelve tipo matriz
            lblrespuesta.Text = "X=" + Objestadistica.Media(txtserie.Text.Split(','));

        }

        private void btncalculartipica_Click(object sender, EventArgs e)
        {
            lblrespuesta.Text = "Estandar=" + Objestadistica.Media(txtserie.Text.Split(','));
        }

        private void btncalcularestandar_Click(object sender, EventArgs e)
        {
            lblrespuesta.Text = "Tipica=" + Objestadistica.Media(txtserie.Text.Split(','));
        }
    }
}
