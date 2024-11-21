namespace ProyHotel_GUI
{
    partial class FrmAgregarTipoHabitacion
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtNombre = new TextBox();
            precioTipoHabitacion = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)precioTipoHabitacion).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 60);
            label2.Name = "label2";
            label2.Size = new Size(212, 21);
            label2.TabIndex = 0;
            label2.Text = "Nuevo Tipo De Habitacion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 102);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 142);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 1;
            label3.Text = "Precio:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(119, 189);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 30);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(226, 189);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(80, 30);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(105, 99);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(201, 23);
            txtNombre.TabIndex = 3;
            // 
            // precioTipoHabitacion
            // 
            precioTipoHabitacion.Location = new Point(105, 140);
            precioTipoHabitacion.Name = "precioTipoHabitacion";
            precioTipoHabitacion.Size = new Size(201, 23);
            precioTipoHabitacion.TabIndex = 4;
            // 
            // FrmAgregarTipoHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 263);
            Controls.Add(precioTipoHabitacion);
            Controls.Add(txtNombre);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "FrmAgregarTipoHabitacion";
            Text = "FrmAgregarTipoHabitacion";
            Load += FrmAgregarTipoHabitacion_Load;
            ((System.ComponentModel.ISupportInitialize)precioTipoHabitacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtNombre;
        private NumericUpDown precioTipoHabitacion;
    }
}