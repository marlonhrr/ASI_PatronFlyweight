using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class ClaseVehiculoNOUSAR
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Matricula { get; set; }
        public DateTime FechaMatricula { get; set; }
        public string Propietario { get; set; }

        public ClaseVehiculoNOUSAR(string marca, string modelo, string color, 
            string matricula, DateTime fechaMatricula, string propietario)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Color = color;
            this.Matricula = matricula;
            this.FechaMatricula = fechaMatricula;
            this.Propietario = propietario;
        }

        public void MostrarCaracteristicas()
        {
            Console.WriteLine(Marca + " " + Modelo + " " + Color + " con matricula " 
                + Matricula + " (" + FechaMatricula + ") registrado por " + Propietario);
        }
    }
}
