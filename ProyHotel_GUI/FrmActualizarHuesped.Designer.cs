namespace ProyHotel_GUI
{
    partial class FrmActualizarHuesped
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
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtDni = new TextBox();
            btnActualizar = new Button();
            btnCancelar = new Button();
            lblidHuesped = new Label();
            id = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(160, 22);
            label1.TabIndex = 0;
            label1.Text = "Actualizar Huesped";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 84);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 120);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 1;
            label3.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 156);
            label4.Name = "label4";
            label4.Size = new Size(164, 15);
            label4.TabIndex = 1;
            label4.Text = "Documento de Identificación:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(183, 81);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(129, 23);
            txtNombre.TabIndex = 2;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(183, 153);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(129, 23);
            txtTelefono.TabIndex = 2;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(183, 117);
            txtDni.Margin = new Padding(3, 2, 3, 2);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(129, 23);
            txtDni.TabIndex = 2;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(230, 225);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(82, 22);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(142, 225);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblidHuesped
            // 
            lblidHuesped.BorderStyle = BorderStyle.FixedSingle;
            lblidHuesped.Location = new Point(183, 47);
            lblidHuesped.Name = "lblidHuesped";
            lblidHuesped.Size = new Size(129, 19);
            lblidHuesped.TabIndex = 4;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(14, 47);
            id.Name = "id";
            id.Size = new Size(20, 15);
            id.TabIndex = 5;
            id.Text = "Id:";
            // 
            // FrmActualizarHuesped
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 258);
            Controls.Add(id);
            Controls.Add(lblidHuesped);
            Controls.Add(btnCancelar);
            Controls.Add(btnActualizar);
            Controls.Add(txtDni);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FrmActualizarHuesped";
            Text = "Actualizar Huesped";
            Load += FrmActualizarHuesped_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtDni;
        private Button btnActualizar;
        private Button btnCancelar;
        private Label lblidHuesped;
        private Label id;
    }
}