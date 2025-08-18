using Composicion.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Composicion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Servicio servicio = new Servicio();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CargaUsuario cargaUsuario = new CargaUsuario();
            cargaUsuario.ShowDialog();

            int dni = Convert.ToInt32(cargaUsuario.txtDNI.Text);
            string nombre = cargaUsuario.txtNOMBRE.Text;

            if (cargaUsuario.DialogResult == DialogResult.OK) 
            {
                if (servicio.AgregarPersona(dni, nombre))
                {
                    MessageBox.Show("Agregado con exito");
                }
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i < servicio.VerCantidadPersonas(); i++)
            {
                listBox1.Items.Add(servicio.VerPersona(i).Describir());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(txtDNIFORMPRINC.Text);
            if (servicio.VerPersonaPorDNI(dni) != null)
            {
                MessageBox.Show("Persona encontrada: " + servicio.VerPersonaPorDNI(dni).Describir());
            }

            txtDNIFORMPRINC.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(txtDNIFORMPRINC.Text);

            Persona personaAeliminar = servicio.VerPersonaPorDNI(dni);
            if (personaAeliminar != null)
            {
                servicio.EliminarPersona(personaAeliminar);
                MessageBox.Show("Persona Eliminada: " + personaAeliminar.Describir());
            }
            else
            {
                MessageBox.Show("Persona no existente");
            }

        }
    }
}
