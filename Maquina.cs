//Proving github is working

using System;

public class Maquina
{
    public Cafetera Cafetera { get; private set; }
    public Vaso Vaso { get; private set; }
    public Azucarero Azucarero { get; private set; }

    public Maquina(Cafetera cafetera, Vaso vaso, Azucarero azucarero)
    {
        Cafetera = cafetera;
        Vaso = vaso;
        Azucarero = azucarero;
    }

    public bool ServirCafe(int cantidadVasos, int cantidadAzucar)
    {
        return Cafetera.UsarCafe(cantidadVasos) && 
               Vaso.UsarVasos(cantidadVasos) && 
               Azucarero.UsarAzucar(cantidadAzucar);
    }
}