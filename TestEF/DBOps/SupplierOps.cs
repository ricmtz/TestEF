using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEF
{
    class SupplierOps
    {
        private NorthwindEntities entities = new NorthwindEntities();

        public bool CreateSupplier(Supplier supplier)
        {
            int result;
            entities.Suppliers.Add(supplier);
            result = entities.SaveChanges();
            return result > 0;
        }

        public List<Supplier> GetSuppliers()
        {
            return entities.Suppliers.ToList();
        }

        public Supplier GetSupplierById(int id)
        {
            return entities.Suppliers.FirstOrDefault(s => s.SupplierID == id);
        }

        public bool UpdateSupplier(Supplier supplier)
        {
            int result = 0;
            var originSupplier = GetSupplierById((int)supplier.SupplierID);
            if(originSupplier != null)
            {
                originSupplier.CompanyName = supplier.CompanyName;
                originSupplier.ContactName = supplier.ContactName;
                originSupplier.ContactTitle = supplier.ContactTitle;
                originSupplier.Address = supplier.Address;
                originSupplier.City = supplier.City;
                originSupplier.Region = supplier.Region;
                originSupplier.PostalCode = supplier.PostalCode;
                originSupplier.Country = supplier.Country;
                originSupplier.Phone = supplier.Phone;
                originSupplier.Fax = supplier.Fax;
                originSupplier.HomePage = supplier.HomePage;
                result = entities.SaveChanges();
            }
            return result > 0;
        }

        public bool DeleteSupplier(int id)
        {
            int result = 0;
            var supplier = GetSupplierById(id);
            if(supplier != null)
            {
                try {
                    foreach (var p in entities.Products.Where(p => p.SupplierID == id)) {
                        foreach (var o in entities.Order_Details.Where(o => o.ProductID == p.ProductID)) {
                            entities.Order_Details.Remove(o);
                        }
                        entities.Products.Remove(p);
                    }
                    entities.Suppliers.Remove(supplier);
                    result = entities.SaveChanges();
                } catch (Exception ex) {
                    result = 0;
                    Console.WriteLine(ex.Message);
                }
            }
            return result > 0;
        }
    }
}
