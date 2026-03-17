using System;
using System.Collections.Generic;
class producto
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
        if (Cantidad == 0) return "Si9n existecia";
        else if (Cantidad <= 6) return "Stock bajo";
        else return "Stock suficinte";
    }
    public void MostrarInformacion()
    {
        Console.WriteLine($"Producto: {Nombre} precio: Q{Precio:F2} cantidad {Cantidad} total: Q{ValorInventario()} estado: {ExisteciaStock()} ");
    }
}