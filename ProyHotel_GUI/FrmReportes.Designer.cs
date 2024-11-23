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
            SuspendLayout();
            // 
            // btn_Usuarios
            // 
            btn_Usuarios.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Usuarios.Location = new Point(65, 95);
            btn_Usuarios.Name = "btn_Usuarios";
            btn_Usuarios.Size = new Size(207, 72);
            btn_Usuarios.TabIndex = 0;
            btn_Usuarios.Text = "Usuarios";
            btn_Usuarios.UseVisualStyleBackColor = true;
            btn_Usuarios.Click += btn_Usuarios_Click;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(597, 521);
            Controls.Add(btn_Usuarios);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmReportes";
            Text = "Reportes";
            Load += Reportes_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Usuarios;
    }
}