public class Cafetera
{
    public int CantidadCafe { get; private set; }

    public Cafetera(int cantidad)
    {
        CantidadCafe = cantidad;
    }

    public bool UsarCafe(int cantidad)
    {
        if (CantidadCafe >= cantidad)
        {
            CantidadCafe -= cantidad;
            return true;
        }
        return false;
    }
}