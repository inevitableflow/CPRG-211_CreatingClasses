using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_Classes
{
    public class Person
    {
        public Person(int personID, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
        {
            this.personID = personID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteColour = favoriteColour;
            this.age = age;
            this.isWorking = isWorking;
        }

        public int personID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string favoriteColour { get; set; }
        public int age { get; set; }
        public bool isWorking { get; set; }

        public string name 
        { 
            get
                {
                    return firstName + " " + lastName;
                }
        }
     
        public string DisplayPersonInfo()
        {
            return (personID + ": " + name + "'s favourite colour is " + favoriteColour);
        }

        public void ChangeFavoriteColour(string colour)
        {
            this.favoriteColour = colour;
        }

        public string GetAgeInTenYears()
        {
            int ageInTen = this.age + 10;

            string s = this.name + "'s Age in 10 years will be: " + ageInTen;
            return s;

        }

        public override string ToString()
        {
            string s = $"{personID},{firstName},{lastName},{favoriteColour},{age},{isWorking}";
            return s;
        }

        public string Details()
        {
            string s = 
                $@"PersonID: {personID}
First Name: {firstName}
Last Name: {lastName}
Favorite Colour: {favoriteColour}
Age: {age}
Is Working: {isWorking}";
            return s;
        }

    }
}
