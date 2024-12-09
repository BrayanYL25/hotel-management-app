namespace ProyHotel_GUI
{
    partial class Menu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            menuStrip1 = new MenuStrip();
            mantenimientoToolStripMenuItem = new ToolStripMenuItem();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem1 = new ToolStripMenuItem();
            tipoUsuariosToolStripMenuItem = new ToolStripMenuItem();
            servicioToolStripMenuItem = new ToolStripMenuItem();
            habitacionToolStripMenuItem1 = new ToolStripMenuItem();
            habitacionesToolStripMenuItem1 = new ToolStripMenuItem();
            tipoDeHabitacionesToolStripMenuItem1 = new ToolStripMenuItem();
            huespedesToolStripMenuItem1 = new ToolStripMenuItem();
            reservaToolStripMenuItem1 = new ToolStripMenuItem();
            reporteToolStripMenuItem1 = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            tlblUsuario = new ToolStripStatusLabel();
            tlblComputer = new ToolStripStatusLabel();
            tlblconexion = new ToolStripStatusLabel();
            tlblsesion = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mantenimientoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1364, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            mantenimientoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuarioToolStripMenuItem, servicioToolStripMenuItem, habitacionToolStripMenuItem1, huespedesToolStripMenuItem1, reservaToolStripMenuItem1, reporteToolStripMenuItem1 });
            mantenimientoToolStripMenuItem.Image = (Image)resources.GetObject("mantenimientoToolStripMenuItem.Image");
            mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            mantenimientoToolStripMenuItem.Size = new Size(117, 20);
            mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem1, tipoUsuariosToolStripMenuItem });
            usuarioToolStripMenuItem.Image = (Image)resources.GetObject("usuarioToolStripMenuItem.Image");
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(180, 22);
            usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // usuariosToolStripMenuItem1
            // 
            usuariosToolStripMenuItem1.Image = (Image)resources.GetObject("usuariosToolStripMenuItem1.Image");
            usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            usuariosToolStripMenuItem1.Size = new Size(162, 22);
            usuariosToolStripMenuItem1.Text = "Usuarios";
            usuariosToolStripMenuItem1.Click += usuariosToolStripMenuItem_Click;
            // 
            // tipoUsuariosToolStripMenuItem
            // 
            tipoUsuariosToolStripMenuItem.Image = (Image)resources.GetObject("tipoUsuariosToolStripMenuItem.Image");
            tipoUsuariosToolStripMenuItem.Name = "tipoUsuariosToolStripMenuItem";
            tipoUsuariosToolStripMenuItem.Size = new Size(162, 22);
            tipoUsuariosToolStripMenuItem.Text = "Tipo De Usuarios";
            tipoUsuariosToolStripMenuItem.Click += tipoDeUsuarioToolStripMenuItem_Click;
            // 
            // servicioToolStripMenuItem
            // 
            servicioToolStripMenuItem.Image = (Image)resources.GetObject("servicioToolStripMenuItem.Image");
            servicioToolStripMenuItem.Name = "servicioToolStripMenuItem";
            servicioToolStripMenuItem.Size = new Size(180, 22);
            servicioToolStripMenuItem.Text = "Servicio";
            servicioToolStripMenuItem.Click += serviciosToolStripMenuItem1_Click;
            // 
            // habitacionToolStripMenuItem1
            // 
            habitacionToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { habitacionesToolStripMenuItem1, tipoDeHabitacionesToolStripMenuItem1 });
            habitacionToolStripMenuItem1.Image = (Image)resources.GetObject("habitacionToolStripMenuItem1.Image");
            habitacionToolStripMenuItem1.Name = "habitacionToolStripMenuItem1";
            habitacionToolStripMenuItem1.Size = new Size(180, 22);
            habitacionToolStripMenuItem1.Text = "Habitacion";
            // 
            // habitacionesToolStripMenuItem1
            // 
            habitacionesToolStripMenuItem1.Image = (Image)resources.GetObject("habitacionesToolStripMenuItem1.Image");
            habitacionesToolStripMenuItem1.Name = "habitacionesToolStripMenuItem1";
            habitacionesToolStripMenuItem1.Size = new Size(186, 22);
            habitacionesToolStripMenuItem1.Text = "Habitaciones";
            habitacionesToolStripMenuItem1.Click += habitacionToolStripMenuItem_Click;
            // 
            // tipoDeHabitacionesToolStripMenuItem1
            // 
            tipoDeHabitacionesToolStripMenuItem1.Image = (Image)resources.GetObject("tipoDeHabitacionesToolStripMenuItem1.Image");
            tipoDeHabitacionesToolStripMenuItem1.Name = "tipoDeHabitacionesToolStripMenuItem1";
            tipoDeHabitacionesToolStripMenuItem1.Size = new Size(186, 22);
            tipoDeHabitacionesToolStripMenuItem1.Text = "Tipo De Habitaciones";
            tipoDeHabitacionesToolStripMenuItem1.Click += tipoDeHabitacionesToolStripMenuItem_Click;
            // 
            // huespedesToolStripMenuItem1
            // 
            huespedesToolStripMenuItem1.Image = (Image)resources.GetObject("huespedesToolStripMenuItem1.Image");
            huespedesToolStripMenuItem1.Name = "huespedesToolStripMenuItem1";
            huespedesToolStripMenuItem1.Size = new Size(180, 22);
            huespedesToolStripMenuItem1.Text = "Huespedes";
            huespedesToolStripMenuItem1.Click += huespedesToolStripMenuItem_Click;
            // 
            // reservaToolStripMenuItem1
            // 
            reservaToolStripMenuItem1.Image = (Image)resources.GetObject("reservaToolStripMenuItem1.Image");
            reservaToolStripMenuItem1.Name = "reservaToolStripMenuItem1";
            reservaToolStripMenuItem1.Size = new Size(180, 22);
            reservaToolStripMenuItem1.Text = "Reserva";
            reservaToolStripMenuItem1.Click += reservToolStripMenuItem_Click;
            // 
            // reporteToolStripMenuItem1
            // 
            reporteToolStripMenuItem1.Image = (Image)resources.GetObject("reporteToolStripMenuItem1.Image");
            reporteToolStripMenuItem1.Name = "reporteToolStripMenuItem1";
            reporteToolStripMenuItem1.Size = new Size(180, 22);
            reporteToolStripMenuItem1.Text = "Reporte";
            reporteToolStripMenuItem1.Click += reporteDeUsuariosToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tlblUsuario, tlblComputer, tlblconexion, tlblsesion });
            statusStrip1.Location = new Point(0, 625);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1364, 22);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // tlblUsuario
            // 
            tlblUsuario.Name = "tlblUsuario";
            tlblUsuario.Size = new Size(56, 17);
            tlblUsuario.Text = "Usuario : ";
            tlblUsuario.Click += toolStripStatusLabel1_Click;
            // 
            // tlblComputer
            // 
            tlblComputer.Name = "tlblComputer";
            tlblComputer.Size = new Size(31, 17);
            tlblComputer.Text = "PC : ";
            // 
            // tlblconexion
            // 
            tlblconexion.Name = "tlblconexion";
            tlblconexion.Size = new Size(64, 17);
            tlblconexion.Text = "Conexión: ";
            // 
            // tlblsesion
            // 
            tlblsesion.Name = "tlblsesion";
            tlblsesion.Size = new Size(50, 17);
            tlblsesion.Text = "Tiempo:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1364, 647);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            TransparencyKey = Color.White;
            FormClosing += Menu_FormClosing;
            FormClosed += Menu_FormClosed;
            Load += Menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tlblUsuario;
        private System.Windows.Forms.Timer timer1;
        private ToolStripStatusLabel tlblComputer;
        private ToolStripStatusLabel tlblconexion;
        private ToolStripStatusLabel tlblsesion;
        private ToolStripMenuItem mantenimientoToolStripMenuItem;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem1;
        private ToolStripMenuItem tipoUsuariosToolStripMenuItem;
        private ToolStripMenuItem servicioToolStripMenuItem;
        private ToolStripMenuItem habitacionToolStripMenuItem1;
        private ToolStripMenuItem habitacionesToolStripMenuItem1;
        private ToolStripMenuItem tipoDeHabitacionesToolStripMenuItem1;
        private ToolStripMenuItem huespedesToolStripMenuItem1;
        private ToolStripMenuItem reservaToolStripMenuItem1;
        private ToolStripMenuItem reporteToolStripMenuItem1;
    }
}