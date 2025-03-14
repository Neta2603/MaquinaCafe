using Xunit;

public class TestCafetera
{
    [Fact]
    public void UsarCafe_DeberiaReducirCantidad()
    {
        var cafetera = new Cafetera(10);
        bool resultado = cafetera.UsarCafe(4);
        Assert.True(resultado);
        Assert.Equal(6, cafetera.CantidadCafe);
    }
}