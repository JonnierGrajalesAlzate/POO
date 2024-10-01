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
          

    }
}
