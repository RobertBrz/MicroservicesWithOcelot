using CatalogService.Database;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CatalogController : ControllerBase
    {
        DatabaseContext _db;

        public CatalogController(DatabaseContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IEnumerable<Product> GetProductes()
        {
            return _db.Products.ToList();
        }
    }
}
