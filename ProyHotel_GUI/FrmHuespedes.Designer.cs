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
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "Filtro por nombre";
            // 
            // dgtDatosHuesped
            // 
            dgtDatosHuesped.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtDatosHuesped.Location = new Point(27, 131);
            dgtDatosHuesped.Name = "dgtDatosHuesped";
            dgtDatosHuesped.RowHeadersWidth = 51;
            dgtDatosHuesped.Size = new Size(741, 296);
            dgtDatosHuesped.TabIndex = 1;
            // 
            // lblRegistroHuesped
            // 
            lblRegistroHuesped.BorderStyle = BorderStyle.FixedSingle;
            lblRegistroHuesped.Location = new Point(633, 455);
            lblRegistroHuesped.Name = "lblRegistroHuesped";
            lblRegistroHuesped.Size = new Size(89, 28);
            lblRegistroHuesped.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(512, 463);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 0;
            label2.Text = "Cantidad:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(157, 48);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(125, 27);
            txtFiltro.TabIndex = 3;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // btnAgregarHuesped
            // 
            btnAgregarHuesped.Location = new Point(387, 523);
            btnAgregarHuesped.Name = "btnAgregarHuesped";
            btnAgregarHuesped.Size = new Size(94, 29);
            btnAgregarHuesped.TabIndex = 4;
            btnAgregarHuesped.Text = "Agregar";
            btnAgregarHuesped.UseVisualStyleBackColor = true;
            btnAgregarHuesped.Click += btnAgregarHuesped_Click;
            // 
            // btnActualizarHuesped
            // 
            btnActualizarHuesped.Location = new Point(512, 523);
            btnActualizarHuesped.Name = "btnActualizarHuesped";
            btnActualizarHuesped.Size = new Size(94, 29);
            btnActualizarHuesped.TabIndex = 4;
            btnActualizarHuesped.Text = "Actualizar";
            btnActualizarHuesped.UseVisualStyleBackColor = true;
            btnActualizarHuesped.Click += btnActualizarHuesped_Click;
            // 
            // btnEliminarHuesped
            // 
            btnEliminarHuesped.Location = new Point(633, 523);
            btnEliminarHuesped.Name = "btnEliminarHuesped";
            btnEliminarHuesped.Size = new Size(94, 29);
            btnEliminarHuesped.TabIndex = 4;
            btnEliminarHuesped.Text = "Eliminar";
            btnEliminarHuesped.UseVisualStyleBackColor = true;
            // 
            // FrmHuespedes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 602);
            Controls.Add(btnEliminarHuesped);
            Controls.Add(btnActualizarHuesped);
            Controls.Add(btnAgregarHuesped);
            Controls.Add(txtFiltro);
            Controls.Add(lblRegistroHuesped);
            Controls.Add(dgtDatosHuesped);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmHuespedes";
            Text = "FrmHuespedes";
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