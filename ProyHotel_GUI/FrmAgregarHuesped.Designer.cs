namespace ProyHotel_GUI
{
    partial class FrmAgregarHuesped
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
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            txtTelefono = new TextBox();
            label3 = new Label();
            TxtDni = new TextBox();
            label4 = new Label();
            btnAgregar = new Button();
            button2 = new Button();
            lblFecha = new Label();
            lblFechaaaa = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(140, 21);
            label2.TabIndex = 1;
            label2.Text = "Agregar huesped";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(201, 53);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(165, 23);
            txtNombre.TabIndex = 2;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre: ";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(201, 99);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(165, 23);
            txtTelefono.TabIndex = 2;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 3;
            label3.Text = "Telefono : ";
            // 
            // TxtDni
            // 
            TxtDni.Location = new Point(201, 150);
            TxtDni.Margin = new Padding(3, 2, 3, 2);
            TxtDni.Name = "TxtDni";
            TxtDni.Size = new Size(165, 23);
            TxtDni.TabIndex = 2;
            TxtDni.KeyPress += TxtDni_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 153);
            label4.Name = "label4";
            label4.Size = new Size(164, 15);
            label4.TabIndex = 3;
            label4.Text = "Documento de Identificación:";
            // 
            // btnAgregar
            // 
            btnAgregar.AutoSize = true;
            btnAgregar.Location = new Point(282, 267);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(84, 25);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Location = new Point(191, 267);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(85, 25);
            button2.TabIndex = 4;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(201, 227);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(0, 15);
            lblFecha.TabIndex = 5;
            // 
            // lblFechaaaa
            // 
            lblFechaaaa.AccessibleName = "";
            lblFechaaaa.BorderStyle = BorderStyle.FixedSingle;
            lblFechaaaa.Location = new Point(139, 197);
            lblFechaaaa.Name = "lblFechaaaa";
            lblFechaaaa.Size = new Size(227, 19);
            lblFechaaaa.TabIndex = 6;
            // 
            // FrmAgregarHuesped
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 303);
            Controls.Add(lblFechaaaa);
            Controls.Add(lblFecha);
            Controls.Add(button2);
            Controls.Add(btnAgregar);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtTelefono);
            Controls.Add(TxtDni);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FrmAgregarHuesped";
            Text = "Agregar Huesped";
            Load += FrmrAgregarHuesped_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private TextBox txtTelefono;
        private Label label3;
        private TextBox TxtDni;
        private Label label4;
        private Button btnAgregar;
        private Button button2;
        private Label lblFecha;
        private Label lblFechaaaa;
    }
}