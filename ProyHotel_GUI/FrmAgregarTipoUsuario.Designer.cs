namespace ProyHotel_GUI
{
    partial class FrmAgregarTipoUsuario
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
            textboxTipoUsuario = new TextBox();
            botonCrear = new Button();
            botonCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(185, 21);
            label1.TabIndex = 0;
            label1.Text = "Nuevo Tipo de Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 1;
            label2.Text = "Tipo de Usuario:";
            // 
            // textboxTipoUsuario
            // 
            textboxTipoUsuario.Location = new Point(126, 51);
            textboxTipoUsuario.Name = "textboxTipoUsuario";
            textboxTipoUsuario.Size = new Size(246, 23);
            textboxTipoUsuario.TabIndex = 2;
            // 
            // botonCrear
            // 
            botonCrear.Location = new Point(297, 98);
            botonCrear.Name = "botonCrear";
            botonCrear.Size = new Size(75, 23);
            botonCrear.TabIndex = 3;
            botonCrear.Text = "Crear";
            botonCrear.UseVisualStyleBackColor = true;
            botonCrear.Click += botonCrear_Click;
            // 
            // botonCancelar
            // 
            botonCancelar.Location = new Point(216, 98);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(75, 23);
            botonCancelar.TabIndex = 4;
            botonCancelar.Text = "Cancelar";
            botonCancelar.UseVisualStyleBackColor = true;
            botonCancelar.Click += botonCancelar_Click;
            // 
            // FrmAgregarTipoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 133);
            Controls.Add(botonCancelar);
            Controls.Add(botonCrear);
            Controls.Add(textboxTipoUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAgregarTipoUsuario";
            Text = "Crear tipo usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textboxTipoUsuario;
        private Button botonCrear;
        private Button botonCancelar;
    }
}