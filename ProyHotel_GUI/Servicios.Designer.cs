namespace ProyHotel_GUI
{
    partial class Servicios
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
            gridServicios = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            servicioDescripcion = new DataGridViewTextBoxColumn();
            servicioPrecio = new DataGridViewTextBoxColumn();
            servicioFechaCreacion = new DataGridViewTextBoxColumn();
            servicioEstado = new DataGridViewTextBoxColumn();
            label1 = new Label();
            recordsCount = new Label();
            botonCrear = new Button();
            botonEditar = new Button();
            label2 = new Label();
            botonEliminar = new Button();
            botonBuscar = new Button();
            buscarServicioTextbox = new TextBox();
            botonRefrescar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridServicios).BeginInit();
            SuspendLayout();
            // 
            // gridServicios
            // 
            gridServicios.AllowUserToAddRows = false;
            gridServicios.AllowUserToDeleteRows = false;
            gridServicios.AllowUserToOrderColumns = true;
            gridServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridServicios.BackgroundColor = SystemColors.ControlLightLight;
            gridServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridServicios.Columns.AddRange(new DataGridViewColumn[] { Id, servicioDescripcion, servicioPrecio, servicioFechaCreacion, servicioEstado });
            gridServicios.Location = new Point(13, 68);
            gridServicios.Name = "gridServicios";
            gridServicios.ReadOnly = true;
            gridServicios.RowHeadersVisible = false;
            gridServicios.Size = new Size(772, 382);
            gridServicios.TabIndex = 0;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // servicioDescripcion
            // 
            servicioDescripcion.DataPropertyName = "Servicio Descripcion";
            servicioDescripcion.HeaderText = "Descripcion de Servicio";
            servicioDescripcion.Name = "servicioDescripcion";
            servicioDescripcion.ReadOnly = true;
            // 
            // servicioPrecio
            // 
            servicioPrecio.DataPropertyName = "Precio";
            servicioPrecio.HeaderText = "Precio del Servicio";
            servicioPrecio.Name = "servicioPrecio";
            servicioPrecio.ReadOnly = true;
            // 
            // servicioFechaCreacion
            // 
            servicioFechaCreacion.DataPropertyName = "Fecha Creacion";
            servicioFechaCreacion.HeaderText = "Fecha de Creacion";
            servicioFechaCreacion.Name = "servicioFechaCreacion";
            servicioFechaCreacion.ReadOnly = true;
            // 
            // servicioEstado
            // 
            servicioEstado.DataPropertyName = "Estado";
            servicioEstado.HeaderText = "Estado";
            servicioEstado.Name = "servicioEstado";
            servicioEstado.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 481);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 1;
            label1.Text = "Registros";
            // 
            // recordsCount
            // 
            recordsCount.BorderStyle = BorderStyle.FixedSingle;
            recordsCount.Location = new Point(74, 480);
            recordsCount.Name = "recordsCount";
            recordsCount.Size = new Size(100, 25);
            recordsCount.TabIndex = 2;
            recordsCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // botonCrear
            // 
            botonCrear.Location = new Point(606, 481);
            botonCrear.Name = "botonCrear";
            botonCrear.Size = new Size(80, 25);
            botonCrear.TabIndex = 3;
            botonCrear.Text = "Crear";
            botonCrear.UseVisualStyleBackColor = true;
            botonCrear.Click += botonCrear_Click;
            // 
            // botonEditar
            // 
            botonEditar.Location = new Point(705, 481);
            botonEditar.Name = "botonEditar";
            botonEditar.Size = new Size(80, 25);
            botonEditar.TabIndex = 4;
            botonEditar.Text = "Editar";
            botonEditar.UseVisualStyleBackColor = true;
            botonEditar.Click += botonEditar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 26);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 5;
            label2.Text = "Servicios";
            // 
            // botonEliminar
            // 
            botonEliminar.Location = new Point(511, 481);
            botonEliminar.Name = "botonEliminar";
            botonEliminar.Size = new Size(80, 25);
            botonEliminar.TabIndex = 6;
            botonEliminar.Text = "Eliminar";
            botonEliminar.UseVisualStyleBackColor = true;
            botonEliminar.Click += botonEliminar_Click;
            // 
            // botonBuscar
            // 
            botonBuscar.Location = new Point(705, 26);
            botonBuscar.Name = "botonBuscar";
            botonBuscar.Size = new Size(80, 25);
            botonBuscar.TabIndex = 7;
            botonBuscar.Text = "Buscar";
            botonBuscar.UseVisualStyleBackColor = true;
            botonBuscar.Click += botonBuscar_Click;
            // 
            // buscarServicioTextbox
            // 
            buscarServicioTextbox.Location = new Point(531, 28);
            buscarServicioTextbox.Name = "buscarServicioTextbox";
            buscarServicioTextbox.PlaceholderText = "Ingrese el servicio";
            buscarServicioTextbox.Size = new Size(168, 23);
            buscarServicioTextbox.TabIndex = 8;
            // 
            // botonRefrescar
            // 
            botonRefrescar.Location = new Point(98, 26);
            botonRefrescar.Name = "botonRefrescar";
            botonRefrescar.Size = new Size(80, 25);
            botonRefrescar.TabIndex = 9;
            botonRefrescar.Text = "Refrescar";
            botonRefrescar.UseVisualStyleBackColor = true;
            botonRefrescar.Click += botonRefrescar_Click;
            // 
            // Servicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 535);
            Controls.Add(botonRefrescar);
            Controls.Add(buscarServicioTextbox);
            Controls.Add(botonBuscar);
            Controls.Add(botonEliminar);
            Controls.Add(label2);
            Controls.Add(botonEditar);
            Controls.Add(botonCrear);
            Controls.Add(recordsCount);
            Controls.Add(label1);
            Controls.Add(gridServicios);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Servicios";
            Text = "Gestion Servicios";
            Load += Servicios_Load;
            ((System.ComponentModel.ISupportInitialize)gridServicios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridServicios;
        private Label label1;
        private Label recordsCount;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn servicioDescripcion;
        private DataGridViewTextBoxColumn servicioPrecio;
        private DataGridViewTextBoxColumn servicioFechaCreacion;
        private DataGridViewTextBoxColumn servicioEstado;
        private Button botonCrear;
        private Button botonEditar;
        private Label label2;
        private Button botonEliminar;
        private Button botonBuscar;
        private TextBox buscarServicioTextbox;
        private Button botonRefrescar;
    }
}