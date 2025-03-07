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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTitulos));
            btnInsertar = new Button();
            dgvTitulos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTitulos).BeginInit();
            SuspendLayout();
            // 
            // btnInsertar
            // 
            btnInsertar.BackgroundImage = (Image)resources.GetObject("btnInsertar.BackgroundImage");
            btnInsertar.BackgroundImageLayout = ImageLayout.Zoom;
            btnInsertar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertar.Location = new Point(666, 7);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(94, 44);
            btnInsertar.TabIndex = 0;
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // dgvTitulos
            // 
            dgvTitulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTitulos.Location = new Point(2, 57);
            dgvTitulos.Name = "dgvTitulos";
            dgvTitulos.RowHeadersWidth = 51;
            dgvTitulos.Size = new Size(798, 395);
            dgvTitulos.TabIndex = 1;
            dgvTitulos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FrmTitulos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvTitulos);
            Controls.Add(btnInsertar);
            Name = "FrmTitulos";
            Text = "Tabla de Titulos";
            Activated += FrmTitulos_Activated;
            Load += FrmTitulos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTitulos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnInsertar;
        private DataGridView dgvTitulos;
    }
}