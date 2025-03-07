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
       
        public FrmActualizarEmpleados(string id, string fname, string lname, string minit, string jobId,
                                    string joblevel, string pubId, string hireDate)
        {
            InitializeComponent();
            txtId.Text = id;
            txtFirst.Text = fname;
            txtLast.Text = lname;
            txtMinit.Text = minit;
            //txtJId.Text = jobId;
            txtLevel.Text = joblevel;

            dtpFecha.Text = hireDate;
            dtpFecha.MaxDate = System.DateTime.Now;

            for (int i = 0; i < cbIdTrabajador.Items.Count; i++)
            {
                if (cbIdTrabajador.Items[i].ToString() == jobId)
                {
                    cbIdTrabajador.SelectedIndex = i;
                }

            }

            for (int i = 0; i < cbIdPub.Items.Count; i++)
            {
                if (cbIdPub.Items[i].ToString() == pubId)
                {
                    cbIdPub.SelectedIndex = i;
                }
            }


        }
        private void validarNivel()
        {
            string desc = cbIdTrabajador.SelectedItem.ToString();
            switch (desc)
            {
                case "New Hire":
                    MessageBox.Show("Error al elegir el nivel de trabajo. \n Rango para: " + desc + " (10-10)", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Chief Executive Officer":
                    MessageBox.Show("Error al elegir el nivel de trabajo. \n Rango para: " + desc + " (200-250)", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Business Operations Manager":
                    MessageBox.Show("Error al elegir el nivel de trabajo. \n Rango para: " + desc + " (175-225)", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Chief Financial Officier":
                    MessageBox.Show("Error al elegir el nivel de trabajo. \n Rango para: " + desc + " (175-250)", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Publisher":
                    MessageBox.Show("Error al elegir el nivel de trabajo. \n Rango para: " + desc + " (150-250)", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Managing Editor":
                    MessageBox.Show("Error al elegir el nivel de trabajo. \n Rango para: " + desc + " (140-225)", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Marketing Manager":
                    MessageBox.Show("Error al elegir el nivel de trabajo. \n Rango para: " + desc + " (120-200)", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Public Relations Manager":
                    MessageBox.Show("Error al elegir el nivel de trabajo. \n Rango para: " + desc + " (100-175)", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Acquisitions Manager":
                    MessageBox.Show("Error al elegir el nivel de trabajo. \n Rango para: " + desc + " (75-175)", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Productions Manager":
                    MessageBox.Show("Error al elegir el nivel de trabajo. \n Rango para: " + desc + " (75-165)", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Operations Manager":
                    MessageBox.Show("Error al elegir el nivel de trabajo. \n Rango para: " + desc + " (75-150)", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Editor":
                    MessageBox.Show("Error al elegir el nivel de trabajo. \n Rango para: " + desc + " (25-100)", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Sales Representative":
                    MessageBox.Show("Error al elegir el nivel de trabajo. \n Rango para: " + desc + " (25-100)", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Designer":
                    MessageBox.Show("Error al elegir el nivel de trabajo. \n Rango para: " + desc + " (25-100)", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

            }
        }



        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtMinit.Text = txtMinit.Text.Length > 1 ? txtMinit.Text.Substring(1, 1) : txtMinit.Text;
            Datos datos = new Datos();
            bool f = datos.comando("update employee set fname = '" + txtFirst.Text.Replace("'", "''") + "'," +
                "minit ='" + txtMinit.Text + "',lname ='" + txtLast.Text.Replace("'", "''") + "',job_id= '" + (cbIdTrabajador.SelectedIndex + 1 ) +
                "', job_lvL ='" + txtLevel.Text + "',pub_id = (select pub_id from publishers where pub_name = '" + cbIdPub.SelectedItem.ToString() + "'), hire_date= '"
                + dtpFecha.Value.Year + "-" + dtpFecha.Value.Month + "-" + dtpFecha.Value.Day + "' where emp_id = " +
                "'" + txtId.Text + "'");

            if (f)
            {
                MessageBox.Show("Datos actualizados correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                //MessageBox.Show("Ocurrio un error al actualizar datos", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                validarNivel();

            }
        }
               private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Estas seguro de eliminar al empleado " + txtFirst.Text + " " + txtLast.Text + "?",
             "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (res == DialogResult.OK)
            {
                Datos datos = new Datos();
                bool deleteEmp = datos.comando("delete  from employee where emp_id = '" + txtId.Text + "'");

                if (deleteEmp)
                {
                    MessageBox.Show("Empleado borrado correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al eliminar al empleado", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
