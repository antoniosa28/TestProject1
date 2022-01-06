using System;
using Xunit;

namespace TestProject1
{
    public class TestDominio
    {
        [Fact]
        public void VariaveisTeroMesmoValor()
        {

            //Arrange
            var var1 = 1;
            var var2 = 1;

            //Act
            var1 = var2;

            //Assert
            Assert.Equal(var1, var2); 
        }
    }
}
