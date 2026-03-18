using System;
using System.Collections.Generic;

Dictionary<int, Estudiante> estudiantes=new Dictionary<int ,Estudiante>();
Console.WriteLine("Cuantos estudiantes desea registrar?");
int n = int.Parse(Console.ReadLine());
for(int i=0;i<n;i++)
{
    Console.WriteLine($"Registro {i+1}");
    Console.WriteLine("Numero de carnet: ");
    int carnet=int.Parse(Console.ReadLine());
    Estudiante e=new Estudiante();
    Console.WriteLine("Nombre: "); e.Nombre = Console.ReadLine();
    Console.WriteLine("Carrera: "); e.Carrera = Console.ReadLine();
    Console.WriteLine("Nota final: "); e.NotaFinal=double.Parse(Console.ReadLine());
    estudiantes[carnet] = e;
 }
Console.Clear();
Console.WriteLine("Estudiantes registrados");
foreach (KeyValuePair<int, Estudiante> item in estudiantes)
{
    Console.Write($"Carnet: {item.Key} | ");
    item.Value.MostrarInformacion();
}
string op;
do
{
    Console.WriteLine("Desea buscar un alumno en especifico? (s/n)");
    op = Console.ReadLine();
    if (op == "s")
    {
        Console.WriteLine("Ingrese el carnet del estudiante");
        int buscar = int.Parse(Console.ReadLine());
        if (estudiantes.ContainsKey(buscar))
        {
            Console.WriteLine("Estudiante encontrado:");
            estudiantes[buscar].MostrarInformacion();
        }
        else
        {
            Console.WriteLine("No existe un estudiante con ese carnet.");
        }
    }
} while (op != "n");
class Estudiante
{
    public string Nombre;
    public string Carrera;
    public double NotaFinal;
    public string Estado()
    {
        if (NotaFinal >= 61) return "Aprobado";
        else return "Reprobado";
    }
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre} Carrera: {Carrera} Nota final: {NotaFinal} Estado: {Estado()}");
    }
}