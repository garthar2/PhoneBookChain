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
    public partial class Form3 : Form
    {
        public BindingList<Credentials> CredentialsList { get; set; } = new BindingList<Credentials>();
        public Form3()
        {
            
            InitializeComponent();
            credentialsListBindingSource.DataSource = CredentialsList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(CredentialsList);
            form6.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //редактировать
            //credentialsListDataGridView.SelectedRows
            //DataGridView1
        //    credentialsListDataGridView.
        }
        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    dataGridView1.CurrentCell.Value = textBox1.Text;
        //}
    }
}
