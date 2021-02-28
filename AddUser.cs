using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace CrudEFhomework
{
    public partial class AddUser : Form
    {
        DataGridView userData;
        public AddUser(DataGridView userdata)
        {
            InitializeComponent();
            userData = userdata;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNbox.Text.ToString()) || string.IsNullOrEmpty(lastNBox.Text.ToString()))
                MessageBox.Show("Enter a First and Last name to continue.");
            else
            {
                string city = null, country = null, phone = null;
                if (string.IsNullOrEmpty(cityBox.Text.ToString())) { city = null; }
                else { city = cityBox.Text.ToString(); }
                if (string.IsNullOrEmpty(countryBox.Text.ToString())) { country = null; }
                else { country = countryBox.Text.ToString(); }
                if (string.IsNullOrEmpty(phoneBox.Text.ToString())) { phone = null; }
                else { phone = phoneBox.Text.ToString();  }
                SalesContext stx = new SalesContext();
                var newUser = new Customer
                {
                    FirstName = firstNbox.Text.ToString(),
                    LastName = lastNBox.Text.ToString(),
                    City = city,
                    Country = country,
                    Phone = phone
                };
                stx.Add<Customer>(newUser);
                stx.SaveChanges();
                userData.DataSource = stx.Customers.OrderBy(c => c.Id).Select(a => new { a.FirstName, a.LastName, a.City, a.Country, a.Phone }).ToList();
                this.Close();
            }
        }
    }
}
