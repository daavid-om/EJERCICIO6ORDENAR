using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenarListaObjeto.Servicios
{
    /// <summary>
    /// Interfaz que implementa el menú
    /// dom - 190124
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que muestra el menú de la aplicación y recoge la selección del usuario
        /// dom - 190124
        /// </summary>
        public int mostrarMenuYSeleccion();
    }
}
