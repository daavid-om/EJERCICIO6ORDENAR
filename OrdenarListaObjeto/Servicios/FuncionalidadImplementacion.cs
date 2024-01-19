using OrdenarListaObjeto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenarListaObjeto.Servicios
{
    /// <summary>
    /// Clase que implementa la interfaz de funcionalidad
    /// dom - 190124
    /// </summary>
    internal class FuncionalidadImplementacion : FuncionalidadInterfaz
    {
        public void darAltaCliente(List<ClienteDto> listaClienteAntigua)
        {
            ClienteDto nuevoCliente = crearCliente();
            listaClienteAntigua.Add(nuevoCliente);
        }

        /// <summary>
        /// Método que pide al usuario la informacion necesaria para crear un nuevo cliente
        /// dom - 190124
        /// </summary>
        /// <returns></returns>
        private ClienteDto crearCliente()
        {
            ClienteDto cliente = new ClienteDto();
            Console.WriteLine("Introduce el id del cliente: ");
            cliente.IdCliente = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Introduzca el nombre del cliente: ");
            cliente.NombreCliente = Console.ReadLine();
            Console.WriteLine("Introduzca los apellidos del cliente: ");
            cliente.ApellidosCliente = Console.ReadLine();
            Console.WriteLine("Introduzca la edad del cliente: ");
            cliente.EdadCliente = Convert.ToInt32(Console.ReadLine());
            return cliente;
        }
        //Algoritmo de ordenación burbuja
        public void ordenarCLiente(List<ClienteDto> listaClienteAntigua)
        {
            int ter = listaClienteAntigua.Count;
            if (ter >= 3)
            {
                for (int i = 0; i < listaClienteAntigua.Count; i++)
                {
                    for (int j = 0; j < listaClienteAntigua.Count - 1 - i; j++)
                    {
                        if (listaClienteAntigua[j + 1].EdadCliente > listaClienteAntigua[j].EdadCliente)
                        {
                            ClienteDto aux = listaClienteAntigua[j];
                            listaClienteAntigua[j] = listaClienteAntigua[j + 1];
                            listaClienteAntigua[j + 1] = aux;
                        }
                    }
                }

                foreach (ClienteDto cliente in listaClienteAntigua)
                {   
                    Console.WriteLine(cliente.ToString());
                }
            }
            else
            {
                Console.WriteLine("[INFO] - No hay suficientes clientes para ordenar");
            }
        }
    }
}