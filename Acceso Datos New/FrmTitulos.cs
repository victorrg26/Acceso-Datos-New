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
            DataSet dataSet = datos.Consulta("Select title_id as ID,title as [Title], type as [Type], pb.pub_name as PubNombre,price as Price,advance as Advance ,royalty as Royalty,ytd_sales as Sales,notes as Notes,pubdate as PubDate  From Titles t, publishers pb where t.pub_id = pb.pub_id");

            if (dataSet != null)
            {
                dgvTitulos.DataSource = dataSet.Tables[0];
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmActualizarTitulos titulo = new FrmActualizarTitulos(dgvTitulos[0, e.RowIndex].Value.ToString(),
            dgvTitulos[1, e.RowIndex].Value.ToString(), dgvTitulos[2, e.RowIndex].Value.ToString(), dgvTitulos[3, e.RowIndex].Value.ToString(),
            dgvTitulos[4, e.RowIndex].Value.ToString(), dgvTitulos[5, e.RowIndex].Value.ToString(),
            dgvTitulos[6, e.RowIndex].Value.ToString(), dgvTitulos[7, e.RowIndex].Value.ToString(),
            dgvTitulos[8, e.RowIndex].Value.ToString(), dgvTitulos[9, e.RowIndex].Value.ToString());

            titulo.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 menu = Application.OpenForms["Form1"] as Form1;

            if (menu != null)
            {
                menu.Show();  
                this.Close();  
            }
            else
            {
                menu = new Form1();
                menu.Show();
                this.Close();
            }
        }
    }
}
