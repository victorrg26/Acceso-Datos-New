using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acceso_Datos_New
{
    public partial class FrmTitulos : Form
    {
        public FrmTitulos()
        {
            InitializeComponent();
        }
        private void actualizarGrid()
        {
            Datos datos = new Datos();
            DataSet dataSet = datos.Consulta("select title_id as 'ID',\r\ntitle as 'Titulo',\r\ntype as 'Genero',\r\npub_id as 'Editorial',\r\nprice as 'Precio',\r\nadvance as 'Anticipo',\r\nroyalty as 'Regalias',\r\nytd_sales as 'Ventas anuales',\r\nnotes as 'Descripcion',\r\npubdate as 'Fecha de Lanzamiento'\r\nfrom titles;");
            if (dataSet != null)
            {
                dataGridViewTitulos.DataSource = dataSet.Tables[0];
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmActualizarTitulos actualizaTitulos = new FrmActualizarTitulos(
               dataGridViewTitulos[0, e.RowIndex].Value.ToString(),
               dataGridViewTitulos[1, e.RowIndex].Value.ToString(),
               dataGridViewTitulos[2, e.RowIndex].Value.ToString(),
               dataGridViewTitulos[3, e.RowIndex].Value.ToString(),
               dataGridViewTitulos[4, e.RowIndex].Value.ToString(),
               dataGridViewTitulos[5, e.RowIndex].Value.ToString(),
               dataGridViewTitulos[6, e.RowIndex].Value.ToString(),
               dataGridViewTitulos[7, e.RowIndex].Value.ToString(),
               dataGridViewTitulos[8, e.RowIndex].Value.ToString(),
               dataGridViewTitulos[9, e.RowIndex].Value.ToString()
           );
            actualizaTitulos.ShowDialog();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            FrmInsertarTitulos insertaTitulos = new FrmInsertarTitulos();
            insertaTitulos.ShowDialog();
        }

        private void FrmTitulos_Load(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void FrmTitulos_Activated(object sender, EventArgs e)
        {
            actualizarGrid();
        
    }
    }
}
