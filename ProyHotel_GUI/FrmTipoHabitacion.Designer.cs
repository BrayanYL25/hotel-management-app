namespace ProyHotel_GUI
{
    partial class FrmTipoHabitacion
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
            txtFiltroTipoHabitacion = new TextBox();
            btnBuscar = new Button();
            label3 = new Label();
            lblRegistroTipoHabitaciones = new Label();
            btnAgregarTipoHabitacion = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            dgtDatosTipoHabitacion = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgtDatosTipoHabitacion).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 23);
            label1.Name = "label1";
            label1.Size = new Size(213, 20);
            label1.TabIndex = 0;
            label1.Text = "Gestión Tipo de Habitaciones";
            // 
            // txtFiltroTipoHabitacion
            // 
            txtFiltroTipoHabitacion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFiltroTipoHabitacion.Location = new Point(345, 20);
            txtFiltroTipoHabitacion.Margin = new Padding(3, 2, 3, 2);
            txtFiltroTipoHabitacion.Name = "txtFiltroTipoHabitacion";
            txtFiltroTipoHabitacion.PlaceholderText = "Ingrese la habitacion";
            txtFiltroTipoHabitacion.Size = new Size(172, 23);
            txtFiltroTipoHabitacion.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.Location = new Point(523, 20);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(25, 494);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 2;
            label3.Text = "Total de registros: ";
            // 
            // lblRegistroTipoHabitaciones
            // 
            lblRegistroTipoHabitaciones.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblRegistroTipoHabitaciones.BorderStyle = BorderStyle.FixedSingle;
            lblRegistroTipoHabitaciones.Location = new Point(131, 490);
            lblRegistroTipoHabitaciones.Name = "lblRegistroTipoHabitaciones";
            lblRegistroTipoHabitaciones.Size = new Size(84, 22);
            lblRegistroTipoHabitaciones.TabIndex = 4;
            lblRegistroTipoHabitaciones.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAgregarTipoHabitacion
            // 
            btnAgregarTipoHabitacion.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAgregarTipoHabitacion.AutoSize = true;
            btnAgregarTipoHabitacion.Location = new Point(518, 486);
            btnAgregarTipoHabitacion.Margin = new Padding(3, 2, 3, 2);
            btnAgregarTipoHabitacion.Name = "btnAgregarTipoHabitacion";
            btnAgregarTipoHabitacion.Size = new Size(80, 30);
            btnAgregarTipoHabitacion.TabIndex = 5;
            btnAgregarTipoHabitacion.Text = "Crear";
            btnAgregarTipoHabitacion.UseVisualStyleBackColor = true;
            btnAgregarTipoHabitacion.Click += btnAgregarTipoHabitacion_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnActualizar.AutoSize = true;
            btnActualizar.Location = new Point(426, 486);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(86, 30);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Editar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.AutoSize = true;
            btnEliminar.Location = new Point(340, 486);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(80, 30);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgtDatosTipoHabitacion
            // 
            dgtDatosTipoHabitacion.AllowUserToAddRows = false;
            dgtDatosTipoHabitacion.AllowUserToDeleteRows = false;
            dgtDatosTipoHabitacion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgtDatosTipoHabitacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgtDatosTipoHabitacion.BackgroundColor = SystemColors.ControlLightLight;
            dgtDatosTipoHabitacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtDatosTipoHabitacion.Location = new Point(25, 53);
            dgtDatosTipoHabitacion.Name = "dgtDatosTipoHabitacion";
            dgtDatosTipoHabitacion.ReadOnly = true;
            dgtDatosTipoHabitacion.RowHeadersVisible = false;
            dgtDatosTipoHabitacion.Size = new Size(573, 428);
            dgtDatosTipoHabitacion.TabIndex = 0;
            dgtDatosTipoHabitacion.CellContentClick += dgtDatosTipoHabitacion_CellContentClick;
            // 
            // FrmTipoHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 525);
            Controls.Add(dgtDatosTipoHabitacion);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(label1);
            Controls.Add(btnActualizar);
            Controls.Add(txtFiltroTipoHabitacion);
            Controls.Add(btnAgregarTipoHabitacion);
            Controls.Add(lblRegistroTipoHabitaciones);
            Controls.Add(label3);
            Name = "FrmTipoHabitacion";
            Text = "FrmTipoHabitacion";
            Load += FrmTipoHabitacion_Load;
            ((System.ComponentModel.ISupportInitialize)dgtDatosTipoHabitacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFiltroTipoHabitacion;
        private Button btnBuscar;
        private Label label3;
        private Label lblRegistroTipoHabitaciones;
        private Button btnAgregarTipoHabitacion;
        private Button btnActualizar;
        private Button btnEliminar;
        private DataGridView dgtDatosTipoHabitacion;
    }
}