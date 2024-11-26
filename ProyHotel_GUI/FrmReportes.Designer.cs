namespace ProyHotel_GUI
{
    partial class FrmReportes
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
            btn_Usuarios = new Button();
            comboBoxPlantillas = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_Usuarios
            // 
            btn_Usuarios.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Usuarios.Location = new Point(210, 117);
            btn_Usuarios.Name = "btn_Usuarios";
            btn_Usuarios.Size = new Size(140, 39);
            btn_Usuarios.TabIndex = 0;
            btn_Usuarios.Text = "Generar Reporte";
            btn_Usuarios.UseVisualStyleBackColor = true;
            btn_Usuarios.Click += btn_Usuarios_Click;
            // 
            // comboBoxPlantillas
            // 
            comboBoxPlantillas.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPlantillas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxPlantillas.FormattingEnabled = true;
            comboBoxPlantillas.Items.AddRange(new object[] { "Usuarios", "Habitacion por Reserva", "Servicios por Reserva", "Huespesdes en Habitacion por Reserva" });
            comboBoxPlantillas.Location = new Point(12, 50);
            comboBoxPlantillas.Name = "comboBoxPlantillas";
            comboBoxPlantillas.Size = new Size(338, 29);
            comboBoxPlantillas.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(157, 21);
            label1.TabIndex = 2;
            label1.Text = "Selecciona la tabla:";
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(362, 168);
            Controls.Add(label1);
            Controls.Add(comboBoxPlantillas);
            Controls.Add(btn_Usuarios);
            Name = "FrmReportes";
            Text = "Reportes";
            Load += Reportes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Usuarios;
        private ComboBox comboBoxPlantillas;
        private Label label1;
    }
}