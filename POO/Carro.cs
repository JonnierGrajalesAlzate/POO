using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Carro
    {
        //Atributos
        //Private para que esos atributos solo sean accesibles desde la misma clase
        private string pcMatricula;
        private string pcModelo;
        private double pnPotenciaCV;

        //Constructor
        public Carro(string tcMat, string tcMod, double tnPot) 
        {
            pcMatricula = tcMat;
            pcModelo = tcMod;
            pnPotenciaCV = tnPot; 
        }

        public Carro(string tcMat, string tcMod)
        {
            pcMatricula = tcMat;
            pcModelo = tcMod;
        }
        public Carro(string tcMat)
        {
            pcMatricula = tcMat;
        }


        //Metodos Get 
        public string getMatricula()
        {
            return pcMatricula;
        }
        public string getModelo()
        {
            return pcModelo;
        }
        public double getPotencia()
        {
            return pnPotenciaCV;
        }
    }
}
