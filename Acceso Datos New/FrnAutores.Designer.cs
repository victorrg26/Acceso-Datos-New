﻿namespace Acceso_Datos_New
{
    partial class FrnAutores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrnAutores));
            dgvAutors = new DataGridView();
            btnInsertar = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAutors).BeginInit();
            SuspendLayout();
            // 
            // dgvAutors
            // 
            dgvAutors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAutors.Location = new Point(-2, 58);
            dgvAutors.Name = "dgvAutors";
            dgvAutors.RowHeadersWidth = 51;
            dgvAutors.Size = new Size(804, 391);
            dgvAutors.TabIndex = 0;
            dgvAutors.CellContentClick += dgvAuthors_CellContentClick;
            // 
            // btnInsertar
            // 
            btnInsertar.BackgroundImage = (Image)resources.GetObject("btnInsertar.BackgroundImage");
            btnInsertar.BackgroundImageLayout = ImageLayout.Zoom;
            btnInsertar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertar.Location = new Point(554, 7);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(94, 45);
            btnInsertar.TabIndex = 1;
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(683, 7);
            button1.Name = "button1";
            button1.Size = new Size(84, 44);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrnAutores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnInsertar);
            Controls.Add(dgvAutors);
            Name = "FrnAutores";
            Text = "Tabla de Autores";
            Activated += FrnAutores_Activated;
            Load += FrnAutores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAutors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAutors;
        private Button btnInsertar;
        private Button button1;
    }
}