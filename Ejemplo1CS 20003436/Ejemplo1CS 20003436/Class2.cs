using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1CS_20003436
{
    internal class Persona
    {
        public Persona(string ojos, string altura, string peso, string sexo) {
            this.Ojos = ojos;
            this.Altura = altura;
            this.Peso = peso;
            this.Sexo = sexo;
        }
        public string Ojos;
        public string Altura;
        public string Peso;
        public string Sexo;

        public void Hablar(string texto)
        {
            Console.WriteLine("Voy a decir:" + texto);
        }
        public void Comer(double calorias)
        {
            Console.WriteLine("Ganando" + calorias + "Calorias");
            this.Peso += calorias / 1000;
        }
        public void correr(double calorias)
        {
            Console.WriteLine("Perdiendo" + calorias + "calorias");
            this.Peso = Convert.ToString(calorias / 1000);
        }
         
}
            }
public class PersonaNadadodora
{
    public PersonaNadadora(string ojos, string altura, string peso, string sexo) { }

    public void Nadar()
    {
        Console.WriteLine("Nadando para volver al peso ideal");
        this.Peso = "85";
   }
}





