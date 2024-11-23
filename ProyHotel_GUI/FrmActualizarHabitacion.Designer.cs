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
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            chkActivo = new CheckBox();
            txtNombre = new TextBox();
            cboTipo = new ComboBox();
            btnActualizar = new Button();
            button2 = new Button();
            lblIdHabitacion = new Label();
            groupBox1 = new GroupBox();
            numericoAforo = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericoAforo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(175, 21);
            label1.TabIndex = 0;
            label1.Text = "Actualizar Habitacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Codigo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 101);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 1;
            label4.Text = "Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 149);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 1;
            label5.Text = "Tipo Habitacion:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 192);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 1;
            label8.Text = "Aforo:";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(13, 46);
            chkActivo.Margin = new Padding(3, 2, 3, 2);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(81, 19);
            chkActivo.TabIndex = 2;
            chkActivo.Text = "Habilitado";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(135, 101);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(165, 23);
            txtNombre.TabIndex = 3;
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(135, 146);
            cboTipo.Margin = new Padding(3, 2, 3, 2);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(165, 23);
            cboTipo.TabIndex = 4;
            // 
            // btnActualizar
            // 
            btnActualizar.AutoSize = true;
            btnActualizar.Location = new Point(220, 355);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(80, 30);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Editar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Location = new Point(134, 355);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(80, 30);
            button2.TabIndex = 5;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblIdHabitacion
            // 
            lblIdHabitacion.BorderStyle = BorderStyle.FixedSingle;
            lblIdHabitacion.Location = new Point(135, 52);
            lblIdHabitacion.Name = "lblIdHabitacion";
            lblIdHabitacion.Size = new Size(165, 25);
            lblIdHabitacion.TabIndex = 1;
            lblIdHabitacion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkActivo);
            groupBox1.Location = new Point(12, 234);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(288, 100);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado";
            // 
            // numericoAforo
            // 
            numericoAforo.Location = new Point(135, 190);
            numericoAforo.Name = "numericoAforo";
            numericoAforo.Size = new Size(165, 23);
            numericoAforo.TabIndex = 7;
            numericoAforo.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericoAforo.ValueChanged += numericoAforo_ValueChanged;
            // 
            // FrmActualizarHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 397);
            Controls.Add(numericoAforo);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(btnActualizar);
            Controls.Add(cboTipo);
            Controls.Add(txtNombre);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblIdHabitacion);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmActualizarHabitacion";
            Text = "Editar Habitacion";
            Load += FrmActualizarHabitacion_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericoAforo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label8;
        private CheckBox chkActivo;
        private TextBox txtNombre;
        private ComboBox cboTipo;
        private Button btnActualizar;
        private Button button2;
        private Label lblIdHabitacion;
        private GroupBox groupBox1;
        private NumericUpDown numericoAforo;
    }
}