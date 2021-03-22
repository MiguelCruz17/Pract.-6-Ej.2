using System;

namespace Pract._6_Ej._2
{
    #region Detalles del Programa
    
    /*2.    Crear una clase Contacto. Esta clase deberá tener los atributos "nombre, apellidos, telefono y direccion". 
    También deberá tener un método "SetContacto", de tipo void y con los parámetros string, que permita cambiar el valor 
    de los atributos. También tendrá un método "Saludar", que escribirá en pantalla "Hola, soy " seguido de sus datos. Crear 
    también una clase llamada ProbarContacto. Esta clase deberá contener sólo la función Main, que creará dos objetos de tipo 
    Contacto, les asignará los datos del contacto y les pedirá que saluden.*/

    #endregion
    public class Contacto
    {

        private string nombre_a;
        private string apellido_a;
        private ulong telefono_a;
        private string direccion_a;

        public string nombre
        {

            get { return nombre_a; }
            set { nombre_a = value; }
        }
        public string apellido
        {
            get { return apellido_a; }
            set { apellido_a = value; }
        }
        public ulong telefono
        {
            get { return telefono_a; }
            set { telefono_a = value; }
        }
        public string direccion
        {
            get { return direccion_a; }
            set { direccion_a = value; }
        }

        public Contacto(string pNombre, string pApellido, ulong pTelefono, string pDireccion)
        {

            nombre = pNombre;
            apellido = pApellido;
            telefono = pTelefono;
            direccion = pDireccion;
        }
        public void SetContacto(string sNombre, string sApellido, ulong sTelefono, string sDireccion)
        {
            nombre = sNombre;
            apellido = sApellido;
            telefono = sTelefono;
            direccion = sDireccion;
        }
        public String Saludar = "Hola soy";
        
        class ProbarContacto
        {
            static void Main(string[] args)
            {
                Contacto aContacto = new Contacto("Marcos", "Liberata", 8095847894, "Barrio Nuevo, Villa Mella, Calle Proyecto Casa no. 65");
                Contacto aContacto1 = new Contacto("Miguel", "Cruz", 8095847111, "Barrio Nuevo, Villa Mella, Calle Proyecto Casa no. 66");

                Console.WriteLine("\nClase Contacto\n");
                Console.WriteLine(aContacto.Saludar);
                Console.WriteLine("Nombre: {0}", aContacto.nombre);
                Console.WriteLine("Apellido: {0}", aContacto.apellido);
                Console.WriteLine("Teléfono: {0}", aContacto.telefono);
                Console.WriteLine("Dirección: {0}", aContacto.direccion);
                Console.WriteLine("\n*****************************************************************");
                Console.WriteLine("");
                Console.WriteLine(aContacto.Saludar);
                Console.WriteLine("Nombre: {0}", aContacto1.nombre);
                Console.WriteLine("Apellido: {0}", aContacto1.apellido);
                Console.WriteLine("Teléfono: {0}", aContacto1.telefono);
                Console.WriteLine("Dirección: {0}", aContacto1.direccion);
            }
        }
    }
}


