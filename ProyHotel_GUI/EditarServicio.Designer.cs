namespace ProyHotel_GUI
{
    partial class EditarServicio
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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkboxDisponible);
            groupBox1.Location = new Point(21, 165);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(276, 100);
            groupBox1.TabIndex = 8;
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
            // textboxPrecio
            // 
            textboxPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textboxPrecio.Location = new Point(94, 115);
            textboxPrecio.Name = "textboxPrecio";
            textboxPrecio.Size = new Size(203, 29);
            textboxPrecio.TabIndex = 6;
            // 
            // textboxServicio
            // 
            textboxServicio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textboxServicio.Location = new Point(94, 59);
            textboxServicio.Name = "textboxServicio";
            textboxServicio.Size = new Size(203, 29);
            textboxServicio.TabIndex = 5;
            // 
            // botonCancelar
            // 
            botonCancelar.CausesValidation = false;
            botonCancelar.Location = new Point(127, 295);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(75, 23);
            botonCancelar.TabIndex = 11;
            botonCancelar.Text = "Cancelar";
            botonCancelar.UseVisualStyleBackColor = true;
            botonCancelar.Click += botonCancelar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(222, 295);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 115);
            label2.Name = "label2";
            label2.Size = new Size(67, 29);
            label2.TabIndex = 10;
            label2.Text = "Precio";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 59);
            label1.Name = "label1";
            label1.Size = new Size(67, 29);
            label1.TabIndex = 7;
            label1.Text = "Servicio";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 12);
            label3.Name = "label3";
            label3.Size = new Size(67, 29);
            label3.TabIndex = 13;
            label3.Text = "Id";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // labelId
            // 
            labelId.BorderStyle = BorderStyle.FixedSingle;
            labelId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelId.Location = new Point(94, 12);
            labelId.Name = "labelId";
            labelId.Size = new Size(203, 23);
            labelId.TabIndex = 14;
            // 
            // EditarServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 332);
            Controls.Add(labelId);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(textboxPrecio);
            Controls.Add(textboxServicio);
            Controls.Add(botonCancelar);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditarServicio";
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
    }
}