using OrdenarListaObjeto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenarListaObjeto.Servicios
{
    /// <summary>
    /// Interfaz que implementa la funcionalidad de las operaciones
    /// dom - 190124
    /// </summary>
    internal interface FuncionalidadInterfaz
    {
        /// <summary>
        /// Método que da alta a los clinetes
        /// dom - 190124
        /// </summary>
        /// <param name="listaClienteAntigua"></param>
        public void darAltaCliente(List<ClienteDto> listaClienteAntigua);
        /// <summary>
        /// Método que ordena los clientes
        /// dom - 190124
        /// </summary>
        /// <param name="listaClienteAtigua"></param>
        public void ordenarCLiente(List<ClienteDto> listaClienteAtigua);
    }
}
