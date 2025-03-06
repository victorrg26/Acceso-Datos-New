namespace Acceso_Datos_New
{
    partial class FrmTitulos
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
            dataGridViewTitulos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTitulos).BeginInit();
            SuspendLayout();
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(666, 12);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(94, 29);
            btnInsertar.TabIndex = 0;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // dataGridViewTitulos
            // 
            dataGridViewTitulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTitulos.Location = new Point(2, 47);
            dataGridViewTitulos.Name = "dataGridViewTitulos";
            dataGridViewTitulos.RowHeadersWidth = 51;
            dataGridViewTitulos.Size = new Size(798, 405);
            dataGridViewTitulos.TabIndex = 1;
            dataGridViewTitulos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FrmTitulos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewTitulos);
            Controls.Add(btnInsertar);
            Name = "FrmTitulos";
            Text = "FrmTitulos";
            Activated += FrmTitulos_Activated;
            Load += FrmTitulos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTitulos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnInsertar;
        private DataGridView dataGridViewTitulos;
    }
}