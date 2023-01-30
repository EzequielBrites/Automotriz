using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Automotriz.dominio
{
    internal class Vehiculos
    {
        private string marca;
        private string modelo;
        private int añofab;
        private string descripcion;

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Añofab { get => añofab; set => añofab = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public override string ToString()
        {
            return "Marca:" + marca + "Modelo:" + modelo + "Descripcion:" + descripcion;
        }
    }
}
