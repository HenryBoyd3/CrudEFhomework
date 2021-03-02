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
    public partial class Form1 : Form
    {
        SalesContext stx = new DataLayer.SalesContext();
        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userView.DataSource = stx.Customers.Where(c => c.LastName == searchBox.Text.ToString())
                .Select(a => new { a.FirstName, a.LastName, a.City, a.Country, a.Phone }).ToList();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (radioName.Checked)
            { userView.DataSource = stx.Customers.Where(c => c.LastName == filterBox.Text.ToString()).
                    Select(a => new { a.FirstName, a.LastName, a.City, a.Country, a.Phone }).ToList(); }
            else if (radioCity.Checked)
            { userView.DataSource = stx.Customers.Where(c => c.City == filterBox.Text.ToString()).
                    Select(a => new { a.FirstName, a.LastName, a.City, a.Country, a.Phone }).ToList(); }
            else if (radioLetter.Checked&& filterBox.TextLength > 0)
            { userView.DataSource = stx.Customers.Where(c => c.LastName.StartsWith(filterBox.Text.First().
                ToString())).Select(a => new { a.FirstName, a.LastName, a.City, a.Country, a.Phone }).ToList(); }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddUser ad = new AddUser(userView);
            ad.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int userID=0;
            if (userView.Rows.Count > 0)
            {
                userView.Rows[userView.CurrentCell.RowIndex].Selected = true;
                if (userView.SelectedRows[0].Cells[0].Value != DBNull.Value)
                {
                    userID = (Int32)userView.SelectedRows[0].Cells[0].Value;
                }
                var newUser = stx.Customers.First(c => c.Id == userID);
                var thisUser = userView.SelectedRows;
                foreach (DataGridViewRow cell in thisUser)
                {
                    if (string.IsNullOrEmpty(cell.Cells[1].Value.ToString())) { MessageBox.Show("enter a first Name"); }
                    else { newUser.FirstName = cell.Cells[1].Value.ToString(); }
                    if (string.IsNullOrEmpty(cell.Cells[2].Value.ToString())) { MessageBox.Show("enter a last Name"); }
                    else { newUser.LastName = cell.Cells[2].Value.ToString(); }
                    if (string.IsNullOrEmpty(cell.Cells[3].Value.ToString())) { newUser.City = null; }
                    else { newUser.City = cell.Cells[3].Value.ToString(); }
                    if (string.IsNullOrEmpty(cell.Cells[4].Value.ToString())) { newUser.Country = null; }
                    else { newUser.Country = cell.Cells[4].Value.ToString(); }
                    if (string.IsNullOrEmpty(cell.Cells[5].Value.ToString())) { newUser.Phone = null; }
                    else { newUser.Phone = cell.Cells[5].Value.ToString(); }
                }
                stx.SaveChanges();
                getUsers();
            }
            else
            {
                MessageBox.Show("to update a row please search then select a row");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(searchBox.TextLength >0)
            { 
                int userID=0;
                userView.Rows[userView.CurrentCell.RowIndex].Selected = true;
                if (userView.SelectedRows[0].Cells[0].Value != DBNull.Value)
                    {
                        userID = (Int32)userView.SelectedRows[0].Cells[0].Value;
                    }
                stx.Remove(stx.Customers.Single(u => u.Id == userID));
                stx.SaveChanges();
                getUsers();
            }
            else
            { 
                MessageBox.Show("to delete a user please search then select a row"); 
            }
                
        }
        private void getUsers()
        {
            userView.DataSource = stx.Customers.OrderBy(c => c.Id).Select(a => new {a.FirstName, a.LastName, a.City, a.Country,a.Phone }).ToList();
        }

    }
}
