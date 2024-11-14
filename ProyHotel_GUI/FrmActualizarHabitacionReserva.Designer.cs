namespace ProyHotel_GUI
{
    partial class FrmActualizarHabitacionReserva
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
            labelTipoHabitacion = new Label();
            groupBox1 = new GroupBox();
            label6 = new Label();
            lblPrecioNoche = new Label();
            lblHabitacion = new Label();
            lblTipoHabitacion = new Label();
            lblHabitacionId = new Label();
            lblReservaId = new Label();
            labelHabitacion = new Label();
            labelReserva = new Label();
            label1 = new Label();
            label4 = new Label();
            dtpCheckIn = new DateTimePicker();
            label5 = new Label();
            dtpCheckOut = new DateTimePicker();
            lblPrecioTotal = new Label();
            label7 = new Label();
            botonCancelar = new Button();
            botonEditar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(12, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(310, 28);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Editar Habitación de la Reserva";
            // 
            // labelTipoHabitacion
            // 
            labelTipoHabitacion.AutoSize = true;
            labelTipoHabitacion.Location = new Point(9, 149);
            labelTipoHabitacion.Name = "labelTipoHabitacion";
            labelTipoHabitacion.Size = new Size(119, 20);
            labelTipoHabitacion.TabIndex = 3;
            labelTipoHabitacion.Text = "Tipo Habitacion:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblPrecioNoche);
            groupBox1.Controls.Add(lblHabitacion);
            groupBox1.Controls.Add(lblTipoHabitacion);
            groupBox1.Controls.Add(lblHabitacionId);
            groupBox1.Controls.Add(lblReservaId);
            groupBox1.Controls.Add(labelHabitacion);
            groupBox1.Controls.Add(labelReserva);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(labelTipoHabitacion);
            groupBox1.Location = new Point(12, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 291);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(9, 248);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 9;
            label6.Text = "Precio por Noche:";
            // 
            // lblPrecioNoche
            // 
            lblPrecioNoche.BorderStyle = BorderStyle.FixedSingle;
            lblPrecioNoche.Location = new Point(152, 242);
            lblPrecioNoche.Name = "lblPrecioNoche";
            lblPrecioNoche.Size = new Size(218, 33);
            lblPrecioNoche.TabIndex = 10;
            lblPrecioNoche.Text = "S/";
            lblPrecioNoche.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHabitacion
            // 
            lblHabitacion.BorderStyle = BorderStyle.FixedSingle;
            lblHabitacion.Location = new Point(152, 200);
            lblHabitacion.Name = "lblHabitacion";
            lblHabitacion.Size = new Size(218, 30);
            lblHabitacion.TabIndex = 8;
            lblHabitacion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTipoHabitacion
            // 
            lblTipoHabitacion.BorderStyle = BorderStyle.FixedSingle;
            lblTipoHabitacion.Location = new Point(152, 144);
            lblTipoHabitacion.Name = "lblTipoHabitacion";
            lblTipoHabitacion.Size = new Size(218, 30);
            lblTipoHabitacion.TabIndex = 8;
            lblTipoHabitacion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHabitacionId
            // 
            lblHabitacionId.BorderStyle = BorderStyle.FixedSingle;
            lblHabitacionId.Location = new Point(152, 88);
            lblHabitacionId.Name = "lblHabitacionId";
            lblHabitacionId.Size = new Size(218, 30);
            lblHabitacionId.TabIndex = 8;
            lblHabitacionId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblReservaId
            // 
            lblReservaId.BorderStyle = BorderStyle.FixedSingle;
            lblReservaId.Location = new Point(152, 32);
            lblReservaId.Name = "lblReservaId";
            lblReservaId.Size = new Size(218, 30);
            lblReservaId.TabIndex = 7;
            lblReservaId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelHabitacion
            // 
            labelHabitacion.AutoSize = true;
            labelHabitacion.Location = new Point(9, 93);
            labelHabitacion.Name = "labelHabitacion";
            labelHabitacion.Size = new Size(102, 20);
            labelHabitacion.TabIndex = 6;
            labelHabitacion.Text = "Id Habitación:";
            // 
            // labelReserva
            // 
            labelReserva.AutoSize = true;
            labelReserva.Location = new Point(9, 37);
            labelReserva.Name = "labelReserva";
            labelReserva.Size = new Size(80, 20);
            labelReserva.TabIndex = 5;
            labelReserva.Text = "Id Reserva:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 205);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 3;
            label1.Text = "Habitación:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 412);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 5;
            label4.Text = "Fecha de Check-out: ";
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.Format = DateTimePickerFormat.Short;
            dtpCheckIn.Location = new Point(164, 358);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(218, 27);
            dtpCheckIn.TabIndex = 7;
            dtpCheckIn.Value = new DateTime(2024, 10, 28, 19, 0, 49, 0);
            dtpCheckIn.ValueChanged += dtpCheckIn_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 363);
            label5.Name = "label5";
            label5.Size = new Size(136, 20);
            label5.TabIndex = 6;
            label5.Text = "Fecha de Check-in: ";
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.Format = DateTimePickerFormat.Short;
            dtpCheckOut.Location = new Point(164, 406);
            dtpCheckOut.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(218, 27);
            dtpCheckOut.TabIndex = 8;
            dtpCheckOut.Value = new DateTime(2024, 10, 28, 19, 1, 2, 0);
            dtpCheckOut.ValueChanged += dtpCheckOut_ValueChanged;
            // 
            // lblPrecioTotal
            // 
            lblPrecioTotal.BorderStyle = BorderStyle.FixedSingle;
            lblPrecioTotal.Location = new Point(164, 454);
            lblPrecioTotal.Name = "lblPrecioTotal";
            lblPrecioTotal.Size = new Size(218, 33);
            lblPrecioTotal.TabIndex = 10;
            lblPrecioTotal.Text = "S/";
            lblPrecioTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 461);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 9;
            label7.Text = "Precio Total:";
            // 
            // botonCancelar
            // 
            botonCancelar.Location = new Point(195, 527);
            botonCancelar.Margin = new Padding(3, 4, 3, 4);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(90, 40);
            botonCancelar.TabIndex = 17;
            botonCancelar.Text = "Cancelar";
            botonCancelar.UseVisualStyleBackColor = true;
            botonCancelar.Click += botonCancelar_Click;
            // 
            // botonEditar
            // 
            botonEditar.Location = new Point(292, 527);
            botonEditar.Margin = new Padding(3, 4, 3, 4);
            botonEditar.Name = "botonEditar";
            botonEditar.Size = new Size(90, 40);
            botonEditar.TabIndex = 16;
            botonEditar.Text = "Editar";
            botonEditar.UseVisualStyleBackColor = true;
            botonEditar.Click += botonEditar_Click;
            // 
            // FrmActualizarHabitacionReserva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 580);
            Controls.Add(botonCancelar);
            Controls.Add(botonEditar);
            Controls.Add(lblPrecioTotal);
            Controls.Add(label7);
            Controls.Add(dtpCheckOut);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(labelTitulo);
            Controls.Add(label5);
            Controls.Add(dtpCheckIn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmActualizarHabitacionReserva";
            Text = "Actualizar Habitación de Reserva";
            Load += FrmActualizarHabitacionReserva_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Label labelTipoHabitacion;
        private GroupBox groupBox1;
        private Label lblHabitacionId;
        private Label lblReservaId;
        private Label labelHabitacion;
        private Label labelReserva;
        private Label label1;
        private Label lblHabitacion;
        private Label lblTipoHabitacion;
        private DateTimePicker dtpCheckOut;
        private Label label4;
        private DateTimePicker dtpCheckIn;
        private Label label5;
        private Label label6;
        private Label lblPrecioNoche;
        private Label lblPrecioTotal;
        private Label label7;
        private Button botonCancelar;
        private Button botonEditar;
    }
}