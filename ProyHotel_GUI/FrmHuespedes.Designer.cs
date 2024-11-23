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
            dgtDatosHuesped.Location = new Point(12, 71);
            dgtDatosHuesped.Margin = new Padding(3, 2, 3, 2);
            dgtDatosHuesped.Name = "dgtDatosHuesped";
            dgtDatosHuesped.ReadOnly = true;
            dgtDatosHuesped.RowHeadersVisible = false;
            dgtDatosHuesped.RowHeadersWidth = 51;
            dgtDatosHuesped.Size = new Size(646, 265);
            dgtDatosHuesped.TabIndex = 1;
            // 
            // lblRegistroHuesped
            // 
            lblRegistroHuesped.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistroHuesped.BorderStyle = BorderStyle.FixedSingle;
            lblRegistroHuesped.Location = new Point(77, 361);
            lblRegistroHuesped.Name = "lblRegistroHuesped";
            lblRegistroHuesped.Size = new Size(78, 22);
            lblRegistroHuesped.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(13, 362);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 0;
            label2.Text = "Cantidad:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(419, 27);
            txtFiltro.Margin = new Padding(3, 2, 3, 2);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.PlaceholderText = "Ingrese el nombre";
            txtFiltro.Size = new Size(152, 23);
            txtFiltro.TabIndex = 3;
            // 
            // btnAgregarHuesped
            // 
            btnAgregarHuesped.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAgregarHuesped.Location = new Point(577, 363);
            btnAgregarHuesped.Margin = new Padding(3, 2, 3, 2);
            btnAgregarHuesped.Name = "btnAgregarHuesped";
            btnAgregarHuesped.Size = new Size(82, 25);
            btnAgregarHuesped.TabIndex = 4;
            btnAgregarHuesped.Text = "Agregar";
            btnAgregarHuesped.UseVisualStyleBackColor = true;
            btnAgregarHuesped.Click += btnAgregarHuesped_Click;
            // 
            // btnActualizarHuesped
            // 
            btnActualizarHuesped.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnActualizarHuesped.Location = new Point(489, 363);
            btnActualizarHuesped.Margin = new Padding(3, 2, 3, 2);
            btnActualizarHuesped.Name = "btnActualizarHuesped";
            btnActualizarHuesped.Size = new Size(82, 25);
            btnActualizarHuesped.TabIndex = 4;
            btnActualizarHuesped.Text = "Editar";
            btnActualizarHuesped.UseVisualStyleBackColor = true;
            btnActualizarHuesped.Click += btnActualizarHuesped_Click;
            // 
            // btnEliminarHuesped
            // 
            btnEliminarHuesped.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminarHuesped.Location = new Point(401, 363);
            btnEliminarHuesped.Margin = new Padding(3, 2, 3, 2);
            btnEliminarHuesped.Name = "btnEliminarHuesped";
            btnEliminarHuesped.Size = new Size(82, 25);
            btnEliminarHuesped.TabIndex = 4;
            btnEliminarHuesped.Text = "Eliminar";
            btnEliminarHuesped.UseVisualStyleBackColor = true;
            btnEliminarHuesped.Click += btnEliminar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 27);
            label3.Name = "label3";
            label3.Size = new Size(178, 21);
            label3.TabIndex = 5;
            label3.Text = "Gestion de Huéspedes";
            // 
            // botonBuscar
            // 
            botonBuscar.Location = new Point(583, 26);
            botonBuscar.Name = "botonBuscar";
            botonBuscar.Size = new Size(75, 23);
            botonBuscar.TabIndex = 6;
            botonBuscar.Text = "Buscar";
            botonBuscar.UseVisualStyleBackColor = true;
            botonBuscar.Click += botonBuscar_Click;
            // 
            // FrmHuespedes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 399);
            Controls.Add(botonBuscar);
            Controls.Add(label3);
            Controls.Add(btnEliminarHuesped);
            Controls.Add(btnActualizarHuesped);
            Controls.Add(btnAgregarHuesped);
            Controls.Add(txtFiltro);
            Controls.Add(lblRegistroHuesped);
            Controls.Add(dgtDatosHuesped);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
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