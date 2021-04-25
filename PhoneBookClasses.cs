using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBookChain
{
    //public class Credentials
    //{
    //    // Определяем поля в базовом классе.
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public string MiddleName { get; set; }
    //    public bool Gender { get; set; }
    //    public DateTime YearOfBirth { get; set; }
    //    // Определяем и реализуем конструктор.
    //    public Credentials(string firstName, string lastName, string middleName, bool gender, DateTime yearOfBirth)
    //    {
    //        FirstName = firstName;
    //        LastName = lastName;
    //        MiddleName = middleName;
    //        Gender = gender;
    //        YearOfBirth = yearOfBirth;
    //    }

    //}
    //public class Address : Credentials
    //{
    //    public string StreetName { get; set; }// Расширяем функционал производного класса добавлением нового поля.
    //    public string BuildNum { get; set; }// Расширяем функционал производного класса добавлением нового поля.
    //    public string FlatNum { get; set; }// Расширяем функционал производного класса добавлением нового поля.
    //    // Определяем конструктор для производного класса.
    //    public Address(string firstName, string lastName, string middleName, bool gender, DateTime yearOfBirth, string streetName, 
    //        string buildNum, string flatNum) : base ( firstName,  lastName,  middleName,  gender, yearOfBirth)
    //    {
    //        FirstName = firstName;
    //        LastName = lastName;
    //        MiddleName = middleName;
    //        Gender = gender;
    //        YearOfBirth = yearOfBirth;
    //        StreetName = streetName;
    //        BuildNum = buildNum;
    //        FlatNum = flatNum;
    //    }

    //}
    //public class PhoneInfo : Address
    //{
    //    public string PhoneNum { get; set; }// Расширяем функционал производного класса добавлением нового поля.
    //    public bool IsMobile { get; set; }// Расширяем функционал производного класса добавлением нового поля.
    //    public string Email { get; set; }// Расширяем функционал производного класса добавлением нового поля.

    //    // Определяем конструктор для производного класса.
    //    public PhoneInfo(string firstName, string lastName, string middleName, bool gender, DateTime yearOfBirth, string streetName,
    //        string buildNum, string flatNum, string phoneNum, bool isMobile, string email) : base(firstName, lastName, 
    //            middleName, gender, yearOfBirth,streetName, buildNum, flatNum)
    //    {
    //        PhoneNum = phoneNum;
    //        IsMobile = isMobile;
    //        Email = email;
    //    }
    //}

    public class Credentials
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        public DateTime YearOfBirth { get; set; }
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
        public Address(string streetName, string buildNum, string flatNum)
        {
            StreetName = streetName;
            BuildNum = buildNum;
            FlatNum = flatNum;
        }

    }
    public class PhoneInfo
    {
        public PhoneInfo(string phoneNum, string isMobile, string email)
        {
            PhoneNum = phoneNum;
            IsMobile = isMobile;
            Email = email;
        }

        public string PhoneNum { get; set; }
        public string IsMobile { get; set; }
        public string Email { get; set; }


    }
    public class PhoneBook
    {
        public PhoneBook(string firstName, string lastName, string middleName, string gender, 
            DateTime yearOfBirth, string streetName, string buildNum, string flatNum, 
            string phoneNum, string isMobile, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Gender = gender;
            YearOfBirth = yearOfBirth;
            StreetName = streetName;
            BuildNum = buildNum;
            FlatNum = flatNum;
            PhoneNum = phoneNum;
            IsMobile = isMobile;
            Email = email;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        public DateTime YearOfBirth { get; set; }
        public string StreetName { get; set; }
        public string BuildNum { get; set; }
        public string FlatNum { get; set; }
        public string PhoneNum { get; set; }
        public string IsMobile { get; set; }
        public string Email { get; set; }

    }
}
