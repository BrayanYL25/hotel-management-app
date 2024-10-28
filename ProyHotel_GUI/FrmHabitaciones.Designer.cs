namespace ProyHotel_GUI
{
    partial class FrmHabitaciones
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
            button1 = new Button();
            label2 = new Label();
            txtFiltroHabitacion = new TextBox();
            dgtDatosHabitaciones = new DataGridView();
            lblRegistroHabitaciones = new Label();
            label3 = new Label();
            btnAgregarHabitacion = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgtDatosHabitaciones).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(366, 33);
            label1.Name = "label1";
            label1.Size = new Size(368, 37);
            label1.TabIndex = 0;
            label1.Text = "FORMULARIO HABITACIONES";
            // 
            // button1
            // 
            button1.Location = new Point(816, 40);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 1;
            button1.Text = "cerrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 50);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 2;
            label2.Text = "Buscar por nombre: ";
            // 
            // txtFiltroHabitacion
            // 
            txtFiltroHabitacion.Location = new Point(208, 46);
            txtFiltroHabitacion.Margin = new Padding(3, 2, 3, 2);
            txtFiltroHabitacion.Name = "txtFiltroHabitacion";
            txtFiltroHabitacion.Size = new Size(110, 23);
            txtFiltroHabitacion.TabIndex = 3;
            txtFiltroHabitacion.TextChanged += txtFiltroHabitacion_TextChanged;
            // 
            // dgtDatosHabitaciones
            // 
            dgtDatosHabitaciones.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dgtDatosHabitaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtDatosHabitaciones.Location = new Point(31, 83);
            dgtDatosHabitaciones.Name = "dgtDatosHabitaciones";
            dgtDatosHabitaciones.RowHeadersVisible = false;
            dgtDatosHabitaciones.RowHeadersWidth = 51;
            dgtDatosHabitaciones.Size = new Size(900, 332);
            dgtDatosHabitaciones.TabIndex = 0;
            // 
            // lblRegistroHabitaciones
            // 
            lblRegistroHabitaciones.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistroHabitaciones.BorderStyle = BorderStyle.FixedSingle;
            lblRegistroHabitaciones.Location = new Point(815, 429);
            lblRegistroHabitaciones.Name = "lblRegistroHabitaciones";
            lblRegistroHabitaciones.Size = new Size(84, 22);
            lblRegistroHabitaciones.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(665, 436);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 2;
            label3.Text = "Total de registros: ";
            // 
            // btnAgregarHabitacion
            // 
            btnAgregarHabitacion.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAgregarHabitacion.AutoSize = true;
            btnAgregarHabitacion.Location = new Point(494, 469);
            btnAgregarHabitacion.Margin = new Padding(3, 2, 3, 2);
            btnAgregarHabitacion.Name = "btnAgregarHabitacion";
            btnAgregarHabitacion.Size = new Size(122, 38);
            btnAgregarHabitacion.TabIndex = 5;
            btnAgregarHabitacion.Text = "AGREGAR";
            btnAgregarHabitacion.UseVisualStyleBackColor = true;
            btnAgregarHabitacion.Click += btnAgregarHabitacion_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnActualizar.AutoSize = true;
            btnActualizar.Location = new Point(652, 469);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(122, 38);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.AutoSize = true;
            btnEliminar.Location = new Point(794, 469);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(122, 38);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmHabitaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 524);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregarHabitacion);
            Controls.Add(lblRegistroHabitaciones);
            Controls.Add(dgtDatosHabitaciones);
            Controls.Add(txtFiltroHabitacion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmHabitaciones";
            Text = "FrmHabitaciones";
            Load += FrmHabitaciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgtDatosHabitaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox txtFiltroHabitacion;
        private DataGridView dgtDatosHabitaciones;
        private Label lblRegistroHabitaciones;
        private Label label3;
        private Button btnAgregarHabitacion;
        private Button btnActualizar;
        private Button btnEliminar;
    }
}