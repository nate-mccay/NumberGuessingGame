using System;
using System.Collections.Generic;

namespace TrueCoders1
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new People();
            people.FirstName = "Nate";
            var firstname = people.FirstName;
            people.LastName = "McCay";
            var LastName = people.LastName;
            people.Age = 21;
            var age = people.Age;
            people.HairColor = "brown";
            var haircolor = people.HairColor;

            var people2 = new People();
            people2.FirstName = "James";
            var FirstName2 = people2.FirstName;
            people2.LastName = "Tisdale";
            var LastName2 = people2.LastName;
            people2.Age = 30;
            var Age2 = people2.Age;
            people2.HairColor = "blonde";
            var HairColor2 = people2.HairColor;

            var people3 = new People();
            people3.FirstName = "Somebody";
            var FirstName3 = people3.FirstName;
            people3.LastName = "Else";
            var LastName3 = people3.LastName;
            people3.Age = 2000;
            var Age3 = people3.Age;
            people3.HairColor = "something";
            var HairColor3 = people3.HairColor;

            var myList = new List<People>();
            myList.Add(people);
            myList.Add(people2);
            myList.Add(people3);

            foreach(var person in myList)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} Age:{person.Age} Hair Color:{person.HairColor}");
            }
        }
    }
}
