using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using ProisoCortex;

namespace CoreCortex
{
    public class UsuarioController : ApiController
    {
       

        public IEnumerable<Usuario> Get()
        {
            var dtDo2 = new Core.OpcionesDataBase<Usuario>
            {
                TipoDeQuery = Core.Constante.ExecuteReader,
                MensajeError = "Error al cargar usuarios",
                Query = "select * from usuario"
            };
            return Core.EjecutarQuery<Usuario>(dtDo2, null).Lista;
            //    return contacts;
        }
        public IEnumerable<Usuario> Post(Usuario contact)
        {
            var parametros = new List<Core.ParametrosQuery>
            {
                new Core.ParametrosQuery {Parametro = "@user", Valor = contact.idusuario},
                new Core.ParametrosQuery {Parametro = "@pwd", Valor = contact.pwd}
            };
            var dtDo2 = new Core.OpcionesDataBase<Usuario>
                    {
                        TipoDeQuery = Core.Constante.ExecuteReader,
                        MensajeError = "Error al cargar usuarios",
                        Query = "select * from usuario where idusuario=@user and pwd=@pwd"
                    };
            return Core.EjecutarQuery<Usuario>(dtDo2, parametros).Lista;

        }
        /*
        public usuario Get(int id)
        {
            var product = contacts.FirstOrDefault((p) => p.usuario == id);
            if (product == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return product;
        }

        public IEnumerable<Contact> GetContactsByCountry(string country)
        {
            return contacts.Where(p => string.Equals(p.Country, country,
                    StringComparison.OrdinalIgnoreCase));
        }*/
    }
}
