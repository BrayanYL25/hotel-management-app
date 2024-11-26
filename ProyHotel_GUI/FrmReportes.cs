using OfficeOpenXml;
using OfficeOpenXml.Style;
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
        HabitacionesBL objhabitacion = new HabitacionesBL();
        ServicioBL objservicios = new ServicioBL();
        HuespedBL objhuespedes = new HuespedBL();

        // **************** IMPORTANT ****************
        // Cambiar las rutas por las que ustedes requieran
        // *******************************************
        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            try
            {
                
                DataTable dtDatos = Reporte(comboBoxPlantillas.Text.Trim()) ; // Implementa esta función

                if (dtDatos == null || dtDatos.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para generar el reporte.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear un nuevo archivo Excel
                using ExcelPackage package = new ExcelPackage();

                // Crear una hoja de trabajo con un nombre
                var worksheet = package.Workbook.Worksheets.Add("Reporte");

                var rangeTitle = worksheet.Cells["C1:F2"];
                rangeTitle.Merge = true; // Combinar celdas
                rangeTitle.Value = "REPORTE "+comboBoxPlantillas.Text; // Texto del título
                rangeTitle.Style.Font.Name = "Arial"; // Fuente Arial
                rangeTitle.Style.Font.Size = 20; // Tamaño de la fuente
                rangeTitle.Style.Font.Bold = true; // Negrita
                rangeTitle.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center; // Centrar horizontalmente
                rangeTitle.Style.VerticalAlignment = ExcelVerticalAlignment.Center; // Centrar verticalmente

                // Agregar cabeceras
                for (int col = 0; col < dtDatos.Columns.Count; col++)
                {
                    worksheet.Cells[4, col + 1].Value = dtDatos.Columns[col].ColumnName;
                    worksheet.Cells[4, col + 1].Style.Font.Bold = true;
                    worksheet.Cells[4, col + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    worksheet.Cells[4, col + 1].Style.Fill.BackgroundColor.SetColor(Color.LightGray);
                    worksheet.Cells[4, col + 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                }

                // Agregar datos 
                for (int row = 0; row < dtDatos.Rows.Count; row++)
                {
                    for (int col = 0; col < dtDatos.Columns.Count; col++)
                    {
                        worksheet.Cells[row + 5, col + 1].Value = dtDatos.Rows[row][col].ToString();
                    }
                }

                // Ajustar automáticamente el ancho de las columnas
                worksheet.Cells.AutoFitColumns();
                string nombrearchivo= clsCredenciales.Usuario.ToString()+"-"+comboBoxPlantillas.Text;

                // Guardar el archivo Excel
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Title = "Guardar reporte como",
                    Filter = "Archivos Excel (*.xlsx)|*.xlsx",
                    FileName = $"{nombrearchivo}.xlsx"
                    
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    package.SaveAs(new FileInfo(saveFileDialog.FileName));
                    MessageBox.Show("Reporte generado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el archivo Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext= OfficeOpenXml.LicenseContext.NonCommercial;

            
        }

        private DataTable Reporte(string nombre)
        {
            switch (nombre)
            {
                case "Usuarios": return objusuario.ListarUsuarios();
                    
                case "Habitacion por Reserva": return objhabitacion.listarHabitacion();

                case "Servicios por Reserva": return objservicios.ListarServicio();

                case "Huespesdes en Habitacion por Reserva": return objhuespedes.listarHuesped();


                default: return null;
            }
        }
    }
}
