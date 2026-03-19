using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

List<Pedido> pedidos=new List<Pedido>();
Console.WriteLine("Cuantos pedido desea registrar?");
int n=int.Parse(Console.ReadLine());
for(int i=0; i<n; i++)
{
    Pedido p=new Pedido();
    Console.WriteLine($"Ingrese el pedido {i+1}");
    Console.WriteLine("Nombre del cliente: "); p.Cliente = Console.ReadLine();
    Console.WriteLine("Producto: "); p.Producto = Console.ReadLine();
    Console.WriteLine("Cantidad: "); p.Cantidad=int.Parse(Console.ReadLine());
    Console.WriteLine("Precio por unidad: "); p.PrecioUnitario=double.Parse(Console.ReadLine());
    pedidos.Add(p);
}
Console.Clear();
double suma = 0;
foreach(Pedido p in pedidos)
{
    p.MostrarInformacion();
    suma += p.Total();
}
Console.WriteLine($"El tottal de los pedidos registrados es de: {suma}");
class Pedido
{
    public string Cliente;
    public string Producto;
    public int Cantidad;
    public double PrecioUnitario;
    public double Subtotal()
    {
        return Cantidad * PrecioUnitario;
    }
    public double PrecioEnvio()
    {
        if (Subtotal() >= 400) return 0;
        else return 10;
    }
    public double Total()
    {
        double suma = 0;
        return suma = Subtotal() + PrecioEnvio();
    }
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre del cliente: {Cliente} Producto: {Producto} Cantidad: {Cantidad} Precio unitario: {PrecioUnitario} Subtotal: {Subtotal():F2} Precio de envio {PrecioEnvio():F2} Total: {Total():F2}");
    }
}