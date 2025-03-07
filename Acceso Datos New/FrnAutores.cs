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
    public partial class FrnAutores : Form
    {
        public FrnAutores()
        {
            InitializeComponent();
        }
        private void ActualizaGrid()
        {
            Datos obj = new Datos();
            DataSet ds = obj.Consulta("Select au_id as ID,au_fname as [First Name],au_lname as [Last Name],phone as Phone,authors.address as Address,city as City,state as State,zip as Zip,contract as Contract From authors");

            if (ds != null)
            {
                dgvAutors.DataSource = ds.Tables[0];
            }
        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmInsertar inse = new frmInsertar();
            inse.Show();
        }

        private void FrnAutores_Activated(object sender, EventArgs e)
        {
            ActualizaGrid();
        }

        private void FrnAutores_Load(object sender, EventArgs e)
        {
            ActualizaGrid();
        }

        private void dgvAuthors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmActualizaAutor actualiza = new frmActualizaAutor(dgvAutors[0, e.RowIndex].Value.ToString(), dgvAutors[1, e.RowIndex].Value.ToString(),
                                            dgvAutors[2, e.RowIndex].Value.ToString(), dgvAutors[3, e.RowIndex].Value.ToString(),
                                            dgvAutors[4, e.RowIndex].Value.ToString(), dgvAutors[5, e.RowIndex].Value.ToString(),
                                            dgvAutors[6, e.RowIndex].Value.ToString(), dgvAutors[7, e.RowIndex].Value.ToString(),
                                            Convert.ToBoolean(dgvAutors[8, e.RowIndex].Value));
            actualiza.Show();
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
