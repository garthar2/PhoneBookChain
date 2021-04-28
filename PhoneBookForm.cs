using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Serialization;



namespace PhoneBookChain
{
    public partial class PhoneBookForm : Form
    {
        //  https://www.youtube.com/watch?v=6uSWzKMgbzs
        public static string datafile = null; //путь к файлу base.xml
        public static bool unsaved = false;
        public static string config = null;
        public static System.Collections.ArrayList database = new System.Collections.ArrayList();
        //public static string[] elements = { "name", "phone1", "phone2", "phone3", "mail", "organisation", "departament", "section", "position" };
        public BindingList<PhoneBook> PhoneBookList { get; set; } = new BindingList<PhoneBook>();
        public PhoneBookForm()
        {
            InitializeComponent();
            phoneBookListBindingSource.DataSource = PhoneBookList;
            config = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\phonebook.cfg";
            if (File.Exists(config))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(config);
                XmlNode node = doc.DocumentElement.SelectSingleNode("/config/basefile");

                if (node != null)
                {
                    datafile = node.InnerText;
                }

                node = doc.DocumentElement.SelectSingleNode("/config/local");
                if (node != null && node.InnerText.ToLower() == "true")
                {
                    //local_version = true;
                    MessageBox.Show("!");
                }
            }
            // объект для сериализации
            PhoneBook phoneBook = new PhoneBook("Филип", "Дачев", "Бедросович", "Мужск.", new DateTime(1967, 12, 12),
                                             "Ленина", "10", "5", "3242342", "Мобил.", "asd@sdfs.com");
            Console.WriteLine("Объект создан");

            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(PhoneBook));

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("base.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, phoneBook);

                Console.WriteLine("Объект сериализован");
            }

            // десериализация
            using (FileStream fs = new FileStream("base.xml", FileMode.OpenOrCreate))
            {
                PhoneBook newphoneBook = (PhoneBook)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
                int dob = int.Parse(newphoneBook.YearOfBirth.ToString("yyyyMMdd"));
                int age = (now - dob) / 10000;
                Console.WriteLine($"Имя: {newphoneBook.FirstName} --- Возраст: {age}");
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            AddPhoneBookForm form2 = new AddPhoneBookForm(PhoneBookList);
            form2.ShowDialog();
        }
    }
}
