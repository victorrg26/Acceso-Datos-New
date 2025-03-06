namespace Acceso_Datos_New
{
    partial class FrmActualizarEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActualizarEmpleados));
            btnActualizar = new Button();
            btnEliminar = new Button();
            txtId = new TextBox();
            txtFirst = new TextBox();
            txtMinit = new TextBox();
            txtLevel = new TextBox();
            txtLast = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dtpHireDate = new DateTimePicker();
            label9 = new Label();
            cbIDTrabajador = new ComboBox();
            cbIdPub = new ComboBox();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // btnActualizar
            // 
            btnActualizar.BackgroundImage = (Image)resources.GetObject("btnActualizar.BackgroundImage");
            btnActualizar.BackgroundImageLayout = ImageLayout.Zoom;
            btnActualizar.Location = new Point(115, 376);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(137, 70);
            btnActualizar.TabIndex = 0;
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminar.Location = new Point(497, 376);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 70);
            btnEliminar.TabIndex = 1;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnCancelar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(202, 104);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 2;
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(202, 178);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(125, 27);
            txtFirst.TabIndex = 3;
            // 
            // txtMinit
            // 
            txtMinit.Location = new Point(646, 161);
            txtMinit.Name = "txtMinit";
            txtMinit.Size = new Size(125, 27);
            txtMinit.TabIndex = 4;
            // 
            // txtLevel
            // 
            txtLevel.Location = new Point(663, 278);
            txtLevel.Name = "txtLevel";
            txtLevel.Size = new Size(125, 27);
            txtLevel.TabIndex = 6;
            // 
            // txtLast
            // 
            txtLast.Location = new Point(646, 97);
            txtLast.Name = "txtLast";
            txtLast.Size = new Size(125, 27);
            txtLast.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 104);
            label1.Name = "label1";
            label1.Size = new Size(33, 28);
            label1.TabIndex = 9;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 177);
            label2.Name = "label2";
            label2.Size = new Size(95, 28);
            label2.TabIndex = 10;
            label2.Text = "Nombre ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(429, 157);
            label3.Name = "label3";
            label3.Size = new Size(192, 28);
            label3.TabIndex = 11;
            label3.Text = "Inicial Seg Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(472, 100);
            label4.Name = "label4";
            label4.Size = new Size(91, 28);
            label4.TabIndex = 12;
            label4.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 242);
            label5.Name = "label5";
            label5.Size = new Size(140, 28);
            label5.TabIndex = 13;
            label5.Text = "ID Trabajador";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(429, 274);
            label6.Name = "label6";
            label6.Size = new Size(169, 28);
            label6.TabIndex = 14;
            label6.Text = "Nivel Trabajador";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(448, 218);
            label7.Name = "label7";
            label7.Size = new Size(140, 28);
            label7.TabIndex = 15;
            label7.Text = "ID Publicador";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 328);
            label8.Name = "label8";
            label8.Size = new Size(207, 28);
            label8.TabIndex = 16;
            label8.Text = "Fecha de nacimiento";
            // 
            // dtpHireDate
            // 
            dtpHireDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpHireDate.Location = new Point(228, 325);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(335, 31);
            dtpHireDate.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(193, 23);
            label9.Name = "label9";
            label9.Size = new Size(327, 41);
            label9.TabIndex = 18;
            label9.Text = "Empleados Actualizar";
            // 
            // cbIDTrabajador
            // 
            cbIDTrabajador.FormattingEnabled = true;
            cbIDTrabajador.Location = new Point(202, 246);
            cbIDTrabajador.Name = "cbIDTrabajador";
            cbIDTrabajador.Size = new Size(151, 28);
            cbIDTrabajador.TabIndex = 19;
            cbIDTrabajador.SelectedIndexChanged += cbIDTrabajador_SelectedIndexChanged;
            // 
            // cbIdPub
            // 
            cbIdPub.FormattingEnabled = true;
            cbIdPub.Location = new Point(637, 222);
            cbIdPub.Name = "cbIdPub";
            cbIdPub.Size = new Size(151, 28);
            cbIdPub.TabIndex = 20;
            cbIdPub.SelectedIndexChanged += cbIdPub_SelectedIndexChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.BackgroundImage = (Image)resources.GetObject("btnCancelar.BackgroundImage");
            btnCancelar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCancelar.Location = new Point(308, 376);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(139, 70);
            btnCancelar.TabIndex = 21;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // FrmActualizarEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(cbIdPub);
            Controls.Add(cbIDTrabajador);
            Controls.Add(label9);
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
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Name = "FrmActualizarEmpleados";
            Text = "FrmActualizarEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnActualizar;
        private Button btnEliminar;
        private TextBox txtId;
        private TextBox txtFirst;
        private TextBox txtMinit;
        private TextBox txtLevel;
        private TextBox txtLast;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dtpHireDate;
        private Label label9;
        private ComboBox cbIDTrabajador;
        private ComboBox cbIdPub;
        private Button btnCancelar;
    }
}