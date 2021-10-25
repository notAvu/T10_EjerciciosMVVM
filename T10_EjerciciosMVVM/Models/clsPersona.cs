using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T10_EjerciciosMVVM.Models
{
    public class clsPersona
    {
        string nombre;
        string apellido;

        clsPersona() 
        {
            nombre = "Alvaro";
            apellido = "Fernandez Villar";
        }

        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
