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
            //добавить
            Form6 CreateCredentials = new Form6(CredentialsList);
            CreateCredentials.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //редактировать
            MessageBox.Show("Выбрано строк:"+ credentialsListDataGridView.SelectedRows.Count);
            //DataGridView1
            //    credentialsListDataGridView.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //удалить строку

                if (this.credentialsListDataGridView.SelectedRows.Count > 0 &&
                    this.credentialsListDataGridView.SelectedRows[0].Index !=
                    this.credentialsListDataGridView.Rows.Count - 1)
                {
                    this.credentialsListDataGridView.Rows.RemoveAt(
                        this.credentialsListDataGridView.SelectedRows[0].Index);
                }
        }
        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    dataGridView1.CurrentCell.Value = textBox1.Text;
        //}
    }
}
