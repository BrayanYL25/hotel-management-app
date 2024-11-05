namespace ProyHotel_GUI
{
    partial class FrmActualizarServicioReserva
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
            labelTitulo = new Label();
            groupboxReserva = new GroupBox();
            labelServicioNombresRes = new Label();
            labelIdServicioRes = new Label();
            labelIdReservaRes = new Label();
            labelServicioNombre = new Label();
            labelServicio = new Label();
            labelReserva = new Label();
            numericoCantidad = new NumericUpDown();
            labelCantidad = new Label();
            labelPrecioTotal = new Label();
            precioTotal = new Label();
            botonCancelar = new Button();
            botonEditar = new Button();
            groupboxReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericoCantidad).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(12, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(226, 21);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Editar Servicio de la Reserva";
            // 
            // groupboxReserva
            // 
            groupboxReserva.Controls.Add(labelServicioNombresRes);
            groupboxReserva.Controls.Add(labelIdServicioRes);
            groupboxReserva.Controls.Add(labelIdReservaRes);
            groupboxReserva.Controls.Add(labelServicioNombre);
            groupboxReserva.Controls.Add(labelServicio);
            groupboxReserva.Controls.Add(labelReserva);
            groupboxReserva.Location = new Point(12, 42);
            groupboxReserva.Name = "groupboxReserva";
            groupboxReserva.Size = new Size(311, 149);
            groupboxReserva.TabIndex = 1;
            groupboxReserva.TabStop = false;
            groupboxReserva.Text = "Informacion:";
            // 
            // labelServicioNombresRes
            // 
            labelServicioNombresRes.BorderStyle = BorderStyle.FixedSingle;
            labelServicioNombresRes.Location = new Point(97, 114);
            labelServicioNombresRes.Name = "labelServicioNombresRes";
            labelServicioNombresRes.Size = new Size(208, 23);
            labelServicioNombresRes.TabIndex = 5;
            labelServicioNombresRes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelIdServicioRes
            // 
            labelIdServicioRes.BorderStyle = BorderStyle.FixedSingle;
            labelIdServicioRes.Location = new Point(97, 71);
            labelIdServicioRes.Name = "labelIdServicioRes";
            labelIdServicioRes.Size = new Size(208, 23);
            labelIdServicioRes.TabIndex = 4;
            labelIdServicioRes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelIdReservaRes
            // 
            labelIdReservaRes.BorderStyle = BorderStyle.FixedSingle;
            labelIdReservaRes.Location = new Point(97, 27);
            labelIdReservaRes.Name = "labelIdReservaRes";
            labelIdReservaRes.Size = new Size(208, 23);
            labelIdReservaRes.TabIndex = 3;
            labelIdReservaRes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelServicioNombre
            // 
            labelServicioNombre.AutoSize = true;
            labelServicioNombre.Location = new Point(6, 118);
            labelServicioNombre.Name = "labelServicioNombre";
            labelServicioNombre.Size = new Size(51, 15);
            labelServicioNombre.TabIndex = 2;
            labelServicioNombre.Text = "Servicio:";
            // 
            // labelServicio
            // 
            labelServicio.AutoSize = true;
            labelServicio.Location = new Point(6, 75);
            labelServicio.Name = "labelServicio";
            labelServicio.Size = new Size(64, 15);
            labelServicio.TabIndex = 1;
            labelServicio.Text = "Id Servicio:";
            // 
            // labelReserva
            // 
            labelReserva.AutoSize = true;
            labelReserva.Location = new Point(6, 31);
            labelReserva.Name = "labelReserva";
            labelReserva.Size = new Size(63, 15);
            labelReserva.TabIndex = 0;
            labelReserva.Text = "Id Reserva:";
            // 
            // numericoCantidad
            // 
            numericoCantidad.Location = new Point(109, 211);
            numericoCantidad.Name = "numericoCantidad";
            numericoCantidad.Size = new Size(208, 23);
            numericoCantidad.TabIndex = 2;
            numericoCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericoCantidad.ValueChanged += numericoCantidad_ValueChanged;
            // 
            // labelCantidad
            // 
            labelCantidad.AutoSize = true;
            labelCantidad.Location = new Point(18, 211);
            labelCantidad.Name = "labelCantidad";
            labelCantidad.Size = new Size(58, 15);
            labelCantidad.TabIndex = 6;
            labelCantidad.Text = "Cantidad:";
            // 
            // labelPrecioTotal
            // 
            labelPrecioTotal.BorderStyle = BorderStyle.FixedSingle;
            labelPrecioTotal.Location = new Point(109, 250);
            labelPrecioTotal.Name = "labelPrecioTotal";
            labelPrecioTotal.Size = new Size(208, 23);
            labelPrecioTotal.TabIndex = 17;
            labelPrecioTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // precioTotal
            // 
            precioTotal.AutoSize = true;
            precioTotal.Location = new Point(18, 254);
            precioTotal.Name = "precioTotal";
            precioTotal.Size = new Size(71, 15);
            precioTotal.TabIndex = 16;
            precioTotal.Text = "Precio Total:";
            // 
            // botonCancelar
            // 
            botonCancelar.Location = new Point(153, 320);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(79, 30);
            botonCancelar.TabIndex = 15;
            botonCancelar.Text = "Cancelar";
            botonCancelar.UseVisualStyleBackColor = true;
            botonCancelar.Click += botonCancelar_Click;
            // 
            // botonEditar
            // 
            botonEditar.Location = new Point(238, 320);
            botonEditar.Name = "botonEditar";
            botonEditar.Size = new Size(79, 30);
            botonEditar.TabIndex = 14;
            botonEditar.Text = "Editar";
            botonEditar.UseVisualStyleBackColor = true;
            botonEditar.Click += botonEditar_Click;
            // 
            // FrmActualizarServicioReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 362);
            Controls.Add(labelPrecioTotal);
            Controls.Add(precioTotal);
            Controls.Add(botonCancelar);
            Controls.Add(botonEditar);
            Controls.Add(labelCantidad);
            Controls.Add(numericoCantidad);
            Controls.Add(groupboxReserva);
            Controls.Add(labelTitulo);
            Name = "FrmActualizarServicioReserva";
            Text = "Editar Servicio de Reserva";
            Load += FrmActualizarServicioReserva_Load;
            groupboxReserva.ResumeLayout(false);
            groupboxReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericoCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private GroupBox groupboxReserva;
        private Label labelServicio;
        private Label labelReserva;
        private Label labelServicioNombre;
        private Label labelIdReservaRes;
        private NumericUpDown numericoCantidad;
        private Label labelServicioNombresRes;
        private Label labelIdServicioRes;
        private Label labelCantidad;
        private Label labelPrecioTotal;
        private Label precioTotal;
        private Button botonCancelar;
        private Button botonEditar;
    }
}