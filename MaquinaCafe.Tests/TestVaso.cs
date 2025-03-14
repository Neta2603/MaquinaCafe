using Xunit;

public class TestVaso
{
    [Fact]
    public void UsarVasos_DeberiaReducirCantidad()
    {
        var vaso = new Vaso(5);
        bool resultado = vaso.UsarVasos(2);
        Assert.True(resultado);
        Assert.Equal(3, vaso.Cantidad);
    }
}