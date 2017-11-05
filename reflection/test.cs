using System;
using reflection;

namespace tests
{
    public class test
    {

        public static void Main(string[] args)
        {

            //person 1
            Date fd1 = new Date(1992, 10, 13);
            Person p1 = new Person(null, ' ', null, true, 12.21, 12, null, null, null);

            //person 2
            Date b2 = new Date(2015, 9, 21);
            Person p2 = new Person("Melissa", 'F', b2, false, 1.50, 1995, p1, p1, null);

            //person 3
            Person p3 = new Person("Mack", 'M', b2, true, 1234.56, 2015, p1, p2, null);


            string output = new to_json().getJson(p3);

            Console.WriteLine(output);
        }

        public test()
        {
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
}
