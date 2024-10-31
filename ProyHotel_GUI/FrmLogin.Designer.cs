namespace ProyHotel_GUI
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            pictureBox1 = new PictureBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            txtLogin = new TextBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            txtPassword = new TextBox();
            label2 = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(55, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 177);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(124, 166);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(141, 25);
            label3.TabIndex = 5;
            label3.Text = "Iniciar Sesión";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 229);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // txtLogin
            // 
            txtLogin.CharacterCasing = CharacterCasing.Upper;
            txtLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogin.Location = new Point(193, 233);
            txtLogin.Margin = new Padding(4, 3, 4, 3);
            txtLogin.Multiline = true;
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(164, 23);
            txtLogin.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 177);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(55, 232);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 8;
            label1.Text = "Usuario:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(9, 288);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(193, 292);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(164, 23);
            txtPassword.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(52, 291);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 10;
            label2.Text = "Contraseña:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.HotTrack;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(226, 373);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(89, 28);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = SystemColors.HotTrack;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(58, 373);
            btnAceptar.Margin = new Padding(4, 3, 4, 3);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(89, 28);
            btnAceptar.TabIndex = 13;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(378, 522);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(pictureBox3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(txtLogin);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label3;
        private PictureBox pictureBox2;
        private TextBox txtLogin;
        private Label label1;
        private PictureBox pictureBox3;
        private TextBox txtPassword;
        private Label label2;
        private Button btnCancelar;
        private Button btnAceptar;
        private System.Windows.Forms.Timer timer1;
    }
}
