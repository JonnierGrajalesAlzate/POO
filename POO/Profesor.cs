using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Profesor
    {
        //Atributos
        private string pcNombre;
        private string pcApellidos;
        private int pnCedula;
        private string pcDedicacion;

        //Constructor
        public Profesor(string tcNom, string tcApe, int tnCed, string tcDed)
        {
            pcNombre = tcNom;
            pcApellidos = tcApe;
            pnCedula = tnCed;
            pcDedicacion = tcDed;
        }

        //Métodos Get
        public string getNombre()
        {
        return pcNombre;
        }
        
        public string getApellidos()
        {
            return pcApellidos;
        }
        public int getCedula()
        {
            return pnCedula;
        }
        public string getDedicacion()
        {
            return pcDedicacion;
        }

        //Otros Métodos
        /*Inclusion, elimacion, modificacion, reportes1, reportes2*/
    }
}
