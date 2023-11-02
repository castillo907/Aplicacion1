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
    public partial class datosguardados : Form
    {
        public datosguardados()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void datosguardados_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow renglon = (DataGridViewRow)dataEstudiante.Rows[0].Clone();

                renglon.Cells[0].Value = textBox5.Text;
                renglon.Cells[1].Value = textBox6.Text;
                renglon.Cells[2].Value = textBox2.Text;
                renglon.Cells[3].Value = textBox1.Text;
                renglon.Cells[4].Value = comboBox1.Text;
                renglon.Cells[5].Value = comboBox2.Text;
                renglon.Cells[6].Value = textBox4.Text;
                renglon.Cells[7].Value = textBox3.Text;

                dataEstudiante.Rows.Add(renglon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando Estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDalete_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea eliminar elregistro?";
            string titulo = "Eliminando elregistro";

            if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    dataEstudiante.Rows.Remove(dataEstudiante.CurrentRow);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eliminando Estudiante",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar un renglon", "Eliminado Estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataEstudiante.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Debes seleccionar un renglon", "Estudiante modificado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                textBox1.Text = dataEstudiante.CurrentRow.Cells["Nombre"].Value.ToString();
                textBox2.Text = dataEstudiante.CurrentRow.Cells["Apellidos"].Value.ToString();
                textBox3.Text = dataEstudiante.CurrentRow.Cells["Edad"].Value.ToString();
                textBox4.Text = dataEstudiante.CurrentRow.Cells["Telefono"].Value.ToString();
                textBox5.Text = dataEstudiante.CurrentRow.Cells["No.Control"].Value.ToString();
                comboBox1.Text = dataEstudiante.CurrentRow.Cells["Carrera"].Value.ToString();
                comboBox2.Text = dataEstudiante.CurrentRow.Cells["Grupo"].Value.ToString();
                textBox6.Text = dataEstudiante.CurrentRow.Cells["Matricula"].Value.ToString();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ingresa los datos del estudiante," +
                "usa los botones que te ayudaran en poner columnas," +
                "eliminar estas columnas y modificarlas", "ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("adios vuelva pronto", "atencion");
            Application.Exit();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
