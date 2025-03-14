using Xunit;

public class TestAzucarero
{
    [Fact]
    public void UsarAzucar_DeberiaReducirCantidad()
    {
        var azucarero = new Azucarero(8);
        bool resultado = azucarero.UsarAzucar(3);
        Assert.True(resultado);
        Assert.Equal(5, azucarero.CantidadAzucar);
    }
}