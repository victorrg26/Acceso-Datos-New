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
    public partial class FrmActualizarEmpleados : Form
    {
        private Datos datos = new Datos();
        public FrmActualizarEmpleados(string id, string fname, string minit, string lname, string idjob, string lvljob, string idpub, string hiredate)
        {
            InitializeComponent();
            txtId.Text = id;
            txtFirst.Text = fname;
            txtLast.Text = lname;
            txtMinit.Text = minit;
            txtLevel.Text = lvljob;
            dtpHireDate.Text = hiredate;

            // Llenar los ComboBoxes con valores predeterminados al cargar el formulario
            LoadComboBoxes(idjob, idpub);
        }
        private void LoadComboBoxes(string selectedJobId, string selectedPubId)
        {
            // Cargar los ComboBoxes con los valores de las llaves foráneas
            LoadComboBox("publishers", "pub_id", cbIdPub, selectedPubId);
            LoadComboBox("jobs", "job_id", cbIDTrabajador, selectedJobId);
        }

        private void LoadComboBox(string tableName, string keyColumn, ComboBox comboBox, string selectedValue)
        {
            DataSet ds = datos.Consulta($"SELECT {keyColumn} FROM {tableName}");
            if (ds != null && ds.Tables.Count > 0)
            {
                comboBox.DataSource = ds.Tables[0];
                comboBox.DisplayMember = keyColumn;
                comboBox.ValueMember = keyColumn;

                // Seleccionar el valor predeterminado según el ID pasado al constructor
                comboBox.SelectedValue = selectedValue;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string lname = txtLast.Text;
            string fname = txtFirst.Text;
            string minit = txtMinit.Text;
            string idjob = cbIDTrabajador.SelectedValue.ToString();
            string lvljob = txtLevel.Text;
            string idpub = cbIdPub.SelectedValue.ToString();
            string date = dtpHireDate.Value.ToString("yyyy-MM-dd HH:mm:ss");

            // Ejecutar la actualización
            bool f = datos.comando("UPDATE employee SET " +
                 "fname='" + fname + "', " +
                 "lname='" + lname + "', " +
                 "minit='" + minit + "', " +
                 "job_id='" + idjob + "', " +
                 "job_lvl='" + lvljob + "', " +
                 "pub_id='" + idpub + "', " +
                 "hire_date='" + date + "' " +
                 "WHERE emp_id='" + id + "';");

            if (f)
            {
                MessageBox.Show("Registro actualizado", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al actualizar", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;

            DialogResult r = MessageBox.Show("Seguro que quieres eliminar?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                bool f = datos.comando("delete from employee where emp_id='" + id + "';");
                if (f)
                {
                    MessageBox.Show("Registro eliminado", "Sistema", MessageBoxButtons.OKCancel);
                }
                else
                {
                    MessageBox.Show("Error al eliminar", "Sistema", MessageBoxButtons.OKCancel);
                }
            }
        }

        private void cbIDTrabajador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbIdPub_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
