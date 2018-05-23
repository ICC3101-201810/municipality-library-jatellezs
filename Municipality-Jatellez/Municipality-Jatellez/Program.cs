using System;
using System.Reflection;
using System.Linq;
using System.IO;
using System.Text;

namespace Municipality_Jatellez
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            path += "\\ClassLibrary1.dll";
            Assembly a = Assembly.LoadFrom(path);
            foreach (Type b in a.GetTypes())
            {
                Console.WriteLine(b.FullName);
                PropertyInfo[] properties = b.GetProperties();
                MethodInfo[] info = b.GetMethods();

            }
            Console.WriteLine("Que desea hacer?\n(1) Agregar Personas\n(2) Agregar Propiedades\n(3) Agregar Automoviles");
            int opcion = Convert.ToInt32(Console.ReadLine());
            while(opcion < 1 || opcion > 3)
            {
                Console.WriteLine("Que desea hacer?\n(1) Agregar Personas\n(2) Agregar Propiedades\n(3) Agregar Automoviles");
                opcion = Convert.ToInt32(Console.ReadLine());
            }

            if(opcion == 1)
            {
                Console.WriteLine("Ingrese el nombre de la persona: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido de la persona: ");
                string apellido = Console.ReadLine();
                Console.WriteLine("Ingrese la fecha de nacimiento de la persona: ");
                DateTime nacimiento = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Ingrese el alma mater de la persona: ");
                string alma = Console.ReadLine();
                Console.WriteLine("Ingrese la educacion de la persona: ");
                string educacion = Console.ReadLine();
                Console.WriteLine("Ingrese el rut de la persona: ");
                string rut = Console.ReadLine();

                
            }

            Console.ReadLine();
        }
    }
}
