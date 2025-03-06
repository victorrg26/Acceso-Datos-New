namespace Acceso_Datos_New
{
    partial class FrnEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnInsertar = new Button();
            dataGridViewEmpleados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpleados).BeginInit();
            SuspendLayout();
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(654, 12);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(94, 29);
            btnInsertar.TabIndex = 0;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // dataGridViewEmpleados
            // 
            dataGridViewEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmpleados.Location = new Point(5, 61);
            dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            dataGridViewEmpleados.RowHeadersWidth = 51;
            dataGridViewEmpleados.Size = new Size(794, 392);
            dataGridViewEmpleados.TabIndex = 1;
            dataGridViewEmpleados.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FrnEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewEmpleados);
            Controls.Add(btnInsertar);
            Name = "FrnEmpleados";
            Text = "FrnEmpleados";
            Activated += FrnEmpleados_Activated;
            Load += FrnEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnInsertar;
        private DataGridView dataGridViewEmpleados;
    }
}