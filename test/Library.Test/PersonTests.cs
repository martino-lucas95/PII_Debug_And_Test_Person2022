using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        private Person person;

        [SetUp]
        public void Setup()
        {
            this.person = new Person("Lucas Martino", "1.234.567-8");
        }

        [Test]
        public void NameNotNull()
        {
            //Not Null
            const string expected = "Lucas";
            Assert.IsNotNull(expected, person.Name);
        }

        [Test]
        public void NameNotEmpty()
        {
            const string expected = " ";
            Assert.IsNotEmpty(expected, person.Name);
        }

        [Test]
        public void ValidId()
        {
            const string expected = "4.658.761-8";
            Assert.IsNotNull(expected, person.ID);
        }
    }
}