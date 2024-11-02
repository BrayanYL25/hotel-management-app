namespace ProyHotel_GUI
{
    partial class FrmDetalleHuespedHabitacionReserva
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            botonAgregarHuesped = new Button();
            gridHuespedes = new DataGridView();
            Huesped = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Comentarios = new DataGridViewTextBoxColumn();
            labelHabitacion = new Label();
            labelNombreHabitacion = new Label();
            labelReserva = new Label();
            labelIdReserva = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridHuespedes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(299, 21);
            label1.TabIndex = 0;
            label1.Text = "Gestion los Huespedes por Habitacion";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelIdReserva);
            groupBox1.Controls.Add(labelReserva);
            groupBox1.Controls.Add(labelNombreHabitacion);
            groupBox1.Controls.Add(labelHabitacion);
            groupBox1.Location = new Point(12, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(683, 72);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información de Reserva";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(botonAgregarHuesped);
            groupBox2.Controls.Add(gridHuespedes);
            groupBox2.Location = new Point(12, 111);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(683, 277);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Huespedes";
            // 
            // botonAgregarHuesped
            // 
            botonAgregarHuesped.Location = new Point(654, 22);
            botonAgregarHuesped.Name = "botonAgregarHuesped";
            botonAgregarHuesped.Size = new Size(23, 23);
            botonAgregarHuesped.TabIndex = 3;
            botonAgregarHuesped.Text = "+";
            botonAgregarHuesped.UseVisualStyleBackColor = true;
            // 
            // gridHuespedes
            // 
            gridHuespedes.AllowUserToAddRows = false;
            gridHuespedes.AllowUserToDeleteRows = false;
            gridHuespedes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridHuespedes.BackgroundColor = SystemColors.ControlLightLight;
            gridHuespedes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridHuespedes.Columns.AddRange(new DataGridViewColumn[] { Huesped, Estado, Comentarios });
            gridHuespedes.Location = new Point(6, 22);
            gridHuespedes.Name = "gridHuespedes";
            gridHuespedes.ReadOnly = true;
            gridHuespedes.RowHeadersVisible = false;
            gridHuespedes.Size = new Size(642, 249);
            gridHuespedes.TabIndex = 0;
            // 
            // Huesped
            // 
            Huesped.DataPropertyName = "Huesped Nombre";
            Huesped.HeaderText = "Huesped";
            Huesped.Name = "Huesped";
            Huesped.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // Comentarios
            // 
            Comentarios.DataPropertyName = "Comentarios del Huesped";
            Comentarios.HeaderText = "Comentarios";
            Comentarios.Name = "Comentarios";
            Comentarios.ReadOnly = true;
            // 
            // labelHabitacion
            // 
            labelHabitacion.AutoSize = true;
            labelHabitacion.Location = new Point(355, 33);
            labelHabitacion.Name = "labelHabitacion";
            labelHabitacion.Size = new Size(68, 15);
            labelHabitacion.TabIndex = 0;
            labelHabitacion.Text = "Habitacion:";
            // 
            // labelNombreHabitacion
            // 
            labelNombreHabitacion.BorderStyle = BorderStyle.FixedSingle;
            labelNombreHabitacion.Location = new Point(429, 29);
            labelNombreHabitacion.Name = "labelNombreHabitacion";
            labelNombreHabitacion.Size = new Size(248, 23);
            labelNombreHabitacion.TabIndex = 1;
            labelNombreHabitacion.Text = "A101";
            labelNombreHabitacion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelReserva
            // 
            labelReserva.AutoSize = true;
            labelReserva.Location = new Point(6, 33);
            labelReserva.Name = "labelReserva";
            labelReserva.Size = new Size(63, 15);
            labelReserva.TabIndex = 2;
            labelReserva.Text = "Id Reserva:";
            // 
            // labelIdReserva
            // 
            labelIdReserva.BorderStyle = BorderStyle.FixedSingle;
            labelIdReserva.Location = new Point(80, 29);
            labelIdReserva.Name = "labelIdReserva";
            labelIdReserva.Size = new Size(258, 23);
            labelIdReserva.TabIndex = 3;
            labelIdReserva.Text = "A101";
            labelIdReserva.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmDetalleHuespedHabitacionReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 402);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmDetalleHuespedHabitacionReserva";
            Text = "Huespedes por Habitacion";
            Load += FrmDetalleHuespedHabitacionReserva_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridHuespedes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button botonAgregarHuesped;
        private DataGridView gridHuespedes;
        private Label labelHabitacion;
        private DataGridViewTextBoxColumn Huesped;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Comentarios;
        private Label labelIdReserva;
        private Label labelReserva;
        private Label labelNombreHabitacion;
    }
}