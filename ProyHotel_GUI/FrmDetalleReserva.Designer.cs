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
            botonAgregarServicio = new Button();
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
            groupboxServicio = new GroupBox();
            gridServiciosReserva = new DataGridView();
            Servicio = new DataGridViewTextBoxColumn();
            PrecioTotal = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            label1 = new Label();
            labelResultadoPrecioTotal = new Label();
            habitacion = new DataGridViewTextBoxColumn();
            tipoHabitacion = new DataGridViewTextBoxColumn();
            precioTotalHabitacion = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupboxHabitacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridHabitaciones).BeginInit();
            groupboxServicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridServiciosReserva).BeginInit();
            SuspendLayout();
            // 
            // botonAgregarHabitacion
            // 
            botonAgregarHabitacion.Location = new Point(441, 29);
            botonAgregarHabitacion.Margin = new Padding(3, 4, 3, 4);
            botonAgregarHabitacion.Name = "botonAgregarHabitacion";
            botonAgregarHabitacion.Size = new Size(26, 31);
            botonAgregarHabitacion.TabIndex = 0;
            botonAgregarHabitacion.Text = "+";
            botonAgregarHabitacion.UseVisualStyleBackColor = true;
            botonAgregarHabitacion.Click += botonAgregarHabitacion_Click;
            // 
            // botonAgregarServicio
            // 
            botonAgregarServicio.Location = new Point(371, 29);
            botonAgregarServicio.Margin = new Padding(3, 4, 3, 4);
            botonAgregarServicio.Name = "botonAgregarServicio";
            botonAgregarServicio.Size = new Size(26, 31);
            botonAgregarServicio.TabIndex = 1;
            botonAgregarServicio.Text = "+";
            botonAgregarServicio.UseVisualStyleBackColor = true;
            botonAgregarServicio.Click += botonAgregarServicio_Click;
            // 
            // tituloDetalleReserva
            // 
            tituloDetalleReserva.AutoSize = true;
            tituloDetalleReserva.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tituloDetalleReserva.Location = new Point(14, 12);
            tituloDetalleReserva.Name = "tituloDetalleReserva";
            tituloDetalleReserva.Size = new Size(190, 28);
            tituloDetalleReserva.TabIndex = 2;
            tituloDetalleReserva.Text = "Detalle de Reserva";
            // 
            // labelIdReserva
            // 
            labelIdReserva.AutoSize = true;
            labelIdReserva.Location = new Point(7, 45);
            labelIdReserva.Name = "labelIdReserva";
            labelIdReserva.Size = new Size(101, 20);
            labelIdReserva.TabIndex = 3;
            labelIdReserva.Text = "Id de Reserva:";
            // 
            // labelTitularReserva
            // 
            labelTitularReserva.AutoSize = true;
            labelTitularReserva.Location = new Point(474, 46);
            labelTitularReserva.Name = "labelTitularReserva";
            labelTitularReserva.Size = new Size(67, 20);
            labelTitularReserva.TabIndex = 4;
            labelTitularReserva.Text = "Nombre:";
            // 
            // labelDocumento
            // 
            labelDocumento.AutoSize = true;
            labelDocumento.Location = new Point(7, 103);
            labelDocumento.Name = "labelDocumento";
            labelDocumento.Size = new Size(90, 20);
            labelDocumento.TabIndex = 5;
            labelDocumento.Text = "Documento:";
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(474, 104);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(70, 20);
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
            groupBox1.Location = new Point(14, 59);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(879, 156);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información del Titular:";
            // 
            // labelResultadoTelefono
            // 
            labelResultadoTelefono.BorderStyle = BorderStyle.FixedSingle;
            labelResultadoTelefono.Location = new Point(543, 102);
            labelResultadoTelefono.Name = "labelResultadoTelefono";
            labelResultadoTelefono.Size = new Size(315, 30);
            labelResultadoTelefono.TabIndex = 10;
            labelResultadoTelefono.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelResultadoDocumento
            // 
            labelResultadoDocumento.BorderStyle = BorderStyle.FixedSingle;
            labelResultadoDocumento.Location = new Point(104, 101);
            labelResultadoDocumento.Name = "labelResultadoDocumento";
            labelResultadoDocumento.Size = new Size(315, 30);
            labelResultadoDocumento.TabIndex = 9;
            labelResultadoDocumento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelResultadoNombre
            // 
            labelResultadoNombre.BorderStyle = BorderStyle.FixedSingle;
            labelResultadoNombre.Location = new Point(543, 45);
            labelResultadoNombre.Name = "labelResultadoNombre";
            labelResultadoNombre.Size = new Size(315, 30);
            labelResultadoNombre.TabIndex = 8;
            labelResultadoNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelResultadoId
            // 
            labelResultadoId.BorderStyle = BorderStyle.FixedSingle;
            labelResultadoId.Location = new Point(104, 44);
            labelResultadoId.Name = "labelResultadoId";
            labelResultadoId.Size = new Size(315, 30);
            labelResultadoId.TabIndex = 7;
            labelResultadoId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupboxHabitacion
            // 
            groupboxHabitacion.Controls.Add(gridHabitaciones);
            groupboxHabitacion.Controls.Add(botonAgregarHabitacion);
            groupboxHabitacion.Location = new Point(14, 239);
            groupboxHabitacion.Margin = new Padding(3, 4, 3, 4);
            groupboxHabitacion.Name = "groupboxHabitacion";
            groupboxHabitacion.Padding = new Padding(3, 4, 3, 4);
            groupboxHabitacion.Size = new Size(473, 345);
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
            gridHabitaciones.Columns.AddRange(new DataGridViewColumn[] { habitacion, tipoHabitacion, precioTotalHabitacion });
            gridHabitaciones.Location = new Point(7, 29);
            gridHabitaciones.Margin = new Padding(3, 4, 3, 4);
            gridHabitaciones.Name = "gridHabitaciones";
            gridHabitaciones.ReadOnly = true;
            gridHabitaciones.RowHeadersVisible = false;
            gridHabitaciones.RowHeadersWidth = 51;
            gridHabitaciones.Size = new Size(428, 308);
            gridHabitaciones.TabIndex = 1;
            // 
            // groupboxServicio
            // 
            groupboxServicio.Controls.Add(gridServiciosReserva);
            groupboxServicio.Controls.Add(botonAgregarServicio);
            groupboxServicio.Location = new Point(493, 239);
            groupboxServicio.Margin = new Padding(3, 4, 3, 4);
            groupboxServicio.Name = "groupboxServicio";
            groupboxServicio.Padding = new Padding(3, 4, 3, 4);
            groupboxServicio.Size = new Size(400, 345);
            groupboxServicio.TabIndex = 9;
            groupboxServicio.TabStop = false;
            groupboxServicio.Text = "Servicios";
            // 
            // gridServiciosReserva
            // 
            gridServiciosReserva.AllowUserToAddRows = false;
            gridServiciosReserva.AllowUserToDeleteRows = false;
            gridServiciosReserva.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridServiciosReserva.BackgroundColor = SystemColors.ControlLightLight;
            gridServiciosReserva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridServiciosReserva.Columns.AddRange(new DataGridViewColumn[] { Servicio, PrecioTotal, cantidad });
            gridServiciosReserva.Location = new Point(7, 29);
            gridServiciosReserva.Margin = new Padding(3, 4, 3, 4);
            gridServiciosReserva.Name = "gridServiciosReserva";
            gridServiciosReserva.ReadOnly = true;
            gridServiciosReserva.RowHeadersVisible = false;
            gridServiciosReserva.RowHeadersWidth = 51;
            gridServiciosReserva.Size = new Size(353, 308);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(688, 19);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 10;
            label1.Text = "Precio Total:";
            // 
            // labelResultadoPrecioTotal
            // 
            labelResultadoPrecioTotal.BorderStyle = BorderStyle.FixedSingle;
            labelResultadoPrecioTotal.Location = new Point(776, 14);
            labelResultadoPrecioTotal.Name = "labelResultadoPrecioTotal";
            labelResultadoPrecioTotal.Size = new Size(114, 30);
            labelResultadoPrecioTotal.TabIndex = 11;
            labelResultadoPrecioTotal.TextAlign = ContentAlignment.MiddleRight;
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(labelResultadoPrecioTotal);
            Controls.Add(label1);
            Controls.Add(groupboxServicio);
            Controls.Add(groupboxHabitacion);
            Controls.Add(groupBox1);
            Controls.Add(tituloDetalleReserva);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmDetalleReserva";
            Text = "Gestionar Detalle de Reserva";
            Load += FrmDetalleReserva_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupboxHabitacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridHabitaciones).EndInit();
            groupboxServicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridServiciosReserva).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonAgregarHabitacion;
        private Button botonAgregarServicio;
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
        private GroupBox groupboxServicio;
        private DataGridView gridHabitaciones;
        private DataGridView gridServiciosReserva;
        private Label label1;
        private Label labelResultadoPrecioTotal;
        private DataGridViewTextBoxColumn Servicio;
        private DataGridViewTextBoxColumn PrecioTotal;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn habitacion;
        private DataGridViewTextBoxColumn tipoHabitacion;
        private DataGridViewTextBoxColumn precioTotalHabitacion;
    }
}