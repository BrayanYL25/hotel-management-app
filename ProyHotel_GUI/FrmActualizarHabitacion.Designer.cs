namespace ProyHotel_GUI
{
    partial class FrmActualizarHabitacion
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            chkActivo = new CheckBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtAforo = new TextBox();
            cboTipo = new ComboBox();
            btnActualizar = new Button();
            button2 = new Button();
            lblIdHabitacion = new Label();
            lblIdTipoHabitacion = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(230, 28);
            label1.Name = "label1";
            label1.Size = new Size(243, 33);
            label1.TabIndex = 0;
            label1.Text = "Actualizar Habitacion";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 77);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "codigo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(352, 77);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 1;
            label3.Text = "Tipo codigo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 123);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 1;
            label4.Text = "Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(352, 123);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 1;
            label5.Text = "Tipo Habitacion:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 178);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 1;
            label6.Text = "Precio por noche:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 180);
            label7.Name = "label7";
            label7.Size = new Size(100, 15);
            label7.TabIndex = 1;
            label7.Text = "Precio por noche:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(352, 178);
            label8.Name = "label8";
            label8.Size = new Size(117, 15);
            label8.TabIndex = 1;
            label8.Text = "Aforo de Habitacion:";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(352, 220);
            chkActivo.Margin = new Padding(3, 2, 3, 2);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 2;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(119, 121);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(110, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(162, 176);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(110, 23);
            txtPrecio.TabIndex = 3;
            // 
            // txtAforo
            // 
            txtAforo.Location = new Point(486, 176);
            txtAforo.Margin = new Padding(3, 2, 3, 2);
            txtAforo.Name = "txtAforo";
            txtAforo.Size = new Size(110, 23);
            txtAforo.TabIndex = 3;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(461, 120);
            cboTipo.Margin = new Padding(3, 2, 3, 2);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(133, 23);
            cboTipo.TabIndex = 4;
            // 
            // btnActualizar
            // 
            btnActualizar.AutoSize = true;
            btnActualizar.Location = new Point(352, 276);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(99, 35);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Location = new Point(497, 276);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(99, 35);
            button2.TabIndex = 5;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblIdHabitacion
            // 
            lblIdHabitacion.BorderStyle = BorderStyle.FixedSingle;
            lblIdHabitacion.Location = new Point(105, 74);
            lblIdHabitacion.Name = "lblIdHabitacion";
            lblIdHabitacion.Size = new Size(124, 18);
            lblIdHabitacion.TabIndex = 1;
            // 
            // lblIdTipoHabitacion
            // 
            lblIdTipoHabitacion.BorderStyle = BorderStyle.FixedSingle;
            lblIdTipoHabitacion.Location = new Point(438, 74);
            lblIdTipoHabitacion.Name = "lblIdTipoHabitacion";
            lblIdTipoHabitacion.Size = new Size(124, 18);
            lblIdTipoHabitacion.TabIndex = 1;
            // 
            // FrmActualizarHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 349);
            Controls.Add(button2);
            Controls.Add(btnActualizar);
            Controls.Add(cboTipo);
            Controls.Add(txtAforo);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(chkActivo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblIdTipoHabitacion);
            Controls.Add(lblIdHabitacion);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmActualizarHabitacion";
            Text = "Editar Habitacion";
            Load += FrmActualizarHabitacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private CheckBox chkActivo;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtAforo;
        private ComboBox cboTipo;
        private Button btnActualizar;
        private Button button2;
        private Label lblIdHabitacion;
        private Label lblIdTipoHabitacion;
    }
}