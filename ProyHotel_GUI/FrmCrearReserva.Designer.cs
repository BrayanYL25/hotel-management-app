namespace ProyHotel_GUI
{
    partial class FrmCrearReserva
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
            textboxDNI = new TextBox();
            textboxNombre = new TextBox();
            label4 = new Label();
            textboxTelefono = new TextBox();
            botonGuardar = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 19);
            label1.Name = "label1";
            label1.Size = new Size(114, 21);
            label1.TabIndex = 0;
            label1.Text = "Crear Reserva";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 105);
            label2.Name = "label2";
            label2.Size = new Size(164, 15);
            label2.TabIndex = 1;
            label2.Text = "Documento de Identificacion:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 143);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefono:";
            // 
            // textboxDNI
            // 
            textboxDNI.Location = new Point(188, 102);
            textboxDNI.Name = "textboxDNI";
            textboxDNI.Size = new Size(211, 23);
            textboxDNI.TabIndex = 1;
            textboxDNI.KeyPress += textBox1_KeyPress;
            // 
            // textboxNombre
            // 
            textboxNombre.Location = new Point(188, 65);
            textboxNombre.Name = "textboxNombre";
            textboxNombre.Size = new Size(211, 23);
            textboxNombre.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 68);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 8;
            label4.Text = "Nombre:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // textboxTelefono
            // 
            textboxTelefono.Location = new Point(188, 140);
            textboxTelefono.Name = "textboxTelefono";
            textboxTelefono.Size = new Size(211, 23);
            textboxTelefono.TabIndex = 2;
            textboxTelefono.KeyPress += textBox3_KeyPress;
            // 
            // botonGuardar
            // 
            botonGuardar.Location = new Point(326, 199);
            botonGuardar.Name = "botonGuardar";
            botonGuardar.Size = new Size(75, 23);
            botonGuardar.TabIndex = 8;
            botonGuardar.Text = "Guardar";
            botonGuardar.UseVisualStyleBackColor = true;
            botonGuardar.Click += botonGuardar_Click;
            // 
            // button8
            // 
            button8.Location = new Point(245, 199);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 9;
            button8.Text = "Cancelar";
            button8.UseVisualStyleBackColor = true;
            // 
            // FrmCrearReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 234);
            Controls.Add(button8);
            Controls.Add(botonGuardar);
            Controls.Add(textboxTelefono);
            Controls.Add(textboxNombre);
            Controls.Add(label4);
            Controls.Add(textboxDNI);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmCrearReserva";
            Text = "Crear Reserva";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textboxDNI;
        private TextBox textboxNombre;
        private Label label4;
        private TextBox textboxTelefono;
        private Button botonGuardar;
        private Button button8;
    }
}