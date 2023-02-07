// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¿Cuántos estudiantes quieres calificar?");
        int numEstudiantes = int.Parse(Console.ReadLine());

        string[] nombres = new string[numEstudiantes];
        double[] nota1 = new double[numEstudiantes];
        double[] nota2 = new double[numEstudiantes];
        double[] promedios = new double[numEstudiantes];
        double sumaTotal = 0;

        for (int i = 0; i < numEstudiantes; i++)
        {
            Console.WriteLine("Ingresa el nombre del estudiante:");
            nombres[i] = Console.ReadLine();

            Console.WriteLine("Ingresa la nota 1:");
            nota1[i] = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la nota 2:");
            nota2[i] = double.Parse(Console.ReadLine());

            promedios[i] = (nota1[i] + nota2[i]) / 2;
            sumaTotal += promedios[i];
        }

        Console.WriteLine("\nResultados:");
        for (int i = 0; i < numEstudiantes; i++)
        {
            Console.WriteLine("Nombre: " + nombres[i]);
            Console.WriteLine("Nota1 " + nota1[i]);
            Console.WriteLine("Nota2 " + nota2[i]);
            Console.WriteLine( "Promedio " + promedios[i]);
        }
        double promedioTotal = sumaTotal / numEstudiantes;
        Console.WriteLine("La suma total es:" + sumaTotal);

       Console.WriteLine("El promedio total es " + promedioTotal);
    }
}


