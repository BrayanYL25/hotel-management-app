namespace ProyHotel_GUI
{
    partial class FrmAgregarReservaHabitacion
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
            lblReservaId = new Label();
            label1 = new Label();
            dtpCheckIn = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            dtpCheckOut = new DateTimePicker();
            cbxTipoHabitacion = new ComboBox();
            labelTipoHabitacion = new Label();
            labelPrecioNoche = new Label();
            label6 = new Label();
            btnAgregar = new Button();
            btnCancelar = new Button();
            label5 = new Label();
            labelHabitacion = new Label();
            comboboxHabitacion = new ComboBox();
            label4 = new Label();
            lblPrecioEstadia = new Label();
            SuspendLayout();
            // 
            // lblReservaId
            // 
            lblReservaId.BorderStyle = BorderStyle.FixedSingle;
            lblReservaId.Location = new Point(173, 59);
            lblReservaId.Name = "lblReservaId";
            lblReservaId.Size = new Size(219, 25);
            lblReservaId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 1;
            label1.Text = "ID de la Reserva: ";
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.Format = DateTimePickerFormat.Short;
            dtpCheckIn.Location = new Point(173, 209);
            dtpCheckIn.Margin = new Padding(3, 2, 3, 2);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(219, 23);
            dtpCheckIn.TabIndex = 2;
            dtpCheckIn.Value = new DateTime(2024, 10, 28, 19, 0, 49, 0);
            dtpCheckIn.ValueChanged += dtpCheckIn_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 209);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 1;
            label2.Text = "Fecha de Check-in: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 247);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 1;
            label3.Text = "Fecha de Check-out: ";
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.Format = DateTimePickerFormat.Short;
            dtpCheckOut.Location = new Point(173, 248);
            dtpCheckOut.Margin = new Padding(3, 2, 3, 2);
            dtpCheckOut.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(219, 23);
            dtpCheckOut.TabIndex = 3;
            dtpCheckOut.Value = new DateTime(2024, 10, 28, 19, 1, 2, 0);
            dtpCheckOut.ValueChanged += dtpCheckOut_ValueChanged;
            // 
            // cbxTipoHabitacion
            // 
            cbxTipoHabitacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoHabitacion.FormattingEnabled = true;
            cbxTipoHabitacion.Location = new Point(173, 94);
            cbxTipoHabitacion.Margin = new Padding(3, 2, 3, 2);
            cbxTipoHabitacion.Name = "cbxTipoHabitacion";
            cbxTipoHabitacion.Size = new Size(219, 23);
            cbxTipoHabitacion.TabIndex = 0;
            cbxTipoHabitacion.SelectedIndexChanged += cbxTipoHabitacion_SelectedIndexChanged;
            cbxTipoHabitacion.SelectionChangeCommitted += cbxTipoHabitacion_SelectionChangeCommitted;
            // 
            // labelTipoHabitacion
            // 
            labelTipoHabitacion.AutoSize = true;
            labelTipoHabitacion.Location = new Point(12, 96);
            labelTipoHabitacion.Name = "labelTipoHabitacion";
            labelTipoHabitacion.Size = new Size(94, 15);
            labelTipoHabitacion.TabIndex = 1;
            labelTipoHabitacion.Text = "Tipo Habitacion:";
            // 
            // labelPrecioNoche
            // 
            labelPrecioNoche.BorderStyle = BorderStyle.FixedSingle;
            labelPrecioNoche.Location = new Point(173, 167);
            labelPrecioNoche.Name = "labelPrecioNoche";
            labelPrecioNoche.Size = new Size(219, 25);
            labelPrecioNoche.TabIndex = 1;
            labelPrecioNoche.Text = "S/";
            labelPrecioNoche.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 172);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 1;
            label6.Text = "Precio por Noche:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(296, 345);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(96, 30);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Reservar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(173, 345);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 30);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(254, 21);
            label5.TabIndex = 5;
            label5.Text = "Agregar Habitación a la Reserva";
            // 
            // labelHabitacion
            // 
            labelHabitacion.AutoSize = true;
            labelHabitacion.Location = new Point(12, 132);
            labelHabitacion.Name = "labelHabitacion";
            labelHabitacion.Size = new Size(68, 15);
            labelHabitacion.TabIndex = 6;
            labelHabitacion.Text = "Habitacion:";
            // 
            // comboboxHabitacion
            // 
            comboboxHabitacion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxHabitacion.Enabled = false;
            comboboxHabitacion.FormattingEnabled = true;
            comboboxHabitacion.Location = new Point(173, 130);
            comboboxHabitacion.Margin = new Padding(3, 2, 3, 2);
            comboboxHabitacion.Name = "comboboxHabitacion";
            comboboxHabitacion.Size = new Size(219, 23);
            comboboxHabitacion.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 295);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 7;
            label4.Text = "Precio Total:";
            // 
            // lblPrecioEstadia
            // 
            lblPrecioEstadia.BorderStyle = BorderStyle.FixedSingle;
            lblPrecioEstadia.Location = new Point(173, 290);
            lblPrecioEstadia.Name = "lblPrecioEstadia";
            lblPrecioEstadia.Size = new Size(219, 25);
            lblPrecioEstadia.TabIndex = 8;
            lblPrecioEstadia.Text = "S/";
            lblPrecioEstadia.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmAgregarReservaHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 386);
            Controls.Add(lblPrecioEstadia);
            Controls.Add(label4);
            Controls.Add(comboboxHabitacion);
            Controls.Add(labelHabitacion);
            Controls.Add(label5);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(cbxTipoHabitacion);
            Controls.Add(dtpCheckOut);
            Controls.Add(label3);
            Controls.Add(dtpCheckIn);
            Controls.Add(label2);
            Controls.Add(labelTipoHabitacion);
            Controls.Add(label6);
            Controls.Add(labelPrecioNoche);
            Controls.Add(label1);
            Controls.Add(lblReservaId);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAgregarReservaHabitacion";
            Text = "Agregar Reserva a la Habitacion";
            Load += AgregarReservaHabitacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReservaId;
        private Label label1;
        private DateTimePicker dtpCheckIn;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpCheckOut;
        private ComboBox cbxTipoHabitacion;
        private Label labelTipoHabitacion;
        private Label labelPrecioNoche;
        private Label label6;
        private Button btnAgregar;
        private Button btnCancelar;
        private Label label5;
        private Label labelHabitacion;
        private ComboBox comboboxHabitacion;
        private Label label4;
        private Label lblPrecioEstadia;
    }
}