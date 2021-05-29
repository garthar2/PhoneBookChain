
namespace PhoneBookChain
{
    partial class AddRowAddressForm
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
            System.Windows.Forms.Label buildNumLabel;
            System.Windows.Forms.Label flatNumLabel;
            System.Windows.Forms.Label streetNameLabel;
            this.cancelAddAdrbutton = new System.Windows.Forms.Button();
            this.saveAddAdrbutton = new System.Windows.Forms.Button();
            this.buildNumTextBox = new System.Windows.Forms.TextBox();
            this.flatNumTextBox = new System.Windows.Forms.TextBox();
            this.streetNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneBookListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            buildNumLabel = new System.Windows.Forms.Label();
            flatNumLabel = new System.Windows.Forms.Label();
            streetNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buildNumLabel
            // 
            buildNumLabel.AutoSize = true;
            buildNumLabel.Location = new System.Drawing.Point(53, 43);
            buildNumLabel.Name = "buildNumLabel";
            buildNumLabel.Size = new System.Drawing.Size(88, 17);
            buildNumLabel.TabIndex = 49;
            buildNumLabel.Text = "Номер дома";
            // 
            // flatNumLabel
            // 
            flatNumLabel.AutoSize = true;
            flatNumLabel.Location = new System.Drawing.Point(23, 71);
            flatNumLabel.Name = "flatNumLabel";
            flatNumLabel.Size = new System.Drawing.Size(118, 17);
            flatNumLabel.TabIndex = 51;
            flatNumLabel.Text = "Номер квартиры";
            // 
            // streetNameLabel
            // 
            streetNameLabel.AutoSize = true;
            streetNameLabel.Location = new System.Drawing.Point(24, 15);
            streetNameLabel.Name = "streetNameLabel";
            streetNameLabel.Size = new System.Drawing.Size(117, 17);
            streetNameLabel.TabIndex = 53;
            streetNameLabel.Text = "Название улицы";
            streetNameLabel.UseWaitCursor = true;
            // 
            // cancelAddAdrbutton
            // 
            this.cancelAddAdrbutton.Location = new System.Drawing.Point(319, 118);
            this.cancelAddAdrbutton.Name = "cancelAddAdrbutton";
            this.cancelAddAdrbutton.Size = new System.Drawing.Size(97, 32);
            this.cancelAddAdrbutton.TabIndex = 51;
            this.cancelAddAdrbutton.Text = "Отменить";
            this.cancelAddAdrbutton.UseVisualStyleBackColor = true;
            this.cancelAddAdrbutton.Click += new System.EventHandler(this.CancelAddAdrbutton_Click);
            // 
            // saveAddAdrbutton
            // 
            this.saveAddAdrbutton.Location = new System.Drawing.Point(147, 118);
            this.saveAddAdrbutton.Name = "saveAddAdrbutton";
            this.saveAddAdrbutton.Size = new System.Drawing.Size(97, 32);
            this.saveAddAdrbutton.TabIndex = 50;
            this.saveAddAdrbutton.Text = "Сохранить";
            this.saveAddAdrbutton.UseVisualStyleBackColor = true;
            this.saveAddAdrbutton.Click += new System.EventHandler(this.SaveAddAdrbutton_Click);
            // 
            // buildNumTextBox
            // 
            this.buildNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookListBindingSource, "Address.BuildNum", true));
            this.buildNumTextBox.Location = new System.Drawing.Point(147, 40);
            this.buildNumTextBox.Name = "buildNumTextBox";
            this.buildNumTextBox.Size = new System.Drawing.Size(269, 22);
            this.buildNumTextBox.TabIndex = 48;
            // 
            // flatNumTextBox
            // 
            this.flatNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookListBindingSource, "Address.FlatNum", true));
            this.flatNumTextBox.Location = new System.Drawing.Point(147, 68);
            this.flatNumTextBox.Name = "flatNumTextBox";
            this.flatNumTextBox.Size = new System.Drawing.Size(269, 22);
            this.flatNumTextBox.TabIndex = 49;
            // 
            // streetNameTextBox
            // 
            this.streetNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookListBindingSource, "Address.StreetName", true));
            this.streetNameTextBox.Location = new System.Drawing.Point(147, 12);
            this.streetNameTextBox.Name = "streetNameTextBox";
            this.streetNameTextBox.Size = new System.Drawing.Size(269, 22);
            this.streetNameTextBox.TabIndex = 47;
            // 
            // phoneBookListBindingSource
            // 
            this.phoneBookListBindingSource.DataSource = typeof(PhoneBookChain.PhoneBook);
            // 
            // AddRowAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 166);
            this.Controls.Add(buildNumLabel);
            this.Controls.Add(this.buildNumTextBox);
            this.Controls.Add(flatNumLabel);
            this.Controls.Add(this.flatNumTextBox);
            this.Controls.Add(streetNameLabel);
            this.Controls.Add(this.streetNameTextBox);
            this.Controls.Add(this.cancelAddAdrbutton);
            this.Controls.Add(this.saveAddAdrbutton);
            this.Name = "AddRowAddressForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление адреса";
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelAddAdrbutton;
        private System.Windows.Forms.Button saveAddAdrbutton;
        private System.Windows.Forms.BindingSource phoneBookListBindingSource;
        private System.Windows.Forms.TextBox buildNumTextBox;
        private System.Windows.Forms.TextBox flatNumTextBox;
        private System.Windows.Forms.TextBox streetNameTextBox;
    }
}