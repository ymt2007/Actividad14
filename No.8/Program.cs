using System;
using System.Collections.Generic;



class Cuenta
{
    public string Titular;
    public double Saldo;
    public double Depositar()
    {
        Console.WriteLine("Cuanto dinero desea depositar?");
        double monto=double.Parse(Console.ReadLine());
        Console.WriteLine("Deposito realizado");
        return Saldo+=monto;
    }
    public string Retirar()
    {
        Console.WriteLine("Cuanto dinero desea retirar?");
        double retiro=double.Parse(Console.ReadLine());
        if (retiro <= 0) return "Cantidad invalida";
        else if (retiro > Saldo) return "Error, el retiro no puede ser mayor al saldo";
        else
        {
            Saldo-=retiro;
            return "Retiro realizado con exito!";
        }
    }
    public void MostrarInformacion()
    {
        Console.WriteLine($"Titular: {Titular} Saldo: {Saldo }");
    }
}