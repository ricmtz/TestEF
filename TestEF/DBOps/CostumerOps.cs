using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEF.DBOps
{
    // CRUD: Create, Read, Update, Delete
    public class CostumerOps
    {
        private NorthwindEntities entities = new NorthwindEntities();

        public void CreateCustomers(Customer customer)
        {
            entities.Customers.Add(customer);
            entities.SaveChanges();
        }

        public List<Customer> GetCustomers()
        {
            return entities.Customers.ToList();
        }

        public Customer GetCustomerById(string id)
        {
            return entities.Customers.FirstOrDefault(c=> c.CustomerID == id);
        }

        public void UpdateCustomer(string id, string companyName)
        {
            var customer = GetCustomerById(id);
            if(customer != null)
            {
                customer.CompanyName = companyName;
                entities.SaveChanges();
            }
        }

        public void UpdateCustomer(Customer customer)
        {
            var originCustumer = GetCustomerById(customer.CustomerID);
            if(originCustumer != null)
            {
                originCustumer.Address = customer.Address;
                originCustumer.City = customer.City;
                originCustumer.CompanyName = customer.CompanyName;
                originCustumer.ContactName = customer.ContactName;
                originCustumer.ContactTitle = customer.ContactTitle;
                originCustumer.Country = customer.Country;
                originCustumer.Fax = customer.Fax;
                originCustumer.Phone = customer.Phone;
                originCustumer.PostalCode = customer.PostalCode;
                originCustumer.Region = customer.Region;
                entities.SaveChanges();
            }
        }

        public void DeleteCustumer(string id)
        {
            var customer = GetCustomerById(id);
            if(customer != null) {
                entities.Customers.Remove(customer);
                entities.SaveChanges();
            }
        }
    }
}
