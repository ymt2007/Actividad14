using System;
using System.Collections.Generic;
class Venta
{
    public string Producto;
    public double Precio;
    public int Cantidad;
    public double Subtotal()
    {
        return (Precio * Cantidad);
    }
    public double Descuento()
    {
        if (Subtotal() > 2000) return Subtotal() * 0.10;
        else if (Subtotal() >= 1000) return Subtotal() * 0.05;
        else return 0;
    }
    public double MontoTotal()
    {
        return Subtotal()-Descuento();
    }
    public void MostrarInformacion()
    {
        Console.WriteLine($"Producto: {Producto} Precio: {Precio} Cantidad; {Cantidad} Subtotal: {Subtotal():F2} Descuento:{Descuento():F2} Total a pagar: {MontoTotal():F2}");
    }
}