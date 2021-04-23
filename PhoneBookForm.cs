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
    public partial class PhoneBookForm : Form
    {
        //  https://www.youtube.com/watch?v=6uSWzKMgbzs
        public BindingList<PhoneBook> PhoneBookList { get; set; } = new BindingList<PhoneBook>();
        public PhoneBookForm()
        {
            InitializeComponent();
            phoneBookListBindingSource.DataSource = PhoneBookList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPhoneBookForm form2 = new AddPhoneBookForm(PhoneBookList);
            form2.ShowDialog();
        }
    }
}
