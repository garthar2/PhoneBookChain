using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PhoneBookChain
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //PhoneInfo[] phoneBookDataBase = new PhoneInfo[]
            //{
            //        //new Credentials ( "Колян", "Петров", "Иванович",true,new DateTime(1945,10,6) ),
            //        //new Credentials ("Васян", "Дачев","Бедросович",false, new DateTime(1967,12,12)),
            //new PhoneInfo ("Васян", "Дачев","Бедросович",false, new DateTime(1967,12,12), "Ленина", "10","5", "3242342", false),
            //        //new Address ("Гаражная", "2","105"),
            //        //new PhoneInfo("4096583",false),
            //        //new PhoneInfo("0679146592",true)
            //};
            //Credentials[][] jaggArr = new Credentials[][]
            //    {
            //        new Credentials ( "Колян", "Петров", "Иванович",true,new DateTime(1945,10,6) )
            //    };
            //jaggArr[0] = new Credentials ("Колян", "Петров", "Иванович", true, new DateTime(1945, 10, 6));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
