using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POSLyion
{
    public partial class formConfiguracion : Form
    {
        public formConfiguracion()
        {
            InitializeComponent();

        }

        private void btn_añadir_Click(object sender, EventArgs e)
        {
            using (var formLoginPOS = new LoginPOS())
            {
                _ = formLoginPOS.ShowDialog();
                if (formLoginPOS.sesion_iniciada == true)
                {
                    lbl_informe.Text = "Usuario: " + formLoginPOS.UsuarioPOS.Nombre + " - Empresa: " + formLoginPOS.UsuarioPOS.Nombre_empresa + " - Número de sucursales: " + formLoginPOS.UsuarioPOS.Cantidad_sucursales;
                    lbl_fecha_vencimiento.Text = "Fecha de vencimiento de pago: " + formLoginPOS.UsuarioPOS.Fecha_vencimiento;
                    lbl_informe.Visible = true;
                    lbl_fecha_vencimiento.Visible = true;
                }
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_buscar_backup_Click(object sender, EventArgs e)
        {
            var dialogo = new FolderBrowserDialog();
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                txt_ruta_backup.Text = dialogo.SelectedPath;
            }
        }

        private void btb_backup_bd_Click(object sender, EventArgs e)
        {
            var fecha = DateTime.Now.ToString("dd-MMM-yyyy-HH-Mmm-ss");
            if (txt_ruta_backup.Text == string.Empty)
            {
                _ = MessageBox.Show("Ingrese la ruta donde guardará el backup");
                return;
            }
            try
            {
                var cadenaConexion = ConfigurationManager.ConnectionStrings["CadenaConexion"].ToString();
                var oConexion = new SqlConnection(cadenaConexion);
                var cmd = "BACKUP DATABASE [" + oConexion.Database.ToString() + "] TO DISK = '" + txt_ruta_backup.Text + "\\" + "POSLyion"
                   + "-" + fecha + ".bak'";
                oConexion.Open();
                var comando = new SqlCommand(cmd, oConexion);
                _ = comando.ExecuteNonQuery();
                _ = MessageBox.Show("Base de datos respaldada exitosamente");
                oConexion.Close();
                txt_ruta_backup.Text = "";
            }
            catch
            {
                _ = MessageBox.Show("Respaldo de base de datos fallida");
            }
        }

        private void btn_buscar_restaurar_Click(object sender, EventArgs e)
        {
            var dialogo = new OpenFileDialog
            {
                Filter = "SQL SERVER Backup files |*.bak",
                Title = "Restauración de base de datos"
            };
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                txt_ruta_restaurar.Text = dialogo.FileName;
            }
        }

        private void btn_restaurar_bd_Click(object sender, EventArgs e)
        {
            var cadenaConexion = ConfigurationManager.ConnectionStrings["CadenaConexion"].ToString();
            using (var oConexion = new SqlConnection(cadenaConexion))
            {
                oConexion.Open();
                if (string.IsNullOrEmpty(txt_ruta_restaurar.Text))
                {
                    _ = MessageBox.Show("Por favor seleccione el archivo de restauración");
                }
                else
                {
                    try
                    {
                        // Cambiar a la base de datos master
                        var cambiarABaseDeDatosMaster = "USE master";
                        using (var cmdCambiarABaseDeDatosMaster = new SqlCommand(cambiarABaseDeDatosMaster, oConexion))
                        {
                            _ = cmdCambiarABaseDeDatosMaster.ExecuteNonQuery();
                        }

                        var setSingleUser = $"ALTER DATABASE POSLyion SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                        using (var cmdSetSingleUser = new SqlCommand(setSingleUser, oConexion))
                        {
                            _ = cmdSetSingleUser.ExecuteNonQuery();
                        }

                        var restaurarBaseDeDatos = $"RESTORE DATABASE POSLyion FROM DISK = '{txt_ruta_restaurar.Text}' WITH REPLACE";
                        using (var cmdRestaurarBaseDeDatos = new SqlCommand(restaurarBaseDeDatos, oConexion))
                        {
                            _ = cmdRestaurarBaseDeDatos.ExecuteNonQuery();
                        }

                        var setMultiUser = $"ALTER DATABASE POSLyion SET MULTI_USER";
                        using (var cmdSetMultiUser = new SqlCommand(setMultiUser, oConexion))
                        {
                            _ = cmdSetMultiUser.ExecuteNonQuery();
                        }

                        _ = MessageBox.Show("Base de datos restaurada con éxito");
                    }
                    catch (Exception ex)
                    {
                        _ = MessageBox.Show("La restauración no se pudo realizar. Error: " + ex.Message);
                    }
                }
            }
        }
    }
}

