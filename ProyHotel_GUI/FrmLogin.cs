using ProyHotel_BE;
using ProyHotel_BL;
using ProyVentas_GUI;
using System.Drawing.Imaging;

namespace ProyHotel_GUI
{
    public partial class FrmLogin : Form
    {
        Int16 intentos = 0;
        Int16 tiempo = 20;
        UsuarioBE objUsuarioBE = new UsuarioBE();
        UsuarioBL objUsuarioBL = new UsuarioBL();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Login()
        {
            try
            {
                if (txtLogin.Text.Trim() == String.Empty && txtPassword.Text.Trim() == String.Empty)
                {
                    intentos += 1;
                    throw new Exception("El ingreso del usuario y contraseña es obligatorio");
                }

                objUsuarioBE = objUsuarioBL.IngresoUsuario(txtLogin.Text.Trim(), txtPassword.Text.Trim());
                if (objUsuarioBE.usuarioNombre == null)
                {
                    intentos += 1;
                    throw new Exception("El usuario no existe o la contraseña es incorrecta");
                }
                else
                {
                    this.Hide();
                    timer1.Enabled = false;
                    clsCredenciales.id = objUsuarioBE.usuarioId;
                    clsCredenciales.Usuario = objUsuarioBE.usuarioNombre;
                    clsCredenciales.Password = objUsuarioBE.usuarioContraseña;
                    clsCredenciales.Nivel = objUsuarioBE.usuarioEstado;
                    Menu men = new Menu();
                    men.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (intentos == 3)
                {
                    MessageBox.Show("Lo sentimos, superó el número de intentos válidos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo -= 1;
            this.Text = "Ingrese su login y contraseña. Le quedan...." + tiempo;
            if (tiempo == 0)
            {
                MessageBox.Show("Lo sentimos, sobrepasó el tiempo de espera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();
        }

        private void FrmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                Login();
            }
        }
    }
}
