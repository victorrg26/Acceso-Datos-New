namespace Acceso_Datos_New
{
    partial class FrmInsertarEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInsertarEmpleados));
            dtpHireDate = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtLast = new TextBox();
            txtLevel = new TextBox();
            txtMinit = new TextBox();
            txtFirst = new TextBox();
            txtId = new TextBox();
            btnInsertar = new Button();
            cbIdPub = new ComboBox();
            cbIdTrabajador = new ComboBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // dtpHireDate
            // 
            dtpHireDate.Location = new Point(12, 373);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(250, 27);
            dtpHireDate.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 327);
            label8.Name = "label8";
            label8.Size = new Size(211, 28);
            label8.TabIndex = 34;
            label8.Text = "Fecha de Nacimiento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(610, 148);
            label7.Name = "label7";
            label7.Size = new Size(140, 28);
            label7.TabIndex = 33;
            label7.Text = "ID Publicador";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(600, 222);
            label6.Name = "label6";
            label6.Size = new Size(169, 28);
            label6.TabIndex = 32;
            label6.Text = "Nivel Trabajador";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(610, 327);
            label5.Name = "label5";
            label5.Size = new Size(140, 28);
            label5.TabIndex = 31;
            label5.Text = "ID Trabajador";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(628, 46);
            label4.Name = "label4";
            label4.Size = new Size(91, 28);
            label4.TabIndex = 30;
            label4.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 192);
            label3.Name = "label3";
            label3.Size = new Size(186, 28);
            label3.TabIndex = 29;
            label3.Text = "Inical Seg Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 96);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 28;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 42);
            label1.Name = "label1";
            label1.Size = new Size(33, 28);
            label1.TabIndex = 27;
            label1.Text = "ID";
            // 
            // txtLast
            // 
            txtLast.Location = new Point(610, 96);
            txtLast.Name = "txtLast";
            txtLast.Size = new Size(125, 27);
            txtLast.TabIndex = 26;
            // 
            // txtLevel
            // 
            txtLevel.Location = new Point(610, 274);
            txtLevel.Name = "txtLevel";
            txtLevel.Size = new Size(125, 27);
            txtLevel.TabIndex = 24;
            // 
            // txtMinit
            // 
            txtMinit.Location = new Point(25, 248);
            txtMinit.Name = "txtMinit";
            txtMinit.Size = new Size(125, 27);
            txtMinit.TabIndex = 22;
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(25, 138);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(125, 27);
            txtFirst.TabIndex = 21;
            // 
            // txtId
            // 
            txtId.Location = new Point(91, 46);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 20;
            // 
            // btnInsertar
            // 
            btnInsertar.BackgroundImage = (Image)resources.GetObject("btnInsertar.BackgroundImage");
            btnInsertar.BackgroundImageLayout = ImageLayout.Zoom;
            btnInsertar.Font = new Font("Segoe UI", 4.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertar.Location = new Point(377, 369);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(124, 44);
            btnInsertar.TabIndex = 19;
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // cbIdPub
            // 
            cbIdPub.FormattingEnabled = true;
            cbIdPub.Location = new Point(610, 191);
            cbIdPub.Name = "cbIdPub";
            cbIdPub.Size = new Size(151, 28);
            cbIdPub.TabIndex = 36;
            cbIdPub.SelectedIndexChanged += cbIdPub_SelectedIndexChanged;
            // 
            // cbIdTrabajador
            // 
            cbIdTrabajador.FormattingEnabled = true;
            cbIdTrabajador.Location = new Point(610, 375);
            cbIdTrabajador.Name = "cbIdTrabajador";
            cbIdTrabajador.Size = new Size(151, 28);
            cbIdTrabajador.TabIndex = 37;
            cbIdTrabajador.SelectedIndexChanged += cbIdTrabajador_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(258, 20);
            label9.Name = "label9";
            label9.Size = new Size(303, 41);
            label9.TabIndex = 38;
            label9.Text = "Insertar Empleados";
            // 
            // FrmInsertarEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(cbIdTrabajador);
            Controls.Add(cbIdPub);
            Controls.Add(dtpHireDate);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLast);
            Controls.Add(txtLevel);
            Controls.Add(txtMinit);
            Controls.Add(txtFirst);
            Controls.Add(txtId);
            Controls.Add(btnInsertar);
            Name = "FrmInsertarEmpleados";
            Text = "FrmInsertarEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpHireDate;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtLast;
        private TextBox txtLevel;
        private TextBox txtMinit;
        private TextBox txtFirst;
        private TextBox txtId;
        private Button btnInsertar;
        private ComboBox cbIdPub;
        private ComboBox cbIdTrabajador;
        private Label label9;
    }
}