using System;

namespace POSLyion.Resources.Interfaces
{
    public interface IFormCRUD
    {
        void CargarManejadoresEventos();
        void CargarValoresPorDefecto();
        void MostrarDatosObjeto();
        void CrearNuevoObjeto();
        void EditarObjeto();
        bool ValidarDatos();
        void RespaldoDatosObjeto();
        void btn_guardar_Click(object sender, EventArgs e);
        void btn_cerrar_Click(object sender, EventArgs e);
        void btn_reiniciar_datos_Click(object sender, EventArgs e);
    }
}
