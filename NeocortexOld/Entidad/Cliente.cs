using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neocortex.Entidad
{
    public class Cliente
    {
        public Int32 Codigo { get; set; }
        public String Nombre { get; set; }
        public String Representante { get; set; }
        public String Rfc { get; set; }
        public String Curp { get; set; }
        public String Domicilio { get; set; }
        public String NumeroExt { get; set; }
        public String NumeroInt { get; set; }
        public String Colonia { get; set; }
        public String CodigoPostal { get; set; }
        public String Localidad { get; set; }
        public String Municipio { get; set; }
        public String Estado { get; set; }
        public String Telefono { get; set; }
        public String TelefonoMovil { get; set; }
        public String RutaId { get; set; }
        //public Int32 CondicionPagoId { get; set; }
        public Double LimiteCredito { get; set; }
        public Int32  DiasCredito { get; set; }
        public String Email { get; set; }

    }
}
