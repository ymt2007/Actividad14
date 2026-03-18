using System;
using System.Collections.Generic;
List<Libro> libros = new List<Libro>();
Console.WriteLine("Cuantos libros desea registrar?");
int n=int.Parse(Console.ReadLine());
for(int i=0;i<n;i++)
{
    Libro l = new Libro();
    Console.WriteLine($"Libro {i+1}");
    Console.WriteLine("Titulo: "); l.Titulo = Console.ReadLine();
    Console.WriteLine("Autor: "); l.Autor = Console.ReadLine();
    Console.WriteLine("Categoria: "); l.Categoria = Console.ReadLine();
    Console.WriteLine("Numero de paginas: "); l.Paginas=int.Parse(Console.ReadLine());
    libros.Add(l);
}
Console.Clear();
Libro mayor = libros[0];
Console.WriteLine("Libros registrados");
foreach(Libro l in libros)
{
    l.MostrarInformacion();
    if(l.Paginas>mayor.Paginas)
    {
        mayor = l;
    }
}
Console.WriteLine("El libro con mas paginas es: ");
mayor.MostrarInformacion();
class Libro
{
    public string Titulo;
    public string Autor;
    public string Categoria;
    public int Paginas;
    public string Clasificacion()
    {
     if (Paginas >= 500) return "Muy extenso";
     else if (Paginas >= 200) return "Mediano";
     else return "Corto";
    }
    public void MostrarInformacion()
    {
        Console.WriteLine($"Titulo: {Titulo} Autor: {Autor} categoria: {Categoria} paginas: {Paginas} clasificaion: {Clasificacion()}");
    }
}