using System;
using System.Collections.Generic;

List<Producto> productos = new List<Producto>();
Console.WriteLine("Cuantos productos desea ingresar?");
int n=int.Parse(Console.ReadLine());
for(int i=0; i<n; i++)
{
   Producto P=new Producto();
    Console.WriteLine($"Producto {i+1}");
    Console.WriteLine("Nombre del producto: "); P.Nombre = Console.ReadLine();
    Console.WriteLine("Precio: "); P.Precio=double.Parse(Console.ReadLine());
    Console.WriteLine("Cantidad: "); P.Cantidad = int.Parse(Console.ReadLine());
    productos.Add(P);
}
Console.Clear();
double sumaInventario = 0;
Producto masCaro = productos[0];
Console.WriteLine("Inventario");
foreach(Producto p in productos)
{
    p.MostrarInformacion();
    sumaInventario += p.ValorInventario();
    if (p.Precio > masCaro.Precio) 
    { 
        masCaro = p; 
    }
}
Console.WriteLine($"Total del inventario: {sumaInventario:F2}");
Console.WriteLine("Producto mas caro:");
masCaro.MostrarInformacion();
class Producto
{
    public string Nombre;
    public double Precio;
    public int Cantidad;
    public double ValorInventario()
    {
        return (Precio * Cantidad);
    }
    public string ExisteciaStock()
    {
        if (Cantidad == 0) return "Sin existecia";
        else if (Cantidad <= 6) return "Stock bajo";
        else return "Stock suficiente";
    }
    public void MostrarInformacion()
    {
        Console.WriteLine($"Producto: {Nombre} precio: Q{Precio:F2} cantidad {Cantidad} total: Q{ValorInventario()} estado: {ExisteciaStock()} ");
    }
}