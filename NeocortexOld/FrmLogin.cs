using System;
using System.Net;
using System.Windows.Forms;
using ProisoCortex;

namespace Neocortex
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            fader.Start();
        }

        private int x = 0;

        private bool bandera = true;
        private void fader_Tick(object sender, EventArgs e)
        {

          /*  for (var x = 0; x == 100; x++)
            {*/
                bunifuColorTransition1.ProgessValue = x;
                this.BackColor = bunifuColorTransition1.Value;
                if (x <100 && bandera)
                {
                    x++;
                }
            else
            {
                x--;
                bandera = false;
                if (x == 1)
                {
                    bandera = true;
                    x++;
                }
            }

            /* }*/
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            Datos.DatosCliente.Lista(response =>
            {
                BeginInvoke((Action)(() =>
                {
                    switch (response.StatusCode)
                    {
                        case HttpStatusCode.OK:
                            var frm = new FrmMenuPrincipal();
                            frm.Show();
                            Hide();
                            break;
                        default:
                            MessageBox.Show(@"no no no no entres ahi");
                            break;
                    }
                }));
               
            },new Usuario {idusuario=txtUsuario.Text,pwd=txtPassword.Text});
          
           // frm.BringToFront();
           // this.Close();
        }
    }
}
