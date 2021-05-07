﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBookChain
{
    public class PhoneBookGrid
    {
        // стандартный конструктор без параметров
        public PhoneBookGrid()
        { }
        public PhoneBookGrid(string email, string lastName, string firstName, string middleName, string gender, DateTime yearOfBirth, string streetName, string buildNum, string flatNum, string phoneNum, string isMobile)
        {
            Email = email;
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            Gender = gender;
            YearOfBirth = yearOfBirth;
            StreetName = streetName;
            BuildNum = buildNum;
            FlatNum = flatNum;
            PhoneNum = phoneNum;
            IsMobile = isMobile;
        }

        public string Email { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        public DateTime YearOfBirth { get; set; }
        public string StreetName { get; set; }
        public string BuildNum { get; set; }
        public string FlatNum { get; set; }
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
        { }

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
        public Credentials() { }

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
        public Address() { }
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
        public PhoneInfo() { }
        public PhoneInfo(string phoneNum, string isMobile)
        {
            PhoneNum = phoneNum;
            IsMobile = isMobile;
        }

        public string PhoneNum { get; set; }
        public string IsMobile { get; set; }

    }
}
