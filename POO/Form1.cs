using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        private List<Profesor> oListaProfesores = new List<Profesor>();

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

        private string ObtenerListaProfesores()
        {
            StringBuilder oCadenas = new StringBuilder();
            oCadenas.AppendLine("Lista de Profesores:\n");

            foreach (var tcProfesor in oListaProfesores)
            {
                oCadenas.AppendLine($"Nombre: {tcProfesor.getNombre()}, Apellidos: {tcProfesor.getApellidos()}, Cédula: {tcProfesor.getCedula()}, Dedicación: {tcProfesor.getDedicacion()}\n");
            }

            return oCadenas.ToString();
        }

        private void btnAceptarProfesor_Click(object sender, EventArgs e)
        {
            string lcNombre = txtNombre.Text.Trim();
            string lcApellidos = txtApellidos.Text.Trim();
            string lcDedicacion = txtDedicacion.Text.Trim();
            int lnCedula;

            if (!string.IsNullOrEmpty(lcNombre) &&
                !string.IsNullOrEmpty(lcApellidos) &&
                !string.IsNullOrEmpty(lcDedicacion) &&
                int.TryParse(txtCedula.Text.Trim(), out lnCedula))
            {
                string lcFechaInicio = txtInicio.Text.Trim();
                string lcFechaFin = txtFinContrato.Text.Trim();
                int lnAniosServicio;

                if (!string.IsNullOrEmpty(lcFechaInicio) && !string.IsNullOrEmpty(lcFechaFin))
                {
                    Contratado oContratado = new Contratado(lcNombre, lcApellidos, lnCedula, lcDedicacion, lcFechaInicio, lcFechaFin);
                    MessageBox.Show(oContratado.Reporte() + $"\nFecha Inicio: {lcFechaInicio} \nFecha Fin: {lcFechaFin}");
                }
                else if (int.TryParse(txtAniosServicio.Text.Trim(), out lnAniosServicio))
                {
                    Ordinario oOrdinario = new Ordinario(lcNombre, lcApellidos, lnCedula, lcDedicacion, lnAniosServicio);
                    MessageBox.Show(oOrdinario.Reporte() + $"\nAños de servicio: {lnAniosServicio}");
                }
                else
                {
                    Profesor oProfesor = new Profesor(lcNombre, lcApellidos, lnCedula, lcDedicacion);
                    MessageBox.Show(Profesor.IncluirProfesor(oListaProfesores, oProfesor));
                    MessageBox.Show(oProfesor.Reporte());
                }
            }
            else
            {
                MessageBox.Show("Por favor, diligencie todos los campos obligatorios.");
            }
        }

        private void btnModificarProfesor_Click(object sender, EventArgs e)
        {
            int cedula;
            if (int.TryParse(txtCedula.Text.Trim(), out cedula))
            { 
                Profesor profesorAModificar = oListaProfesores.FirstOrDefault(p => p.getCedula() == cedula);

                if (profesorAModificar != null)
                { 
                    profesorAModificar.ModificarDatos(txtNombre.Text.Trim(), txtApellidos.Text.Trim(), txtDedicacion.Text.Trim());
                    MessageBox.Show("Datos modificados correctamente.");
                }
                else
                {
                    MessageBox.Show("Profesor no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una cédula válida.");
            }
        }

        private void btnEliminarProfesor_Click(object sender, EventArgs e)
        {
            int cedulaAEliminar;

            if (int.TryParse(txtCedula.Text.Trim(), out cedulaAEliminar))
            {
                string resultado = Profesor.EliminarProfesor(oListaProfesores, cedulaAEliminar);
                MessageBox.Show(resultado);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una cédula válida.");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ObtenerListaProfesores());
        }
    }
}
