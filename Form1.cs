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
    public partial class Form1 : Form
    {
        //  https://www.youtube.com/watch?v=6uSWzKMgbzs
        public BindingList<PhoneBook> PhoneBookList { get; set; } = new BindingList<PhoneBook>();
        public Form1()
        {
            InitializeComponent();
            phoneBookListBindingSource.DataSource = PhoneBookList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(PhoneBookList);
            form2.ShowDialog();
        }
    }
}
