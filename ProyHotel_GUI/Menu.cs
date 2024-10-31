using Microsoft.VisualBasic.Devices;
using ProyVentas_GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyHotel_GUI
{
    public partial class Menu : Form
    {
        Computer computer = new Computer();
        TimeSpan horaentrada = new TimeSpan();
        public Menu()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios frm1 = new Usuarios();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            horaentrada = DateTime.Now.TimeOfDay;
            tlblUsuario.Text = "Usuario: " + clsCredenciales.Usuario;

            if (computer.Network.IsAvailable)
            {
                tlblconexion.Text = "Equipo con conexion Disponible";
            }
            else
            {
                tlblconexion.Text = "Equipo sin conexion Disponible";
            }
            tlblComputer.Text = "Equipo: " + computer.Name + ".";
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "Menu Principal - Hotel   --  " + DateTime.Now.ToString();
            tlblsesion.Text = "Tiempo: " + DateTime.Now.TimeOfDay.Subtract(horaentrada).ToString().Substring(0, 8);
        }

        private void cRUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.MdiParent = this;
            usuarios.Show();
        }

        private void huespedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHuespedes frmHuespedes = new();
            frmHuespedes.MdiParent = this;
            frmHuespedes.Show();
        }

        private void usuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.MdiParent = this;
            usuarios.Show();
        }

        private void serviciosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Servicios servicios = new();
            servicios.MdiParent = this;
            servicios.Show();
        }

        private void habitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHabitaciones frmHabitaciones = new FrmHabitaciones();
            frmHabitaciones.MdiParent = this;
            frmHabitaciones.Show();
        }

        private void tipoDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoUsuario frmTipoUsuario = new();
            frmTipoUsuario.MdiParent = this;
            frmTipoUsuario.Show();
        }

        private void reservToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReserva frmReserva = new FrmReserva();
            frmReserva.Show();
        }

        private void crearReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrearReserva frmCrearReserva = new FrmCrearReserva();
            frmCrearReserva.Show();
        }
    }
}
