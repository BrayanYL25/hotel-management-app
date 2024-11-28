namespace ProyHotel_GUI
{
    partial class FrmReserva
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
            tituloReserva = new Label();
            gridReservas = new DataGridView();
            reservaId = new DataGridViewTextBoxColumn();
            creadoPor = new DataGridViewTextBoxColumn();
            tipoUsuario = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            aNombreDe = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            fechaCreacion = new DataGridViewTextBoxColumn();
            fechaUltimaModificacion = new DataGridViewTextBoxColumn();
            usuarioUltimaModificacion = new DataGridViewTextBoxColumn();
            estadoPago = new DataGridViewTextBoxColumn();
            textboxBuscar = new TextBox();
            botonBuscar = new Button();
            botonCrear = new Button();
            botonEditar = new Button();
            tituoResultado = new Label();
            labelResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)gridReservas).BeginInit();
            SuspendLayout();
            // 
            // tituloReserva
            // 
            tituloReserva.AutoSize = true;
            tituloReserva.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tituloReserva.Location = new Point(12, 21);
            tituloReserva.Name = "tituloReserva";
            tituloReserva.Size = new Size(77, 21);
            tituloReserva.TabIndex = 0;
            tituloReserva.Text = "Reservas";
            // 
            // gridReservas
            // 
            gridReservas.AllowUserToAddRows = false;
            gridReservas.AllowUserToDeleteRows = false;
            gridReservas.BackgroundColor = SystemColors.ButtonHighlight;
            gridReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridReservas.Columns.AddRange(new DataGridViewColumn[] { reservaId, creadoPor, tipoUsuario, dni, telefono, aNombreDe, precio, estado, fechaCreacion, fechaUltimaModificacion, usuarioUltimaModificacion, estadoPago });
            gridReservas.Location = new Point(12, 60);
            gridReservas.Name = "gridReservas";
            gridReservas.ReadOnly = true;
            gridReservas.RowHeadersVisible = false;
            gridReservas.RowHeadersWidth = 51;
            gridReservas.Size = new Size(854, 349);
            gridReservas.TabIndex = 1;
            gridReservas.CellDoubleClick += gridReservas_CellDoubleClick;
            // 
            // reservaId
            // 
            reservaId.DataPropertyName = "Reserva Id";
            reservaId.HeaderText = "Id";
            reservaId.MinimumWidth = 6;
            reservaId.Name = "reservaId";
            reservaId.ReadOnly = true;
            reservaId.Width = 88;
            // 
            // creadoPor
            // 
            creadoPor.DataPropertyName = "Creado Por";
            creadoPor.HeaderText = "Creado Por";
            creadoPor.MinimumWidth = 6;
            creadoPor.Name = "creadoPor";
            creadoPor.ReadOnly = true;
            creadoPor.Width = 89;
            // 
            // tipoUsuario
            // 
            tipoUsuario.DataPropertyName = "Tipo Usuario";
            tipoUsuario.HeaderText = "Tipo Usuario";
            tipoUsuario.MinimumWidth = 6;
            tipoUsuario.Name = "tipoUsuario";
            tipoUsuario.ReadOnly = true;
            tipoUsuario.Width = 88;
            // 
            // dni
            // 
            dni.DataPropertyName = "DNI";
            dni.HeaderText = "DNI";
            dni.MinimumWidth = 6;
            dni.Name = "dni";
            dni.ReadOnly = true;
            dni.Width = 89;
            // 
            // telefono
            // 
            telefono.DataPropertyName = "Telefono";
            telefono.HeaderText = "Telefono";
            telefono.MinimumWidth = 6;
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            telefono.Width = 88;
            // 
            // aNombreDe
            // 
            aNombreDe.DataPropertyName = "A Nombre de";
            aNombreDe.HeaderText = "A Nombre De";
            aNombreDe.MinimumWidth = 6;
            aNombreDe.Name = "aNombreDe";
            aNombreDe.ReadOnly = true;
            aNombreDe.Width = 89;
            // 
            // precio
            // 
            precio.DataPropertyName = "precio";
            precio.HeaderText = "Total";
            precio.MinimumWidth = 6;
            precio.Name = "precio";
            precio.ReadOnly = true;
            precio.Width = 88;
            // 
            // estado
            // 
            estado.DataPropertyName = "Estado";
            estado.HeaderText = "Estado";
            estado.MinimumWidth = 6;
            estado.Name = "estado";
            estado.ReadOnly = true;
            estado.Width = 89;
            // 
            // fechaCreacion
            // 
            fechaCreacion.DataPropertyName = "Fecha Creacion";
            fechaCreacion.HeaderText = "Fecha Creacion";
            fechaCreacion.MinimumWidth = 6;
            fechaCreacion.Name = "fechaCreacion";
            fechaCreacion.ReadOnly = true;
            fechaCreacion.Width = 88;
            // 
            // fechaUltimaModificacion
            // 
            fechaUltimaModificacion.DataPropertyName = "Fecha Ultima Modificacion";
            fechaUltimaModificacion.HeaderText = "Fecha Ultima Modificación";
            fechaUltimaModificacion.MinimumWidth = 6;
            fechaUltimaModificacion.Name = "fechaUltimaModificacion";
            fechaUltimaModificacion.ReadOnly = true;
            fechaUltimaModificacion.Width = 125;
            // 
            // usuarioUltimaModificacion
            // 
            usuarioUltimaModificacion.DataPropertyName = "Usuario Ultima Modificacion";
            usuarioUltimaModificacion.HeaderText = "Usuario Última Modificación";
            usuarioUltimaModificacion.MinimumWidth = 6;
            usuarioUltimaModificacion.Name = "usuarioUltimaModificacion";
            usuarioUltimaModificacion.ReadOnly = true;
            usuarioUltimaModificacion.Width = 89;
            // 
            // estadoPago
            // 
            estadoPago.DataPropertyName = "Estado Pago";
            estadoPago.HeaderText = "Estado Pago";
            estadoPago.MinimumWidth = 6;
            estadoPago.Name = "estadoPago";
            estadoPago.ReadOnly = true;
            estadoPago.Width = 88;
            // 
            // textboxBuscar
            // 
            textboxBuscar.Location = new Point(648, 21);
            textboxBuscar.Name = "textboxBuscar";
            textboxBuscar.PlaceholderText = "Ingrese...";
            textboxBuscar.Size = new Size(137, 23);
            textboxBuscar.TabIndex = 2;
            // 
            // botonBuscar
            // 
            botonBuscar.Location = new Point(791, 21);
            botonBuscar.Name = "botonBuscar";
            botonBuscar.Size = new Size(75, 26);
            botonBuscar.TabIndex = 3;
            botonBuscar.Text = "Buscar";
            botonBuscar.UseVisualStyleBackColor = true;
            botonBuscar.Click += botonBuscar_Click;
            // 
            // botonCrear
            // 
            botonCrear.Location = new Point(768, 436);
            botonCrear.Name = "botonCrear";
            botonCrear.Size = new Size(98, 30);
            botonCrear.TabIndex = 4;
            botonCrear.Text = "Crear";
            botonCrear.UseVisualStyleBackColor = true;
            botonCrear.Click += botonCrear_Click;
            // 
            // botonEditar
            // 
            botonEditar.Location = new Point(664, 436);
            botonEditar.Name = "botonEditar";
            botonEditar.Size = new Size(98, 30);
            botonEditar.TabIndex = 5;
            botonEditar.Text = "Editar";
            botonEditar.UseVisualStyleBackColor = true;
            botonEditar.Click += botonEditar_Click;
            // 
            // tituoResultado
            // 
            tituoResultado.AutoSize = true;
            tituoResultado.Location = new Point(12, 446);
            tituoResultado.Name = "tituoResultado";
            tituoResultado.Size = new Size(59, 15);
            tituoResultado.TabIndex = 6;
            tituoResultado.Text = "Resultado";
            // 
            // labelResultado
            // 
            labelResultado.BorderStyle = BorderStyle.FixedSingle;
            labelResultado.Location = new Point(77, 441);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(100, 25);
            labelResultado.TabIndex = 7;
            labelResultado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 480);
            Controls.Add(labelResultado);
            Controls.Add(tituoResultado);
            Controls.Add(botonEditar);
            Controls.Add(botonCrear);
            Controls.Add(botonBuscar);
            Controls.Add(textboxBuscar);
            Controls.Add(gridReservas);
            Controls.Add(tituloReserva);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmReserva";
            Text = "FrmReserva";
            Load += FrmReserva_Load;
            ((System.ComponentModel.ISupportInitialize)gridReservas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloReserva;
        private DataGridView gridReservas;
        private TextBox textboxBuscar;
        private Button botonBuscar;
        private Button botonCrear;
        private Button botonEditar;
        private Label tituoResultado;
        private Label labelResultado;
        private DataGridViewTextBoxColumn reservaId;
        private DataGridViewTextBoxColumn creadoPor;
        private DataGridViewTextBoxColumn tipoUsuario;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn aNombreDe;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn estado;
        private DataGridViewTextBoxColumn fechaCreacion;
        private DataGridViewTextBoxColumn fechaUltimaModificacion;
        private DataGridViewTextBoxColumn usuarioUltimaModificacion;
        private DataGridViewTextBoxColumn estadoPago;
    }
}