using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agregacion.Models;

namespace Agregacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Servicio claseServicio = new Servicio();
        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            FormPersona formPersona = new FormPersona();
            formPersona.ShowDialog();
            string nombre = formPersona.txtNombre.Text;
            int dni = Convert.ToInt32(formPersona.txtDNI.Text);

            if (formPersona.DialogResult == DialogResult.OK)
            {
                Persona personaNueva = new Persona(dni, nombre);
                if (claseServicio.AgregarPersona(personaNueva))
                {
                    MessageBox.Show("Persona agregada exitosamente");
                };
            }
        }

        private void btnListarPersonas_Click(object sender, EventArgs e)
        {
            lbPersonas.Items.Clear();

            for (int i = 0; i < claseServicio.VerCantidadPersonas(); i++)
            {
                lbPersonas.Items.Add(claseServicio.VerPersona(i).Describir());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int dniBuscado = Convert.ToInt32(txtBusqDNI.Text);
            MessageBox.Show("Persona encontrada " + 
                claseServicio.VerPersonaPorDni(dniBuscado).Describir());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(txtDniEliminar.Text);
            Persona personaEliminar = new Persona(dni, "");
            claseServicio.EliminarPersona(personaEliminar);            
        }
    }
}
