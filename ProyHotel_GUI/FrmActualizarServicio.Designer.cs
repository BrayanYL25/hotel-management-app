namespace ProyHotel_GUI
{
    partial class FrmActualizarServicio
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
            groupBox1 = new GroupBox();
            checkboxDisponible = new CheckBox();
            textboxPrecio = new TextBox();
            textboxServicio = new TextBox();
            botonCancelar = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            labelId = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkboxDisponible);
            groupBox1.Location = new Point(12, 165);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(294, 81);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado";
            // 
            // checkboxDisponible
            // 
            checkboxDisponible.AutoSize = true;
            checkboxDisponible.Location = new Point(17, 37);
            checkboxDisponible.Name = "checkboxDisponible";
            checkboxDisponible.Size = new Size(82, 19);
            checkboxDisponible.TabIndex = 0;
            checkboxDisponible.Text = "Disponible";
            checkboxDisponible.UseVisualStyleBackColor = true;
            // 
            // textboxPrecio
            // 
            textboxPrecio.Font = new Font("Segoe UI", 9F);
            textboxPrecio.Location = new Point(74, 127);
            textboxPrecio.Name = "textboxPrecio";
            textboxPrecio.Size = new Size(232, 23);
            textboxPrecio.TabIndex = 6;
            // 
            // textboxServicio
            // 
            textboxServicio.Font = new Font("Segoe UI", 9F);
            textboxServicio.Location = new Point(74, 88);
            textboxServicio.Name = "textboxServicio";
            textboxServicio.Size = new Size(232, 23);
            textboxServicio.TabIndex = 5;
            // 
            // botonCancelar
            // 
            botonCancelar.CausesValidation = false;
            botonCancelar.Location = new Point(150, 275);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(75, 23);
            botonCancelar.TabIndex = 11;
            botonCancelar.Text = "Cancelar";
            botonCancelar.UseVisualStyleBackColor = true;
            botonCancelar.Click += botonCancelar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(231, 275);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(12, 130);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 10;
            label2.Text = "Precio:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(12, 91);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 7;
            label1.Text = "Servicio:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(12, 52);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 13;
            label3.Text = "Id:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // labelId
            // 
            labelId.BorderStyle = BorderStyle.FixedSingle;
            labelId.Font = new Font("Segoe UI", 9F);
            labelId.Location = new Point(74, 51);
            labelId.Name = "labelId";
            labelId.Size = new Size(232, 23);
            labelId.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(121, 21);
            label4.TabIndex = 15;
            label4.Text = "Editar Servicio";
            // 
            // FrmActualizarServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 310);
            Controls.Add(label4);
            Controls.Add(labelId);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(textboxPrecio);
            Controls.Add(textboxServicio);
            Controls.Add(botonCancelar);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmActualizarServicio";
            Text = "Editar Servicio";
            Load += EditarServicio_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox checkboxDisponible;
        private TextBox textboxPrecio;
        private TextBox textboxServicio;
        private Button botonCancelar;
        private Button button1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label labelId;
        private Label label4;
    }
}