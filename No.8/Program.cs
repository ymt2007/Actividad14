using System;
using System.Collections.Generic;

List<Cuenta> cuentas=new List<Cuenta>();
Console.WriteLine("Cuantas cuentas desea ingresar?");
int n = int.Parse(Console.ReadLine());
for(int i=0;i<n;i++)
{
    Cuenta c=new Cuenta();
    Console.WriteLine($"Cuenta {i+1}");
    Console.WriteLine("Titular: "); c.Titular = Console.ReadLine();
    Console.WriteLine("Saldo: "); c.Saldo=double.Parse(Console.ReadLine());
    cuentas.Add(c);
}
Console.Clear();
string op;
int op1=0;
do
{
    Console.WriteLine("Desea hacer una modificacion con la cuenta? (s/n)");
    op=Console.ReadLine();
    if( op=="s")
    {
        Console.WriteLine("Seleccione la cuenta (en numero)");
        for(int i=0;i<cuentas.Count;i++)
        {
            Console.WriteLine($"{i+1}. {cuentas[i].Titular}");
        }
        int indice=int.Parse(Console.ReadLine())-1;
        Console.WriteLine("1. Deposito");
        Console.WriteLine("2. Retiro");
        Console.WriteLine("3. Salir ");
        Console.WriteLine("Ingrese la opcion que necesita (en numero)");
        op1 = int.Parse(Console.ReadLine());
        if (op1 == 1)
        {
            cuentas[indice].Depositar();
        }
        else if (op1 == 2)
        {
            Console.WriteLine(cuentas[indice].Retirar());
        }
    }
} while (op == "s" && op1 != 3); 
foreach(Cuenta c in cuentas)
{
    c.MostrarInformacion();
}

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