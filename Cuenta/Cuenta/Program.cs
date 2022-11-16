
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    internal class Cuenta
    {
        private string titular;
        public string Titular
        {
            get { return this.titular; }
            set { this.titular = value; }
        }
        private double cantidad;
        public double Cantidad
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }
            
        public Cuenta(string titular, double cantidad)
        {
            Titular = titular;
            Cantidad = cantidad;
        }

        public void Mostrar(string titular, double cantidad)
        {
            Console.WriteLine(titular);
            Console.WriteLine(cantidad);
           

        }

        public void ingresar( double cantidad)
        {
            int ingreso=0;
            ingreso =Int32.Parse(Console.ReadLine());

            if (ingreso < 0){
                Console.WriteLine("Ingreso no efectuado, introduzca un numero válido.");
            }else if (ingreso>=0)
            {
                cantidad = cantidad + ingreso;
                Console.WriteLine("Su ingreso se ha efectuado correctamente.");
            }
        }

        public void retirar(double cantidad)
        {
            int retiro=0;
            retiro = Int32.Parse(Console.ReadLine());

            if (cantidad<retiro)
            {
                Console.WriteLine("Atención, saldo insuficiente.");
            }else if(cantidad>retiro && cantidad > 0)
            {
                cantidad=cantidad - retiro;
                Console.WriteLine("Se ha retirado el dinero correctamente.");
            }
        }

    }



}