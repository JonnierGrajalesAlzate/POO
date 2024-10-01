using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Taxi : Carro
    {
        //Atributos
        //Private para que esos atributos solo sean accesibles desde la misma clase
        private int pnNumeroLicencia;

        //Constructor
        public Taxi(string tcMat, string tcMod, double tnPot, int tnNLic):base(tcMat,tcMod,tnPot)
        {
            pnNumeroLicencia = tnNLic;
        }

        //Método Set
        public void setNumeroLicencia(int tnNumeroLicencia)
        {
            pnNumeroLicencia = tnNumeroLicencia;
        }
        //Método Get
        public int getNumeroLicencia()
        {
            return pnNumeroLicencia;
        }

    }
}
