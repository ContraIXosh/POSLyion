using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace POSLyion.Resources
{
    public sealed class FormManager
    {
        private static readonly Lazy<FormManager> instance = new Lazy<FormManager>(() => new FormManager());
        public Dictionary<int, Form> formulariosPrincipales = new Dictionary<int, Form>();
        public Dictionary<int, Form> formulariosDialogo = new Dictionary<int, Form>();

        private FormManager() { }

        public static FormManager Instance => instance.Value;

        public void RegistrarFormularioPrincipal(int index, Form form)
        {
            formulariosPrincipales[index] = form;
        }

        public void RegistrarFormularioDialogo(int index, Form form)
        {
            formulariosDialogo[index] = form;
        }

        public void MostrarFormularioPrincipal(int index)
        {
            foreach (var form in formulariosPrincipales.Values)
            {
                form.Visible = false;
            }

            if (formulariosPrincipales.ContainsKey(index))
            {
                formulariosPrincipales[index].Visible = true;
                formulariosPrincipales[index].BringToFront(); // Traer el formulario al frente
            }
        }

        public void MostrarFormularioDialogo(int index)
        {
            if (formulariosDialogo.ContainsKey(index))
            {
                _ = formulariosDialogo[index].ShowDialog();
            }
        }

        public Form ObtenerFormularioDialogo(int index)
        {
            return formulariosDialogo.ContainsKey(index) ? formulariosPrincipales[index] : null;
        }

        public Form ObtenerFormularioPrincipal(int index)
        {
            return formulariosPrincipales.ContainsKey(index) ? formulariosPrincipales[index] : null;
        }

    }
}
