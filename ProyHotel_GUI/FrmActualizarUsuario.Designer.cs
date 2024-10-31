namespace ProyHotel_GUI
{
    partial class FrmActualizarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActualizarUsuario));
            label1 = new Label();
            txtId = new TextBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            cmbUsuario = new ComboBox();
            label3 = new Label();
            txtCorreo = new TextBox();
            label4 = new Label();
            txtContraseña = new TextBox();
            label5 = new Label();
            checkInactivo = new CheckBox();
            checkActivo = new CheckBox();
            groupBox1 = new GroupBox();
            btn_Guardar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 1;
            label1.Text = "ID Usuario:";
            // 
            // txtId
            // 
            txtId.CharacterCasing = CharacterCasing.Upper;
            txtId.Enabled = false;
            txtId.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(136, 19);
            txtId.MaxLength = 20;
            txtId.Name = "txtId";
            txtId.Size = new Size(64, 33);
            txtId.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.CharacterCasing = CharacterCasing.Upper;
            txtUsuario.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(134, 77);
            txtUsuario.MaxLength = 20;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(190, 33);
            txtUsuario.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 80);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 3;
            label2.Text = "Usuario:";
            // 
            // cmbUsuario
            // 
            cmbUsuario.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuario.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(134, 128);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(190, 29);
            cmbUsuario.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 131);
            label3.Name = "label3";
            label3.Size = new Size(109, 21);
            label3.TabIndex = 5;
            label3.Text = "Tipo Usuario:";
            // 
            // txtCorreo
            // 
            txtCorreo.CharacterCasing = CharacterCasing.Upper;
            txtCorreo.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(134, 238);
            txtCorreo.MaxLength = 30;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(190, 33);
            txtCorreo.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(53, 248);
            label4.Name = "label4";
            label4.Size = new Size(65, 21);
            label4.TabIndex = 11;
            label4.Text = "Correo:";
            // 
            // txtContraseña
            // 
            txtContraseña.CharacterCasing = CharacterCasing.Upper;
            txtContraseña.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(134, 177);
            txtContraseña.MaxLength = 10;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(190, 33);
            txtContraseña.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 180);
            label5.Name = "label5";
            label5.Size = new Size(100, 21);
            label5.TabIndex = 9;
            label5.Text = "Contraseña:";
            // 
            // checkInactivo
            // 
            checkInactivo.AutoSize = true;
            checkInactivo.Location = new Point(21, 63);
            checkInactivo.Name = "checkInactivo";
            checkInactivo.Size = new Size(68, 19);
            checkInactivo.TabIndex = 1;
            checkInactivo.Text = "Inactivo";
            checkInactivo.UseVisualStyleBackColor = true;
            checkInactivo.CheckedChanged += checkInactivo_CheckedChanged;
            // 
            // checkActivo
            // 
            checkActivo.AutoSize = true;
            checkActivo.Location = new Point(21, 29);
            checkActivo.Name = "checkActivo";
            checkActivo.Size = new Size(60, 19);
            checkActivo.TabIndex = 0;
            checkActivo.Text = "Activo";
            checkActivo.UseVisualStyleBackColor = true;
            checkActivo.CheckedChanged += checkActivo_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkInactivo);
            groupBox1.Controls.Add(checkActivo);
            groupBox1.Location = new Point(53, 309);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado";
            // 
            // btn_Guardar
            // 
            btn_Guardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Guardar.Image = (Image)resources.GetObject("btn_Guardar.Image");
            btn_Guardar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Guardar.Location = new Point(115, 520);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(127, 43);
            btn_Guardar.TabIndex = 14;
            btn_Guardar.Text = "GUARDAR";
            btn_Guardar.TextAlign = ContentAlignment.MiddleRight;
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // Actualizar_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 648);
            Controls.Add(btn_Guardar);
            Controls.Add(txtCorreo);
            Controls.Add(label4);
            Controls.Add(txtContraseña);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(cmbUsuario);
            Controls.Add(label3);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "Actualizar_Usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Usuario";
            Load += Actualizar_Usuario_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private TextBox txtUsuario;
        private Label label2;
        private ComboBox cmbUsuario;
        private Label label3;
        private TextBox txtCorreo;
        private Label label4;
        private TextBox txtContraseña;
        private Label label5;
        private CheckBox checkInactivo;
        private CheckBox checkActivo;
        private GroupBox groupBox1;
        private Button btn_Guardar;
    }
}