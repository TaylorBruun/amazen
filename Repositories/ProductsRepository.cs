using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using amazen.Models;
using Dapper;

namespace amazen.Repositories
{
    public class ProductsRepository
    {

        public readonly IDbConnection _db;

        public ProductsRepository(IDbConnection db)
        {
            _db = db;
        }

        public Product Create(Product productData)
        {
            string sql = "INSERT INTO products (upc, price) VALUES (@UPC, @Price); SELECT LAST_INSERT_ID();";
            int id = _db.ExecuteScalar<int>(sql, productData);
            productData.Id = id;
            return productData;
        }

        public List<Product> GetAll()
        {
            string sql = "SELECT * FROM products";
            return _db.Query<Product>(sql).ToList();

        }
    }
}