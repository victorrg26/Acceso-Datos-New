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
            LoadComboBoxes();

        }
        private void LoadComboBoxes()
        {
            LoadComboBox("publishers", "pub_id", cbPubId);
        }

        private void LoadComboBox(string tableName, string keyColumn, ComboBox comboBox)
        {
            DataSet ds = datos.Consulta($"SELECT {keyColumn} FROM {tableName}");
            if (ds != null && ds.Tables.Count > 0)
            {
                comboBox.DataSource = ds.Tables[0];
                comboBox.DisplayMember = keyColumn;
                comboBox.ValueMember = keyColumn;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string name = txtName.Text;
            string type = txtType.Text;
            string pub_id = cbPubId.SelectedValue?.ToString();
            string price = txtPrice.Text;
            string advance = txtAdvanced.Text;
            string royalty = txtRoyalty.Text;
            string ytd_sales = txtYearSales.Text;
            string notes = rtbNotes.Text;
            string date = dtpDate.Value.ToString("yyyy-MM-dd HH:mm:ss");

            if (string.IsNullOrEmpty(pub_id))
            {
                MessageBox.Show("Seleccione un Publisher ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Datos datos = new Datos();
            bool f = datos.comando($"INSERT INTO titles (title_id, title, type, pub_id, price, advance, royalty, ytd_sales, notes, pubdate) VALUES " +
                $"('{id}', '{name}', '{type}', '{pub_id}', '{price}', '{advance}', '{royalty}', '{ytd_sales}', '{notes}', '{date}')");

            if (f)
            {
                MessageBox.Show("Se han insertado los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al insertar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
