
namespace PhoneBookChain
{
    partial class AddRowCredForm
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label middleNameLabel;
            System.Windows.Forms.Label yearOfBirthLabel;
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.credentialsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.yearOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            firstNameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            middleNameLabel = new System.Windows.Forms.Label();
            yearOfBirthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.credentialsListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(13, 43);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(35, 17);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "Имя";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(12, 128);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(34, 17);
            genderLabel.TabIndex = 3;
            genderLabel.Text = "Пол";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(12, 9);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(70, 17);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Фамилия";
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Location = new System.Drawing.Point(12, 71);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new System.Drawing.Size(71, 17);
            middleNameLabel.TabIndex = 7;
            middleNameLabel.Text = "Отчество";
            // 
            // yearOfBirthLabel
            // 
            yearOfBirthLabel.AutoSize = true;
            yearOfBirthLabel.Location = new System.Drawing.Point(12, 101);
            yearOfBirthLabel.Name = "yearOfBirthLabel";
            yearOfBirthLabel.Size = new System.Drawing.Size(111, 17);
            yearOfBirthLabel.TabIndex = 9;
            yearOfBirthLabel.Text = "Дата рождения";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.credentialsListBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(161, 40);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(304, 22);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // credentialsListBindingSource
            // 
            this.credentialsListBindingSource.DataSource = typeof(PhoneBookChain.Credentials);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.credentialsListBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(161, 12);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(304, 22);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.credentialsListBindingSource, "MiddleName", true));
            this.middleNameTextBox.Location = new System.Drawing.Point(161, 68);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(304, 22);
            this.middleNameTextBox.TabIndex = 8;
            // 
            // yearOfBirthDateTimePicker
            // 
            this.yearOfBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.credentialsListBindingSource, "YearOfBirth", true));
            this.yearOfBirthDateTimePicker.Location = new System.Drawing.Point(161, 96);
            this.yearOfBirthDateTimePicker.Name = "yearOfBirthDateTimePicker";
            this.yearOfBirthDateTimePicker.Size = new System.Drawing.Size(304, 22);
            this.yearOfBirthDateTimePicker.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(16, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Location = new System.Drawing.Point(138, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Отменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(161, 128);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 21);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Мужск.";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(285, 128);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(76, 21);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.Text = "Женск.";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // AddRowCredForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 225);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(middleNameLabel);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(yearOfBirthLabel);
            this.Controls.Add(this.yearOfBirthDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddRowCredForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление в список людей";
            ((System.ComponentModel.ISupportInitialize)(this.credentialsListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource credentialsListBindingSource;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.DateTimePicker yearOfBirthDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}