using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Creating_Classes
{
    public class Relation
    {
        public Relation(Person p1, int relationshipType, Person p2)
        {
            this.p1 = p1;
            this.relationshipType = relationshipType;
            this.p2 = p2;
        }

        public Person p1 { get; set; }
        public Person p2 { get; set; }

        public int relationshipType { get; set; }

        public string ShowRelationship()
        {

            string s = null;
            switch (relationshipType)
            {
                case 1:
                    s = "Sisters";
                    break;
                case 2:
                    s = "Brothers";
                    break;
                case 3:
                    s = "Mother and child";
                    break;
                case 4:
                    s = "Father and child";
                    break;
            }

            string msg = $"Relationship between {p1.firstName} and {p2.firstName} is: {s}";
            return msg;
        }
    }
 
}
