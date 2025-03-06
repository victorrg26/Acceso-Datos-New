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
        private Datos datos = new Datos();
        public FrmActualizarTitulos(string id, string title, string type, string pub_id, string price, string advance, string royalty, string ytd_sales, string notes, string pubdate)
        {
            InitializeComponent();
            LoadComboBoxes();

            txtId.Text = id;
            txtName.Text = title;
            txtType.Text = type;
            cbPubId.SelectedValue = pub_id;
            txtPrice.Text = price;
            txtAdvanced.Text = advance;
            txtRoyalty.Text = royalty;
            txtYearSales.Text = ytd_sales;
            rtbNotes.Text = notes;
            dtpDate.Text = pubdate;
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
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string name = txtName.Text;
            string type = txtType.Text;
            string pub_id = cbPubId.SelectedValue?.ToString();
            string price = txtPrice.Text;
            string advance = txtAdvanced.Text;
            string ytd_sales = txtYearSales.Text;
            string notes = rtbNotes.Text;
            string pubdate = dtpDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string royalty = txtRoyalty.Text;

            if (string.IsNullOrEmpty(pub_id))
            {
                MessageBox.Show("Seleccione un Publisher ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Datos datos = new Datos();
            bool f = datos.comando($"UPDATE titles SET " +
               $"title='{name}', " +
               $"type='{type}', " +
               $"pub_id='{pub_id}', " +
               $"price={price}, " +
               $"advance={advance}, " +
               $"royalty={royalty}, " +
               $"ytd_sales={ytd_sales}, " +
               $"notes='{notes}', " +
               $"pubdate='{pubdate}' " +
               $"WHERE title_id='{id}'");

            if (f)
            {
                MessageBox.Show("Se han actualizado los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al actualizar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Desea eliminar?", "Sistema", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Datos datos = new Datos();
                string id = txtId.Text;
                bool f = datos.comando($"DELETE FROM TITLES WHERE title_id='{id}'");
                if (f)
                {
                    MessageBox.Show("Registro eliminado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
