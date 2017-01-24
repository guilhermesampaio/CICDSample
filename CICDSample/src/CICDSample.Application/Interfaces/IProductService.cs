using CICDSample.Application.ViewModels;
using CICDSample.Domain.Entities;

namespace CICDSample.Application.Interfaces
{
    public interface IProductService
    {
        BaseResponse Create(Product product);

    }
}
