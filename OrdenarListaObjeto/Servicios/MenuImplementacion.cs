using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenarListaObjeto.Servicios
{
    /// <summary>
    /// Clase que que implementa el menu de la aplicación
    /// dom - 190124
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcion = 0;
            Console.WriteLine("0. Se cierra la aplicación");
            Console.WriteLine("1. Dar alta nuevo cliente");
            Console.WriteLine("2. Ordenar lista clientes");
            Console.WriteLine("Introduzca la opcion deseada:");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
    }
}
