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
            usuarioSeccion = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            tipoDeUsuarioToolStripMenuItem = new ToolStripMenuItem();
            servicioSeccion = new ToolStripMenuItem();
            serviciosToolStripMenuItem1 = new ToolStripMenuItem();
            habitacionesToolStripMenuItem = new ToolStripMenuItem();
            habitacionToolStripMenuItem = new ToolStripMenuItem();
            huespedesToolStripMenuItem = new ToolStripMenuItem();
            reservaToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            tlblUsuario = new ToolStripStatusLabel();
            tlblComputer = new ToolStripStatusLabel();
            tlblconexion = new ToolStripStatusLabel();
            tlblsesion = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            reservToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { usuarioSeccion, servicioSeccion, habitacionesToolStripMenuItem, huespedesToolStripMenuItem, reservaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1364, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // usuarioSeccion
            // 
            usuarioSeccion.DropDownItems.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, tipoDeUsuarioToolStripMenuItem });
            usuarioSeccion.Image = (Image)resources.GetObject("usuarioSeccion.Image");
            usuarioSeccion.Name = "usuarioSeccion";
            usuarioSeccion.Size = new Size(75, 20);
            usuarioSeccion.Text = "Usuario";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Image = (Image)resources.GetObject("usuariosToolStripMenuItem.Image");
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(156, 22);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click_1;
            // 
            // tipoDeUsuarioToolStripMenuItem
            // 
            tipoDeUsuarioToolStripMenuItem.Image = (Image)resources.GetObject("tipoDeUsuarioToolStripMenuItem.Image");
            tipoDeUsuarioToolStripMenuItem.Name = "tipoDeUsuarioToolStripMenuItem";
            tipoDeUsuarioToolStripMenuItem.Size = new Size(156, 22);
            tipoDeUsuarioToolStripMenuItem.Text = "Tipo de Usuario";
            tipoDeUsuarioToolStripMenuItem.Click += tipoDeUsuarioToolStripMenuItem_Click;
            // 
            // servicioSeccion
            // 
            servicioSeccion.DropDownItems.AddRange(new ToolStripItem[] { serviciosToolStripMenuItem1 });
            servicioSeccion.Image = (Image)resources.GetObject("servicioSeccion.Image");
            servicioSeccion.Name = "servicioSeccion";
            servicioSeccion.Size = new Size(76, 20);
            servicioSeccion.Text = "Servicio";
            // 
            // serviciosToolStripMenuItem1
            // 
            serviciosToolStripMenuItem1.Image = (Image)resources.GetObject("serviciosToolStripMenuItem1.Image");
            serviciosToolStripMenuItem1.Name = "serviciosToolStripMenuItem1";
            serviciosToolStripMenuItem1.Size = new Size(120, 22);
            serviciosToolStripMenuItem1.Text = "Servicios";
            serviciosToolStripMenuItem1.Click += serviciosToolStripMenuItem1_Click;
            // 
            // habitacionesToolStripMenuItem
            // 
            habitacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { habitacionToolStripMenuItem });
            habitacionesToolStripMenuItem.Image = (Image)resources.GetObject("habitacionesToolStripMenuItem.Image");
            habitacionesToolStripMenuItem.Name = "habitacionesToolStripMenuItem";
            habitacionesToolStripMenuItem.Size = new Size(93, 20);
            habitacionesToolStripMenuItem.Text = "Habitacion";
            // 
            // habitacionToolStripMenuItem
            // 
            habitacionToolStripMenuItem.Image = (Image)resources.GetObject("habitacionToolStripMenuItem.Image");
            habitacionToolStripMenuItem.Name = "habitacionToolStripMenuItem";
            habitacionToolStripMenuItem.Size = new Size(143, 22);
            habitacionToolStripMenuItem.Text = "Habitaciones";
            habitacionToolStripMenuItem.Click += habitacionToolStripMenuItem_Click;
            // 
            // huespedesToolStripMenuItem
            // 
            huespedesToolStripMenuItem.Image = (Image)resources.GetObject("huespedesToolStripMenuItem.Image");
            huespedesToolStripMenuItem.Name = "huespedesToolStripMenuItem";
            huespedesToolStripMenuItem.Size = new Size(93, 20);
            huespedesToolStripMenuItem.Text = "Huespedes";
            huespedesToolStripMenuItem.Click += huespedesToolStripMenuItem_Click;
            // 
            // reservaToolStripMenuItem
            // 
            reservaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reservToolStripMenuItem });
            reservaToolStripMenuItem.Image = (Image)resources.GetObject("reservaToolStripMenuItem.Image");
            reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            reservaToolStripMenuItem.Size = new Size(75, 20);
            reservaToolStripMenuItem.Text = "Reserva";
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
            // reservToolStripMenuItem
            // 
            reservToolStripMenuItem.Image = (Image)resources.GetObject("reservToolStripMenuItem.Image");
            reservToolStripMenuItem.Name = "reservToolStripMenuItem";
            reservToolStripMenuItem.Size = new Size(180, 22);
            reservToolStripMenuItem.Text = "Reservas";
            reservToolStripMenuItem.Click += reservToolStripMenuItem_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1364, 647);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
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
        private ToolStripMenuItem usuarioSeccion;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tlblUsuario;
        private System.Windows.Forms.Timer timer1;
        private ToolStripStatusLabel tlblComputer;
        private ToolStripStatusLabel tlblconexion;
        private ToolStripStatusLabel tlblsesion;
        private ToolStripMenuItem servicioSeccion;
        private ToolStripMenuItem habitacionesToolStripMenuItem;
        private ToolStripMenuItem huespedesToolStripMenuItem;
        private ToolStripMenuItem tipoDeUsuarioToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem serviciosToolStripMenuItem1;
        private ToolStripMenuItem habitacionToolStripMenuItem;
        private ToolStripMenuItem reservaToolStripMenuItem;
        private ToolStripMenuItem reservToolStripMenuItem;
    }
}