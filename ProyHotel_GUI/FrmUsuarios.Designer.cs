namespace ProyHotel_GUI
{
    partial class FrmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            dtgUsuarios = new DataGridView();
            label1 = new Label();
            txtNombre = new TextBox();
            btn_Editar = new Button();
            BtnAgregar = new Button();
            btn_bloquear = new Button();
            label2 = new Label();
            txtRegistros = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dtgUsuarios
            // 
            dtgUsuarios.AllowUserToAddRows = false;
            dtgUsuarios.AllowUserToDeleteRows = false;
            dtgUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgUsuarios.BackgroundColor = Color.White;
            dtgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgUsuarios.Location = new Point(56, 89);
            dtgUsuarios.Name = "dtgUsuarios";
            dtgUsuarios.ReadOnly = true;
            dtgUsuarios.Size = new Size(1159, 456);
            dtgUsuarios.TabIndex = 0;
            dtgUsuarios.CellFormatting += dtgUsuarios_CellFormatting;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 34);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(138, 36);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(221, 23);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // btn_Editar
            // 
            btn_Editar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Editar.Image = (Image)resources.GetObject("btn_Editar.Image");
            btn_Editar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Editar.Location = new Point(1092, 581);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(123, 43);
            btn_Editar.TabIndex = 3;
            btn_Editar.Text = "EDITAR";
            btn_Editar.UseVisualStyleBackColor = true;
            btn_Editar.Click += btn_Editar_Click;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnAgregar.Image = (Image)resources.GetObject("BtnAgregar.Image");
            BtnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgregar.Location = new Point(925, 581);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(119, 43);
            BtnAgregar.TabIndex = 4;
            BtnAgregar.Text = "AGREGAR";
            BtnAgregar.TextAlign = ContentAlignment.MiddleRight;
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // btn_bloquear
            // 
            btn_bloquear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_bloquear.Image = (Image)resources.GetObject("btn_bloquear.Image");
            btn_bloquear.ImageAlign = ContentAlignment.MiddleLeft;
            btn_bloquear.Location = new Point(1092, 25);
            btn_bloquear.Name = "btn_bloquear";
            btn_bloquear.Size = new Size(109, 43);
            btn_bloquear.TabIndex = 5;
            btn_bloquear.Text = "BLOQUEAR";
            btn_bloquear.TextAlign = ContentAlignment.MiddleRight;
            btn_bloquear.UseVisualStyleBackColor = true;
            btn_bloquear.Click += btn_bloquear_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(62, 554);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 6;
            label2.Text = "Registros:";
            // 
            // txtRegistros
            // 
            txtRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtRegistros.Enabled = false;
            txtRegistros.Location = new Point(126, 551);
            txtRegistros.Name = "txtRegistros";
            txtRegistros.Size = new Size(49, 23);
            txtRegistros.TabIndex = 7;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1304, 636);
            Controls.Add(txtRegistros);
            Controls.Add(label2);
            Controls.Add(btn_bloquear);
            Controls.Add(BtnAgregar);
            Controls.Add(btn_Editar);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(dtgUsuarios);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion Usuarios";
            Load += Usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dtgUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgUsuarios;
        private Label label1;
        private TextBox txtNombre;
        private Button btn_Editar;
        private Button BtnAgregar;
        private Button btn_bloquear;
        private Label label2;
        private TextBox txtRegistros;
    }
}