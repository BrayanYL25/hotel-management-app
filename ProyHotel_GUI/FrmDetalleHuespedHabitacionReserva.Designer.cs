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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetalleHuespedHabitacionReserva));
            label1 = new Label();
            groupBox1 = new GroupBox();
            labelIdReserva = new Label();
            labelReserva = new Label();
            labelNombreHabitacion = new Label();
            labelHabitacion = new Label();
            groupBox2 = new GroupBox();
            botonBorrarHabitacion = new Button();
            botonAgregarHuesped = new Button();
            gridHuespedes = new DataGridView();
            huespedId = new DataGridViewTextBoxColumn();
            Huesped = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Comentarios = new DataGridViewTextBoxColumn();
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
            // labelIdReserva
            // 
            labelIdReserva.BorderStyle = BorderStyle.FixedSingle;
            labelIdReserva.Location = new Point(70, 22);
            labelIdReserva.Name = "labelIdReserva";
            labelIdReserva.Size = new Size(226, 18);
            labelIdReserva.TabIndex = 3;
            labelIdReserva.Text = "A101";
            labelIdReserva.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelReserva
            // 
            labelReserva.AutoSize = true;
            labelReserva.Location = new Point(5, 25);
            labelReserva.Name = "labelReserva";
            labelReserva.Size = new Size(63, 15);
            labelReserva.TabIndex = 2;
            labelReserva.Text = "Id Reserva:";
            // 
            // labelNombreHabitacion
            // 
            labelNombreHabitacion.BorderStyle = BorderStyle.FixedSingle;
            labelNombreHabitacion.Location = new Point(375, 22);
            labelNombreHabitacion.Name = "labelNombreHabitacion";
            labelNombreHabitacion.Size = new Size(217, 18);
            labelNombreHabitacion.TabIndex = 1;
            labelNombreHabitacion.Text = "A101";
            labelNombreHabitacion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelHabitacion
            // 
            labelHabitacion.AutoSize = true;
            labelHabitacion.Location = new Point(311, 25);
            labelHabitacion.Name = "labelHabitacion";
            labelHabitacion.Size = new Size(68, 15);
            labelHabitacion.TabIndex = 0;
            labelHabitacion.Text = "Habitacion:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(botonBorrarHabitacion);
            groupBox2.Controls.Add(botonAgregarHuesped);
            groupBox2.Controls.Add(gridHuespedes);
            groupBox2.Location = new Point(12, 111);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(683, 277);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Huespedes";
            // 
            // botonBorrarHabitacion
            // 
            botonBorrarHabitacion.Image = (Image)resources.GetObject("botonBorrarHabitacion.Image");
            botonBorrarHabitacion.Location = new Point(654, 248);
            botonBorrarHabitacion.Name = "botonBorrarHabitacion";
            botonBorrarHabitacion.Size = new Size(23, 23);
            botonBorrarHabitacion.TabIndex = 4;
            botonBorrarHabitacion.UseVisualStyleBackColor = true;
            botonBorrarHabitacion.Click += botonBorrarHabitacion_Click;
            // 
            // botonAgregarHuesped
            // 
            botonAgregarHuesped.Location = new Point(654, 22);
            botonAgregarHuesped.Name = "botonAgregarHuesped";
            botonAgregarHuesped.Size = new Size(23, 23);
            botonAgregarHuesped.TabIndex = 3;
            botonAgregarHuesped.Text = "+";
            botonAgregarHuesped.UseVisualStyleBackColor = true;
            botonAgregarHuesped.Click += botonAgregarHuesped_Click;
            // 
            // gridHuespedes
            // 
            gridHuespedes.AllowUserToAddRows = false;
            gridHuespedes.AllowUserToDeleteRows = false;
            gridHuespedes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridHuespedes.BackgroundColor = SystemColors.ControlLightLight;
            gridHuespedes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridHuespedes.Columns.AddRange(new DataGridViewColumn[] { huespedId, Huesped, Estado, Comentarios });
            gridHuespedes.Location = new Point(6, 22);
            gridHuespedes.Name = "gridHuespedes";
            gridHuespedes.ReadOnly = true;
            gridHuespedes.RowHeadersVisible = false;
            gridHuespedes.RowHeadersWidth = 51;
            gridHuespedes.Size = new Size(642, 249);
            gridHuespedes.TabIndex = 0;
            // 
            // huespedId
            // 
            huespedId.DataPropertyName = "Huesped Id";
            huespedId.HeaderText = "Huesped Id";
            huespedId.MinimumWidth = 6;
            huespedId.Name = "huespedId";
            huespedId.ReadOnly = true;
            huespedId.Visible = false;
            // 
            // Huesped
            // 
            Huesped.DataPropertyName = "Huesped Nombre";
            Huesped.HeaderText = "Huesped";
            Huesped.MinimumWidth = 6;
            Huesped.Name = "Huesped";
            Huesped.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // Comentarios
            // 
            Comentarios.DataPropertyName = "Comentarios del Huesped";
            Comentarios.HeaderText = "Comentarios";
            Comentarios.MinimumWidth = 6;
            Comentarios.Name = "Comentarios";
            Comentarios.ReadOnly = true;
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
            MaximizeBox = false;
            MinimizeBox = false;
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
        private Label labelIdReserva;
        private Label labelReserva;
        private Label labelNombreHabitacion;
        private Button botonBorrarHabitacion;
        private DataGridViewTextBoxColumn huespedId;
        private DataGridViewTextBoxColumn Huesped;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Comentarios;
    }
}