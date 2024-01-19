using OrdenarListaObjeto.Dto;
using OrdenarListaObjeto.Servicios;

namespace OrdenarListaObjeto
{
    /// <summary>
    /// Clase principal de la aplicación
    /// dom - 190124
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal de la aplicación
        /// dom - 190124
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //creamos los objetos
            MenuInterfaz mi = new MenuImplementacion();
            FuncionalidadInterfaz fi = new FuncionalidadImplementacion();
            List<ClienteDto> listaCliente = new List<ClienteDto>();
            
            int opcionSeleccionada = 0;
            bool cerrarMenu = false;
            
            while (!cerrarMenu)
            {
                opcionSeleccionada = mi.mostrarMenuYSeleccion();
                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO] Ha seleccionado la opcion 0");
                        Console.WriteLine("Se cierra la aplicación");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] Ha seleccionado la opcion 1");
                        fi.darAltaCliente(listaCliente);
                        break;
                    case 2:
                        Console.WriteLine("[INFO] Ha seleccionado la opcion 2");
                        fi.ordenarCLiente(listaCliente);
                        break;
                    default:
                        Console.WriteLine("[INFO] La opcion seleccionada no coincide con ninguna opción del menu");
                        break;
                }
            }

        }
    }
}