using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T10_EjerciciosMVVM.Models;

namespace T10_EjerciciosMVVM.ViewModels
{
    public class Ejercicio2VM
    {
        private clsPersona oPersona= new clsPersona();
        public clsPersona OPersona
        {
            get { return oPersona; }
            set { oPersona = value; }
        }
    }
}
