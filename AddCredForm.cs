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
    public partial class AddCredForm : Form
    {
        //private BindingList<PhoneBook> PhoneBookList;
        private Credentials Credentials;
        public Credentials resultCredentials
        {
            get
            {
                //проверка, выбрана строка или ячейка
                if (this.credentialsListDataGridView.SelectedRows.Count > 0)
                {
                    return CredentialsList[credentialsListDataGridView.SelectedRows[0].Index];
                }
                else
                {
                    return CredentialsList[credentialsListDataGridView.CurrentCell.RowIndex];
                }
            }
        }

        public BindingList<Credentials> CredentialsList { get; set; } = new BindingList<Credentials>();
        public AddCredForm()
        {
            
            InitializeComponent();
            credentialsListBindingSource.DataSource = CredentialsList;
        }
        public AddCredForm(Credentials credentials, int RowIndex)
        {
            Credentials = credentials;
            int rowIndex = RowIndex;
            InitializeComponent();
            CredentialsList.Add(new Credentials());
            CredentialsList[0] = Credentials;
            credentialsListBindingSource.DataSource = CredentialsList;
            credentialsListDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            credentialsListDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            credentialsListDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        }

         private void Add_toolStripButton1_Click(object sender, EventArgs e)
        {
            //добавить
            AddRowCredForm CreateCredentials = new AddRowCredForm(CredentialsList);
            CreateCredentials.ShowDialog();
        }

        private void Edit_toolStripButton2_Click(object sender, EventArgs e)
        {
            //редактировать
            //MessageBox.Show("Выбрано строк:" + credentialsListDataGridView.SelectedRows.Count);

            if (this.credentialsListDataGridView.SelectedRows.Count > 0)
            {
                AddRowCredForm CreateCredentials = new AddRowCredForm(CredentialsList, credentialsListDataGridView.SelectedRows[0].Index);

                DialogResult dr = CreateCredentials.ShowDialog();
                if (dr == DialogResult.Cancel)
                {
                    //CopyListToGrid();
                }
            }
            else
            {
                AddRowCredForm CreateCredentials = new AddRowCredForm(CredentialsList, credentialsListDataGridView.CurrentCell.RowIndex);
                DialogResult dr = CreateCredentials.ShowDialog();
                if (dr == DialogResult.Cancel)
                {
                    //CopyListToGrid();
                }
            }
        }

        private void Delete_toolStripButton3_Click(object sender, EventArgs e)
        {
            //удалить строку
            if (this.credentialsListDataGridView.SelectedRows.Count > 0)
            {
                //MessageBox.Show("Индекс строки: " + credentialsListDataGridView.SelectedRows[0].Index);
                CredentialsList.RemoveAt(credentialsListDataGridView.SelectedRows[0].Index);

            }
            else
            {
                MessageBox.Show("Выберите строку для удаления");
            }

        }

    }
}
