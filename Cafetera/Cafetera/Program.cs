
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafetera
{
    internal class Cafetera
    {
        private int capacidadMax;
        public int CapacidadMax
        {
            get { return this.capacidadMax; }
            set { this.capacidadMax = value; }
        }
        private int capacidadAct;
        public int CapacidadAct
        {
            get { return this.capacidadAct; }
            set { this.capacidadAct = value; }
        }

        public Cafetera(int capacidadMax, int capacidadAct)
        {
            CapacidadMax = capacidadMax;

            CapacidadAct = capacidadAct;
            capacidadAct = 0;
            capacidadMax = 1000;
        }

        public void llenar(int capacidadMax,int capacidadAct)
        {
            capacidadAct = capacidadMax;
            Console.WriteLine("Cafetera llenada correctamente");
        }

        public int servirTaza(int capacidadAct)
        {
            int taza = 0;
            taza = Int32.Parse(Console.ReadLine());

            if (taza <= capacidadAct)
            {
                capacidadAct = capacidadAct - taza;
                return capacidadAct;
                Console.WriteLine("Taza servida");
            }
            else if (taza > capacidadAct)
            {
                taza = capacidadAct;
                return capacidadAct = 0;
                Console.WriteLine("Cantidad insuficiente, taza servida a medias.");
            }
            else
            {
                return capacidadAct;
            }

        }

        public void vaciar(int capacidadAct)
        {
            capacidadAct =0 ;
            Console.WriteLine("Cafetera vaciada");
        }

        public int agregarCafe(int capacidadAct,int capacidadMax)
        {
            int agregar=0;
            agregar = Int32.Parse(Console.ReadLine());
            if(agregar>capacidadMax || agregar > (capacidadMax - capacidadAct))
            {
                Console.WriteLine("Error, estas añadiendo demasiado café.");
                return capacidadAct;
            }
            else
            {
                capacidadAct = capacidadAct + agregar;
                return agregar;
                Console.WriteLine("Café añadido.");
            }


        }

    }



}
