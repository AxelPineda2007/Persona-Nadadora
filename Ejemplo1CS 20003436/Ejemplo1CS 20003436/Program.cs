using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1CS_20003436
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciar o crear objeto
            Persona Personal = new Persona("Verdes", "187", "85", "V");
            Console.WriteLine("Descripción de la persona: ");
            Console.WriteLine("Ojos:"+ Personal.Ojos);
            Console.WriteLine("Altura:" + Personal.Altura);
            Console.WriteLine("Peso:" + Personal.Peso);
            Console.WriteLine("Sexo:" + Personal.Sexo);

            Personal.Hablar("Me llamo Borja");
            Console.WriteLine("Color de mis ojos:" + Personal.Ojos);
            Personal.correr(1000);
            Console.WriteLine("Mi peso actual es:" + Personal.Peso);

            
        }
        
    }
}
