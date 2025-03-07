using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Acceso_Datos_New
{
    public partial class FrmInsertarTitulos : Form
    {
        private Datos datos = new Datos();
        public FrmInsertarTitulos()
        {
            InitializeComponent();
      

        }
       

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                Datos datos = new Datos();
                bool aggTitulo = datos.comando("insert into titles values('" +
                "" + txtId.Text.Replace("'", "''") + "', '" + txtName.Text.Replace("'", "''") + "', '" + txtType.Text.Replace("'", "''") + "', (select pub_id from publishers where pub_name ='" +
                "" + cbPubId.SelectedItem.ToString() + "')," + double.Parse(txtPrice.Text) + "," + double.Parse(txtAdvanced.Text) +
                "," + double.Parse(txtRoyalty.Text) + "," + int.Parse(txtYearSales.Text) + ", '" + rtbNotes.Text.Replace("'", "''") + "'" +
                ", '" + dtpDate.Value.Year + "-" + dtpDate.Value.Month + "-" + dtpDate.Value.Day + "')");

                if (aggTitulo)
                {
                    MessageBox.Show("Libro agregado correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al agregar el libro", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Valores no esperados\nAsegurse de no haber introducido letras en vez de numeros", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
