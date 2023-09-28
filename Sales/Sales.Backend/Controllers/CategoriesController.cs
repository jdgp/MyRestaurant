using Microsoft.AspNetCore.Mvc;
using Sales.Backend.Data;
using Microsoft.AspNetCore.Mvc;
using Sales.Backend.Data;
using Sales.Shared.Entities;
using Sales.Backend.Interfaces;

namespace Sales.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : GenericController<Category>
    {
        public CategoriesController(IGenericUnitOfWork<Category> unitOfWork, DataContext context) : base(unitOfWork, context)
        {
        }
    }
}