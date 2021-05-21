
namespace PhoneBookChain
{
    partial class AddAddressForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAddressForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Add_toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Edit_toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.Del_toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.addressListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressListDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addAddressFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addAddressFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_toolStripButton1,
            this.Edit_toolStripButton2,
            this.Del_toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(433, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Add_toolStripButton1
            // 
            this.Add_toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("Add_toolStripButton1.Image")));
            this.Add_toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Add_toolStripButton1.Name = "Add_toolStripButton1";
            this.Add_toolStripButton1.Size = new System.Drawing.Size(100, 24);
            this.Add_toolStripButton1.Text = "Добавить";
            this.Add_toolStripButton1.Click += new System.EventHandler(this.Add_toolStripButton1_Click);
            // 
            // Edit_toolStripButton2
            // 
            this.Edit_toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("Edit_toolStripButton2.Image")));
            this.Edit_toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_toolStripButton2.Name = "Edit_toolStripButton2";
            this.Edit_toolStripButton2.Size = new System.Drawing.Size(135, 24);
            this.Edit_toolStripButton2.Text = "Редактировать";
            this.Edit_toolStripButton2.Click += new System.EventHandler(this.Edit_toolStripButton2_Click);
            // 
            // Del_toolStripButton3
            // 
            this.Del_toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("Del_toolStripButton3.Image")));
            this.Del_toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Del_toolStripButton3.Name = "Del_toolStripButton3";
            this.Del_toolStripButton3.Size = new System.Drawing.Size(89, 24);
            this.Del_toolStripButton3.Text = "Удалить";
            this.Del_toolStripButton3.Click += new System.EventHandler(this.Del_toolStripButton3_Click);
            // 
            // addressListBindingSource
            // 
            this.addressListBindingSource.DataMember = "AddressList";
            this.addressListBindingSource.DataSource = this.addAddressFormBindingSource;
            // 
            // addressListDataGridView
            // 
            this.addressListDataGridView.AllowUserToAddRows = false;
            this.addressListDataGridView.AllowUserToDeleteRows = false;
            this.addressListDataGridView.AutoGenerateColumns = false;
            this.addressListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addressListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.addressListDataGridView.DataSource = this.addressListBindingSource;
            this.addressListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressListDataGridView.Location = new System.Drawing.Point(0, 27);
            this.addressListDataGridView.Name = "addressListDataGridView";
            this.addressListDataGridView.ReadOnly = true;
            this.addressListDataGridView.RowHeadersWidth = 51;
            this.addressListDataGridView.RowTemplate.Height = 24;
            this.addressListDataGridView.Size = new System.Drawing.Size(433, 423);
            this.addressListDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StreetName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Улица";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BuildNum";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер дома";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FlatNum";
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер квартиры";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // addAddressFormBindingSource
            // 
            this.addAddressFormBindingSource.DataSource = typeof(PhoneBookChain.AddAddressForm);
            // 
            // AddAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.addressListDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "AddAddressForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление в список адресов";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addAddressFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Add_toolStripButton1;
        private System.Windows.Forms.ToolStripButton Edit_toolStripButton2;
        private System.Windows.Forms.ToolStripButton Del_toolStripButton3;
        private System.Windows.Forms.BindingSource addAddressFormBindingSource;
        private System.Windows.Forms.BindingSource addressListBindingSource;
        private System.Windows.Forms.DataGridView addressListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}