namespace Acceso_Datos_New
{
    partial class FrmActualizarTitulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActualizarTitulos));
            dtpDate = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtYearSales = new TextBox();
            txtRoyalty = new TextBox();
            txtAdvanced = new TextBox();
            txtType = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            btnEliminar = new Button();
            btnActualizar = new Button();
            txtPrice = new TextBox();
            label9 = new Label();
            label10 = new Label();
            rtbNotes = new RichTextBox();
            label11 = new Label();
            cbPubId = new ComboBox();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDate.Location = new Point(57, 334);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(356, 31);
            dtpDate.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(99, 298);
            label8.Name = "label8";
            label8.Size = new Size(210, 28);
            label8.TabIndex = 34;
            label8.Text = "Fecha de Publicacion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(398, 207);
            label7.Name = "label7";
            label7.Size = new Size(91, 28);
            label7.TabIndex = 33;
            label7.Text = "Regalias";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(248, 207);
            label6.Name = "label6";
            label6.Size = new Size(92, 28);
            label6.TabIndex = 32;
            label6.Text = "Anticipo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(113, 206);
            label5.Name = "label5";
            label5.Size = new Size(71, 28);
            label5.TabIndex = 31;
            label5.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(602, 106);
            label4.Name = "label4";
            label4.Size = new Size(92, 28);
            label4.TabIndex = 30;
            label4.Text = "Editorial";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(330, 106);
            label3.Name = "label3";
            label3.Size = new Size(80, 28);
            label3.TabIndex = 29;
            label3.Text = "Genero";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 106);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 28;
            label2.Text = "Titulo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 62);
            label1.Name = "label1";
            label1.Size = new Size(33, 28);
            label1.TabIndex = 27;
            label1.Text = "ID";
            // 
            // txtYearSales
            // 
            txtYearSales.Location = new Point(522, 244);
            txtYearSales.Name = "txtYearSales";
            txtYearSales.Size = new Size(125, 27);
            txtYearSales.TabIndex = 25;
            // 
            // txtRoyalty
            // 
            txtRoyalty.Location = new Point(362, 244);
            txtRoyalty.Name = "txtRoyalty";
            txtRoyalty.Size = new Size(125, 27);
            txtRoyalty.TabIndex = 24;
            // 
            // txtAdvanced
            // 
            txtAdvanced.Location = new Point(213, 244);
            txtAdvanced.Name = "txtAdvanced";
            txtAdvanced.Size = new Size(125, 27);
            txtAdvanced.TabIndex = 23;
            // 
            // txtType
            // 
            txtType.Location = new Point(307, 147);
            txtType.Name = "txtType";
            txtType.Size = new Size(125, 27);
            txtType.TabIndex = 22;
            // 
            // txtName
            // 
            txtName.Location = new Point(57, 147);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 21;
            // 
            // txtId
            // 
            txtId.Location = new Point(113, 66);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 20;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminar.Location = new Point(349, 394);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(140, 57);
            btnEliminar.TabIndex = 19;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackgroundImage = (Image)resources.GetObject("btnActualizar.BackgroundImage");
            btnActualizar.BackgroundImageLayout = ImageLayout.Zoom;
            btnActualizar.Location = new Point(56, 394);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(125, 57);
            btnActualizar.TabIndex = 18;
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(57, 244);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(547, 207);
            label9.Name = "label9";
            label9.Size = new Size(156, 28);
            label9.TabIndex = 37;
            label9.Text = "Ventas Anuales";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(602, 287);
            label10.Name = "label10";
            label10.Size = new Size(68, 28);
            label10.TabIndex = 38;
            label10.Text = "Notas";
            // 
            // rtbNotes
            // 
            rtbNotes.Location = new Point(511, 318);
            rtbNotes.Name = "rtbNotes";
            rtbNotes.Size = new Size(249, 120);
            rtbNotes.TabIndex = 39;
            rtbNotes.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(248, 9);
            label11.Name = "label11";
            label11.Size = new Size(276, 41);
            label11.TabIndex = 40;
            label11.Text = "Actualizar Titulos";
            // 
            // cbPubId
            // 
            cbPubId.FormattingEnabled = true;
            cbPubId.Location = new Point(578, 147);
            cbPubId.Name = "cbPubId";
            cbPubId.Size = new Size(151, 28);
            cbPubId.TabIndex = 41;
            // 
            // btnCancelar
            // 
            btnCancelar.BackgroundImage = (Image)resources.GetObject("btnCancelar.BackgroundImage");
            btnCancelar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCancelar.Location = new Point(213, 395);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 56);
            btnCancelar.TabIndex = 42;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += button1_Click;
            // 
            // FrmActualizarTitulos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(cbPubId);
            Controls.Add(label11);
            Controls.Add(rtbNotes);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtPrice);
            Controls.Add(dtpDate);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtYearSales);
            Controls.Add(txtRoyalty);
            Controls.Add(txtAdvanced);
            Controls.Add(txtType);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Name = "FrmActualizarTitulos";
            Text = "FrmActualizarTitulos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDate;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtYearSales;
        private TextBox txtRoyalty;
        private TextBox txtAdvanced;
        private TextBox txtType;
        private TextBox txtName;
        private TextBox txtId;
        private Button btnEliminar;
        private Button btnActualizar;
        private TextBox txtPrice;
        private Label label9;
        private Label label10;
        private RichTextBox rtbNotes;
        private Label label11;
        private ComboBox cbPubId;
        private Button btnCancelar;
    }
}