using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion1.formas
{
    public partial class registrate : Form
    {
        public registrate()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void registrate_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void fecha_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            datosguardados datosguardados = new datosguardados();
            datosguardados.Show();
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            string edad = textBox3.Text;
            string email = textBox4.Text;
            string contraseña = textBox5.Text;
            string usuario = textBox6.Text;
            string fecha = dateTimePicker1.Text;
            string sexo = comboBox1.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña) || string.IsNullOrWhiteSpace(nombre)
                    || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(fecha)
                    || string.IsNullOrWhiteSpace(sexo) || string.IsNullOrWhiteSpace(edad))
                {
                    MessageBox.Show("por favor, completa todos los campos");
                }
                else
                {
                    MessageBox.Show("Bienvenido");
                    this.Hide();

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nombre_Click(object sender, EventArgs e)
        {

        }

        private void apellido_Click(object sender, EventArgs e)
        {

        }
    }
}
