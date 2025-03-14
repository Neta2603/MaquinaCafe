using Xunit;

public class TestMaquina
{
    [Fact]
    public void ServirCafe_DeberiaReducirRecursos()
    {
        var cafetera = new Cafetera(10);
        var vaso = new Vaso(10);
        var azucarero = new Azucarero(10);
        var maquina = new Maquina(cafetera, vaso, azucarero);
        
        bool resultado = maquina.ServirCafe(2, 2);
        
        Assert.True(resultado);
        Assert.Equal(8, cafetera.CantidadCafe);
        Assert.Equal(8, vaso.Cantidad);
        Assert.Equal(8, azucarero.CantidadAzucar);
    }
}
