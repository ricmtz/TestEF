using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEF
{
    class ProductOps
    {
        private NorthwindEntities entities = new NorthwindEntities();

        public void CreateProduc(Product product)
        {
            entities.Products.Add(product);
            entities.SaveChanges();
        }

        public List<Product> GetProducts()
        {
            return entities.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return entities.Products.FirstOrDefault(p => p.CategoryID == id);
        }

        public void UpdateProduct(Product product)
        {
            var originProduct = GetProductById((int)product.CategoryID);
            if(originProduct  != null)
            {
                originProduct.ProductName = product.ProductName;
                originProduct.SupplierID = product.ProductID;
                originProduct.CategoryID = product.CategoryID;
                originProduct.QuantityPerUnit = product.QuantityPerUnit;
                originProduct.UnitPrice = product.UnitPrice;
                originProduct.UnitsInStock = product.UnitsInStock;
                originProduct.UnitsOnOrder = product.UnitsOnOrder;
                originProduct.ReorderLevel = product.ReorderLevel;
                originProduct.Discontinued = product.Discontinued;
                entities.SaveChanges();
            }
        }

        public void DeleteProduct(int id)
        {
            var product = GetProductById(id);
            if(product != null)
            {
                entities.Products.Remove(product);
                entities.SaveChanges();
            }
        }
    }
}
