using CapaEntidad;
using CapaNegocio;
using POSLyion.Resources;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace POSLyion
{
    public partial class Start : Form
    {
        private static readonly List<Form> oFormList = new List<Form>();
        private ToolStripMenuItem currentSelectedMenuItem;

        public Start()
        {
            InitializeComponent();
            lbl_usuario.Text = VariablesGlobales.Usuario_actual.Nombre_completo;
            KeyPreview = true;
            AbrirFormularios();
            RegistrarEventos();
            FormManager.Instance.MostrarFormularioPrincipal(0);
            ActualizarColorSeleccionado(EncontrarMenuItem("tsmenu_venta"));
        }

        // Método para encontrar un ToolStripMenuItem por su nombre
        private ToolStripMenuItem EncontrarMenuItem(string nombreItem)
        {
            foreach (ToolStripMenuItem item in menu.Items)
            {
                if (item.Name == nombreItem)
                {
                    return item;
                }
            }
            return null; // Retornar null si no se encuentra el ítem
        }

        private void Start_Load(object sender, EventArgs e)
        {
            var lista_permisos = new CN_Permisos().Leer(VariablesGlobales.Usuario_actual.Id_usuario);
            foreach (ToolStripMenuItem item in menu.Items)
            {
                var encontrado = lista_permisos.Any(m => m.Nombre_menu == item.Name);
                if (encontrado == false)
                {
                    item.Visible = false;
                }
            }
        }

        private void NavbarClick(object sender, EventArgs e)
        {
            var menuSeleccionado = sender as ToolStripMenuItem;
            ActualizarColorSeleccionado(menuSeleccionado);

            if (menuSeleccionado != null)
            {
                // Definir un diccionario para mapear nombres de menús a índices
                var menuIndices = new Dictionary<string, int>
                {
                    { "tsmenu_venta", 0 },
                    { "tsmenu_compras", 1 },
                    { "tsmenu_prods", 2 },
                    { "tsmenu_users", 3 },
                    { "tsmenu_clientes", 4 },
                    { "tsmenu_proveedor", 5 },
                    { "tsmenu_reports", 6 },
                    { "tsmenu_cat", 7 },
                    { "tsmenu_config", 8 },
                    { "cerrarSesionToolStripMenuItem", 9 },
                };

                if (menuIndices.ContainsKey(menuSeleccionado.Name))
                {
                    var index = menuIndices[menuSeleccionado.Name];

                    if (FormManager.Instance.formulariosPrincipales.ContainsKey(index))
                    {
                        FormManager.Instance.MostrarFormularioPrincipal(index);
                    }
                    else if (FormManager.Instance.formulariosDialogo.ContainsKey(index))
                    {
                        FormManager.Instance.MostrarFormularioDialogo(index);
                    }
                }
            }
        }

        private void AbrirFormularios()
        {
            var formVentas = new formVentas();
            var formProductos = new formProductos();
            var formUsuarios = new formUsuarios();
            var formClientes = new formClientes();
            var formProveedores = new formProveedores();
            var formReportes = new formReportes();
            var formCategorias = new formCategorias();

            panel_formularios.Controls.Add(ConfigurarFormularios(formVentas));
            panel_formularios.Controls.Add(ConfigurarFormularios(formProductos));
            panel_formularios.Controls.Add(ConfigurarFormularios(formUsuarios));
            panel_formularios.Controls.Add(ConfigurarFormularios(formClientes));
            panel_formularios.Controls.Add(ConfigurarFormularios(formProveedores));
            panel_formularios.Controls.Add(ConfigurarFormularios(formReportes));
            panel_formularios.Controls.Add(ConfigurarFormularios(formCategorias));

            FormManager.Instance.RegistrarFormularioPrincipal(0, formVentas);
            FormManager.Instance.RegistrarFormularioPrincipal(2, formProductos);
            FormManager.Instance.RegistrarFormularioPrincipal(3, formUsuarios);
            FormManager.Instance.RegistrarFormularioPrincipal(4, formClientes);
            FormManager.Instance.RegistrarFormularioPrincipal(5, formProveedores);
            FormManager.Instance.RegistrarFormularioPrincipal(6, formReportes);
            FormManager.Instance.RegistrarFormularioPrincipal(7, formCategorias);

            FormManager.Instance.RegistrarFormularioDialogo(1, new formCompras());
            FormManager.Instance.RegistrarFormularioDialogo(8, new formConfiguracion());
            FormManager.Instance.RegistrarFormularioDialogo(9, new formLogOut());
        }

        private Form ConfigurarFormularios(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            return form;
        }

        private void RegistrarEventos()
        {
            tsmenu_venta.Click += new EventHandler(NavbarClick);
            tsmenu_compras.Click += new EventHandler(NavbarClick);
            tsmenu_prods.Click += new EventHandler(NavbarClick);
            tsmenu_users.Click += new EventHandler(NavbarClick);
            tsmenu_clientes.Click += new EventHandler(NavbarClick);
            tsmenu_proveedor.Click += new EventHandler(NavbarClick);
            tsmenu_reports.Click += new EventHandler(NavbarClick);
            tsmenu_cat.Click += new EventHandler(NavbarClick);
            tsmenu_config.Click += new EventHandler(NavbarClick);
            cerrarSesionToolStripMenuItem.Click += new EventHandler(NavbarClick);
        }

        private void ActualizarColorSeleccionado(ToolStripMenuItem menuItem)
        {
            if (currentSelectedMenuItem != null)
            {
                currentSelectedMenuItem.BackColor = Color.Transparent;
            }
            menuItem.BackColor = Color.Teal;
            currentSelectedMenuItem = menuItem;
        }
    }
}
