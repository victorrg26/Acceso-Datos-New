namespace Acceso_Datos_New
{
    partial class frmInsertar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertar));
            chkContract = new CheckBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnInsertar = new Button();
            txtZip = new TextBox();
            txtState = new TextBox();
            txtCity = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtLast = new TextBox();
            txtFirst = new TextBox();
            txtId = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // chkContract
            // 
            chkContract.AutoSize = true;
            chkContract.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkContract.Location = new Point(53, 394);
            chkContract.Name = "chkContract";
            chkContract.Size = new Size(115, 32);
            chkContract.TabIndex = 39;
            chkContract.Text = "Contract";
            chkContract.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(483, 272);
            label8.Name = "label8";
            label8.Size = new Size(101, 28);
            label8.TabIndex = 38;
            label8.Text = "ZIP CODE";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(293, 268);
            label7.Name = "label7";
            label7.Size = new Size(61, 28);
            label7.TabIndex = 37;
            label7.Text = "State";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(72, 272);
            label6.Name = "label6";
            label6.Size = new Size(49, 28);
            label6.TabIndex = 36;
            label6.Text = "City";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(305, 204);
            label5.Name = "label5";
            label5.Size = new Size(87, 28);
            label5.TabIndex = 35;
            label5.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(97, 204);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 34;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(286, 117);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 33;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 122);
            label2.Name = "label2";
            label2.Size = new Size(115, 28);
            label2.TabIndex = 32;
            label2.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 73);
            label1.Name = "label1";
            label1.Size = new Size(33, 28);
            label1.TabIndex = 31;
            label1.Text = "ID";
            // 
            // btnInsertar
            // 
            btnInsertar.BackgroundImage = (Image)resources.GetObject("btnInsertar.BackgroundImage");
            btnInsertar.BackgroundImageLayout = ImageLayout.Zoom;
            btnInsertar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertar.Location = new Point(498, 366);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(101, 60);
            btnInsertar.TabIndex = 29;
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtZip
            // 
            txtZip.Location = new Point(474, 305);
            txtZip.Name = "txtZip";
            txtZip.Size = new Size(125, 27);
            txtZip.TabIndex = 27;
            // 
            // txtState
            // 
            txtState.Location = new Point(275, 305);
            txtState.Name = "txtState";
            txtState.Size = new Size(125, 27);
            txtState.TabIndex = 26;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(56, 305);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(125, 27);
            txtCity.TabIndex = 25;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(275, 231);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(125, 27);
            txtAddress.TabIndex = 24;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(56, 231);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 23;
            // 
            // txtLast
            // 
            txtLast.Location = new Point(275, 149);
            txtLast.Name = "txtLast";
            txtLast.Size = new Size(125, 27);
            txtLast.TabIndex = 22;
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(56, 149);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(125, 27);
            txtFirst.TabIndex = 21;
            // 
            // txtId
            // 
            txtId.Location = new Point(200, 73);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(256, 20);
            label9.Name = "label9";
            label9.Size = new Size(268, 41);
            label9.TabIndex = 40;
            label9.Text = "Insertar Autores";
            // 
            // frmInsertar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
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
            Controls.Add(btnInsertar);
            Controls.Add(txtZip);
            Controls.Add(txtState);
            Controls.Add(txtCity);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtLast);
            Controls.Add(txtFirst);
            Controls.Add(txtId);
            Name = "frmInsertar";
            Text = "frmInsertar";
            Load += frmInsertar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkContract;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnInsertar;
        private TextBox txtZip;
        private TextBox txtState;
        private TextBox txtCity;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtLast;
        private TextBox txtFirst;
        private TextBox txtId;
        private Label label9;
    }
}