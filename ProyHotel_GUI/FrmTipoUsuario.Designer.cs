namespace ProyHotel_GUI
{
    partial class FrmTipoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoUsuario));
            gridTipoUsuario = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            descripcionTipoUsuario = new DataGridViewTextBoxColumn();
            tituloTipoUsuario = new Label();
            botonCrearTipoUsuario = new Button();
            botonEditar = new Button();
            labelResultado = new Label();
            labelCantidadRegistros = new Label();
            botonEliminar = new Button();
            textboxTipoUsuario = new TextBox();
            botonBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridTipoUsuario).BeginInit();
            SuspendLayout();
            // 
            // gridTipoUsuario
            // 
            gridTipoUsuario.AllowUserToAddRows = false;
            gridTipoUsuario.AllowUserToDeleteRows = false;
            gridTipoUsuario.AllowUserToOrderColumns = true;
            gridTipoUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridTipoUsuario.BackgroundColor = SystemColors.ControlLightLight;
            gridTipoUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTipoUsuario.Columns.AddRange(new DataGridViewColumn[] { Id, descripcionTipoUsuario });
            gridTipoUsuario.Location = new Point(12, 76);
            gridTipoUsuario.Name = "gridTipoUsuario";
            gridTipoUsuario.ReadOnly = true;
            gridTipoUsuario.RowHeadersVisible = false;
            gridTipoUsuario.Size = new Size(454, 323);
            gridTipoUsuario.TabIndex = 0;
            // 
            // Id
            // 
            Id.DataPropertyName = "tipo_usuario_id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // descripcionTipoUsuario
            // 
            descripcionTipoUsuario.DataPropertyName = "tipo_usuario_descripcion";
            descripcionTipoUsuario.HeaderText = "Descripcion de Tipo de Usuario";
            descripcionTipoUsuario.Name = "descripcionTipoUsuario";
            descripcionTipoUsuario.ReadOnly = true;
            // 
            // tituloTipoUsuario
            // 
            tituloTipoUsuario.AutoSize = true;
            tituloTipoUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tituloTipoUsuario.Location = new Point(12, 22);
            tituloTipoUsuario.Name = "tituloTipoUsuario";
            tituloTipoUsuario.Size = new Size(137, 21);
            tituloTipoUsuario.TabIndex = 1;
            tituloTipoUsuario.Text = "Tipos de Usuario";
            // 
            // botonCrearTipoUsuario
            // 
            botonCrearTipoUsuario.Location = new Point(386, 429);
            botonCrearTipoUsuario.Name = "botonCrearTipoUsuario";
            botonCrearTipoUsuario.Size = new Size(80, 30);
            botonCrearTipoUsuario.TabIndex = 2;
            botonCrearTipoUsuario.Text = "Crear";
            botonCrearTipoUsuario.UseVisualStyleBackColor = true;
            botonCrearTipoUsuario.Click += botonCrearTipoUsuario_Click;
            // 
            // botonEditar
            // 
            botonEditar.Location = new Point(300, 429);
            botonEditar.Name = "botonEditar";
            botonEditar.Size = new Size(80, 30);
            botonEditar.TabIndex = 3;
            botonEditar.Text = "Editar";
            botonEditar.UseVisualStyleBackColor = true;
            botonEditar.Click += botonEditar_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(12, 437);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(64, 15);
            labelResultado.TabIndex = 4;
            labelResultado.Text = "Resultados";
            labelResultado.TextAlign = ContentAlignment.TopRight;
            // 
            // labelCantidadRegistros
            // 
            labelCantidadRegistros.BorderStyle = BorderStyle.FixedSingle;
            labelCantidadRegistros.Location = new Point(82, 429);
            labelCantidadRegistros.Name = "labelCantidadRegistros";
            labelCantidadRegistros.Size = new Size(67, 30);
            labelCantidadRegistros.TabIndex = 5;
            labelCantidadRegistros.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // botonEliminar
            // 
            botonEliminar.Location = new Point(214, 429);
            botonEliminar.Name = "botonEliminar";
            botonEliminar.Size = new Size(80, 30);
            botonEliminar.TabIndex = 6;
            botonEliminar.Text = "Eliminar";
            botonEliminar.UseVisualStyleBackColor = true;
            botonEliminar.Click += botonEliminar_Click;
            // 
            // textboxTipoUsuario
            // 
            textboxTipoUsuario.CharacterCasing = CharacterCasing.Upper;
            textboxTipoUsuario.Location = new Point(226, 20);
            textboxTipoUsuario.Name = "textboxTipoUsuario";
            textboxTipoUsuario.PlaceholderText = "Ingrese el tipo de usuario";
            textboxTipoUsuario.Size = new Size(154, 23);
            textboxTipoUsuario.TabIndex = 7;
            // 
            // botonBuscar
            // 
            botonBuscar.Location = new Point(386, 18);
            botonBuscar.Name = "botonBuscar";
            botonBuscar.Size = new Size(80, 25);
            botonBuscar.TabIndex = 8;
            botonBuscar.Text = "Buscar";
            botonBuscar.UseVisualStyleBackColor = true;
            botonBuscar.Click += botonBuscar_Click;
            // 
            // FrmTipoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(478, 471);
            Controls.Add(botonBuscar);
            Controls.Add(textboxTipoUsuario);
            Controls.Add(botonEliminar);
            Controls.Add(labelCantidadRegistros);
            Controls.Add(labelResultado);
            Controls.Add(botonEditar);
            Controls.Add(botonCrearTipoUsuario);
            Controls.Add(tituloTipoUsuario);
            Controls.Add(gridTipoUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmTipoUsuario";
            Text = "Tipos de usuario";
            Load += FrmTipoUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)gridTipoUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridTipoUsuario;
        private Label tituloTipoUsuario;
        private Button botonCrearTipoUsuario;
        private Button botonEditar;
        private Label labelResultado;
        private Label labelCantidadRegistros;
        private Button botonEliminar;
        private TextBox textboxTipoUsuario;
        private Button botonBuscar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn descripcionTipoUsuario;
    }
}