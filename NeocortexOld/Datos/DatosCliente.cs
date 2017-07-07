using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neocortex.Herramientas;
using RestSharp;


namespace Neocortex.Datos
{
    internal class DatosCliente
    {
        public static void Lista(Action<IRestResponse> callback, ProisoCortex.Usuario f1)
        {
            try
            {
                var rest = new Rest("http://localhost:8080", "/api/usuario/", Method.POST);
                rest.Peticion.AddHeader(Constantes.Http.ObtenerTipoDeContenido, Constantes.Http.TipoDeContenido.Json);
                rest.Peticion.AddJsonBody(f1);
                rest.Cliente.ExecuteAsync(rest.Peticion,callback);
            }
            catch (Exception e)
            {
                // Opcion.Log(Log.Interno.Categoria, "EXCEPCION: " + e.Message);
                // callback("CONTINUAR");
            }
        }
        public static void Seleccionar(Action<List<Entidad.Cliente>> callback)
        {
            try
            {
                var listaCliente = new List<Entidad.Cliente>
                {
                    new Entidad.Cliente
                    {
                        Nombre = "EDWIN JESUS GARCIA GALLEGOS",
                        Codigo = 1,
                        CodigoPostal = "33010",
                        Colonia = "Carmen Serdan",
                        Curp = "GAGE910718HCHRLD03",
                        DiasCredito = 15,
                        Domicilio = "Calle 2da Ote",
                        Email = "ed@live.no",
                        Estado = "Chihuahua",
                        LimiteCredito = 1500,
                        NumeroExt = "709",
                        NumeroInt = "",
                        Representante = "",
                        Rfc = "GAGE910718UT3",
                        RutaId = "1",
                        Telefono = "6391166494",
                        TelefonoMovil = "6391166494",
                        Localidad = "Delicias",
                        Municipio = "Delicias"
                    }
                };
                callback(listaCliente);
            }
            catch (Exception e)
            {
                // Opcion.Log(Log.Interno.Categoria, "EXCEPCION: " + e.Message);
                // callback("CONTINUAR");
            }
        }
    }
}
