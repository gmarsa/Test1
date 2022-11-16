using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class Persona
    {
        private string nombre;
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        private int edad;
        public int  Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }
        private string dni;
        public string DNI
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        public Persona(string nombre, int edad, string dni)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
        }

    public void Mostrar(string nombre,int edad, string dni)
        {
            Console.WriteLine(nombre);
            Console.WriteLine(edad);
            Console.WriteLine(dni);

        }
        public Persona()
        {

        }

        public void esMayor(int edad)
        {
            if (edad>=18)
            {
                Console.WriteLine("Es mayor de edad.");
            }
            else
            {
                Console.WriteLine("Es menor de edad.");
            }
        }


        
    }
    


}
