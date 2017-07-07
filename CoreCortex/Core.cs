using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CoreCortex
{
    public class Core
    {
        public class OpcionesDataBase<T>
        {
            public int TipoDeQuery { get; set; }
            public string Query { get; set; }
            public List<T> Lista { get; set; }
            public string MensajeExito { get; set; }
            public string MensajeError { get; set; }
        }
        public class Constante
        {
            public const int ExecuteNonQuery = 1;
            public const int ExecuteReader = 2;
            public const int ExecuteReaderPivot = 3;
            public static string Ruta = "";
            public static string Nombre = "";
            public class Estado
            {
                public int Id { get; set; }
                public string nombre { get; set; }
            }
        }
        public class ParametrosQuery
        {
            public string Parametro { get; set; }
            public string Valor { get; set; }
        }
        public static T EjecutarQuery<T>(OpcionesDataBase<T> odb, List<ParametrosQuery> parametros) where T : new()
        {
            try
            {
                var constructorT = new List<T>();
                using (
                    var con =
                        new MySqlConnection("SERVER = localhost; " + "DATABASE = " +
                                            "neocortex;" + "UID=root;" + "PASSWORD=javac;")) 
                {
                    using (var com = new MySqlCommand(odb.Query, con))
                    {
                        con.Open();
                        com.CommandText = odb.Query;
                        if (parametros != null)
                        {
                            foreach (var parametro in parametros)
                            {
                                com.Parameters.AddWithValue(parametro.Parametro, parametro.Valor);
                            }
                        }
                        switch (odb.TipoDeQuery)
                        {
                            case Constante.ExecuteNonQuery:
                                var resultado = com.ExecuteNonQuery();
                                T texecute = new T();
                                var typeExecute = texecute.GetType();
                                var respuesta = typeExecute.GetProperty("Respuesta");
                                var flagResultado = typeExecute.GetProperty("FlagRespuesta");
                                respuesta.SetValue(texecute, resultado > 0 ? odb.MensajeExito : odb.MensajeError, null);
                                flagResultado.SetValue(texecute, resultado > 0, null);
                                /*var pivote =
                                    new {MensajeRespuesta = resultado > 1 ? odb.MensajeExito : odb.MensajeError};
                                constructorT.Add((T) Convert.ChangeType(pivote, typeof (T)));*/
                                con.Close();
                                return texecute;
                            case Constante.ExecuteReader:
                                T t2 = new T();
                                using (var reader = com.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        T t = new T();

                                        for (int inc = 0; inc < reader.FieldCount; inc++)
                                        {
                                            var type = t.GetType();
                                            var prop = type.GetProperty(reader.GetName(inc));
                                            prop.SetValue(t, reader.GetValue(inc), null);
                                        }
                                        constructorT.Add(t);
                                    }

                                    var type2 = t2.GetType();
                                    var prop2 = type2.GetProperty("Lista");
                                    prop2.SetValue(t2, constructorT, null);
                                    con.Close();
                                }
                                return t2;
                               
                            case Constante.ExecuteReaderPivot:
                                T t3 = new T();
                                using (var reader = com.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        T t = new T();

                                        for (int inc = 0; inc < reader.FieldCount; inc++)
                                        {
                                            var type = t.GetType();
                                            var prop = type.GetProperty(reader.GetName(inc));
                                            prop.SetValue(t, reader.GetValue(inc), null);
                                        }
                                        constructorT.Add(t);
                                    }

                                    var type2 = t3.GetType();
                                    var prop2 = type2.GetProperty("Lista");
                                    prop2.SetValue(t3, constructorT, null);
                                    con.Close();
                                }
                                return t3;

                        } //switch
                        return new T();
                    }

                    // Close the connection to the database
                }
            }
            catch (Exception e)
            {
              //  MessageBox.Show(e.Message);
                return new T();
            }
        }
    }
}
