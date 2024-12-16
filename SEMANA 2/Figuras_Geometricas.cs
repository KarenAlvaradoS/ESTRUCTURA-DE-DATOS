using System;

class Program
{
    // Clase para el Círculo
    class Circulo
    {
        public double Radio;  // Tipo de dato primitivo para el radio del círculo

        // Constructor de la clase Circulo
        public Circulo(double radio)
        {
            Radio = radio;
        }

        // Método para calcular el área
        public double CalcularArea()
        {
            return Math.PI * Radio * Radio;  // Fórmula para el área de un círculo
        }

        // Método para calcular el perímetro
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;  // Fórmula para el perímetro de un círculo
        }
    }

    // Clase para el Cuadrado
    class Cuadrado
    {
        public double Lado;  // Tipo de dato primitivo para el lado del cuadrado

        // Constructor de la clase Cuadrado
        public Cuadrado(double lado)
        {
            Lado = lado;
        }

        // Método para calcular el área
        public double CalcularArea()
        {
            return Lado * Lado;  // Fórmula para el área de un cuadrado
        }

        // Método para calcular el perímetro
        public double CalcularPerimetro()
        {
            return 4 * Lado;  // Fórmula para el perímetro de un cuadrado
        }
    }

    static void Main(string[] args)
    {
        // Crear un objeto de la clase Circulo
        Circulo circulo = new Circulo(5);  // Radio de 5 unidades
        Console.WriteLine($"Área del círculo: {circulo.CalcularArea()}");
        Console.WriteLine($"Perímetro del círculo: {circulo.CalcularPerimetro()}");

        // Crear un objeto de la clase Cuadrado
        Cuadrado cuadrado = new Cuadrado(4);  // Lado de 4 unidades
        Console.WriteLine($"Área del cuadrado: {cuadrado.CalcularArea()}");
        Console.WriteLine($"Perímetro del cuadrado: {cuadrado.CalcularPerimetro()}");

        // Esperar una tecla antes de cerrar la consola
        Console.ReadKey();
    }
}
