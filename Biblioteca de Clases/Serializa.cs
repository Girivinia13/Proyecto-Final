using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Biblioteca_de_Clases
{
    public static class Serializa<T> where T : class
    {        
        // ---------------------- XML -----------------------------
        public static void EscribirXml(List<T> lista, string path)
        {

            using StreamWriter sw = new (path);
            XmlSerializer ser = new (typeof(List<T>));
            ser.Serialize(sw, lista);            
        }
                
        public static List<T> LeerXml(string path)
        {
            List<T> lista;

            using (StreamReader sr = new (path))
            {
                XmlSerializer ser = new (typeof(List<T>));
                lista = ser.Deserialize(sr) as List<T>;
            }
            return lista;
        }

        // ---------------------- TXT -----------------------------
        public static void EscribirTxt(List<T> lista, string path)
        {
            using StreamWriter sw = new(path);
            sw.Write(lista);
        }

        public static List<T> LeerTxt(string path)
        {
            List<T> lista;

            using StreamReader sr = new(path);
            lista = sr.ReadToEnd() as List<T>;
           
            return lista;
        }
    }
}
