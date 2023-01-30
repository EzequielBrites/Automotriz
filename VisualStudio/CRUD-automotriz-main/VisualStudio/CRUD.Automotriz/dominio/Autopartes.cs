using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Automotriz.dominio
{
    internal class Autopartes
    {
        private int id;
        private string nombre;
        private string modelo;
        private int idcolor;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Idcolor { get => idcolor; set => idcolor = value; }
    }
}
