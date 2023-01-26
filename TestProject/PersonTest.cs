using Creating_Classes;
namespace TestProject
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void TestDisplayPersonInfo()
        {
            Person p = new Person(1, "Ian", "Brooks", "Red", 30, true);
            string expected = "1: Ian Brooks's favourite colour is Red";

            string actual = p.DisplayPersonInfo();

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestChangeFavoriteColour() 
        {
            Person p = new Person(1, "Ian", "Brooks", "Red", 30, true);
            p.ChangeFavoriteColour("White");

            string expected = "White";
            string actual = p.favoriteColour;

            Assert.AreEqual(expected, actual);
                
        }

        [TestMethod]
        public void TestGetAgeInTenYears()
        {
            Person p = new Person(1, "Ian", "Brooks", "Red", 30, true);
            string expected = "Ian Brooks's Age in 10 years will be: 40";
            string actual = p.GetAgeInTenYears();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestToString()
        {
            Person p = new Person(1, "Ian", "Brooks", "Red", 30, true);
            string expected = "1,Ian,Brooks,Red,30,True";
            string actual = p.ToString();
            Assert.AreEqual(expected, actual);
        }

    }
}