using Ejercicio_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        DepartamentoVehicular departamento = new DepartamentoVehicular();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string Dni = null;
            string nombre = null;
            string Patente;
            Persona actual;
            try
            {
                Dni = tbDni.Text;
                nombre = tbNombre.Text;
                Patente = tbPatente.Text;
                actual = new Persona(Dni, nombre);
                departamento.RegistrarVehiculo(actual, Patente);
            }
            catch (Exceptions.FormatoPatenteeNoValidaException ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            catch (Exceptions.RangoDniIncorrectoException zz)
            {
                MessageBox.Show($"{zz.Message}");
            }
            catch(Exception jj)
            {
                MessageBox.Show("Error desconocido");
            }
            tbDni.Clear();
            tbNombre.Clear();
            tbPatente.Clear();
            
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Ver ver = new Ver();
            for(int i=0; i<departamento.CantidadRegistros; i++)
            {
                RegistroVehiculo registro = departamento.VerRegistro(i);

                ver.lbVer.Items.Add($"Patente: {registro.Patente}, Serie: {registro.Serie}, Propietario: {registro.Propietario.Nombre}\r\n");
            }
            ver.ShowDialog();
        }
    }
}
