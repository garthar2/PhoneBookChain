
namespace PhoneBookChain
{
    partial class AddCredForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCredForm));
            this.credentialsListDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credentialsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Add_toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Edit_toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.Delete_toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.credentialsListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credentialsListBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // credentialsListDataGridView
            // 
            this.credentialsListDataGridView.AllowUserToAddRows = false;
            this.credentialsListDataGridView.AllowUserToDeleteRows = false;
            this.credentialsListDataGridView.AutoGenerateColumns = false;
            this.credentialsListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.credentialsListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.credentialsListDataGridView.DataSource = this.credentialsListBindingSource;
            this.credentialsListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.credentialsListDataGridView.Location = new System.Drawing.Point(0, 27);
            this.credentialsListDataGridView.Name = "credentialsListDataGridView";
            this.credentialsListDataGridView.ReadOnly = true;
            this.credentialsListDataGridView.RowHeadersWidth = 51;
            this.credentialsListDataGridView.RowTemplate.Height = 24;
            this.credentialsListDataGridView.Size = new System.Drawing.Size(679, 255);
            this.credentialsListDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MiddleName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn4.HeaderText = "Пол";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "YearOfBirth";
            this.dataGridViewTextBoxColumn5.HeaderText = "Год рождения";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // credentialsListBindingSource
            // 
            this.credentialsListBindingSource.DataSource = typeof(PhoneBookChain.Credentials);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_toolStripButton1,
            this.Edit_toolStripButton2,
            this.Delete_toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(679, 27);
            this.toolStrip1.TabIndex = 5;
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
            // Delete_toolStripButton3
            // 
            this.Delete_toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("Delete_toolStripButton3.Image")));
            this.Delete_toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delete_toolStripButton3.Name = "Delete_toolStripButton3";
            this.Delete_toolStripButton3.Size = new System.Drawing.Size(89, 24);
            this.Delete_toolStripButton3.Text = "Удалить";
            this.Delete_toolStripButton3.Click += new System.EventHandler(this.Delete_toolStripButton3_Click);
            // 
            // AddCredForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 282);
            this.Controls.Add(this.credentialsListDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "AddCredForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список людей";
            this.Load += new System.EventHandler(this.AddCredForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.credentialsListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credentialsListBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource credentialsListBindingSource;
        private System.Windows.Forms.DataGridView credentialsListDataGridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Add_toolStripButton1;
        private System.Windows.Forms.ToolStripButton Edit_toolStripButton2;
        private System.Windows.Forms.ToolStripButton Delete_toolStripButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}