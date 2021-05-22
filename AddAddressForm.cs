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
    public partial class AddAddressForm : Form
    {
        public BindingList<Address> AddressList { get; set; } = new BindingList<Address>();

        private Address Address;
        public Address resultAddresss
        {
            get
            {
                //проверка, выбрана строка или ячейка
                if (this.addressListDataGridView.SelectedRows.Count > 0)
                {
                    return AddressList[addressListDataGridView.SelectedRows[0].Index];
                }
                else
                {
                    return AddressList[addressListDataGridView.CurrentCell.RowIndex];
                }
            }
        }
        public AddAddressForm()
        {
            InitializeComponent();
            addressListBindingSource.DataSource = AddressList;
            addressListDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            addressListDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            addressListDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        }
        public AddAddressForm(Address address, int RowIndex)
        {
            Address = address;
            int rowIndex = RowIndex;
            InitializeComponent();
            AddressList.Add(new Address());
            AddressList[0] = Address;
            addressListDataGridView.DataSource = AddressList;
            addressListDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            addressListDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            addressListDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            this.Text = "Редактирование списка адресов";
        }
        private void Add_toolStripButton1_Click(object sender, EventArgs e)
        {
            AddRowAddressForm CreateAddress = new AddRowAddressForm(AddressList);
            CreateAddress.ShowDialog();
        }

        private void Edit_toolStripButton2_Click(object sender, EventArgs e)
        {
            //редактировать
            //MessageBox.Show("Выбрано строк:" + addressListDataGridView.SelectedRows.Count);

            if (this.addressListDataGridView.SelectedRows.Count > 0)
            {
                AddRowAddressForm EditAddress = new AddRowAddressForm(AddressList, addressListDataGridView.SelectedRows[0].Index);
                DialogResult dr = EditAddress.ShowDialog();
                if (dr == DialogResult.Cancel)
                {
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для редактирования.");
                //AddRowAddressForm CreateAddress = new AddRowAddressForm(AddressList, addressListDataGridView.CurrentCell.RowIndex);
                //DialogResult dr = CreateAddress.ShowDialog();
                //if (dr == DialogResult.Cancel)
                //{
                //    //CopyListToGrid();
                //}
            }

        }

        private void Del_toolStripButton3_Click(object sender, EventArgs e)
        {
            //удалить строку
            if (this.addressListDataGridView.SelectedRows.Count > 0)
            {
                AddressList.RemoveAt(addressListDataGridView.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления");
            }
        }
}


}
