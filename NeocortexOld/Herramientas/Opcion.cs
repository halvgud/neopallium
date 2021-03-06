﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace Neocortex.Herramientas
{
    public class Opcion
    {

        /// <summary>
        /// Función que realiza la escritura de mensajes a un archivo
        /// </summary>
        /// <param name="archivo">Archivo a generar</param>
        /// <param name="mensaje">Mensaje a escribir en archivo</param>
        /// <remarks></remarks>
        public static void Log(string archivo, string mensaje)
        {
            //variable que inicializa el streamwriter
            var txtMirror = default(StreamWriter);
            try
            {
                //si no existe, se crea
                txtMirror = new StreamWriter(archivo, true);
                txtMirror.WriteLine(DateTime.Now.ToLocalTime() + "::" + mensaje);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                txtMirror?.Close();
            }
        }

        public static List<T> JsonaListaGenerica<T>(IRestResponse json)
        {
            List<T> x = new List<T>();
            try
            {
                var desSerializer = new JsonDeserializer();
                x = desSerializer.Deserialize<List<T>>(json);
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return x;
            }
        }

        public static string JsonaString(string json)
        {
            dynamic myObject = JsonConvert.DeserializeObject<dynamic>(json);
            dynamic mensaje = myObject.message ?? myObject.mensaje;
            return Convert.ToString(mensaje);
        }


        public static void EjecucionAsync(Action<Action<IRestResponse>> accionInicial, Action<IRestResponse> accionFinal)
        {
            accionInicial(accionFinal);
        }
        public static void EjecucionAsync(Action<Action<IRestResponse>> accionInicial, Action<Action<IRestResponse>> accionFinal, Action<IRestResponse> callback)
        {
            accionInicial(x =>
            {
                accionFinal(callback);
            });
        }
   

        public static void BorrarDataGridView(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Refresh();
        }
        public static bool ValidarDouble(Control text)
        {
            var regex = new System.Text.RegularExpressions.Regex(@"^[0-9]*(?:\.[0-9]*)?$");
            if (!regex.IsMatch(text.Text))
            {
                text.Text = "";
                return false;
            }
            return true;
        }
        public static bool ValidarCaracter(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                return true;
            }
            return false;
        }
        private void LimpiarControles(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c.HasChildren)
                {
                    LimpiarControles(c);
                }
                else if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else if (c is CheckBox)
                {

                    ((CheckBox)c).Checked = false;
                }

                else if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
            }
        }
    }
}
