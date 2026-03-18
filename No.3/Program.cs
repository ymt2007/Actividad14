using System;
using System.Collections.Generic;

List<Empleado> empleados=new List<Empleado>();
Console.WriteLine("Cuantos empleados desea ingresar?");
int n=int.Parse(Console.ReadLine());
for(int i=0;i<n;i++)
{
    Empleado e=new Empleado();
    Console.WriteLine($"Empleado {i+1}");
    Console.WriteLine("Nombre: "); e.Nombre = Console.ReadLine();
    Console.WriteLine("Puesto: "); e.Puesto = Console.ReadLine();
    Console.WriteLine("Salario mensual: "); e.Salario=double.Parse(Console.ReadLine());
    empleados.Add(e);
}
Console.Clear();
Console.WriteLine("Listado de empleados ");
foreach(Empleado e in empleados)
{
    e.MostrarDatos();
}

class Empleado
{
    public string Nombre;
    public string Puesto;
    public double Salario;
    public double CalcularSalarioAnual() { return Salario * 12; }
    public double CalcularBono()
    {
        if (Salario >= 6000) return Salario * 0.15;
        else return Salario * 0.10;
    }
    public string ClasificarSalario()
    {
        if (Salario >= 8000) return "Salario alto";
        else if (Salario >= 4500) return "Salario medio";
        else return "Salario básico";
    }
    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre: {Nombre} Puesto: {Puesto}  Salario mensual: Q{Salario:F2} Salario anual: Q{ CalcularSalarioAnual():F2}  Bono: Q{ CalcularBono():F2} Nivel: { ClasificarSalario()}");
        
    }

}