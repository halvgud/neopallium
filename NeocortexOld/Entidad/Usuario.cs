using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neocortex.Entidad
{
  public  class Usuario
    {
        public String usuario { get; set; }
        public String pwd { get; set; }
        public String nombre { get; set; }
        public String materno { get; set; }
        public String paterno { get; set; }
        public String idrol { get; set; }
        public String Respuesta { get; set; }
        public bool FlagRespuesta { get; set; }
        public List<Usuario> Lista { get;set;}
    }
}
