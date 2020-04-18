using Herencia.Clases;
using Herencia.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioVehiculos
{
    public partial class Form1 : Form
    {
        VehiculosManager manager;
        public Form1()
        {
            InitializeComponent();
            manager = new VehiculosManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marca = textBox1.Text;
            int recorrido = Convert.ToInt32(textBox2.Text);
            string numeroSerie = textBox4.Text;
            bool motor = textBox3.Text.Equals("si");
            if(textBox5.Text.Equals("1"))
             manager.AgregarVehiculo(VehiculosManager.CrearBicicleta(marca,recorrido,motor,numeroSerie));
            else
            {
                int cilindrada = Convert.ToInt32(textBox6.Text);
                manager.AgregarVehiculo(VehiculosManager.CrearAutomovil(marca, recorrido, motor, numeroSerie, cilindrada));
            }
            UpdateList();
            ClearForm();
        }

        private void UpdateList()
        {
            listBox1.Items.Clear();
            foreach (Vehiculo item in manager.retornarVehiculos())
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void ClearForm()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tipo = textBox7.Text;
            if (string.IsNullOrEmpty(tipo))
            {
                UpdateList();
            }
            else
            {
                listBox1.Items.Clear();

                foreach (Vehiculo item in manager.retornarTipoVehiculo(Convert.ToInt32(tipo)))
                {
                    listBox1.Items.Add(item.ToString());
                }
            }
           
        }
    }
}
