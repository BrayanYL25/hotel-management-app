namespace ProyHotel_GUI
{
    partial class FrmCrearServicio
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
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textboxServicio
            // 
            textboxServicio.Font = new Font("Segoe UI", 9F);
            textboxServicio.Location = new Point(87, 62);
            textboxServicio.Name = "textboxServicio";
            textboxServicio.Size = new Size(219, 23);
            textboxServicio.TabIndex = 0;
            textboxServicio.Validating += textboxServicio_Validating_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(17, 65);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 1;
            label1.Text = "Servicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(17, 112);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Precio";
            // 
            // textboxPrecio
            // 
            textboxPrecio.Font = new Font("Segoe UI", 9F);
            textboxPrecio.Location = new Point(87, 109);
            textboxPrecio.Name = "textboxPrecio";
            textboxPrecio.Size = new Size(219, 23);
            textboxPrecio.TabIndex = 1;
            textboxPrecio.KeyPress += textBox2_KeyPress;
            textboxPrecio.Validating += textboxPrecio_Validating;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkboxDisponible);
            groupBox1.Location = new Point(17, 153);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(289, 100);
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
            button1.Location = new Point(231, 272);
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
            botonCancelar.Location = new Point(150, 272);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(75, 23);
            botonCancelar.TabIndex = 4;
            botonCancelar.Text = "Cancelar";
            botonCancelar.UseVisualStyleBackColor = true;
            botonCancelar.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(122, 21);
            label3.TabIndex = 5;
            label3.Text = "Nuevo Servico";
            // 
            // FrmCrearServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(318, 307);
            Controls.Add(label3);
            Controls.Add(botonCancelar);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(textboxPrecio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textboxServicio);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmCrearServicio";
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
        private Label label3;
    }
}