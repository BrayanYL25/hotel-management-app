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
            SuspendLayout();
            // 
            // botonAgregarHabitacion
            // 
            botonAgregarHabitacion.Location = new Point(570, 47);
            botonAgregarHabitacion.Name = "botonAgregarHabitacion";
            botonAgregarHabitacion.Size = new Size(23, 23);
            botonAgregarHabitacion.TabIndex = 0;
            botonAgregarHabitacion.Text = "+";
            botonAgregarHabitacion.UseVisualStyleBackColor = true;
            botonAgregarHabitacion.Click += botonAgregarHabitacion_Click;
            // 
            // botonAgregarServicio
            // 
            botonAgregarServicio.Location = new Point(570, 94);
            botonAgregarServicio.Name = "botonAgregarServicio";
            botonAgregarServicio.Size = new Size(23, 23);
            botonAgregarServicio.TabIndex = 1;
            botonAgregarServicio.Text = "+";
            botonAgregarServicio.UseVisualStyleBackColor = true;
            botonAgregarServicio.Click += botonAgregarServicio_Click;
            // 
            // FrmDetalleReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botonAgregarServicio);
            Controls.Add(botonAgregarHabitacion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmDetalleReserva";
            Text = "Gestionar Detalle de Reserva";
            ResumeLayout(false);
        }

        #endregion

        private Button botonAgregarHabitacion;
        private Button botonAgregarServicio;
    }
}