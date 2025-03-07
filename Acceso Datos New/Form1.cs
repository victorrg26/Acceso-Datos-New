namespace Acceso_Datos_New
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrnAutores Autores = new FrnAutores();
            Autores.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrnEmpleados Empleados = new FrnEmpleados();
            Empleados.Show();
        }

        private void titulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTitulos Titulos = new FrmTitulos();
            Titulos.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
