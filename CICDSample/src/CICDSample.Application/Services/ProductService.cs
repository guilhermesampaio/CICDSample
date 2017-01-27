using System;
using CICDSample.Application.Interfaces;
using CICDSample.Domain.Entities;
using CICDSample.Application.ViewModels;

namespace CICDSample.Application.Services
{
    public class ProductService : IProductService
    {
        public BaseResponse Create(Product product)
        {
            BaseResponse response = new BaseResponse();

            if (product.Price <= 0)
                response.Messages.Add("O preço do produto deve ser igual ou maior que 0!");
            
            response.Success = response.Messages.Count == 0;

            return response;
            
        }
    }
}
