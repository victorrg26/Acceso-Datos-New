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
    public partial class FrmInsertarEmpleados : Form
    {
        private Datos datos = new Datos();
        public FrmInsertarEmpleados()
        {
            InitializeComponent();
            LoadComboBoxes();

        }
        private void LoadComboBoxes()
        {
            LoadComboBox("publishers", "pub_id", cbIdPub);
            LoadComboBox("jobs", "job_id", cbIdTrabajador);
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
            string fname = txtFirst.Text;
            string minit = txtMinit.Text;
            string lname = txtLast.Text;
            string jobid = cbIdTrabajador.SelectedValue.ToString();
            string lvjob = txtLevel.Text;
            string idpub = cbIdPub.SelectedValue.ToString();
            string hiredate = dtpHireDate.Value.ToString("yyyy-MM-dd HH:mm:ss");

            Datos datos = new Datos();
            bool f = datos.comando("insert into employee(emp_id,fname,lname,minit,job_id,job_lvl,pub_id,hire_date)"
                + "values ('" + id + "','" + fname + "','" + lname + "','" + minit + "','" + jobid + "','" + lvjob + "','" + idpub + "','" + hiredate + "');");

            if (f)
            {
                MessageBox.Show("Datos insertados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al insertar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbIdPub_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbIdTrabajador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
