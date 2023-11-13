using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpCafeteria
{
    public partial class FrmAutenticacion : Form
    {
        public FrmAutenticacion()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBienvenido bienvenido = new FrmBienvenido();
            bienvenido.ShowDialog();
            FrmPrincipal form = new FrmPrincipal();
            form.Show();
            this.Hide();
        }
    }
}
