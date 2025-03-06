using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Acceso_Datos_New
{
    public partial class frmActualizaAutor : Form
    {
        public frmActualizaAutor(string id, string fname, string lname,
            string phone, string address, string city, string state, string zip,
            bool contract)
        {
            InitializeComponent();

            txtFirst.Text = fname;
            txtLast.Text = lname;
            txtPhone.Text = phone;
            txtAddress.Text = address;
            txtCity.Text = city;
            txtState.Text = state;
            txtZip.Text = zip;
            txtId.Text = id;
            chkContract.Checked = contract;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = txtFirst.Text.Trim(); // Primer nombre
            string lastName = txtLast.Text.Trim();   // Apellido
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();
            string city = txtCity.Text.Trim();
            string state = txtState.Text.Trim();
            string zip = txtZip.Text.Trim();
            string id = txtId.Text.Trim();
            bool contract = chkContract.Checked;

            // Verifica si los campos obligatorios no están vacíos
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Por favor ingrese tanto el primer nombre como el apellido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Datos datos = new Datos();
            bool f = datos.comando("UPDATE authors SET " +
                "au_fname='" + firstName + "', " +
                "au_lname='" + lastName + "', " +
                "phone='" + phone + "', " +
                "address='" + address + "', " +
                "city='" + city + "', " +
                "state='" + state + "', " +
                "zip='" + zip + "', " +
                "contract=" + (contract ? 1 : 0) + " " +
                "WHERE au_id='" + id + "'");

            if (f)
            {
                MessageBox.Show("Datos Actualizados", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro de eliminar el registro?",
               "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Datos datos = new Datos();
                bool f = datos.comando("DELETE FROM authors WHERE au_id='" + txtId.Text + "'");
                if (f)
                {
                    MessageBox.Show("Datos Eliminados", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al eliminar", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
