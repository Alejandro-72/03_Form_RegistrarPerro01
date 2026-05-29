using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _03_Form_RegistrarPerro01
{
    internal class Perro
    {
        private string nombre;
        private string raza;
        private string altura;

        public Perro(string nombre, string raza, string altura)
        {
            this.nombre = nombre;
            this.raza = raza;
            this.altura = altura;
        }
        public string GetNombre() { return nombre; }
        public string GetRaza() { return raza; }
        public string GetAltura() { return raza; }

        public void SetNombre(string nombre) { this.nombre = nombre;}
        public void SetRaza(string raza) { this.raza = raza;}
        public void SetAltura(string altura) { this.altura = altura;}

        public override string ToString()
        {
            return $"{nombre}\t{raza}\t{altura}";
        }
    }
}
