using OfficeOpenXml;
using ProyHotel_BL;
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
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        UsuarioBL objusuario = new UsuarioBL();

        // **************** IMPORTANT ****************
        // Cambiar las rutas por las que ustedes requieran
        // *******************************************
        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            try
            {
                //  
                String strRuta = "C:\\hotel_proyecto\\Reportes\\plantilla_usuario.xlsx";
                DataTable dtusuario = objusuario.ListarUsuarios();

                Int16 fila = 5;

                using var pck = new ExcelPackage(new FileInfo(strRuta));
                ExcelWorksheet ws = pck.Workbook.Worksheets["Hoja1"];

                foreach (DataRow row in dtusuario.Rows)
                {
                    ws.Cells[fila, 1].Value = row["Id"].ToString();
                    ws.Cells[fila, 2].Value = row["Usuario"].ToString();
                    ws.Cells[fila, 3].Value = row["Contraseña"].ToString();
                    ws.Cells[fila, 4].Value = row["tipo"].ToString();
                    ws.Cells[fila, 5].Value = row["Correo"].ToString();
                    ws.Cells[fila, 6].Value = row["Estado"].ToString();
                    fila += 1;
                }

                ws.Column(1).Width = 10;
                ws.Column(2).Width = 40;
                ws.Column(3).Width = 40;
                ws.Column(4).Width = 40;
                ws.Column(5).Width = 40;
                ws.Column(6).Width = 40;

                String strFileName = "Listado Usuario_" + clsCredenciales.Usuario + ".xlsx";

                FileStream fs = new FileStream(@"C:\hotel_proyecto\Reportes\" + strFileName, FileMode.Create);
                pck.SaveAs(fs);
                fs.Dispose();
                pck.Dispose();
                MessageBox.Show("El Reporte " + strFileName + " Se ha generado con Exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message);
            }


        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext= OfficeOpenXml.LicenseContext.NonCommercial;
        }
    }
}
