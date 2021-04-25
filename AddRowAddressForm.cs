using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhoneBookChain
{
    public partial class AddRowAddressForm : Form
    {
        string gender = ""; //никогда это значение
        public BindingList<Address> AddressList { get; set; }
        public AddRowAddressForm()
        {
            InitializeComponent();
        }
        public AddRowAddressForm(BindingList<Address> addressList)
        {
            AddressList = addressList;
            InitializeComponent();
        }

        private void saveAddAdrbutton_Click(object sender, EventArgs e)
        {
            //if ((streetName == "") || (lastNameTextBox.Text == ""))
            //{
            //    MessageBox.Show("Имя и фамилия не должны быть пустыми!");
            //}
            //else
            //{
            //    AddressList.Add(new Address(streetNameTextBox.Text));
            //}
            this.Close();
        }

        private void cancelAddAdrbutton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
