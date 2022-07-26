using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using amazen.Models;
using amazen.Repositories;

namespace amazen.Services
{
    public class ProductsService
    {

    private readonly ProductsRepository _repo;

        public ProductsService(ProductsRepository repo)
        {
            _repo = repo;
        }

        internal List<Product> GetAll()
        {
            return _repo.GetAll();
        }
        internal Product Create(Product newProduct)
        {
            return _repo.Create(newProduct);
        }

    }
}