using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_GUI
{
    public class Empleado
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cargo { get; set; }
        public double PagoPorHora { get; set; }
        public double HorasTrabajadas { get; set; }
        public double SueldoTotal { get; set; }

        public Empleado(int codigo, string nombre, string apellido, string cargo, double pagoPorHora, double horasTrabajadas)
        {
            Codigo = codigo;
            Apellido = apellido;
            Nombre = nombre;
            Cargo = cargo;
            PagoPorHora = pagoPorHora;
            HorasTrabajadas = horasTrabajadas;
            SueldoTotal = CalcularSueldoTotal();
        }

        public double CalcularSueldoTotal()
        {
            return PagoPorHora * HorasTrabajadas *20;
        }

        public override string ToString()
        {
            return $"Código: {Codigo}, Apellido: {Apellido}, Nombre: {Nombre}, Sueldo Total: {SueldoTotal}";
        }
    }
}
