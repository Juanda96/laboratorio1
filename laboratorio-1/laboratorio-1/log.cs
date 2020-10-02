using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logGenerator
{
    class log
    {
        private string path = "";

        public log()
        {
            this.path = @"c:/ temp / log / laboratorio1.txt";
        }

        private string nombreArchivo()
        {
            String nombre = "";
            nombre = "log" + DateTime.Now.Year + "" + DateTime.Now.Day + ".txt";
            return nombre;
        }

        private void directorio()
        {

            try
            {
                if (!Directory.Exists(this.path))
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch (Exception x)
            {
                throw new Exception(x.Message);
            }
        }
        public void agregarLog(string evento)
        {

            try
            {
                directorio();
                string nombre = nombreArchivo();
                string cadena = "";
                cadena += "Hora del evento: " + DateTime.Now + "Situación generada: " + evento + Environment.NewLine;
                StreamWriter sw = new StreamWriter(this.path + "/" + nombre, true);
                sw.Write(cadena);
                sw.Close();
            }
            catch (Exception)
            {

                throw;
            }
            /*finally 
            {
                sw.Close();
            }
            */

        }
    }
}
