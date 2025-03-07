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
    public partial class FrnEmpleados : Form
    {
        public FrnEmpleados()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmActualizarEmpleados empleadoAct = new FrmActualizarEmpleados(dgvEmpleados[0, e.RowIndex].Value.ToString(),
          dgvEmpleados[1, e.RowIndex].Value.ToString(), dgvEmpleados[3, e.RowIndex].Value.ToString(),
          dgvEmpleados[2, e.RowIndex].Value.ToString(), dgvEmpleados[4, e.RowIndex].Value.ToString(),
          dgvEmpleados[5, e.RowIndex].Value.ToString(), dgvEmpleados[6, e.RowIndex].Value.ToString(), dgvEmpleados[7, e.RowIndex].Value.ToString());

            empleadoAct.Show();


        }
        private void actualizarGrid()
        {
            Datos datos = new Datos();
            DataSet dataSet = datos.Consulta("select emp_id as ID , fname as [Frist Name], minit as Minit, lname as [Last Name], j.job_desc as [Job Description], job_lvl as [Job Level], pb.pub_name as [PUB Name], hire_date as [Hire date] from employee e , jobs j, publishers pb where j.job_id = e.job_id and e.pub_id = pb.pub_id");

            if (dataSet != null)
            {
                dgvEmpleados.DataSource = dataSet.Tables[0];

            }
        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
           FrmInsertarEmpleados InsE = new FrmInsertarEmpleados();
            InsE.ShowDialog();
        }

        private void FrnEmpleados_Load(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void FrnEmpleados_Activated(object sender, EventArgs e)
        {
            actualizarGrid();
        }
    }
}
