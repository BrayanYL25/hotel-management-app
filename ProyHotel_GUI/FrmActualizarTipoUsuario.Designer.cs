namespace ProyHotel_GUI
{
    partial class FrmActualizarTipoUsuario
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
            textboxTipoUsuario = new TextBox();
            labelIdReserva = new Label();
            botonEditar = new Button();
            botonCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(179, 21);
            label1.TabIndex = 0;
            label1.Text = "Editar Tipo de Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 1;
            label2.Text = "Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 81);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 2;
            label3.Text = "Tipo de usuario:";
            // 
            // textboxTipoUsuario
            // 
            textboxTipoUsuario.Location = new Point(130, 78);
            textboxTipoUsuario.Name = "textboxTipoUsuario";
            textboxTipoUsuario.Size = new Size(242, 23);
            textboxTipoUsuario.TabIndex = 3;
            // 
            // labelIdReserva
            // 
            labelIdReserva.BorderStyle = BorderStyle.FixedSingle;
            labelIdReserva.Location = new Point(130, 46);
            labelIdReserva.Name = "labelIdReserva";
            labelIdReserva.Size = new Size(242, 23);
            labelIdReserva.TabIndex = 4;
            labelIdReserva.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // botonEditar
            // 
            botonEditar.Location = new Point(297, 126);
            botonEditar.Name = "botonEditar";
            botonEditar.Size = new Size(75, 23);
            botonEditar.TabIndex = 5;
            botonEditar.Text = "Editar";
            botonEditar.UseVisualStyleBackColor = true;
            botonEditar.Click += botonEditar_Click;
            // 
            // botonCancelar
            // 
            botonCancelar.Location = new Point(216, 126);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(75, 23);
            botonCancelar.TabIndex = 6;
            botonCancelar.Text = "Cancelar";
            botonCancelar.UseVisualStyleBackColor = true;
            botonCancelar.Click += botonCancelar_Click;
            // 
            // FrmActualizarTipoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 161);
            Controls.Add(botonCancelar);
            Controls.Add(botonEditar);
            Controls.Add(labelIdReserva);
            Controls.Add(textboxTipoUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmActualizarTipoUsuario";
            Text = "Editar tipo de usuario";
            Load += FrmActualizarTipoUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textboxTipoUsuario;
        private Label labelIdReserva;
        private Button botonEditar;
        private Button botonCancelar;
    }
}