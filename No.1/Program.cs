using System;
using System.Collections.Generic;

List<Estudiante> estudiantes = new List<Estudiante>();
Console.WriteLine("Cuantos estudiantes desea ingresar?");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    Estudiante e = new Estudiante();
    Console.WriteLine($"Estudiante {i + 1}");
}

class Estudiante
{
    public string Nombre;
    public double Nota1;
    public double Nota2;
    public double Nota3;
    public double CalcularPromedio()
    {
        return (Nota1 + Nota2 + Nota3) / 3;
    }
    public string Estado()
    {
        if (CalcularPromedio() >= 61) return "Aprobado";
        else return "Reprobado";
    }
    public void MostrarInfotmacion()
    {
        Console.WriteLine($"Nombre: {Nombre} promedio: {CalcularPromedio:F2} Estado: {Estado}");
    }
}