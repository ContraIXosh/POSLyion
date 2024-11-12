using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows;
using PDCLyion;
using static POSLyion.formConfiguracion;

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
                Server servidor = new Server(new ServerConnection(Environment.MachineName));
                Backup backup = new Backup
                {
                    Action = BackupActionType.Database,
                    Database = nombre_base_datos
                };

                BackupDeviceItem deviceItem = new BackupDeviceItem(backup_direccion, DeviceType.File);
                backup.Devices.Add(deviceItem);
                backup.Incremental = false;
                backup.SqlBackup(servidor);
                System.Windows.Forms.MessageBox.Show("Punto de restauración realizado con éxito en " + backup_direccion, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void RestaurarBD(string nombre_base_datos, string backup_direccion)
        {
            try
            {
                Server servidor = new Server(new ServerConnection(Environment.MachineName));
                servidor.KillAllProcesses("POSLyion");
                Restore restaurar = new Restore
                {
                    Database = nombre_base_datos,
                    Action = RestoreActionType.Database,
                    ReplaceDatabase = true,
                    NoRecovery = false
                };

                BackupDeviceItem deviceItem = new BackupDeviceItem(backup_direccion, DeviceType.File);
                restaurar.Devices.Add(deviceItem);
                restaurar.SqlRestore(servidor);
                System.Windows.Forms.MessageBox.Show("Base de datos restaurada con éxito desde" + backup_direccion, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btb_exportar_bd_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
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
            using (OpenFileDialog ofd = new OpenFileDialog())
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
          LoginPOS loginPOS = new LoginPOS();
            loginPOS.Show();
        }
    }
}

