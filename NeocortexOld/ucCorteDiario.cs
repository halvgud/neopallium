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
    public partial class ucCorteDiario : UserControl
    {
        public ucCorteDiario()
        {
            InitializeComponent();
        }

        private Entidad.Cliente _cliente;
        public ucCorteDiario(Entidad.Cliente cliente)
        {
            _cliente = cliente;
            InitializeComponent();
          //  InicializarControles();

        }
        private void superTabControl1_SelectedTabChanged(object sender, DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs e)
        {

        }
    }
}
