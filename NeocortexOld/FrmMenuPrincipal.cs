using System;
using System.Windows.Forms;

namespace Neocortex
{
    public partial class FrmMenuPrincipal : Form
    {
        //private ucCatalogoUsuario _ucCatalogoUsuario1;
        private ucListaCatalogos _ucListaCatalogos1;
        private ucListaProcesos _ucListaProcesos1;
        public FrmMenuPrincipal()
        {
      
            InitializeComponent();
            _ucListaCatalogos1=new ucListaCatalogos();
            _ucListaProcesos1 = new ucListaProcesos();
            panelSubMenuCatalogo.Visible = false;
        }

        private void MostrarCliente()
        {
            panelContenidoPrincipal.Controls.Clear();
          Datos.DatosCliente.Seleccionar(x =>
          {
              InicializarControl<ucCatalogoUsuario, Entidad.Cliente>(x[0], "ucCatalogoUsuario1");
          });
        }

        private void MostrarCorteDiario()
        {
            panelContenidoPrincipal.Controls.Clear();

            Datos.DatosCorte.Seleccionar(x =>
            {
                InicializarControl<ucCorteDiario, Entidad.Cliente>(x[0], "ucCorteDiario1");

            });
        }

        private T InicializarControl<T,T2>(T2 entidad,string nombre) where T:new()
        {
            var myConstructor = Herramientas.Funcion.CrearConstructor(typeof(T),typeof(T2));
            dynamic uc = (T) myConstructor(entidad);
            uc.Visible = false;
            panelContenidoPrincipal.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.Location = new System.Drawing.Point(688, 33);
            uc.Name = nombre;
            uc.Size = new System.Drawing.Size(608, 579);
            uc.TabIndex = 7;
            uc.BringToFront();
            uc.Visible = true;
            return uc;
        }

        private T InicializarMenu<T>(string nombre) where T : new()
        {
            var myConstructor = Herramientas.Funcion.CrearConstructor(typeof(T));
            dynamic uc = (T)myConstructor(myConstructor);
            uc.Visible = false;
            panelSubMenu.Controls.Add(uc);
            uc.BackColor = System.Drawing.Color.Transparent;
            uc.Dock = DockStyle.Top;
            uc.Location = new System.Drawing.Point(0, 89);
            uc.Name = nombre;
            uc.BringToFront();
            uc.Visible = true;
            uc.Size = new System.Drawing.Size(211, 489);
            uc.TabIndex = 5;
            
            return uc;
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btMaximizar_Click(object sender, EventArgs e)
        {
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

   

        private void btMenuGenerico_Click(object sender, EventArgs e)
        {
            panelSubMenu.Controls.Clear();
            labelMenu.Text = @"Catálogo";
            panelSubMenuCatalogo.Visible = true;
            _ucListaCatalogos1=InicializarMenu<ucListaCatalogos>("ucListaCatalogos1");
            _ucListaCatalogos1.MostrarCliente = MostrarCliente;
        }

        private void btProcesos_Click_1(object sender, EventArgs e)
        {
            panelSubMenu.Controls.Clear();
            panelSubMenuCatalogo.Visible = true;
            labelMenu.Text = @"Procesos";
            _ucListaProcesos1 = InicializarMenu<ucListaProcesos>("ucListaProcesos1");
            _ucListaProcesos1.MostrarCorteDiario =MostrarCorteDiario;
        }

        private void btReportes_Click(object sender, EventArgs e)
        {
            panelSubMenu.Controls.Clear();
            panelSubMenuCatalogo.Visible = true;
            labelMenu.Text = @"Reportes";
           // ucListaProcesos1 = InicializarMenu<ucListaR>("ucListaProcesos1");
           // ucListaProcesos1.MostrarCorteDiario = MostrarCorteDiario;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
        //    panelSubMenuProcesos.Visible = false;
            panelSubMenuCatalogo.Visible = false;
        //    panelSubMenuReportes.Visible = false;
        }

    }
}
