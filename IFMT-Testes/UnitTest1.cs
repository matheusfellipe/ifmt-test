namespace IFMT_Testes
{
    public class UnitTest1
    {
       
         

        //[Theory]
        //[InlineData(60, 1.70, 20.76, "Peso normal")]
        //[InlineData(80, 1.70, 27.68, "Sobrepeso")]
        //[InlineData(100, 1.70, 34.48, "Obesidade grau I")]
        //[InlineData(120, 1.70, 41.18, "Obesidade grau II")]
        //[InlineData(140, 1.70, 47.87, "Obesidade grau III")]
        //public void CalcularImc_Deve_Retornar_Valor_Correto(double peso, double altura, double imcEsperado, string classificacaoEsperada)
        //{
        //    // Arrange
        //    var calculadora = new ImcCalculator();

        //    // Act
        //    var imc = calculadora.CalcularImc(peso, altura);
        //    var classificacao = calculadora.ClassificarImc(imc);

        //    // Assert
        //    Assert.Equal(imcEsperado, imc);
        //    Assert.Equal(classificacaoEsperada, classificacao);
        //}

        [Theory]
        [InlineData(10.00, 4.50)]
        [InlineData(100, 3)]
        [InlineData(1.99, 1.99)]  
        public void ApplyDiscount_ShouldApplyMaximumDiscount_And_PreventZeroPrice(decimal originalPrice, decimal discount)
        {
            // Arrange
            var item = new Item("Test Item", originalPrice);
            var discountCalculator = new DiscountCalculator();

            // Act
            var subTotal = discountCalculator.ApplyDiscount(item, discount);
           

            // Assert
            Assert.True(item.Price > 0);
            Assert.True((discount / originalPrice) *100 <= 3);
          
        }
    }


}