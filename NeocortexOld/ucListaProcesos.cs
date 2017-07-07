using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neocortex
{
    public partial class ucListaProcesos : UserControl
    {
        public ucListaProcesos()
        {
            InitializeComponent();
        }
        public Action MostrarCorteDiario;


        private void btCorte_Click(object sender, EventArgs e)
        {
            FormCorteCaja frm = new FormCorteCaja();
            frm.Show();
        }

        private void btCorteDiario_Click(object sender, EventArgs e)
        {
            MostrarCorteDiario();
        }
    }
}
