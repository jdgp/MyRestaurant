using Microsoft.AspNetCore.Mvc;
using Sales.Backend.Application.UseCase.UnitsOfWork;
using Sales.Backend.Domain.Entities;

namespace Sales.Backend.Infrastructure.Http.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : GenericController<Product>
    {
        public ProductsController(IGenericUnitOfWork<Product> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
