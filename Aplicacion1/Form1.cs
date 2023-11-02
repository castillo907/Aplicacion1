using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicacion1.formas;

namespace Aplicacion1
{
    public partial class Form1 : Form
    {
        private int intentos = 0;
        private const int maxIntentos = 3;
        private const string usuarioCorrecto = "paola";
        private const string contraseñaCorrecta = "dibanhi405";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registrate Form1 = new registrate();
            Form1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string usuario = usuarioo.Text;
            string contraseña = contraseñaa.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
                {
                    MessageBox.Show("Completa lo que se te pide", "Atencion",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (usuario.Length < 3)
                {
                    MessageBox.Show("el nombre de usuario debe contener al menos 3 caracteres");
                }
                else if (intentos >= maxIntentos)
                {
                    MessageBox.Show("te has pasado del limite de intentos");
                    Application.Exit();
                }
                else if (usuario == usuarioCorrecto && contraseña != contraseñaCorrecta)
                {
                    MessageBox.Show("contraseña incorrecta. oportunidades sobrantes:" + (maxIntentos - intentos));
                    intentos++;
                }
                else if (usuario != usuarioCorrecto && contraseña == contraseñaCorrecta)
                {
                    MessageBox.Show("usuario incorrecto. oportunidades restantes:" + (maxIntentos - intentos));
                    intentos++;
                }
                else if (usuario == usuarioCorrecto && contraseña == contraseñaCorrecta)
                {
                    MessageBox.Show("bienvenido", "lo lograste",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    datosguardados datosguardados = new datosguardados();
                    datosguardados.Show();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            datos Form1 = new datos();
            Form1.Show();
        }
    }
}
