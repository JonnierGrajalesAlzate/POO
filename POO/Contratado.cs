using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Contratado : Profesor
    {
        //Atributos
        private string pcFechaIngreso;
        private string pcFechaFinContrato;

        //Constructor
        public Contratado(string tcNom, string tcApe, int tnCed, 
            string tcDed, string tcfIni,string tcfFin) : base(tcNom, tcApe, tnCed, tcDed)
        {
            pcFechaIngreso = tcfIni;
            pcFechaFinContrato = tcfFin;
        }

        //Métodos Set
        public void setFechaInicio(string tcFIni)
        {
            pcFechaIngreso = tcFIni;
        }

        public void setFechaFin(string tcFin)
        { 
            pcFechaFinContrato = tcFin;
        }

        //Métodos Get
        public string getFechaInicio()
        {
            return pcFechaIngreso;
        }
        public string getFechaFinContrato()
        {
            return pcFechaFinContrato;
        }

    }
}
