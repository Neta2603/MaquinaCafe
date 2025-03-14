public class Azucarero
{
    public int CantidadAzucar { get; private set; }

    public Azucarero(int cantidad)
    {
        CantidadAzucar = cantidad;
    }

    public bool UsarAzucar(int cantidad)
    {
        if (CantidadAzucar >= cantidad)
        {
            CantidadAzucar -= cantidad;
            return true;
        }
        return false;
    }
}   