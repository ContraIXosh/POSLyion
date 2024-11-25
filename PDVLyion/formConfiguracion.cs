using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Windows.Forms;

namespace POSLyion
{
    public partial class formConfiguracion : Form
    {
        public formConfiguracion()
        {
            InitializeComponent();

        }



        public void BackupBD(string nombre_base_datos, string backup_direccion)
        {
            try
            {
                var serverName = Environment.MachineName; // Nombre por defecto de la máquina
                var instanceName = "SQLExpress"; // Ejemplo de nombre de instancia nombrada

                // Combinación del nombre del servidor con el nombre de la instancia si es necesario
                var fullServerName = $@"{serverName}\{instanceName}";

                var servidor = new Server(new ServerConnection(fullServerName));
                var backup = new Backup
                {
                    Action = BackupActionType.Database,
                    Database = nombre_base_datos
                };

                var deviceItem = new BackupDeviceItem(backup_direccion, DeviceType.File);
                backup.Devices.Add(deviceItem);
                backup.Incremental = false;
                backup.SqlBackup(servidor);
                _ = System.Windows.Forms.MessageBox.Show("Punto de restauración realizado con éxito en " + backup_direccion, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                _ = System.Windows.Forms.MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void RestaurarBD(string nombre_base_datos, string backup_direccion)
        {
            try
            {
                var servidor = new Server(new ServerConnection(Environment.MachineName));
                servidor.KillAllProcesses("POSLyion");
                var restaurar = new Restore
                {
                    Database = nombre_base_datos,
                    Action = RestoreActionType.Database,
                    ReplaceDatabase = true,
                    NoRecovery = false
                };

                var deviceItem = new BackupDeviceItem(backup_direccion, DeviceType.File);
                restaurar.Devices.Add(deviceItem);
                restaurar.SqlRestore(servidor);
                _ = System.Windows.Forms.MessageBox.Show("Base de datos restaurada con éxito desde" + backup_direccion, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                _ = System.Windows.Forms.MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btb_exportar_bd_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Backup Files|*.bak";
                sfd.Title = "Guardar archivo de punto de restauración";
                sfd.FileName = "BackupPOSLyion" + DateTime.Now.ToString("ddMMyyyyhhmmss");

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    BackupBD("POSLyion", sfd.FileName);
                }
            }
        }

        private void btn_restaurar_bd_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Backup Files|*.bak";
                ofd.Title = "Seleccionar archivo de restauración";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    RestaurarBD("POSLyion", ofd.FileName);
                }
            }
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
    }
}

