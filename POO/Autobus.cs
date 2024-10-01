using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Autobus : Carro
    {
        //Atributos
        //Private para que esos atributos solo sean accesibles desde la misma clase
        private int pnNumeroPlazas;


        //Constructor
        public Autobus(string tcMat, string tcMod, double tnPot, int tnNPla) : base(tcMat, tcMod, tnPot)
        {
            pnNumeroPlazas = tnNPla;
        }

        //Método Set
        public void setNumeroPlazas(int tnNumeroPlazas)
        {
            pnNumeroPlazas = tnNumeroPlazas;
        }

        //Método Get
        public int getNumeroPlazas()
        {
            return pnNumeroPlazas;
        }
    }
}
