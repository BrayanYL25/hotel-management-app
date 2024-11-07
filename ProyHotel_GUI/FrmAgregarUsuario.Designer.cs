namespace ProyHotel_GUI
{
    partial class FrmAgregarUsuario
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
            label1 = new Label();
            txtUsuario = new TextBox();
            label2 = new Label();
            cmbUsuario = new ComboBox();
            label3 = new Label();
            txtContraseña = new TextBox();
            label4 = new Label();
            txtCorreo = new TextBox();
            groupBox1 = new GroupBox();
            checkEstado = new CheckBox();
            btn_Guardar = new Button();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.CharacterCasing = CharacterCasing.Upper;
            txtUsuario.Font = new Font("Segoe UI", 9F);
            txtUsuario.Location = new Point(95, 47);
            txtUsuario.MaxLength = 20;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(201, 23);
            txtUsuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(10, 89);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 2;
            label2.Text = "Tipo Usuario:";
            // 
            // cmbUsuario
            // 
            cmbUsuario.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuario.Font = new Font("Segoe UI", 9F);
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(95, 86);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(201, 23);
            cmbUsuario.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(10, 129);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 4;
            label3.Text = "Contraseña:";
            // 
            // txtContraseña
            // 
            txtContraseña.CharacterCasing = CharacterCasing.Upper;
            txtContraseña.Font = new Font("Segoe UI", 9F);
            txtContraseña.Location = new Point(95, 126);
            txtContraseña.MaxLength = 10;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(201, 23);
            txtContraseña.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(10, 169);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 6;
            label4.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.CharacterCasing = CharacterCasing.Upper;
            txtCorreo.Font = new Font("Segoe UI", 9F);
            txtCorreo.Location = new Point(95, 166);
            txtCorreo.MaxLength = 30;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(201, 23);
            txtCorreo.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkEstado);
            groupBox1.Location = new Point(12, 214);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(284, 67);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado";
            // 
            // checkEstado
            // 
            checkEstado.AutoSize = true;
            checkEstado.Location = new Point(21, 29);
            checkEstado.Name = "checkEstado";
            checkEstado.Size = new Size(81, 19);
            checkEstado.TabIndex = 0;
            checkEstado.Text = "Habilitado";
            checkEstado.UseVisualStyleBackColor = true;
            // 
            // btn_Guardar
            // 
            btn_Guardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Guardar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Guardar.Location = new Point(216, 302);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(80, 30);
            btn_Guardar.TabIndex = 9;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(113, 21);
            label5.TabIndex = 10;
            label5.Text = "Crear Usuario";
            // 
            // FrmAgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 344);
            Controls.Add(label5);
            Controls.Add(btn_Guardar);
            Controls.Add(groupBox1);
            Controls.Add(txtCorreo);
            Controls.Add(label4);
            Controls.Add(txtContraseña);
            Controls.Add(label3);
            Controls.Add(cmbUsuario);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmAgregarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear Usuario";
            Load += Usuario_Ingresar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private Label label2;
        private ComboBox cmbUsuario;
        private Label label3;
        private TextBox txtContraseña;
        private Label label4;
        private TextBox txtCorreo;
        private GroupBox groupBox1;
        private CheckBox checkEstado;
        private Button btn_Guardar;
        private Label label5;
    }
}