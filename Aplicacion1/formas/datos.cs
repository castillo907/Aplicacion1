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
    public partial class datos : Form
    {
        public datos()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow renglon = (DataGridViewRow)dataProducto.Rows[0].Clone();

                renglon.Cells[0].Value = nombre.Text;
                renglon.Cells[1].Value = compa.Text;
                renglon.Cells[2].Value = produc.Text;
                renglon.Cells[3].Value = pre.Text;
                renglon.Cells[4].Value = descrip.Text;
                renglon.Cells[5].Value = descu.Text;
                renglon.Cells[6].Value = mar.Text;
                renglon.Cells[7].Value = almacen.Text;

                dataProducto.Rows.Add(renglon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando Producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDalete_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea eliminar elregistro?";
            string titulo = "Eliminando el registro";

            if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    dataProducto.Rows.Remove(dataProducto.CurrentRow);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eliminando Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar un renglon", "Eliminado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataProducto.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Debes seleccionar un renglon", "Estudiante modificado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                nombre.Text = dataProducto.CurrentRow.Cells["nombre"].Value.ToString();
                compa.Text = dataProducto.CurrentRow.Cells["compañia"].Value.ToString();
                produc.Text = dataProducto.CurrentRow.Cells["producto"].Value.ToString();
                pre.Text = dataProducto.CurrentRow.Cells["precio"].Value.ToString();
                descrip.Text = dataProducto.CurrentRow.Cells["descripcion"].Value.ToString();
                descu.Text = dataProducto.CurrentRow.Cells["descuento"].Value.ToString();
                mar.Text = dataProducto.CurrentRow.Cells["marca"].Value.ToString();
                descu.Text = dataProducto.CurrentRow.Cells["almacenado"].Value.ToString();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show("ingresa los datos del producto," +
                    "usa los botones que te ayudaran en poner columnas," +
                    "eliminar estas columnas y modificarlas", "ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("adios vuelve pronto", "atencion");
            Application.Exit();
        }

        private void datos_Load(object sender, EventArgs e)
        {

        }
    }
}

