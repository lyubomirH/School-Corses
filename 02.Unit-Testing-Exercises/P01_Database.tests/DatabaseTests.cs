using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Database.tests
{
    [TestFixture]
    public class DatabaseTests
    {
        [Test]
        [TestCase(new int[] { })]
        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void ConstructorShouldInitializeWithCorrectElements(int[] initialData)
        {
            var db = new Database(initialData);

            Assert.That(db.Count, Is.EqualTo(initialData.Length));
            Assert.That(db.Fetch(), Is.EquivalentTo(initialData));
        }

        [Test]
        public void ConstructorShouldThrowExceptionWhenExceedingCapacity()
        {
            int[] largeArray = new int[17];

            Assert.Throws<InvalidOperationException>(() => new Database(largeArray),
                "Should throw when initializing with more than 16 elements");
        }

        [Test]
        public void AddShouldIncreaseCount()
        {
            var db = new Database();
            db.Add(1);

            Assert.That(db.Count, Is.EqualTo(1));
        }

        [Test]
        public void AddShouldThrowExceptionWhenExceedingCapacity()
        {
            int[] fullArray = new int[16];
            for (int i = 0; i < 16; i++) fullArray[i] = i + 1;

            var db = new Database(fullArray);

            Assert.Throws<InvalidOperationException>(() => db.Add(17),
                "Should throw when adding to full database");
        }

        [Test]
        public void RemoveShouldDecreaseCount()
        {
            var db = new Database(1, 2, 3);
            db.Remove();

            Assert.That(db.Count, Is.EqualTo(2));
            Assert.That(db.Fetch(), Does.Not.Contain(3));
        }
    }
}
