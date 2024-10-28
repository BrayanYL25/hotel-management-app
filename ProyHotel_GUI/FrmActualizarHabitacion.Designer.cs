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
            label1.Location = new Point(263, 38);
            label1.Name = "label1";
            label1.Size = new Size(278, 44);
            label1.TabIndex = 0;
            label1.Text = "Actualizar Habitacion";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 103);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "codigo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(402, 103);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 1;
            label3.Text = "Tipo codigo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 164);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 1;
            label4.Text = "Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(402, 164);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 1;
            label5.Text = "Tipo Habitacion:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 238);
            label6.Name = "label6";
            label6.Size = new Size(124, 20);
            label6.TabIndex = 1;
            label6.Text = "Precio por noche:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(55, 240);
            label7.Name = "label7";
            label7.Size = new Size(124, 20);
            label7.TabIndex = 1;
            label7.Text = "Precio por noche:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(402, 238);
            label8.Name = "label8";
            label8.Size = new Size(148, 20);
            label8.TabIndex = 1;
            label8.Text = "Aforo de Habitacion:";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(402, 294);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(73, 24);
            chkActivo.TabIndex = 2;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(136, 161);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(185, 235);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 3;
            // 
            // txtAforo
            // 
            txtAforo.Location = new Point(556, 235);
            txtAforo.Name = "txtAforo";
            txtAforo.Size = new Size(125, 27);
            txtAforo.TabIndex = 3;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(527, 160);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(151, 28);
            cboTipo.TabIndex = 4;
            // 
            // btnActualizar
            // 
            btnActualizar.AutoSize = true;
            btnActualizar.Location = new Point(402, 368);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(113, 47);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Location = new Point(568, 368);
            button2.Name = "button2";
            button2.Size = new Size(113, 47);
            button2.TabIndex = 5;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblIdHabitacion
            // 
            lblIdHabitacion.BorderStyle = BorderStyle.FixedSingle;
            lblIdHabitacion.Location = new Point(120, 99);
            lblIdHabitacion.Name = "lblIdHabitacion";
            lblIdHabitacion.Size = new Size(141, 24);
            lblIdHabitacion.TabIndex = 1;
            // 
            // lblIdTipoHabitacion
            // 
            lblIdTipoHabitacion.BorderStyle = BorderStyle.FixedSingle;
            lblIdTipoHabitacion.Location = new Point(501, 99);
            lblIdTipoHabitacion.Name = "lblIdTipoHabitacion";
            lblIdTipoHabitacion.Size = new Size(141, 24);
            lblIdTipoHabitacion.TabIndex = 1;
            // 
            // FrmActualizarHabitacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 465);
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
            Name = "FrmActualizarHabitacion";
            Text = "FrmActualizarHabitacion";
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