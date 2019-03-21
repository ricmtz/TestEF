using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestEF
{
    public partial class Form1 : Form
    {

        private SupplierOps supplierOps;

        public Form1()
        {
            InitializeComponent();
            supplierOps = new SupplierOps();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.gridViewSuppliers.DataSource = supplierOps.GetSuppliers();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.gridViewSuppliers.DataSource = supplierOps.GetSuppliers();
        }

        private void ClearCreateFields()
        {
            txtAddress.Text = "";
            txtCity.Text = "";
            txtCompanyName.Text = "";
            txtContactName.Text = "";
            txtContactTitle.Text = "";
            txtCountry.Text = "";
            txtFax.Text = "";
            txtHomePage.Text = "";
            txtPhone.Text = "";
            txtPostalCode.Text = "";
            txtRegion.Text = "";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string message, caption;
            Supplier supplier = new Supplier() {
                Address = txtAddress.Text,
                City = txtCity.Text.ToString(),
                CompanyName = txtCompanyName.Text,
                ContactName = txtContactName.Text,
                ContactTitle = txtContactTitle.Text,
                Country = txtCountry.Text,
                Fax = txtFax.Text.ToString(),
                HomePage = txtHomePage.Text,
                Phone = txtPhone.Text,
                PostalCode = txtPostalCode.Text,
                Region = txtRegion.Text,
            };
            if (supplierOps.CreateSupplier(supplier)) {
                message = "The item has been added";
                caption = "Item inserted";
                ClearCreateFields();
            } else {
                message = "The item could not be added";
                caption = "An error occurred";
            }
            MessageBox.Show(message, caption, MessageBoxButtons.OK);

        }

        private void btnSearchId_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdSearchUpdate.Text, out int idSupplier)) {
                Supplier supplier = supplierOps.GetSupplierById(idSupplier);
                if(supplier != null)
                {
                    txtUpdateAddress.Text = supplier.Address;
                    txtUpdateCity.Text = supplier.City;
                    txtUpdateCompanyN.Text = supplier.CompanyName;
                    txtUpdateContactN.Text = supplier.ContactName;
                    txtUpdateContactT.Text = supplier.ContactTitle;
                    txtUpdateCountry.Text = supplier.Country;
                    txtUpdateFax.Text = supplier.Fax;
                    txtUpdateHomeP.Text = supplier.HomePage;
                    txtUpdatePhone.Text = supplier.Phone;
                    txtUpdatePostalC.Text = supplier.PostalCode;
                    txtUpdateRegion.Text = supplier.Region;
                } else {
                    ClearUpdateFields();
                    string message = "The item was not found";
                    string caption = "Item not found";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);
                }
            } 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message, caption;
            if(int.TryParse(txtIdDelete.Text, out int idDelete)) {
                if (supplierOps.DeleteSupplier(idDelete)) {
                    message = "The item has been deleted";
                    caption = "Operation success";
                } else {
                    message = "The item could not be deleted";
                    caption = "An error occurred";
                }
                MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
        }

        private void ClearUpdateFields()
        {
            txtUpdateAddress.Text = "";
            txtUpdateCity.Text = "";
            txtUpdateCompanyN.Text = "";
            txtUpdateContactN.Text = "";
            txtUpdateContactT.Text = "";
            txtUpdateCountry.Text = "";
            txtUpdateFax.Text = "";
            txtUpdateHomeP.Text = "";
            txtUpdatePhone.Text = "";
            txtUpdatePostalC.Text = "";
            txtUpdateRegion.Text = "";
            txtIdSearchUpdate.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdSearchUpdate.Text, out int idSupplier)) {
                Supplier supplier = new Supplier {
                    Address = txtUpdateAddress.Text,
                    City = txtUpdateCity.Text,
                    CompanyName = txtUpdateCompanyN.Text,
                    ContactName = txtUpdateContactN.Text,
                    ContactTitle = txtUpdateContactT.Text,
                    Country = txtUpdateCountry.Text,
                    Fax = txtUpdateFax.Text,
                    HomePage = txtUpdateHomeP.Text,
                    Phone = txtUpdatePhone.Text,
                    PostalCode = txtUpdatePostalC.Text,
                    Region = txtUpdateRegion.Text,
                    SupplierID = idSupplier,
                };
                ClearUpdateFields();
                supplierOps.UpdateSupplier(supplier);
            }
        }
    }
}
