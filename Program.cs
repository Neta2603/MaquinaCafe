using System;

class Program
{
    static void Main()
    {
        var cafetera = new Cafetera(10);
        var vaso = new Vaso(10);
        var azucarero = new Azucarero(10);
        var maquina = new Maquina(cafetera, vaso, azucarero);

        Console.WriteLine("Bienvenido a la máquina de café");
        bool servido = maquina.ServirCafe(2, 2);
        Console.WriteLine(servido ? "Café servido con éxito" : "No hay suficientes recursos");
    }
}