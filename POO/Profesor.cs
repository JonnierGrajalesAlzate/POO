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
         public Ordinario oOrdinario;
         public Contratado oContratado; 

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
          
        public static string IncluirProfesor(List<Profesor> oListaProfesores, Profesor oNuevoProfesor)
        {
            oListaProfesores.Add(oNuevoProfesor);
            return("Profesor incluido correctamente.");
        }
         
        public static string EliminarProfesor(List<Profesor> oListaProfesores, int tnCedula)
        {
            Profesor oProfesorAEliminar = oListaProfesores.Find(profesor => profesor.pnCedula == tnCedula);

            if (oProfesorAEliminar != null)
            {
                oListaProfesores.Remove(oProfesorAEliminar);
                return("Profesor eliminado correctamente.");
            }
            else
            {
                return("Profesor no encontrado.");
            }
        }

        public void ModificarDatos(string tcNuevoNombre, string tcNuevosApellidos, string tcNuevaDedicacion)
        {
            pcNombre = tcNuevoNombre;
            pcApellidos = tcNuevosApellidos;
            pcDedicacion = tcNuevaDedicacion; 
        }



        public string Reporte()
        {
            return $"Reporte: Datos Básicos del Profesor:\nNombre: {pcNombre}\nApellidos: " +
                $"{pcApellidos}\nCédula: {pnCedula}\nDedicación: {pcDedicacion}";
        } 
    }
}
