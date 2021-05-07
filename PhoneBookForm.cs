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
        public static string config = null;//путь к файлу phonebook.cfg
        //public static System.Collections.ArrayList database = new System.Collections.ArrayList();
        //public static string[] elements = { "name", "phone1", "phone2", "phone3", "mail", "organisation", "departament", "section", "position" };
        public BindingList<PhoneBook> PhoneBookList { get; set; } = new BindingList<PhoneBook>();
        public BindingList<PhoneBookGrid> PhoneBookGridList { get; set; } = new BindingList<PhoneBookGrid>();
        public PhoneBookForm()
        {
            InitializeComponent();
            phoneBookListBindingSource.DataSource = PhoneBookList;
            phoneBookGridListBindingSource.DataSource = PhoneBookGridList;
            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(BindingList<PhoneBook>));
            //credentialsListBindingSource.DataSource = CredentialsList;
            config = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\phonebook.cfg";
            datafile = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\base.xml";
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
            if (!(File.Exists(datafile)))
            {
                PhoneBookList.Add(new PhoneBook("dfs1452@gmail.com", new Credentials("Филип", "Дачев", "Бедросович", "Мужск.", new DateTime(1967, 12, 12)),
                new Address("Ленина", "10", "5"), new PhoneInfo("3242342", "Мобил.")));
                // получаем поток, куда будем записывать сериализованный объект
                using (FileStream fs = new FileStream("base.xml", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, PhoneBookList);
                    //fs.Close();
                }
                //PhoneBookList.Clear();
                MessageBox.Show("Файл base.xml не найден, создан новый.");
            }
            // десериализация PhoneBookList
            using (FileStream fs = new FileStream("base.xml", FileMode.Open))
            {
                //BindingList<PhoneBook> PhoneBookList = (BindingList<PhoneBook>)formatter.Deserialize(fs);
                PhoneBookList = (BindingList<PhoneBook>)formatter.Deserialize(fs);
                //fs.Close();

            }
            Console.WriteLine("Объект PhoneBookList десериализован");
            foreach (PhoneBook p in PhoneBookList)
            {
                int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
                int dob = int.Parse(p.Credentials.YearOfBirth.ToString("yyyyMMdd"));
                int age = (now - dob) / 10000;
                Console.WriteLine($"Имя: {p.Credentials.FirstName} --- Возраст: {age}");

            }
            CopyToGrid();

        }

        public void CopyToGrid()
        {
            PhoneBookGridList.Clear();
            foreach (PhoneBook rowPhoneBookList in PhoneBookList)
            {
                PhoneBookGridList.Add(new PhoneBookGrid (rowPhoneBookList.Email, rowPhoneBookList.Credentials.LastName, rowPhoneBookList.Credentials.FirstName,
                    rowPhoneBookList.Credentials.MiddleName, rowPhoneBookList.Credentials.Gender, rowPhoneBookList.Credentials.YearOfBirth,
                    rowPhoneBookList.Address.StreetName, rowPhoneBookList.Address.BuildNum, rowPhoneBookList.Address.FlatNum,
                    rowPhoneBookList.PhoneInfo.PhoneNum, rowPhoneBookList.PhoneInfo.IsMobile));
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddPhoneBookForm form2 = new AddPhoneBookForm(PhoneBookList);
            DialogResult dr = form2.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
               CopyToGrid();
            }
        }

        private void PhoneBookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // передаем в конструктор тип класса
            XmlSerializer writer = new XmlSerializer(typeof(BindingList<PhoneBook>));
            using (FileStream fs = new FileStream("base.xml", FileMode.OpenOrCreate))
            {
                writer.Serialize(fs, PhoneBookList);
                //fs.Close();
            }
        }

        private void saveToFile_Click(object sender, EventArgs e)
        {
            // передаем в конструктор тип класса
            XmlSerializer writer = new XmlSerializer(typeof(BindingList<PhoneBook>));
            using (FileStream fs = new FileStream("base.xml", FileMode.OpenOrCreate))
            {
                writer.Serialize(fs, PhoneBookList);
                //fs.Close();
            }
        }
    }
}
