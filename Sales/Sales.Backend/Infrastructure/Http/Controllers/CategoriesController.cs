using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using Sales.Backend.Infrastructure.Data;
using Sales.Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Sales.Backend.Application.UseCase.UnitsOfWork;

namespace Sales.Backend.Infrastructure.Http.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : GenericController<Category>
    {
        public CategoriesController(IGenericUnitOfWork<Category> unitOfWork) : base(unitOfWork)
        {
        }
    }
}