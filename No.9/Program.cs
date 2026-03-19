using System;
using System.Collections.Generic;

List<Curso> cursos = new List<Curso>();
Console.WriteLine("Cuantos cursos desea regsitrar?");
int n=int.Parse(Console.ReadLine());
for(int i=0; i<n;i++)
{
    Curso c = new Curso();
    Console.WriteLine($"Curso {i+1}");
    Console.WriteLine("Nombre del curso: "); c.NombreCurso = Console.ReadLine();
    Console.WriteLine("Creditos: "); c.Creditos=int.Parse((string)Console.ReadLine());
    Console.WriteLine("Nota promedio: "); c.NotaPromedio = double.Parse(Console.ReadLine());
    cursos.Add(c);
}
Console.Clear();
Curso mejor = cursos[0];
Console.WriteLine("Cursos regsitrados: ");
foreach(Curso c in cursos)
{
    c.MostrarInformacion();
    if(c.NotaPromedio>mejor.NotaPromedio)
    {
        mejor = c;
    }
}
Console.WriteLine("Mejor curso: ");
mejor.MostrarInformacion();
class Curso
{
    public string NombreCurso;
    public int Creditos;
    public double NotaPromedio;
    public string Rendimiento()
    {
        if (NotaPromedio < 0) return "Nota negativa no valida";
        else if (NotaPromedio > 0 && NotaPromedio <= 50) return "Bajo";
        else if (NotaPromedio <= 70) return "Aceptable";
        else return "Excelente";
    }
    public void MostrarInformacion()
    {
        Console.WriteLine($"Curso: {NombreCurso} Creditos: {Creditos} Promedio: {NotaPromedio:F2} Rendimiento: {Rendimiento()}");
    }
}