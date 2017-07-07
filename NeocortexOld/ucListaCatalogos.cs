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
    public partial class ucListaCatalogos : UserControl
    {
        public  Action MostrarCliente;
        public ucListaCatalogos()
        {
            InitializeComponent();
        }

        private void btCorteDiario_Click(object sender, EventArgs e)
        {
            MostrarCliente();
        }
    }
}
