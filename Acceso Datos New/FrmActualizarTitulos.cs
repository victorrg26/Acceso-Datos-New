using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Azure.Core.HttpHeader;

namespace Acceso_Datos_New
{
    public partial class FrmActualizarTitulos : Form
    {
     
        public FrmActualizarTitulos(string id, string titulo, string tipo,
            string pubId, string precio, string anticipo, string regalias,
            string ventas, string notas, string fechaPub)
        {
            InitializeComponent();
            txtId.Text = id;
            txtName.Text = titulo;
            txtType.Text = tipo;
            txtPrice.Text = precio;
            txtAdvanced.Text = anticipo;
            txtRoyalty.Text = regalias;
            txtYearSales.Text = ventas;
            rtbNotes.Text = notas;
            dtpDate.Text = fechaPub;

            for (int i = 0; i < cbPubId.Items.Count; i++)
            {
                if (cbPubId.Items[i].ToString() == pubId)
                {
                    cbPubId.SelectedIndex = i;
                }
            }
        }

    
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Datos datos = new Datos();
                bool actTitulo = datos.comando("  update titles set title = '" + txtName.Text.Replace("'", "''") +
                "', type = '" + txtType.Text.Replace("'", "''") + "', pub_id = (select pub_id from publishers where pub_name = '" + cbPubId.SelectedItem.ToString() + "'), price =" + double.Parse(txtPrice.Text == "" ? "0" : txtPrice.Text) + ", advance =" + double.Parse(txtAdvanced.Text == "" ? "0" : txtAdvanced.Text) +
                ", royalty = " + double.Parse(txtRoyalty.Text == "" ? "0" : txtRoyalty.Text) + ",ytd_sales = " + int.Parse(txtYearSales.Text == "" ? "0" : txtYearSales.Text) +
                ", notes= '" + rtbNotes.Text.Replace("'", "''") + "', pubdate='" + dtpDate.Value.Year + "-" + dtpDate.Value.Month + "-" + dtpDate.Value.Day +
                "'  where title_id = '" + txtId.Text + "'");

                if (actTitulo)
                {
                    MessageBox.Show("Titulo Actualizado Correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrio un problema al actualizar el sistema", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException ex)
            {

                MessageBox.Show("Haz introducido un valor no valido en los valores numericos", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool borrarTit = datos.comando(" delete from titles where title_id = '" + txtId.Text + "'");

            if (borrarTit)
            {
                MessageBox.Show("Titulo borrado correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrio un error al borrar el titulo", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtEditorial_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
