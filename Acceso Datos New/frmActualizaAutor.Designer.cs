namespace Acceso_Datos_New
{
    partial class frmActualizaAutor
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
            txtId = new TextBox();
            txtFirst = new TextBox();
            txtLast = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtCity = new TextBox();
            txtState = new TextBox();
            txtZip = new TextBox();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            chkContract = new CheckBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(155, 84);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 0;
            txtId.TextChanged += textBox1_TextChanged;
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(46, 155);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(125, 27);
            txtFirst.TabIndex = 1;
            // 
            // txtLast
            // 
            txtLast.Location = new Point(265, 155);
            txtLast.Name = "txtLast";
            txtLast.Size = new Size(125, 27);
            txtLast.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(46, 237);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(265, 237);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(125, 27);
            txtAddress.TabIndex = 4;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(46, 311);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(125, 27);
            txtCity.TabIndex = 5;
            // 
            // txtState
            // 
            txtState.Location = new Point(265, 311);
            txtState.Name = "txtState";
            txtState.Size = new Size(125, 27);
            txtState.TabIndex = 6;
            // 
            // txtZip
            // 
            txtZip.Location = new Point(464, 311);
            txtZip.Name = "txtZip";
            txtZip.Size = new Size(125, 27);
            txtZip.TabIndex = 7;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(342, 393);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(123, 36);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += button1_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(484, 393);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 36);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(624, 393);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 36);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 80);
            label1.Name = "label1";
            label1.Size = new Size(33, 28);
            label1.TabIndex = 11;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 128);
            label2.Name = "label2";
            label2.Size = new Size(115, 28);
            label2.TabIndex = 12;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(276, 123);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 13;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(87, 210);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 14;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(295, 210);
            label5.Name = "label5";
            label5.Size = new Size(87, 28);
            label5.TabIndex = 15;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(62, 278);
            label6.Name = "label6";
            label6.Size = new Size(49, 28);
            label6.TabIndex = 16;
            label6.Text = "City";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(283, 274);
            label7.Name = "label7";
            label7.Size = new Size(61, 28);
            label7.TabIndex = 17;
            label7.Text = "State";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(473, 278);
            label8.Name = "label8";
            label8.Size = new Size(101, 28);
            label8.TabIndex = 18;
            label8.Text = "ZIP CODE";
            // 
            // chkContract
            // 
            chkContract.AutoSize = true;
            chkContract.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkContract.Location = new Point(43, 400);
            chkContract.Name = "chkContract";
            chkContract.Size = new Size(115, 32);
            chkContract.TabIndex = 19;
            chkContract.Text = "Contract";
            chkContract.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(265, 24);
            label9.Name = "label9";
            label9.Size = new Size(246, 41);
            label9.TabIndex = 20;
            label9.Text = "Actualiza Autor";
            // 
            // frmActualizaAutor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(chkContract);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(txtZip);
            Controls.Add(txtState);
            Controls.Add(txtCity);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtLast);
            Controls.Add(txtFirst);
            Controls.Add(txtId);
            Name = "frmActualizaAutor";
            Text = "Actualiza Autor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtFirst;
        private TextBox txtLast;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtCity;
        private TextBox txtState;
        private TextBox txtZip;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private CheckBox chkContract;
        private Label label9;
    }
}