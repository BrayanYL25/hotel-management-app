namespace ProyHotel_GUI
{
    partial class AgregarReservaHabitacion
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
            cbxHabitacion = new ComboBox();
            label4 = new Label();
            lblPrecioEstadia = new Label();
            label6 = new Label();
            btnAgregar = new Button();
            btnCancelar = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // lblReservaId
            // 
            lblReservaId.BorderStyle = BorderStyle.FixedSingle;
            lblReservaId.Location = new Point(198, 80);
            lblReservaId.Name = "lblReservaId";
            lblReservaId.Size = new Size(96, 25);
            lblReservaId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 81);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 1;
            label1.Text = "ID de la Reserva: ";
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.Location = new Point(198, 174);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(250, 27);
            dtpCheckIn.TabIndex = 2;
            dtpCheckIn.Value = new DateTime(2024, 10, 28, 19, 0, 49, 0);
            dtpCheckIn.ValueChanged += dtpCheckIn_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 175);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 1;
            label2.Text = "Fecha de Check-in: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 222);
            label3.Name = "label3";
            label3.Size = new Size(146, 20);
            label3.TabIndex = 1;
            label3.Text = "Fecha de Check-out: ";
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.Location = new Point(198, 222);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(250, 27);
            dtpCheckOut.TabIndex = 2;
            dtpCheckOut.Value = new DateTime(2024, 10, 28, 19, 1, 2, 0);
            // 
            // cbxHabitacion
            // 
            cbxHabitacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxHabitacion.FormattingEnabled = true;
            cbxHabitacion.Location = new Point(198, 125);
            cbxHabitacion.Name = "cbxHabitacion";
            cbxHabitacion.Size = new Size(250, 28);
            cbxHabitacion.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 128);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 1;
            label4.Text = "Habitación:";
            // 
            // lblPrecioEstadia
            // 
            lblPrecioEstadia.BorderStyle = BorderStyle.FixedSingle;
            lblPrecioEstadia.Location = new Point(198, 271);
            lblPrecioEstadia.Name = "lblPrecioEstadia";
            lblPrecioEstadia.Size = new Size(96, 25);
            lblPrecioEstadia.TabIndex = 0;
            lblPrecioEstadia.Text = "S/";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 272);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 1;
            label6.Text = "Precio por Noche:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(338, 332);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(110, 40);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(198, 332);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 40);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(50, 24);
            label5.Name = "label5";
            label5.Size = new Size(390, 35);
            label5.TabIndex = 5;
            label5.Text = "Agregar Habitación a la Reserva";
            // 
            // AgregarReservaHabitacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 396);
            Controls.Add(label5);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(cbxHabitacion);
            Controls.Add(dtpCheckOut);
            Controls.Add(label3);
            Controls.Add(dtpCheckIn);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(lblPrecioEstadia);
            Controls.Add(label1);
            Controls.Add(lblReservaId);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AgregarReservaHabitacion";
            Text = "Agregar Reserva a la Habitacion";
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
        private ComboBox cbxHabitacion;
        private Label label4;
        private Label lblPrecioEstadia;
        private Label label6;
        private Button btnAgregar;
        private Button btnCancelar;
        private Label label5;
    }
}