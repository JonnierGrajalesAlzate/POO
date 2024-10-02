using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Jonnier Grajales Alzate
 01/10/2024
OOP*/

namespace POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviarCarro_Click(object sender, EventArgs e)
        { 
            string lcMatricula = txtMatricula.Text;
            string lcModelo = txtModelo.Text; 
            double lnPotenciaCV;
            int lnNLicencia;
            int lnNPlazas; 

            if (!string.IsNullOrEmpty(lcMatricula) &&
                !string.IsNullOrEmpty(lcModelo) &&
                double.TryParse(txtPotenciaCaballos.Text, out lnPotenciaCV))
            {
                 
                bool llPlazas = int.TryParse(txtNumeroPlazas.Text, out lnNPlazas); 
                bool llLicencia = int.TryParse(txtNumeroLicencia.Text, out lnNLicencia);
                 
                if (llPlazas && !llLicencia)
                {
                    Autobus oBus = new Autobus(lcMatricula, lcModelo, lnPotenciaCV, lnNPlazas);
                    MessageBox.Show($"Características Autobús: \nMatricula: {lcMatricula} \nModelo: {lcModelo} \nPotenciaCv: {lnPotenciaCV} \n#Plazas: {lnNPlazas}");
                } 
                else if (llLicencia && !llPlazas)
                {
                    Taxi oTaxi = new Taxi(lcMatricula, lcModelo, lnPotenciaCV, lnNLicencia);
                    MessageBox.Show($"Características Taxi: \nMatricula: {lcMatricula} \nModelo: {lcModelo} \nPotenciaCv: {lnPotenciaCV} \n#Licencia: {lnNLicencia}");
                } 
                else if (llLicencia && llPlazas)
                {
                    Autobus oBus = new Autobus(lcMatricula, lcModelo, lnPotenciaCV, lnNPlazas);
                    MessageBox.Show($"Características Autobús: \nMatricula: {lcMatricula} \nModelo: {lcModelo} \nPotenciaCv: {lnPotenciaCV} \n#Plazas: {lnNPlazas}");
                } 
                else
                {
                    Carro oCarro = new Carro(lcMatricula, lcModelo, lnPotenciaCV);
                    MessageBox.Show($"Características Carro: \nMatricula: {lcMatricula} \nModelo: {lcModelo} \nPotenciaCv: {lnPotenciaCV}");
                }
            }
            else
            { 
                MessageBox.Show("Por favor, diligencie todos los campos obligatorios.");
            }
        }

        private void btnAceptarProfesor_Click(object sender, EventArgs e)
        {
            // Obtener los valores obligatorios de la clase Profesor
            string lcNombre = txtNombre.Text.Trim();
            string lcApellidos = txtApellidos.Text.Trim();
            string lcDedicacion = txtDedicacion.Text.Trim();

            int lnCedula;

            // Verificar que los campos obligatorios no estén vacíos y que la cédula sea un número válido
            if (!string.IsNullOrEmpty(lcNombre) &&
                !string.IsNullOrEmpty(lcApellidos) &&
                !string.IsNullOrEmpty(lcDedicacion) &&
                int.TryParse(txtCedula.Text.Trim(), out lnCedula))
            {
                // Crear el objeto Profesor base
                Profesor oProfesor = new Profesor(lcNombre, lcApellidos, lnCedula, lcDedicacion);
                MessageBox.Show($"Datos Docente : \nNombre: {lcNombre} \nApellidos: {lcApellidos} \nCédula: {lnCedula} \nDedicación: {lcDedicacion}");

                // Campos adicionales para determinar si es un Profesor Contratado o Ordinario
                string lcFechaInicio = txtInicioContrato.Text.Trim();
                string lcFechaFin = txtFinContrato.Text.Trim();
                int lnAniosServicio;

                // Verificar si es un Profesor Contratado (basado en las fechas de contrato)
                if (!string.IsNullOrEmpty(lcFechaInicio) && !string.IsNullOrEmpty(lcFechaFin))
                {
                    // Crear el objeto Profesor Contratado
                    Contratado oContratado = new Contratado(lcNombre, lcApellidos, lnCedula, lcDedicacion, lcFechaInicio, lcFechaFin);
                    MessageBox.Show($"Datos Profesor Contratado : \nNombre: {lcNombre} \nApellidos: {lcApellidos} \nCédula: {lnCedula} \nDedicación: {lcDedicacion} \nFecha Inicio: {lcFechaInicio} \nFecha Final: {lcFechaFin}");
                }
                // Verificar si es un Profesor Ordinario (basado en los años de servicio)
                else if (int.TryParse(txtAniosServicio.Text.Trim(), out lnAniosServicio))
                {
                    // Crear el objeto Profesor Ordinario
                    Ordinario oOrdinario = new Ordinario(lcNombre, lcApellidos, lnCedula, lcDedicacion, lnAniosServicio);
                    MessageBox.Show($"Datos Profesor Ordinario : \nNombre: {lcNombre} \nApellidos: {lcApellidos} \nCédula: {lnCedula} \nDedicación: {lcDedicacion} \nAños de servicio: {lnAniosServicio}");
                }
                // Si no cumple con las condiciones de Contratado u Ordinario, mostrar mensaje de error
                else
                {
                    MessageBox.Show("Por favor, complete los campos adicionales para determinar si es un Profesor Contratado o Ordinario.");
                }
            }
            else
            {
                // Mostrar mensaje de error si los campos obligatorios no se han llenado correctamente
                MessageBox.Show("Por favor, diligencie todos los campos obligatorios para crear un Profesor.");
            }
        }

    }
}
