using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bibloteca_
{
    class ListaDeEspera
    {
        private Pacientes primero = new Pacientes();
        private Pacientes ultimo = new Pacientes();


        public ListaDeEspera()
        {
            primero = null;
            ultimo = null;
        }

        public void IngresaPaciente()
        {
            ListaDeEspera nuevo = new ListaDeEspera();
            Console.WriteLine("Ingrese el nombre de los pacientes ");
            nuevo.nombre = Console.ReadLine();
        }
    }
}
