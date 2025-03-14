public class Vaso
{
    public int Cantidad { get; private set; }

    public Vaso(int cantidad)
    {
        Cantidad = cantidad;
    }

    public bool UsarVasos(int cantidad)
    {
        if (Cantidad >= cantidad)
        {
            Cantidad -= cantidad;
            return true;
        }
        return false;
    }
}