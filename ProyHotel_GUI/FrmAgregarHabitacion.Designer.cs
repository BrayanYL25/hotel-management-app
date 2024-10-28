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
            label1.Location = new Point(200, 48);
            label1.Name = "label1";
            label1.Size = new Size(382, 48);
            label1.TabIndex = 0;
            label1.Text = "AGREGAR HABITACION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 140);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(473, 140);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 1;
            label3.Text = "Tipo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 215);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 1;
            label4.Text = "Precio por Noche:";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(522, 282);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(73, 24);
            chkActivo.TabIndex = 2;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtPrecioPorNoche
            // 
            txtPrecioPorNoche.Location = new Point(214, 215);
            txtPrecioPorNoche.Name = "txtPrecioPorNoche";
            txtPrecioPorNoche.Size = new Size(171, 27);
            txtPrecioPorNoche.TabIndex = 3;
            txtPrecioPorNoche.KeyPress += txtPrecioPorNoche_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(156, 133);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(171, 27);
            txtNombre.TabIndex = 3;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(547, 140);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(151, 28);
            cboTipo.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSize = true;
            btnGuardar.Location = new Point(368, 351);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(126, 44);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.Location = new Point(531, 351);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(126, 44);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(485, 215);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 1;
            label5.Text = "Aforo:";
            // 
            // txtAforo
            // 
            txtAforo.Location = new Point(560, 215);
            txtAforo.Name = "txtAforo";
            txtAforo.Size = new Size(125, 27);
            txtAforo.TabIndex = 6;
            txtAforo.KeyPress += txtAforo_KeyPress;
            // 
            // FrmAgregarHabitacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "FrmAgregarHabitacion";
            Text = "FrmAgregarHabitacion";
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