namespace ProyHotel_GUI
{
    partial class FrmBuscarHuespedHabitacion
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
            textboxSearch = new TextBox();
            datagridviewHuespedes = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            botonAsignar = new Button();
            botonCrear = new Button();
            ((System.ComponentModel.ISupportInitialize)datagridviewHuespedes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(129, 21);
            label1.TabIndex = 0;
            label1.Text = "Buscar huesped";
            // 
            // textboxSearch
            // 
            textboxSearch.Location = new Point(185, 12);
            textboxSearch.Name = "textboxSearch";
            textboxSearch.PlaceholderText = "Nombre";
            textboxSearch.Size = new Size(186, 23);
            textboxSearch.TabIndex = 3;
            textboxSearch.TextChanged += textboxSearch_TextChanged;
            // 
            // datagridviewHuespedes
            // 
            datagridviewHuespedes.AllowUserToAddRows = false;
            datagridviewHuespedes.AllowUserToDeleteRows = false;
            datagridviewHuespedes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridviewHuespedes.BackgroundColor = SystemColors.ControlLightLight;
            datagridviewHuespedes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridviewHuespedes.Columns.AddRange(new DataGridViewColumn[] { id, nombre, dni });
            datagridviewHuespedes.Location = new Point(12, 52);
            datagridviewHuespedes.Name = "datagridviewHuespedes";
            datagridviewHuespedes.ReadOnly = true;
            datagridviewHuespedes.RowHeadersVisible = false;
            datagridviewHuespedes.Size = new Size(359, 207);
            datagridviewHuespedes.TabIndex = 4;
            // 
            // id
            // 
            id.DataPropertyName = "Id";
            id.HeaderText = "Id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // nombre
            // 
            nombre.DataPropertyName = "Nombre";
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // dni
            // 
            dni.DataPropertyName = "DNI";
            dni.HeaderText = "DNI";
            dni.Name = "dni";
            dni.ReadOnly = true;
            // 
            // botonAsignar
            // 
            botonAsignar.Location = new Point(296, 274);
            botonAsignar.Name = "botonAsignar";
            botonAsignar.Size = new Size(75, 23);
            botonAsignar.TabIndex = 5;
            botonAsignar.Text = "Asignar";
            botonAsignar.UseVisualStyleBackColor = true;
            botonAsignar.Click += botonAsignar_Click;
            // 
            // botonCrear
            // 
            botonCrear.Location = new Point(215, 274);
            botonCrear.Name = "botonCrear";
            botonCrear.Size = new Size(75, 23);
            botonCrear.TabIndex = 6;
            botonCrear.Text = "Crear";
            botonCrear.UseVisualStyleBackColor = true;
            // 
            // FrmAsignarHuespedHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 309);
            Controls.Add(botonCrear);
            Controls.Add(botonAsignar);
            Controls.Add(datagridviewHuespedes);
            Controls.Add(textboxSearch);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmAsignarHuespedHabitacion";
            Text = "Asignar huesped";
            Load += FrmAsignarHuespedHabitacion_Load;
            ((System.ComponentModel.ISupportInitialize)datagridviewHuespedes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textboxSearch;
        private DataGridView datagridviewHuespedes;
        private Button botonAsignar;
        private Button botonCrear;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn dni;
    }
}