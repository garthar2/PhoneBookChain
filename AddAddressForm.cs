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

        private readonly Address Address;
        private int rowIndex = 0;

        public Address ResultAddr
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
            AddressList.Add(new Address());
            addressListBindingSource.DataSource = AddressList;
            addressListDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            addressListDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            addressListDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            this.Text = "Добавление в список адресов";
        }
        //public AddAddressForm(Address address, int RowIndex)
        public AddAddressForm(Address address) : this()
        {
            Address = address;
            //int rowIndex = RowIndex;
            //InitializeComponent();
            //AddressList.Add(new Address());
            AddressList[0] = Address;
            //addressListDataGridView.DataSource = AddressList;
            //addressListDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //addressListDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            //addressListDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
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

            if (this.addressListDataGridView.CurrentCell != null)
            {
                AddRowAddressForm EditAddress = new AddRowAddressForm(AddressList, addressListDataGridView.CurrentCell.RowIndex);
                DialogResult dr = EditAddress.ShowDialog();
                if (dr == DialogResult.Cancel)
                {
                }
            }
            //else
            //{
            //    MessageBox.Show("Выберите строку для редактирования.");
            //    //AddRowAddressForm CreateAddress = new AddRowAddressForm(AddressList, addressListDataGridView.CurrentCell.RowIndex);
            //    //DialogResult dr = CreateAddress.ShowDialog();
            //    //if (dr == DialogResult.Cancel)
            //    //{
            //    //    //CopyListToGrid();
            //    //}
            //}

        }

        private void Del_toolStripButton3_Click(object sender, EventArgs e)
        {
            //удалить строку
            if (this.addressListDataGridView.SelectedRows.Count > 0)
            {
                if (this.addressListDataGridView.Rows.Count != 1)
                {
                    AddressList.RemoveAt(addressListDataGridView.SelectedRows[0].Index);
                }
                else
                {
                    MessageBox.Show("Всегда должна быть хоть одна строка...");
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления.");
            }
        }

        private void AddAddressForm_Load(object sender, EventArgs e)
        {
            this.addressListDataGridView.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.addressListDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
        }

        //private void addressListDataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    this.addressListDataGridView.Rows[e.RowIndex].Selected = true;
        //    this.rowIndex = e.RowIndex;
        //    this.addressListDataGridView.CurrentCell = this.addressListDataGridView.Rows[e.RowIndex].Cells[1];
        //    this.contextMenuStrip1.Show(this.addressListDataGridView, e.Location);
        //    contextMenuStrip1.Show(Cursor.Position);
        //}
    }


}
