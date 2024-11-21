namespace ProyHotel_GUI
{
    partial class FrmActualizarTipoHabitacion
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
            label3 = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            precioTipoHabitacion = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)precioTipoHabitacion).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 59);
            label2.Name = "label2";
            label2.Size = new Size(238, 21);
            label2.TabIndex = 0;
            label2.Text = "Actualizar Tipo De Habitacion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 149);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 1;
            label3.Text = "Precio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 109);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre: ";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(109, 106);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(215, 23);
            txtNombre.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(121, 215);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 30);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(236, 215);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(80, 30);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // precioTipoHabitacion
            // 
            precioTipoHabitacion.Location = new Point(109, 149);
            precioTipoHabitacion.Name = "precioTipoHabitacion";
            precioTipoHabitacion.Size = new Size(215, 23);
            precioTipoHabitacion.TabIndex = 6;
            // 
            // FrmActualizarTipoHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 271);
            Controls.Add(precioTipoHabitacion);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "FrmActualizarTipoHabitacion";
            Text = "FrmActualizarTipoHabitacion";
            Load += FrmActualizarTipoHabitacion_Load;
            ((System.ComponentModel.ISupportInitialize)precioTipoHabitacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label1;
        private TextBox txtNombre;
        private Button btnCancelar;
        private Button btnGuardar;
        private NumericUpDown precioTipoHabitacion;
    }
}