namespace ProyHotel_GUI
{
    partial class CrearServicio
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
            textboxServicio = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textboxPrecio = new TextBox();
            groupBox1 = new GroupBox();
            checkboxDisponible = new CheckBox();
            button1 = new Button();
            botonCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textboxServicio
            // 
            textboxServicio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textboxServicio.Location = new Point(90, 51);
            textboxServicio.Name = "textboxServicio";
            textboxServicio.Size = new Size(203, 29);
            textboxServicio.TabIndex = 0;
            textboxServicio.Validating += textboxServicio_Validating_1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 51);
            label1.Name = "label1";
            label1.Size = new Size(67, 29);
            label1.TabIndex = 1;
            label1.Text = "Servicio";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 105);
            label2.Name = "label2";
            label2.Size = new Size(67, 29);
            label2.TabIndex = 3;
            label2.Text = "Precio";
            // 
            // textboxPrecio
            // 
            textboxPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textboxPrecio.Location = new Point(90, 105);
            textboxPrecio.Name = "textboxPrecio";
            textboxPrecio.Size = new Size(203, 29);
            textboxPrecio.TabIndex = 1;
            textboxPrecio.KeyPress += textBox2_KeyPress;
            textboxPrecio.Validating += textboxPrecio_Validating;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkboxDisponible);
            groupBox1.Location = new Point(17, 167);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(276, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado";
            // 
            // checkboxDisponible
            // 
            checkboxDisponible.AutoSize = true;
            checkboxDisponible.Location = new Point(15, 42);
            checkboxDisponible.Name = "checkboxDisponible";
            checkboxDisponible.Size = new Size(82, 19);
            checkboxDisponible.TabIndex = 0;
            checkboxDisponible.Text = "Disponible";
            checkboxDisponible.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(218, 297);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Crear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // botonCancelar
            // 
            botonCancelar.CausesValidation = false;
            botonCancelar.Location = new Point(123, 297);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(75, 23);
            botonCancelar.TabIndex = 4;
            botonCancelar.Text = "Cancelar";
            botonCancelar.UseVisualStyleBackColor = true;
            botonCancelar.Click += button2_Click;
            // 
            // CrearServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(318, 332);
            Controls.Add(botonCancelar);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(textboxPrecio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textboxServicio);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CrearServicio";
            Text = "Crear Servicio";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textboxServicio;
        private Label label1;
        private Label label2;
        private TextBox textboxPrecio;
        private GroupBox groupBox1;
        private CheckBox checkboxDisponible;
        private Button button1;
        private Button botonCancelar;
    }
}