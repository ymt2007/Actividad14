using System;
using System.Collections.Generic;
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