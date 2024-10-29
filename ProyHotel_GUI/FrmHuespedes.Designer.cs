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
            label1 = new Label();
            dgtDatosHuesped = new DataGridView();
            lblRegistroHuesped = new Label();
            label2 = new Label();
            txtFiltro = new TextBox();
            btnAgregarHuesped = new Button();
            btnActualizarHuesped = new Button();
            btnEliminarHuesped = new Button();
            ((System.ComponentModel.ISupportInitialize)dgtDatosHuesped).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 42);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Filtro por nombre";
            // 
            // dgtDatosHuesped
            // 
            dgtDatosHuesped.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgtDatosHuesped.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgtDatosHuesped.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtDatosHuesped.Location = new Point(12, 98);
            dgtDatosHuesped.Margin = new Padding(3, 2, 3, 2);
            dgtDatosHuesped.Name = "dgtDatosHuesped";
            dgtDatosHuesped.ReadOnly = true;
            dgtDatosHuesped.RowHeadersWidth = 51;
            dgtDatosHuesped.Size = new Size(646, 240);
            dgtDatosHuesped.TabIndex = 1;
            // 
            // lblRegistroHuesped
            // 
            lblRegistroHuesped.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistroHuesped.BorderStyle = BorderStyle.FixedSingle;
            lblRegistroHuesped.Location = new Point(77, 389);
            lblRegistroHuesped.Name = "lblRegistroHuesped";
            lblRegistroHuesped.Size = new Size(78, 22);
            lblRegistroHuesped.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(13, 390);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 0;
            label2.Text = "Cantidad:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(119, 39);
            txtFiltro.Margin = new Padding(3, 2, 3, 2);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(110, 23);
            txtFiltro.TabIndex = 3;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // btnAgregarHuesped
            // 
            btnAgregarHuesped.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAgregarHuesped.Location = new Point(577, 391);
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
            btnActualizarHuesped.Location = new Point(489, 391);
            btnActualizarHuesped.Margin = new Padding(3, 2, 3, 2);
            btnActualizarHuesped.Name = "btnActualizarHuesped";
            btnActualizarHuesped.Size = new Size(82, 25);
            btnActualizarHuesped.TabIndex = 4;
            btnActualizarHuesped.Text = "Actualizar";
            btnActualizarHuesped.UseVisualStyleBackColor = true;
            btnActualizarHuesped.Click += btnActualizarHuesped_Click;
            // 
            // btnEliminarHuesped
            // 
            btnEliminarHuesped.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminarHuesped.Location = new Point(401, 391);
            btnEliminarHuesped.Margin = new Padding(3, 2, 3, 2);
            btnEliminarHuesped.Name = "btnEliminarHuesped";
            btnEliminarHuesped.Size = new Size(82, 25);
            btnEliminarHuesped.TabIndex = 4;
            btnEliminarHuesped.Text = "Eliminar";
            btnEliminarHuesped.UseVisualStyleBackColor = true;
            btnEliminarHuesped.Click += btnEliminar_Click;
            // 
            // FrmHuespedes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 438);
            Controls.Add(btnEliminarHuesped);
            Controls.Add(btnActualizarHuesped);
            Controls.Add(btnAgregarHuesped);
            Controls.Add(txtFiltro);
            Controls.Add(lblRegistroHuesped);
            Controls.Add(dgtDatosHuesped);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmHuespedes";
            Text = "Gestion de Huespedes";
            Load += FrmHuespedes_Load;
            ((System.ComponentModel.ISupportInitialize)dgtDatosHuesped).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgtDatosHuesped;
        private Label lblRegistroHuesped;
        private Label label2;
        private TextBox txtFiltro;
        private Button btnAgregarHuesped;
        private Button btnActualizarHuesped;
        private Button btnEliminarHuesped;
    }
}