using Creating_Classes;
namespace TestProject
{
    [TestClass]
    public class RelationTest
    {
        [TestMethod]
        public void TestSisterRelationship()
        {
            Person gina = new Person(2, "Gina", "James", "Green", 18, false);
            Person mary = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            int relationship = 1; //sis

            Relation r = new Relation(gina, relationship, mary);

            string expected = "Relationship between Gina and Mary is: Sisters";

            string actual = r.ShowRelationship();

            Assert.AreEqual(expected, actual);
        }
    }
}