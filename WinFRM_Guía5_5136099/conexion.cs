using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFRM_Guía5_5136099
{
    class conexion
    {
        //Parámetros para la cadena de conxión
        public string servidor, usuario, clave, db;
        public string cadena;
        //Función que tendrá la cadena de conexión
        public void conec()
        {
            servidor = "DESKTOP-R518KSR\\SQLEXPRESS";
            usuario = "VirusZ";
            clave = "inefable";
            db = "DB_Avanzada";
            cadena = "server=" + servidor + ";uid=" + usuario + ";pwd=" + clave + ";database= " + db;
        }
    }
}
