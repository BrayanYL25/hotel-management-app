namespace ProyHotel_GUI
{
    partial class FrmHuespedHabitacion
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
            labelCodigo = new Label();
            label4 = new Label();
            labelNombre = new Label();
            textboxComentario = new TextBox();
            label6 = new Label();
            checkboxAsistencia = new CheckBox();
            botonAsignar = new Button();
            botonCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 0;
            label1.Text = "Asignar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Codigo";
            // 
            // labelCodigo
            // 
            labelCodigo.BorderStyle = BorderStyle.FixedSingle;
            labelCodigo.Location = new Point(112, 45);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(245, 23);
            labelCodigo.TabIndex = 2;
            labelCodigo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 89);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "Nombre";
            // 
            // labelNombre
            // 
            labelNombre.BorderStyle = BorderStyle.FixedSingle;
            labelNombre.Location = new Point(112, 85);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(245, 23);
            labelNombre.TabIndex = 4;
            labelNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textboxComentario
            // 
            textboxComentario.Location = new Point(112, 126);
            textboxComentario.Multiline = true;
            textboxComentario.Name = "textboxComentario";
            textboxComentario.Size = new Size(245, 95);
            textboxComentario.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 129);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 7;
            label6.Text = "Comentario";
            // 
            // checkboxAsistencia
            // 
            checkboxAsistencia.AutoSize = true;
            checkboxAsistencia.Location = new Point(214, 13);
            checkboxAsistencia.Name = "checkboxAsistencia";
            checkboxAsistencia.Size = new Size(143, 19);
            checkboxAsistencia.TabIndex = 0;
            checkboxAsistencia.Text = "Asistencia confirmada";
            checkboxAsistencia.UseVisualStyleBackColor = true;
            // 
            // botonAsignar
            // 
            botonAsignar.Location = new Point(282, 243);
            botonAsignar.Name = "botonAsignar";
            botonAsignar.Size = new Size(75, 23);
            botonAsignar.TabIndex = 8;
            botonAsignar.Text = "Asignar";
            botonAsignar.UseVisualStyleBackColor = true;
            botonAsignar.Click += botonAsignar_Click;
            // 
            // botonCancelar
            // 
            botonCancelar.Location = new Point(201, 243);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(75, 23);
            botonCancelar.TabIndex = 9;
            botonCancelar.Text = "Cancelar";
            botonCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmHuespedHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 278);
            Controls.Add(botonCancelar);
            Controls.Add(botonAsignar);
            Controls.Add(checkboxAsistencia);
            Controls.Add(label6);
            Controls.Add(textboxComentario);
            Controls.Add(labelNombre);
            Controls.Add(label4);
            Controls.Add(labelCodigo);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmHuespedHabitacion";
            Text = "Huesped de la habitacion";
            Load += FrmHuespedHabitacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label labelCodigo;
        private Label label4;
        private Label labelNombre;
        private TextBox textboxComentario;
        private Label label6;
        private CheckBox checkboxAsistencia;
        private Button botonAsignar;
        private Button botonCancelar;
    }
}