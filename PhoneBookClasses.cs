using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.ComponentModel;

namespace PhoneBookChain
{
    //static class Data
    //{
    //    public static string Value { get; set; }
    //}
    public class PhoneBookGrid
    {
        // стандартный конструктор без параметров
        public PhoneBookGrid()
        {
        
        }
        public PhoneBookGrid(string email,  string firstName,string lastName, string middleName, string gender,
            string yearOfBirth, string address, string phoneNum, string isMobile)
        {
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Gender = gender;
            YearOfBirth = yearOfBirth;
            Address = address;
            PhoneNum = phoneNum;
            IsMobile = isMobile;
        }

        public string Email { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        //public DateTime YearOfBirth { get; set; }
        public string YearOfBirth { get; set; }
        public string Address { get; set; }
        //public string BuildNum { get; set; }
        //public string FlatNum { get; set; }
        public string PhoneNum { get; set; }
        public string IsMobile { get; set; }

    }
    [Serializable]
    public class PhoneBook
    {
        public string Email { get; set; }
        public Credentials Credentials { get; set; }
        public Address Address { get; set; }
        public PhoneInfo PhoneInfo { get; set; }


        // стандартный конструктор без параметров
        public PhoneBook()
        {
            Email = "@";
            Credentials = new Credentials();
            Address = new Address();
            PhoneInfo = new PhoneInfo();
        }

        public PhoneBook(string email, Credentials credentials, Address address, PhoneInfo phoneInfo)
        {
            Email = email;
            Credentials = credentials;
            Address = address;
            PhoneInfo = phoneInfo;
        }

    }

    public class Credentials
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }

        public DateTime YearOfBirth { get; set; }

        // стандартный конструктор без параметров
        public Credentials() 
        {
            FirstName = "Имя";
            LastName = "Фамилия";
            MiddleName = "Отчество";
            Gender = "Пол";
            YearOfBirth = DateTime.Now;
        }

        public Credentials(string firstName, string lastName, string middleName, string gender, DateTime yearOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Gender = gender;
            YearOfBirth = yearOfBirth;
        }

    }
    public class Address
    {
        public string StreetName { get; set; }
        public string BuildNum { get; set; }
        public string FlatNum { get; set; }
        // стандартный конструктор без параметров
        public Address() 
        {
            StreetName = "Улица";
            BuildNum = "1";
            FlatNum = "2";
        }
        public Address(string streetName, string buildNum, string flatNum)
        {
            StreetName = streetName;
            BuildNum = buildNum;
            FlatNum = flatNum;
        }

    }
    public class PhoneInfo
    {
        // стандартный конструктор без параметров
        public PhoneInfo() 
        {
            PhoneNum = "(000)0000000";
            IsMobile = "Моб.";
        }
        public PhoneInfo(string phoneNum, string isMobile)
        {
            PhoneNum = phoneNum;
            IsMobile = isMobile;
        }

        public string PhoneNum { get; set; }
        public string IsMobile { get; set; }

    }
}
