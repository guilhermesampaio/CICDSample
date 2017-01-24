using CICDSample.Application.Interfaces;
using CICDSample.Application.Services;
using CICDSample.Domain.Entities;
using Xunit;

namespace CICDSample.Tests
{
    public class ProductTests
    {
        private readonly IProductService _productService;

        public ProductTests()
        {
            _productService = new ProductService();
        }

        [Fact]
        public void Product_CreateProduct_ShouldNotCreateWithoutPrice()
        {
            // Arrange
            var product = new Product() { Id = 1, Name = "Esfiha de Carne", Code = 1, Price = 0M };
            
            // Act
            var response = _productService.Create(product);

            // Assert
            Assert.True(!response.Success);
            Assert.True(response.Messages.GetEnumerator().Current.Contains("O produto deve possuir um preço!"));

        }
    }
}
