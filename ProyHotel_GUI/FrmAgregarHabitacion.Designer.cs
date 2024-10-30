namespace ProyHotel_GUI
{
    partial class FrmAgregarHabitacion
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            chkActivo = new CheckBox();
            txtPrecioPorNoche = new TextBox();
            txtNombre = new TextBox();
            cboTipo = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            label5 = new Label();
            txtAforo = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(175, 36);
            label1.Name = "label1";
            label1.Size = new Size(334, 36);
            label1.TabIndex = 0;
            label1.Text = "AGREGAR HABITACION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 105);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(414, 105);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 1;
            label3.Text = "Tipo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 161);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 1;
            label4.Text = "Precio por Noche:";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(457, 212);
            chkActivo.Margin = new Padding(3, 2, 3, 2);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 2;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtPrecioPorNoche
            // 
            txtPrecioPorNoche.Location = new Point(187, 161);
            txtPrecioPorNoche.Margin = new Padding(3, 2, 3, 2);
            txtPrecioPorNoche.Name = "txtPrecioPorNoche";
            txtPrecioPorNoche.Size = new Size(150, 23);
            txtPrecioPorNoche.TabIndex = 3;
            txtPrecioPorNoche.KeyPress += txtPrecioPorNoche_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(136, 100);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 23);
            txtNombre.TabIndex = 3;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(479, 105);
            cboTipo.Margin = new Padding(3, 2, 3, 2);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(133, 23);
            cboTipo.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSize = true;
            btnGuardar.Location = new Point(322, 263);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 33);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.Location = new Point(465, 263);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 33);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(424, 161);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 1;
            label5.Text = "Aforo:";
            // 
            // txtAforo
            // 
            txtAforo.Location = new Point(490, 161);
            txtAforo.Margin = new Padding(3, 2, 3, 2);
            txtAforo.Name = "txtAforo";
            txtAforo.Size = new Size(110, 23);
            txtAforo.TabIndex = 6;
            txtAforo.KeyPress += txtAforo_KeyPress;
            // 
            // FrmAgregarHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(txtAforo);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(cboTipo);
            Controls.Add(txtNombre);
            Controls.Add(txtPrecioPorNoche);
            Controls.Add(chkActivo);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmAgregarHabitacion";
            Text = "Agregar Habitacion";
            Load += FrmAgregarHabitacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox chkActivo;
        private TextBox txtPrecioPorNoche;
        private TextBox txtNombre;
        private ComboBox cboTipo;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label label5;
        private TextBox txtAforo;
    }
}