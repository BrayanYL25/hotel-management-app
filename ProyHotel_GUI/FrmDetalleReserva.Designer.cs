namespace ProyHotel_GUI
{
    partial class FrmDetalleReserva
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
            botonAgregarHabitacion = new Button();
            tituloDetalleReserva = new Label();
            labelIdReserva = new Label();
            labelTitularReserva = new Label();
            labelDocumento = new Label();
            labelTelefono = new Label();
            groupBox1 = new GroupBox();
            labelResultadoTelefono = new Label();
            labelResultadoDocumento = new Label();
            labelResultadoNombre = new Label();
            labelResultadoId = new Label();
            groupboxHabitacion = new GroupBox();
            gridHabitaciones = new DataGridView();
            label1 = new Label();
            labelResultadoPrecioTotal = new Label();
            botonAgregarServicio = new Button();
            gridServiciosReserva = new DataGridView();
            Servicio = new DataGridViewTextBoxColumn();
            PrecioTotal = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            groupboxServicio = new GroupBox();
            idReserva = new DataGridViewTextBoxColumn();
            habitacion = new DataGridViewTextBoxColumn();
            tipoHabitacion = new DataGridViewTextBoxColumn();
            precioTotalHabitacion = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupboxHabitacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridHabitaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridServiciosReserva).BeginInit();
            groupboxServicio.SuspendLayout();
            SuspendLayout();
            // 
            // botonAgregarHabitacion
            // 
            botonAgregarHabitacion.Location = new Point(386, 22);
            botonAgregarHabitacion.Name = "botonAgregarHabitacion";
            botonAgregarHabitacion.Size = new Size(23, 23);
            botonAgregarHabitacion.TabIndex = 0;
            botonAgregarHabitacion.Text = "+";
            botonAgregarHabitacion.UseVisualStyleBackColor = true;
            botonAgregarHabitacion.Click += botonAgregarHabitacion_Click;
            // 
            // tituloDetalleReserva
            // 
            tituloDetalleReserva.AutoSize = true;
            tituloDetalleReserva.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tituloDetalleReserva.Location = new Point(12, 9);
            tituloDetalleReserva.Name = "tituloDetalleReserva";
            tituloDetalleReserva.Size = new Size(152, 21);
            tituloDetalleReserva.TabIndex = 2;
            tituloDetalleReserva.Text = "Detalle de Reserva";
            // 
            // labelIdReserva
            // 
            labelIdReserva.AutoSize = true;
            labelIdReserva.Location = new Point(6, 34);
            labelIdReserva.Name = "labelIdReserva";
            labelIdReserva.Size = new Size(79, 15);
            labelIdReserva.TabIndex = 3;
            labelIdReserva.Text = "Id de Reserva:";
            // 
            // labelTitularReserva
            // 
            labelTitularReserva.AutoSize = true;
            labelTitularReserva.Location = new Point(431, 34);
            labelTitularReserva.Name = "labelTitularReserva";
            labelTitularReserva.Size = new Size(54, 15);
            labelTitularReserva.TabIndex = 4;
            labelTitularReserva.Text = "Nombre:";
            // 
            // labelDocumento
            // 
            labelDocumento.AutoSize = true;
            labelDocumento.Location = new Point(6, 77);
            labelDocumento.Name = "labelDocumento";
            labelDocumento.Size = new Size(73, 15);
            labelDocumento.TabIndex = 5;
            labelDocumento.Text = "Documento:";
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(431, 78);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(55, 15);
            labelTelefono.TabIndex = 6;
            labelTelefono.Text = "Telefono:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelResultadoTelefono);
            groupBox1.Controls.Add(labelResultadoDocumento);
            groupBox1.Controls.Add(labelResultadoNombre);
            groupBox1.Controls.Add(labelResultadoId);
            groupBox1.Controls.Add(labelIdReserva);
            groupBox1.Controls.Add(labelTelefono);
            groupBox1.Controls.Add(labelTitularReserva);
            groupBox1.Controls.Add(labelDocumento);
            groupBox1.Location = new Point(12, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(785, 117);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información del Titular:";
            // 
            // labelResultadoTelefono
            // 
            labelResultadoTelefono.BorderStyle = BorderStyle.FixedSingle;
            labelResultadoTelefono.Location = new Point(491, 76);
            labelResultadoTelefono.Name = "labelResultadoTelefono";
            labelResultadoTelefono.Size = new Size(276, 23);
            labelResultadoTelefono.TabIndex = 10;
            labelResultadoTelefono.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelResultadoDocumento
            // 
            labelResultadoDocumento.BorderStyle = BorderStyle.FixedSingle;
            labelResultadoDocumento.Location = new Point(91, 76);
            labelResultadoDocumento.Name = "labelResultadoDocumento";
            labelResultadoDocumento.Size = new Size(276, 23);
            labelResultadoDocumento.TabIndex = 9;
            labelResultadoDocumento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelResultadoNombre
            // 
            labelResultadoNombre.BorderStyle = BorderStyle.FixedSingle;
            labelResultadoNombre.Location = new Point(491, 34);
            labelResultadoNombre.Name = "labelResultadoNombre";
            labelResultadoNombre.Size = new Size(276, 23);
            labelResultadoNombre.TabIndex = 8;
            labelResultadoNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelResultadoId
            // 
            labelResultadoId.BorderStyle = BorderStyle.FixedSingle;
            labelResultadoId.Location = new Point(91, 33);
            labelResultadoId.Name = "labelResultadoId";
            labelResultadoId.Size = new Size(276, 23);
            labelResultadoId.TabIndex = 7;
            labelResultadoId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupboxHabitacion
            // 
            groupboxHabitacion.Controls.Add(gridHabitaciones);
            groupboxHabitacion.Controls.Add(botonAgregarHabitacion);
            groupboxHabitacion.Location = new Point(12, 179);
            groupboxHabitacion.Name = "groupboxHabitacion";
            groupboxHabitacion.Size = new Size(414, 259);
            groupboxHabitacion.TabIndex = 8;
            groupboxHabitacion.TabStop = false;
            groupboxHabitacion.Text = "Habitaciones";
            // 
            // gridHabitaciones
            // 
            gridHabitaciones.AllowUserToAddRows = false;
            gridHabitaciones.AllowUserToDeleteRows = false;
            gridHabitaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridHabitaciones.BackgroundColor = SystemColors.ButtonHighlight;
            gridHabitaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridHabitaciones.Columns.AddRange(new DataGridViewColumn[] { idReserva, habitacion, tipoHabitacion, precioTotalHabitacion });
            gridHabitaciones.Location = new Point(6, 22);
            gridHabitaciones.Name = "gridHabitaciones";
            gridHabitaciones.ReadOnly = true;
            gridHabitaciones.RowHeadersVisible = false;
            gridHabitaciones.RowHeadersWidth = 51;
            gridHabitaciones.Size = new Size(374, 231);
            gridHabitaciones.TabIndex = 1;
            gridHabitaciones.CellClick += gridHabitaciones_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(620, 14);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 10;
            label1.Text = "Precio Total:";
            // 
            // labelResultadoPrecioTotal
            // 
            labelResultadoPrecioTotal.BorderStyle = BorderStyle.FixedSingle;
            labelResultadoPrecioTotal.Location = new Point(697, 10);
            labelResultadoPrecioTotal.Name = "labelResultadoPrecioTotal";
            labelResultadoPrecioTotal.Size = new Size(100, 23);
            labelResultadoPrecioTotal.TabIndex = 11;
            labelResultadoPrecioTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // botonAgregarServicio
            // 
            botonAgregarServicio.Location = new Point(337, 22);
            botonAgregarServicio.Name = "botonAgregarServicio";
            botonAgregarServicio.Size = new Size(23, 23);
            botonAgregarServicio.TabIndex = 1;
            botonAgregarServicio.Text = "+";
            botonAgregarServicio.UseVisualStyleBackColor = true;
            botonAgregarServicio.Click += botonAgregarServicio_Click;
            // 
            // gridServiciosReserva
            // 
            gridServiciosReserva.AllowUserToAddRows = false;
            gridServiciosReserva.AllowUserToDeleteRows = false;
            gridServiciosReserva.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridServiciosReserva.BackgroundColor = SystemColors.ControlLightLight;
            gridServiciosReserva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridServiciosReserva.Columns.AddRange(new DataGridViewColumn[] { Servicio, PrecioTotal, cantidad });
            gridServiciosReserva.Location = new Point(6, 22);
            gridServiciosReserva.Name = "gridServiciosReserva";
            gridServiciosReserva.ReadOnly = true;
            gridServiciosReserva.RowHeadersVisible = false;
            gridServiciosReserva.RowHeadersWidth = 51;
            gridServiciosReserva.Size = new Size(309, 231);
            gridServiciosReserva.TabIndex = 2;
            // 
            // Servicio
            // 
            Servicio.DataPropertyName = "servicio_descripcion";
            Servicio.HeaderText = "Servicio";
            Servicio.MinimumWidth = 6;
            Servicio.Name = "Servicio";
            Servicio.ReadOnly = true;
            // 
            // PrecioTotal
            // 
            PrecioTotal.DataPropertyName = "precio_total";
            PrecioTotal.HeaderText = "Precio Total";
            PrecioTotal.MinimumWidth = 6;
            PrecioTotal.Name = "PrecioTotal";
            PrecioTotal.ReadOnly = true;
            // 
            // cantidad
            // 
            cantidad.DataPropertyName = "cantidad";
            cantidad.HeaderText = "Cantidad";
            cantidad.MinimumWidth = 6;
            cantidad.Name = "cantidad";
            cantidad.ReadOnly = true;
            // 
            // groupboxServicio
            // 
            groupboxServicio.Controls.Add(gridServiciosReserva);
            groupboxServicio.Controls.Add(botonAgregarServicio);
            groupboxServicio.Location = new Point(431, 179);
            groupboxServicio.Name = "groupboxServicio";
            groupboxServicio.Size = new Size(366, 259);
            groupboxServicio.TabIndex = 9;
            groupboxServicio.TabStop = false;
            groupboxServicio.Text = "Servicios";
            // 
            // idReserva
            // 
            idReserva.DataPropertyName = "habitacion_id";
            idReserva.HeaderText = "Id";
            idReserva.Name = "idReserva";
            idReserva.ReadOnly = true;
            idReserva.Visible = false;
            // 
            // habitacion
            // 
            habitacion.DataPropertyName = "habitacion_nombre";
            habitacion.HeaderText = "Habitación";
            habitacion.MinimumWidth = 6;
            habitacion.Name = "habitacion";
            habitacion.ReadOnly = true;
            // 
            // tipoHabitacion
            // 
            tipoHabitacion.DataPropertyName = "tipo_habitacion_descripcion";
            tipoHabitacion.HeaderText = "Tipo de Habitación";
            tipoHabitacion.MinimumWidth = 6;
            tipoHabitacion.Name = "tipoHabitacion";
            tipoHabitacion.ReadOnly = true;
            // 
            // precioTotalHabitacion
            // 
            precioTotalHabitacion.DataPropertyName = "precio_total";
            precioTotalHabitacion.HeaderText = "Precio Total";
            precioTotalHabitacion.MinimumWidth = 6;
            precioTotalHabitacion.Name = "precioTotalHabitacion";
            precioTotalHabitacion.ReadOnly = true;
            // 
            // FrmDetalleReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 450);
            Controls.Add(labelResultadoPrecioTotal);
            Controls.Add(label1);
            Controls.Add(groupboxServicio);
            Controls.Add(groupboxHabitacion);
            Controls.Add(groupBox1);
            Controls.Add(tituloDetalleReserva);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmDetalleReserva";
            Text = "Gestionar Detalle de Reserva";
            Load += FrmDetalleReserva_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupboxHabitacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridHabitaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridServiciosReserva).EndInit();
            groupboxServicio.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonAgregarHabitacion;
        private Label tituloDetalleReserva;
        private Label labelIdReserva;
        private Label labelTitularReserva;
        private Label labelDocumento;
        private Label labelTelefono;
        private GroupBox groupBox1;
        private Label labelResultadoTelefono;
        private Label labelResultadoDocumento;
        private Label labelResultadoNombre;
        private Label labelResultadoId;
        private GroupBox groupboxHabitacion;
        private DataGridView gridHabitaciones;
        private Label label1;
        private Label labelResultadoPrecioTotal;
        private Button botonAgregarServicio;
        private DataGridView gridServiciosReserva;
        private DataGridViewTextBoxColumn Servicio;
        private DataGridViewTextBoxColumn PrecioTotal;
        private DataGridViewTextBoxColumn cantidad;
        private GroupBox groupboxServicio;
        private DataGridViewTextBoxColumn idReserva;
        private DataGridViewTextBoxColumn habitacion;
        private DataGridViewTextBoxColumn tipoHabitacion;
        private DataGridViewTextBoxColumn precioTotalHabitacion;
    }
}