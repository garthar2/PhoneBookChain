
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
            this.cancelAddAdrbutton = new System.Windows.Forms.Button();
            this.saveAddAdrbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelAddAdrbutton
            // 
            this.cancelAddAdrbutton.Location = new System.Drawing.Point(164, 388);
            this.cancelAddAdrbutton.Name = "cancelAddAdrbutton";
            this.cancelAddAdrbutton.Size = new System.Drawing.Size(97, 32);
            this.cancelAddAdrbutton.TabIndex = 48;
            this.cancelAddAdrbutton.Text = "Отменить";
            this.cancelAddAdrbutton.UseVisualStyleBackColor = true;
            this.cancelAddAdrbutton.Click += new System.EventHandler(this.cancelAddAdrbutton_Click);
            // 
            // saveAddAdrbutton
            // 
            this.saveAddAdrbutton.Location = new System.Drawing.Point(41, 388);
            this.saveAddAdrbutton.Name = "saveAddAdrbutton";
            this.saveAddAdrbutton.Size = new System.Drawing.Size(97, 32);
            this.saveAddAdrbutton.TabIndex = 47;
            this.saveAddAdrbutton.Text = "Сохранить";
            this.saveAddAdrbutton.UseVisualStyleBackColor = true;
            this.saveAddAdrbutton.Click += new System.EventHandler(this.saveAddAdrbutton_Click);
            // 
            // AddRowAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelAddAdrbutton);
            this.Controls.Add(this.saveAddAdrbutton);
            this.Name = "AddRowAddressForm";
            this.Text = "Добавление в список адресов";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelAddAdrbutton;
        private System.Windows.Forms.Button saveAddAdrbutton;
    }
}