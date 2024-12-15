using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace POSLyion
{
    internal class classTicket
    {
        public class CreaTicket
        {
            public static StringBuilder line = new StringBuilder();
            private string ticket = "";
            private string parte1, parte2;

            public static int max = 40;
            private int cort;
            public static string LineasGuion()
            {
                var LineaGuion = "----------------------------------------";

                return line.AppendLine(LineaGuion).ToString();
            }


            public static void EncabezadoVenta(DataGridView dgv)
            {
                var LineEncavesado = "Articulo       Cant   P.Unit    Valor";
                _ = line.AppendLine(LineEncavesado);
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    var venta_detalle =
        row.Cells["dgv_resumen_descripcion"].Value.ToString() + "\t" +
        row.Cells["dgv_resumen_cantidad"].Value.ToString() + "\t" +
        row.Cells["dgv_resumen_precio"].Value.ToString() + "\t" +
        row.Cells["dgv_resumen_subtotal"].Value.ToString() + "\t";
                    _ = line.AppendLine(venta_detalle);
                }
            }
            public void TextoIzquierda(string par1)
            {
                max = par1.Length;
                if (max > 40)
                {
                    cort = max - 40;
                    parte1 = par1.Remove(40, cort);
                }
                else { parte1 = par1; }
                _ = line.AppendLine(ticket = parte1);

            }
            public void TextoDerecha(string par1)
            {
                ticket = "";
                max = par1.Length;
                if (max > 40)
                {
                    cort = max - 40;
                    parte1 = par1.Remove(40, cort);
                }
                else { parte1 = par1; }
                max = 40 - par1.Length;
                for (var i = 0; i < max; i++)
                {
                    ticket += " ";
                }
                _ = line.AppendLine(ticket += parte1 + "\n");

            }
            public void TextoCentro(string par1)
            {
                ticket = "";
                max = par1.Length;
                if (max > 40)
                {
                    cort = max - 40;
                    parte1 = par1.Remove(40, cort);
                }
                else { parte1 = par1; }
                max = (40 - parte1.Length) / 2;
                for (var i = 0; i < max; i++)
                {
                    ticket += " ";
                }
                _ = line.AppendLine(ticket += parte1 + "\n");

            }
            public void TextoExtremos(string par1, string par2)
            {
                max = par1.Length;
                if (max > 18)
                {
                    cort = max - 18;
                    parte1 = par1.Remove(18, cort);
                }
                else { parte1 = par1; }
                ticket = parte1;
                max = par2.Length;
                if (max > 18)
                {
                    cort = max - 18;
                    parte2 = par2.Remove(18, cort);
                }
                else { parte2 = par2; }
                max = 40 - (parte1.Length + parte2.Length);
                for (var i = 0; i < max; i++)
                {
                    ticket += " ";
                }
                _ = line.AppendLine(ticket += parte2 + "\n");

            }
            public void AgregaTotales(string par1, double total)
            {
                max = par1.Length;
                if (max > 25)
                {
                    cort = max - 25;
                    parte1 = par1.Remove(25, cort);
                }
                else { parte1 = par1; }
                ticket = parte1;
                parte2 = total.ToString("c");
                max = 40 - (parte1.Length + parte2.Length);
                for (var i = 0; i < max; i++)
                {
                    ticket += " ";
                }
                _ = line.AppendLine(ticket += parte2 + "\n");

            }

            public void AgregaArticulo(string Articulo, double precio, int cant, double subtotal)
            {
                if (cant.ToString().Length <= 3 && precio.ToString("c").Length <= 10 && subtotal.ToString("c").Length <= 11)
                {
                    string elementos = "", espacios = "";
                    var bandera = false;
                    int nroEspacios;
                    if (Articulo.Length > 40)
                    {

                        nroEspacios = 3 - cant.ToString().Length;
                        espacios = "";
                        for (var i = 0; i < nroEspacios; i++)
                        {
                            espacios += " ";
                        }
                        elementos += espacios + cant.ToString();

                        // colocamos el precio a la derecha
                        nroEspacios = 10 - precio.ToString().Length;
                        espacios = "";

                        for (var i = 0; i < nroEspacios; i++)
                        {
                            espacios += " ";
                        }
                        elementos += espacios + precio.ToString();

                        //colocar el subtotal a la derecha
                        nroEspacios = 11 - subtotal.ToString().Length;
                        espacios = "";

                        for (var i = 0; i < nroEspacios; i++)
                        {
                            espacios += " ";
                        }
                        elementos += espacios + subtotal.ToString();

                        var CaracterActual = 0;
                        for (var Longtext = Articulo.Length; Longtext > 16; Longtext++)
                        {
                            if (bandera == false)
                            {
                                _ = line.AppendLine(Articulo.Substring(CaracterActual, 16) + elementos);
                                bandera = true;
                            }
                            else
                            {
                                _ = line.AppendLine(Articulo.Substring(CaracterActual, 16));

                            }
                            CaracterActual += 16;
                        }
                        _ = line.AppendLine(Articulo.Substring(CaracterActual, Articulo.Length - CaracterActual));


                    }
                    else
                    {
                        for (var i = 0; i < (16 - Articulo.Length); i++)
                        {
                            espacios += " ";

                        }
                        elementos = Articulo + espacios;
                        nroEspacios = 3 - cant.ToString().Length;
                        espacios = "";
                        for (var i = 0; i < nroEspacios; i++)
                        {
                            espacios += " ";
                        }
                        elementos += espacios + cant.ToString();

                        // colocamos el precio a la derecha
                        nroEspacios = 10 - precio.ToString().Length;
                        espacios = "";

                        for (var i = 0; i < nroEspacios; i++)
                        {
                            espacios += " ";
                        }
                        elementos += espacios + precio.ToString();

                        //colocar el subtotal a la derecha
                        nroEspacios = 11 - subtotal.ToString().Length;
                        espacios = "";

                        for (var i = 0; i < nroEspacios; i++)
                        {
                            espacios += " ";
                        }
                        elementos += espacios + subtotal.ToString();
                        _ = line.AppendLine(elementos);

                    }
                }
                else
                {
                    //  MessageBox.Show("Valores fuera de rango");

                }
            }

            public void ImprimirTiket(string stringimpresora)
            {
                _ = RawPrinterHelper.SendStringToPrinter(stringimpresora, line.ToString());
                line = new StringBuilder();

            }
        }
        //API Printer
        public class RawPrinterHelper
        {

            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
            public class DOCINFOA
            {
                [MarshalAs(UnmanagedType.LPStr)]
                public string pDocName;
                [MarshalAs(UnmanagedType.LPStr)]
                public string pOutputFile;
                [MarshalAs(UnmanagedType.LPStr)]
                public string pDataType;
            }
            //API de Printer
            [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

            [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool ClosePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool StartDocPrinter(IntPtr hPrinter, int level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

            [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool EndDocPrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool StartPagePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool EndPagePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, int dwCount, out int dwWritten);

            public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, int dwCount)
            {
                _ = new IntPtr(0);
                var di = new DOCINFOA();
                var bSuccess = false;

                di.pDocName = "Documento de impresion";
                di.pDataType = "RAW";
                if (OpenPrinter(szPrinterName.Normalize(), out var hPrinter, IntPtr.Zero))
                {
                    if (StartDocPrinter(hPrinter, 1, di))
                    {
                        if (StartPagePrinter(hPrinter))
                        {
                            bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out var _);
                            _ = EndPagePrinter(hPrinter);
                        }
                        _ = EndDocPrinter(hPrinter);
                    }
                    _ = ClosePrinter(hPrinter);
                }
                if (bSuccess == false)
                {
                    _ = Marshal.GetLastWin32Error();
                }
                return bSuccess;
            }

            public static bool SendStringToPrinter(string szPrinterName, string szString)
            {
                IntPtr pBytes;
                int dwCount;
                dwCount = szString.Length;
                pBytes = Marshal.StringToCoTaskMemAnsi(szString);
                _ = SendBytesToPrinter(szPrinterName, pBytes, dwCount);
                Marshal.FreeCoTaskMem(pBytes);
                return true;
            }
        }
    }
}
