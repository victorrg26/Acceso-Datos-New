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
            dtpFecha.MaxDate = DateTime.Now;
        }
        private void validarNivel()
        {
            string desc = cbIdTrabajador.SelectedItem.ToString();
            switch (desc)
            {
                case "New Hire- Job not specified":
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
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool aggEmp = datos.comando("insert into employee values ('" + txtId.Text + "'" +
                ",'" + txtFirst.Text.Replace("'", "''") + "','" + txtMinit.Text + "','" + txtLast.Text.Replace("'", "''") + "', (select job_id from jobs where job_desc ='" + cbIdTrabajador.SelectedItem.ToString() + "' )" +
                ",'" + txtLevel.Text + "',(select pub_id from publishers where pub_name = '" + cbIdPub.SelectedItem.ToString() + "'),'" + dtpFecha.Value.Year + "-" + dtpFecha.Value.Month
                + "-" + dtpFecha.Value.Day + "')");

            if (aggEmp)
            {
                MessageBox.Show("Empleado agregado correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                validarNivel();
            }

        }

        private void cbIdPub_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbIdTrabajador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
