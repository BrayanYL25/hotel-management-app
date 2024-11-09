namespace ProyHotel_GUI
{
    partial class FrmHabitaciones
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
            button1 = new Button();
            txtFiltroHabitacion = new TextBox();
            dgtDatosHabitaciones = new DataGridView();
            habitacionId = new DataGridViewTextBoxColumn();
            tipoHabitacionId = new DataGridViewTextBoxColumn();
            habitacionNombre = new DataGridViewTextBoxColumn();
            costoNoche = new DataGridViewTextBoxColumn();
            tipoHabitacion = new DataGridViewTextBoxColumn();
            habitacionAforo = new DataGridViewTextBoxColumn();
            fechaUltimaModificacion = new DataGridViewTextBoxColumn();
            usuarioUltimaModificacion = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            lblRegistroHabitaciones = new Label();
            label3 = new Label();
            btnAgregarHabitacion = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            botonBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgtDatosHabitaciones).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 24);
            label1.Name = "label1";
            label1.Size = new Size(227, 25);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Habitaciones";
            // 
            // button1
            // 
            button1.Location = new Point(933, 53);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "cerrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtFiltroHabitacion
            // 
            txtFiltroHabitacion.Location = new Point(575, 20);
            txtFiltroHabitacion.Name = "txtFiltroHabitacion";
            txtFiltroHabitacion.PlaceholderText = "Ingrese la habitacion";
            txtFiltroHabitacion.Size = new Size(196, 27);
            txtFiltroHabitacion.TabIndex = 3;
            // 
            // dgtDatosHabitaciones
            // 
            dgtDatosHabitaciones.AllowUserToAddRows = false;
            dgtDatosHabitaciones.AllowUserToDeleteRows = false;
            dgtDatosHabitaciones.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dgtDatosHabitaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgtDatosHabitaciones.BackgroundColor = SystemColors.ControlLightLight;
            dgtDatosHabitaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtDatosHabitaciones.Columns.AddRange(new DataGridViewColumn[] { habitacionId, tipoHabitacionId, habitacionNombre, costoNoche, tipoHabitacion, habitacionAforo, fechaUltimaModificacion, usuarioUltimaModificacion, estado });
            dgtDatosHabitaciones.Location = new Point(14, 76);
            dgtDatosHabitaciones.Margin = new Padding(3, 4, 3, 4);
            dgtDatosHabitaciones.Name = "dgtDatosHabitaciones";
            dgtDatosHabitaciones.ReadOnly = true;
            dgtDatosHabitaciones.RowHeadersVisible = false;
            dgtDatosHabitaciones.RowHeadersWidth = 51;
            dgtDatosHabitaciones.Size = new Size(857, 455);
            dgtDatosHabitaciones.TabIndex = 0;
            // 
            // habitacionId
            // 
            habitacionId.DataPropertyName = "Habitacion Id";
            habitacionId.HeaderText = "Habitacion Id";
            habitacionId.MinimumWidth = 6;
            habitacionId.Name = "habitacionId";
            habitacionId.ReadOnly = true;
            // 
            // tipoHabitacionId
            // 
            tipoHabitacionId.DataPropertyName = "Tipo Habitacion Id";
            tipoHabitacionId.HeaderText = "Tipo Habitacion Id";
            tipoHabitacionId.MinimumWidth = 6;
            tipoHabitacionId.Name = "tipoHabitacionId";
            tipoHabitacionId.ReadOnly = true;
            // 
            // habitacionNombre
            // 
            habitacionNombre.DataPropertyName = "Habitacion Nombre";
            habitacionNombre.HeaderText = "Habitacion Nombre";
            habitacionNombre.MinimumWidth = 6;
            habitacionNombre.Name = "habitacionNombre";
            habitacionNombre.ReadOnly = true;
            // 
            // costoNoche
            // 
            costoNoche.DataPropertyName = "Costo Noche";
            costoNoche.HeaderText = "Costo Noche";
            costoNoche.MinimumWidth = 6;
            costoNoche.Name = "costoNoche";
            costoNoche.ReadOnly = true;
            // 
            // tipoHabitacion
            // 
            tipoHabitacion.DataPropertyName = "Tipo Habitacion";
            tipoHabitacion.HeaderText = "Tipo Habitacion";
            tipoHabitacion.MinimumWidth = 6;
            tipoHabitacion.Name = "tipoHabitacion";
            tipoHabitacion.ReadOnly = true;
            // 
            // habitacionAforo
            // 
            habitacionAforo.DataPropertyName = "Habitacion Aforo";
            habitacionAforo.HeaderText = "Habitacion Aforo";
            habitacionAforo.MinimumWidth = 6;
            habitacionAforo.Name = "habitacionAforo";
            habitacionAforo.ReadOnly = true;
            // 
            // fechaUltimaModificacion
            // 
            fechaUltimaModificacion.DataPropertyName = "Fecha Ultima Modificacion";
            fechaUltimaModificacion.FillWeight = 135F;
            fechaUltimaModificacion.HeaderText = "Fecha Ultima Modificacion";
            fechaUltimaModificacion.MinimumWidth = 6;
            fechaUltimaModificacion.Name = "fechaUltimaModificacion";
            fechaUltimaModificacion.ReadOnly = true;
            // 
            // usuarioUltimaModificacion
            // 
            usuarioUltimaModificacion.DataPropertyName = "Usuario Ultima Modificacion";
            usuarioUltimaModificacion.FillWeight = 135F;
            usuarioUltimaModificacion.HeaderText = "Usuario Ultima Modificacion";
            usuarioUltimaModificacion.MinimumWidth = 6;
            usuarioUltimaModificacion.Name = "usuarioUltimaModificacion";
            usuarioUltimaModificacion.ReadOnly = true;
            // 
            // estado
            // 
            estado.DataPropertyName = "Estado";
            estado.HeaderText = "Estado";
            estado.MinimumWidth = 6;
            estado.Name = "estado";
            estado.ReadOnly = true;
            // 
            // lblRegistroHabitaciones
            // 
            lblRegistroHabitaciones.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistroHabitaciones.BorderStyle = BorderStyle.FixedSingle;
            lblRegistroHabitaciones.Location = new Point(136, 567);
            lblRegistroHabitaciones.Name = "lblRegistroHabitaciones";
            lblRegistroHabitaciones.Size = new Size(96, 29);
            lblRegistroHabitaciones.TabIndex = 4;
            lblRegistroHabitaciones.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(13, 568);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 2;
            label3.Text = "Total de registros: ";
            // 
            // btnAgregarHabitacion
            // 
            btnAgregarHabitacion.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAgregarHabitacion.AutoSize = true;
            btnAgregarHabitacion.Location = new Point(778, 556);
            btnAgregarHabitacion.Name = "btnAgregarHabitacion";
            btnAgregarHabitacion.Size = new Size(91, 40);
            btnAgregarHabitacion.TabIndex = 5;
            btnAgregarHabitacion.Text = "Crear";
            btnAgregarHabitacion.UseVisualStyleBackColor = true;
            btnAgregarHabitacion.Click += btnAgregarHabitacion_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnActualizar.AutoSize = true;
            btnActualizar.Location = new Point(673, 556);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(98, 40);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Editar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.AutoSize = true;
            btnEliminar.Location = new Point(575, 556);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(91, 40);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // botonBuscar
            // 
            botonBuscar.Location = new Point(784, 20);
            botonBuscar.Margin = new Padding(3, 4, 3, 4);
            botonBuscar.Name = "botonBuscar";
            botonBuscar.Size = new Size(86, 31);
            botonBuscar.TabIndex = 6;
            botonBuscar.Text = "Buscar";
            botonBuscar.UseVisualStyleBackColor = true;
            botonBuscar.Click += botonBuscar_Click;
            // 
            // FrmHabitaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 611);
            Controls.Add(botonBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregarHabitacion);
            Controls.Add(lblRegistroHabitaciones);
            Controls.Add(dgtDatosHabitaciones);
            Controls.Add(txtFiltroHabitacion);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "FrmHabitaciones";
            Text = "Gestion Habitaciones";
            Load += FrmHabitaciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgtDatosHabitaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox txtFiltroHabitacion;
        private DataGridView dgtDatosHabitaciones;
        private Label lblRegistroHabitaciones;
        private Label label3;
        private Button btnAgregarHabitacion;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button botonBuscar;
        private DataGridViewTextBoxColumn habitacionId;
        private DataGridViewTextBoxColumn tipoHabitacionId;
        private DataGridViewTextBoxColumn habitacionNombre;
        private DataGridViewTextBoxColumn costoNoche;
        private DataGridViewTextBoxColumn tipoHabitacion;
        private DataGridViewTextBoxColumn habitacionAforo;
        private DataGridViewTextBoxColumn fechaUltimaModificacion;
        private DataGridViewTextBoxColumn usuarioUltimaModificacion;
        private DataGridViewTextBoxColumn estado;
    }
}