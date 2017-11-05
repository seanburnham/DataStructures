using System;
using System.Collections.Generic;
using System.Reflection;
using System.Web.Script.Serialization;
using System.Linq;

namespace reflection
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //person 1
            Date fd1 = new Date(1962, 8, 1);
            Franchise f1 = new Franchise("Spiderman", "Marvel", fd1);
            Date b1 = new Date(2011, 2, 3);
            Person p1 = new Person("Peter \"Spidey\" Parker", 'M', b1, false, 15000.00, 1967, null, null, f1);

            //person 2
            Date fd2 = new Date(1962, 8, 1);
            Franchise f2 = new Franchise("Superman", "DC\\Comics", fd2);
            Date b2 = new Date(2014, 5, 6);
            Person p2 = new Person("Lois Lane", 'F', b2, true, 40000.50, 1981, null, null, f2);

            //person 3
            Date fd3 = new Date(1963, 1, 1);
            Franchise f3 = new Franchise("Doctor Who", "BBC", fd3);
            Date b3 = new Date(2017, 8, 9);
            Person p3 = new Person("River Song/Melody Pond", 'F', b3, true, 91234.56, 2001, p1, p2, f3);

            string output = new to_json().getJson(p3);

            Console.WriteLine(output);
        }

    }

    public class Date
    {
        //A date for a person
        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;

        }

        public int year
        {
            get;
            set;
        }

        public int month
        {
            get;
            set;
        }

        public int day
        {
            get;
            set;
        }
    }

    public class Franchise
    {
        //A franchise.
        public Franchise(string name, string owner, Date started)
        {
            this.name = name;
            this.owner = owner;
            this.started = started;
        }

        public string name
        {
            get;
            set;
        }

        public string owner
        {
            get;
            set;
        }

        public Date started
        {
            get;
            set;
        }

    }

    public class Person
    {

        //A person
        public Person(string name, char gender, Date birth_date, bool is_cool, double net_worth, int debut_year, Person father, Person mother, Franchise franchise)
        {
            this.name = name;
            this.gender = gender;
            this.birth_date = birth_date;
            this.is_cool = is_cool;
            this.net_worth = net_worth;
            this.debut_year = debut_year;
            this.father = father;
            this.mother = mother;
            this.franchise = franchise;
        }

        public string name
        {
            get;
            set;
        }

        public char gender
        {
            get;
            set;
        }

        public Date birth_date
        {
            get;
            set;
        }

        public bool is_cool
        {
            get;
            set;
        }

        public double net_worth
        {
            get;
            set;
        }

        public int debut_year
        {
            get;
            set;
        }

        public Person father
        {
            get;
            set;
        }

        public Person mother
        {
            get;
            set;
        }

        public Franchise franchise
        {
            get;
            set;
        }

    }
}
