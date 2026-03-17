using System;
using System.Collections.Generic;

List<Estudiante> estudiantes = new List<Estudiante>();
Console.WriteLine("Cuantos estudiantes desea ingresar?");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    Estudiante e = new Estudiante();
    Console.WriteLine($"Estudiante {i + 1}");
    Console.WriteLine("Nombre: "); e.Nombre = Console.ReadLine();
    Console.WriteLine("Nota 1: "); e.Nota1=double.Parse(Console.ReadLine());
    Console.WriteLine("Nota 1: "); e.Nota2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Nota 1: "); e.Nota3 = double.Parse(Console.ReadLine());
    estudiantes.Add(e);
}
Console.WriteLine("Estudiantes registrados");
Estudiante mejor = estudiantes[0];
foreach(Estudiante e in estudiantes)
{
    e.MostrarInformacion();
    if(e.CalcularPromedio() > mejor.CalcularPromedio())
    {
        mejor = e;
    }
}
Console.WriteLine("El mejor estudiante es: ");
mejor.MostrarInformacion();
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
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre} promedio: {CalcularPromedio():F2} Estado: {Estado()}");
    }
}