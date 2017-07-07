using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace Neocortex
{
    public partial class ucCatalogoUsuario : UserControl
    {
        private Entidad.Cliente _cliente;
        public ucCatalogoUsuario(Entidad.Cliente cliente)
        {
            _cliente = cliente;
            InitializeComponent();
            InicializarControles();

        }
        public ucCatalogoUsuario()
        {
        //    _cliente = cliente;
            InitializeComponent();
            InicializarControles();

        }

        private void InicializarControles()
        {
            foreach (var prop in _cliente.GetType().GetProperties())
            {
                if(prop.GetValue(_cliente, null) != null) { 
                    var resultado = prop.GetValue(_cliente,null).ToString();
                    var bunifuMaterialTextbox = this[prop.Name] as BunifuMetroTextbox;
                    if (bunifuMaterialTextbox != null)
                    {
                       bunifuMaterialTextbox.Text = resultado;
                    }
                }
            }
        }   

        public object this[string propertyName]
        {
            get { return this.GetType().GetField(propertyName).GetValue(this); }
            set { this.GetType().GetField(propertyName).SetValue(this, value); }
        }

        private void ucCatalogoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
