namespace ProyHotel_GUI
{
    partial class FrmHuespedes
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
            dgtDatosHuesped = new DataGridView();
            lblRegistroHuesped = new Label();
            label2 = new Label();
            txtFiltro = new TextBox();
            btnAgregarHuesped = new Button();
            btnActualizarHuesped = new Button();
            btnEliminarHuesped = new Button();
            label3 = new Label();
            botonBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgtDatosHuesped).BeginInit();
            SuspendLayout();
            // 
            // dgtDatosHuesped
            // 
            dgtDatosHuesped.AllowUserToAddRows = false;
            dgtDatosHuesped.AllowUserToDeleteRows = false;
            dgtDatosHuesped.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgtDatosHuesped.BackgroundColor = SystemColors.ControlLightLight;
            dgtDatosHuesped.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtDatosHuesped.Location = new Point(14, 95);
            dgtDatosHuesped.Name = "dgtDatosHuesped";
            dgtDatosHuesped.ReadOnly = true;
            dgtDatosHuesped.RowHeadersVisible = false;
            dgtDatosHuesped.RowHeadersWidth = 51;
            dgtDatosHuesped.Size = new Size(738, 353);
            dgtDatosHuesped.TabIndex = 1;
            // 
            // lblRegistroHuesped
            // 
            lblRegistroHuesped.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistroHuesped.BorderStyle = BorderStyle.FixedSingle;
            lblRegistroHuesped.Location = new Point(88, 481);
            lblRegistroHuesped.Name = "lblRegistroHuesped";
            lblRegistroHuesped.Size = new Size(89, 29);
            lblRegistroHuesped.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(15, 483);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 0;
            label2.Text = "Cantidad:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(479, 36);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.PlaceholderText = "Ingrese el nombre";
            txtFiltro.Size = new Size(173, 27);
            txtFiltro.TabIndex = 3;
            // 
            // btnAgregarHuesped
            // 
            btnAgregarHuesped.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAgregarHuesped.Location = new Point(659, 484);
            btnAgregarHuesped.Name = "btnAgregarHuesped";
            btnAgregarHuesped.Size = new Size(94, 33);
            btnAgregarHuesped.TabIndex = 4;
            btnAgregarHuesped.Text = "Agregar";
            btnAgregarHuesped.UseVisualStyleBackColor = true;
            btnAgregarHuesped.Click += btnAgregarHuesped_Click;
            // 
            // btnActualizarHuesped
            // 
            btnActualizarHuesped.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnActualizarHuesped.Location = new Point(559, 484);
            btnActualizarHuesped.Name = "btnActualizarHuesped";
            btnActualizarHuesped.Size = new Size(94, 33);
            btnActualizarHuesped.TabIndex = 4;
            btnActualizarHuesped.Text = "Editar";
            btnActualizarHuesped.UseVisualStyleBackColor = true;
            btnActualizarHuesped.Click += btnActualizarHuesped_Click;
            // 
            // btnEliminarHuesped
            // 
            btnEliminarHuesped.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminarHuesped.Location = new Point(458, 484);
            btnEliminarHuesped.Name = "btnEliminarHuesped";
            btnEliminarHuesped.Size = new Size(94, 33);
            btnEliminarHuesped.TabIndex = 4;
            btnEliminarHuesped.Text = "Eliminar";
            btnEliminarHuesped.UseVisualStyleBackColor = true;
            btnEliminarHuesped.Click += btnEliminar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 36);
            label3.Name = "label3";
            label3.Size = new Size(221, 28);
            label3.TabIndex = 5;
            label3.Text = "Gestion de Huéspedes";
            // 
            // botonBuscar
            // 
            botonBuscar.Location = new Point(666, 35);
            botonBuscar.Margin = new Padding(3, 4, 3, 4);
            botonBuscar.Name = "botonBuscar";
            botonBuscar.Size = new Size(86, 31);
            botonBuscar.TabIndex = 6;
            botonBuscar.Text = "Buscar";
            botonBuscar.UseVisualStyleBackColor = true;
            botonBuscar.Click += botonBuscar_Click;
            // 
            // FrmHuespedes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 532);
            Controls.Add(botonBuscar);
            Controls.Add(label3);
            Controls.Add(btnEliminarHuesped);
            Controls.Add(btnActualizarHuesped);
            Controls.Add(btnAgregarHuesped);
            Controls.Add(txtFiltro);
            Controls.Add(lblRegistroHuesped);
            Controls.Add(dgtDatosHuesped);
            Controls.Add(label2);
            Name = "FrmHuespedes";
            Text = "Gestion de Huespedes";
            Load += FrmHuespedes_Load;
            ((System.ComponentModel.ISupportInitialize)dgtDatosHuesped).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgtDatosHuesped;
        private Label lblRegistroHuesped;
        private Label label2;
        private TextBox txtFiltro;
        private Button btnAgregarHuesped;
        private Button btnActualizarHuesped;
        private Button btnEliminarHuesped;
        private Label label3;
        private Button botonBuscar;
    }
}