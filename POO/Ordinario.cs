using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Ordinario : Profesor
    {
        //Atributo
        private int pnAniosServicio;

        //Constructor
        public Ordinario(string tcNom, string tcApe, int tnCed, string tcDed, int tnAnios): base(tcNom,tcApe,tnCed,tcDed)
        {
            pnAniosServicio = tnAnios;
        }

        //Método Set
        public void setAniosServicio(int tnAni)
        {
            pnAniosServicio = tnAni;
        }

        //Método Get
        public int getAniosServicio()
        {
            return pnAniosServicio;
        }
       
    }
}
