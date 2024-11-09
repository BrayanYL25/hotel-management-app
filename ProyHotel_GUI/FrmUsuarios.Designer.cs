namespace ProyHotel_GUI
{
    partial class FrmUsuarios
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
            dtgUsuarios = new DataGridView();
            txtNombre = new TextBox();
            btn_Editar = new Button();
            BtnAgregar = new Button();
            label2 = new Label();
            label3 = new Label();
            labelResultados = new Label();
            botonBuscar = new Button();
            id = new DataGridViewTextBoxColumn();
            usuario = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            tipo = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            fechaUltimaModificacion = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dtgUsuarios
            // 
            dtgUsuarios.AllowUserToAddRows = false;
            dtgUsuarios.AllowUserToDeleteRows = false;
            dtgUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgUsuarios.BackgroundColor = Color.White;
            dtgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgUsuarios.Columns.AddRange(new DataGridViewColumn[] { id, usuario, password, tipo, correo, fechaUltimaModificacion, estado });
            dtgUsuarios.Location = new Point(14, 92);
            dtgUsuarios.Margin = new Padding(3, 4, 3, 4);
            dtgUsuarios.Name = "dtgUsuarios";
            dtgUsuarios.ReadOnly = true;
            dtgUsuarios.RowHeadersVisible = false;
            dtgUsuarios.RowHeadersWidth = 51;
            dtgUsuarios.Size = new Size(899, 423);
            dtgUsuarios.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(568, 29);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese nombre de usuario";
            txtNombre.Size = new Size(252, 27);
            txtNombre.TabIndex = 2;
            // 
            // btn_Editar
            // 
            btn_Editar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Editar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Editar.Location = new Point(723, 547);
            btn_Editar.Margin = new Padding(3, 4, 3, 4);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(91, 40);
            btn_Editar.TabIndex = 3;
            btn_Editar.Text = "Editar";
            btn_Editar.UseVisualStyleBackColor = true;
            btn_Editar.Click += btn_Editar_Click;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgregar.Location = new Point(822, 547);
            BtnAgregar.Margin = new Padding(3, 4, 3, 4);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(91, 40);
            BtnAgregar.TabIndex = 4;
            BtnAgregar.Text = "Crear";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(23, 557);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 6;
            label2.Text = "Registros:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 25);
            label3.Name = "label3";
            label3.Size = new Size(200, 28);
            label3.TabIndex = 8;
            label3.Text = "Gestión de Usuarios";
            // 
            // labelResultados
            // 
            labelResultados.BorderStyle = BorderStyle.FixedSingle;
            labelResultados.Location = new Point(96, 552);
            labelResultados.Name = "labelResultados";
            labelResultados.Size = new Size(114, 30);
            labelResultados.TabIndex = 9;
            labelResultados.Text = "0";
            labelResultados.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // botonBuscar
            // 
            botonBuscar.Location = new Point(827, 28);
            botonBuscar.Margin = new Padding(3, 4, 3, 4);
            botonBuscar.Name = "botonBuscar";
            botonBuscar.Size = new Size(86, 31);
            botonBuscar.TabIndex = 10;
            botonBuscar.Text = "Buscar";
            botonBuscar.UseVisualStyleBackColor = true;
            botonBuscar.Click += botonBuscar_Click;
            // 
            // id
            // 
            id.DataPropertyName = "Id";
            id.HeaderText = "Id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // usuario
            // 
            usuario.DataPropertyName = "Usuario";
            usuario.HeaderText = "Usuario";
            usuario.MinimumWidth = 6;
            usuario.Name = "usuario";
            usuario.ReadOnly = true;
            // 
            // password
            // 
            password.DataPropertyName = "Contraseña";
            password.HeaderText = "Contraseña";
            password.MinimumWidth = 6;
            password.Name = "password";
            password.ReadOnly = true;
            // 
            // tipo
            // 
            tipo.DataPropertyName = "Tipo";
            tipo.HeaderText = "Tipo";
            tipo.MinimumWidth = 6;
            tipo.Name = "tipo";
            tipo.ReadOnly = true;
            // 
            // correo
            // 
            correo.DataPropertyName = "Correo";
            correo.HeaderText = "Correo";
            correo.MinimumWidth = 6;
            correo.Name = "correo";
            correo.ReadOnly = true;
            // 
            // fechaUltimaModificacion
            // 
            fechaUltimaModificacion.DataPropertyName = "Fecha Ultima Modificacion";
            fechaUltimaModificacion.HeaderText = "Fecha Ultima Modificacion";
            fechaUltimaModificacion.MinimumWidth = 6;
            fechaUltimaModificacion.Name = "fechaUltimaModificacion";
            fechaUltimaModificacion.ReadOnly = true;
            // 
            // estado
            // 
            estado.DataPropertyName = "Estado";
            estado.HeaderText = "Estado";
            estado.MinimumWidth = 6;
            estado.Name = "estado";
            estado.ReadOnly = true;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(927, 612);
            Controls.Add(botonBuscar);
            Controls.Add(labelResultados);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BtnAgregar);
            Controls.Add(btn_Editar);
            Controls.Add(txtNombre);
            Controls.Add(dtgUsuarios);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion Usuarios";
            Load += Usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dtgUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgUsuarios;
        private TextBox txtNombre;
        private Button btn_Editar;
        private Button BtnAgregar;
        private Label label2;
        private Label label3;
        private Label labelResultados;
        private Button botonBuscar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn usuario;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn tipo;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn fechaUltimaModificacion;
        private DataGridViewTextBoxColumn estado;
    }
}