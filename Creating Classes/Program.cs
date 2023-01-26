using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Creating_Classes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person p2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person p3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person p4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            Console.WriteLine(p2.DisplayPersonInfo());

            Console.WriteLine(p3.ToString());

            p1.ChangeFavoriteColour("White");
            Console.WriteLine($"{p1.name}'s favourite colour is: {p1.favoriteColour}");

            Console.WriteLine(p4.GetAgeInTenYears());

            Relation r1 = new Relation(p2, 1, p4);
            Console.WriteLine(r1.ShowRelationship());

            Relation r2 = new Relation(p1, 2, p3);
            Console.WriteLine(r2.ShowRelationship());

            List<Person> personList = new List<Person> { p1, p2, p3, p4 };

            Console.WriteLine($"Average age is: {avgAge(personList)}");
            Console.WriteLine($"Youngest person is: {youngest(personList).firstName}");
            Console.WriteLine($"Oldest person is: {oldest(personList).firstName}");
            foreach (var p in startingWith(personList, 'M'))
            {
                Console.WriteLine(p.Details());
            }
            foreach (var p in likesColour(personList, "Blue"))
            {
                Console.WriteLine(p.Details());
            }

        }
        public static float avgAge(List<Person> people)
        {
            float sum = 0;
            int size = people.Count;

            foreach (var p in people)
            {
                sum += p.age;
            }   
            return sum / size;
        }

        public static Person youngest(List<Person> people)
        {
            Person y = people.First();

            foreach (var p in people)
            {
                if (p.age < y.age)
                {
                    y = p;
                }
            }
            return y;
        }


        public static Person oldest(List<Person> people)
        {
            Person o = people.First();

            foreach (var p in people)
            {
                if (p.age > o.age)
                {
                    o = p;
                }
            }
            return o;
        }

        public static List<Person> startingWith(List<Person> people, char initial)
        {
            List<Person> output = new List<Person>();

            foreach (var p in people)
            {
                if (p.firstName[0] == initial)
                {
                    output.Add(p);
                }
            }
            return output;

        }

        public static List<Person> likesColour(List<Person> people, string colour)
        {
            List<Person> output = new List<Person>();

            foreach (var p in people)
            {
                if (p.favoriteColour == colour)
                {
                    output.Add(p);
                }
            }
            return output;

        }
    }
}
