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
            label5 = new Label();
            button1 = new Button();
            textboxDNI = new TextBox();
            textboxNombre = new TextBox();
            label4 = new Label();
            textboxTelefono = new TextBox();
            button2 = new Button();
            listView1 = new ListView();
            button3 = new Button();
            button4 = new Button();
            listView2 = new ListView();
            button5 = new Button();
            botonAgregarServicio = new Button();
            label6 = new Label();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 18);
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
            label3.Location = new Point(125, 143);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(101, 184);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 4;
            label5.Text = "Habitaciones:";
            // 
            // button1
            // 
            button1.Location = new Point(404, 183);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
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
            label4.Location = new Point(126, 68);
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
            // button2
            // 
            button2.Location = new Point(404, 212);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(186, 184);
            listView1.Name = "listView1";
            listView1.Size = new Size(213, 97);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button3
            // 
            button3.Location = new Point(405, 241);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 13;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(405, 354);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 7;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            listView2.Location = new Point(186, 297);
            listView2.Name = "listView2";
            listView2.Size = new Size(213, 97);
            listView2.TabIndex = 17;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // button5
            // 
            button5.Location = new Point(404, 325);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 6;
            button5.Text = "Editar";
            button5.UseVisualStyleBackColor = true;
            // 
            // botonAgregarServicio
            // 
            botonAgregarServicio.Location = new Point(404, 296);
            botonAgregarServicio.Name = "botonAgregarServicio";
            botonAgregarServicio.Size = new Size(75, 23);
            botonAgregarServicio.TabIndex = 5;
            botonAgregarServicio.Text = "Agregar";
            botonAgregarServicio.UseVisualStyleBackColor = true;
            botonAgregarServicio.Click += botonAgregarServicio_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(124, 297);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 14;
            label6.Text = "Servicios:";
            // 
            // button7
            // 
            button7.Location = new Point(404, 453);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 8;
            button7.Text = "Guardar";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(323, 453);
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
            ClientSize = new Size(497, 488);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(listView2);
            Controls.Add(button5);
            Controls.Add(botonAgregarServicio);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(listView1);
            Controls.Add(button2);
            Controls.Add(textboxTelefono);
            Controls.Add(textboxNombre);
            Controls.Add(label4);
            Controls.Add(textboxDNI);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmCrearReserva";
            Text = "FrmCrearReserva";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Button button1;
        private TextBox textboxDNI;
        private TextBox textboxNombre;
        private Label label4;
        private TextBox textboxTelefono;
        private Button button2;
        private ListView listView1;
        private Button button3;
        private Button button4;
        private ListView listView2;
        private Button button5;
        private Button botonAgregarServicio;
        private Label label6;
        private Button button7;
        private Button button8;
    }
}