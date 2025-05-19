using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collections;
using Assert = NUnit.Framework.Assert;

namespace Collections.test
{
        [TestFixture]
        public class CollectionTests
        {
            private const int InitialCapacity = 16;

            // Constructor tests
            [Test]
            public void TestCollectionEmptyConstructor()
            {
                // Arrange & Act
                var collection = new Collection<int>();

                // Assert
                Assert.That(collection.Count, Is.EqualTo(0));
                Assert.That(collection.Capacity, Is.GreaterThanOrEqualTo(InitialCapacity));
                Assert.That(collection.ToString(), Is.EqualTo("[]"));
            }

            [Test]
            public void TestCollectionConstructorSingleItem()
            {
                // Arrange & Act
                var collection = new Collection<int>(5);

                // Assert
                Assert.That(collection.Count, Is.EqualTo(1));
                Assert.That(collection[0], Is.EqualTo(5));
                Assert.That(collection.ToString(), Is.EqualTo("[5]"));
            }

            [Test]
            public void TestCollectionConstructorMultipleItems()
            {
                // Arrange & Act
                var collection = new Collection<int>(5, 10, 15);

                // Assert
                Assert.That(collection.Count, Is.EqualTo(3));
                Assert.That(collection[0], Is.EqualTo(5));
                Assert.That(collection[1], Is.EqualTo(10));
                Assert.That(collection[2], Is.EqualTo(15));
                Assert.That(collection.ToString(), Is.EqualTo("[5, 10, 15]"));
            }

            // Add tests
            [Test]
            public void TestCollectionAdd()
            {
                // Arrange
                var collection = new Collection<string>();

                // Act
                collection.Add("Peter");
                collection.Add("Maria");

                // Assert
                Assert.That(collection.Count, Is.EqualTo(2));
                Assert.That(collection.ToString(), Is.EqualTo("[Peter, Maria]"));
            }

            [Test]
            public void TestCollectionAddWithGrow()
            {
                // Arrange
                var collection = new Collection<int>();
                int oldCapacity = collection.Capacity;
                var newItems = Enumerable.Range(1000, oldCapacity).ToArray();

                // Act
                foreach (var item in newItems)
                {
                    collection.Add(item);
                }

                // Assert
                Assert.That(collection.Capacity, Is.GreaterThanOrEqualTo(oldCapacity * 2));
                Assert.That(collection.Count, Is.EqualTo(oldCapacity));
            }

            [Test]
            public void TestCollectionAddRange()
            {
                // Arrange
                var collection = new Collection<int>();

                // Act
                collection.AddRange(1, 2, 3);

                // Assert
                Assert.That(collection.Count, Is.EqualTo(3));
                Assert.That(collection.ToString(), Is.EqualTo("[1, 2, 3]"));
            }

            // Indexer tests
            [Test]
            public void TestCollectionGetByIndex()
            {
                // Arrange
                var collection = new Collection<string>("Peter", "Maria");

                // Act & Assert
                Assert.That(collection[0], Is.EqualTo("Peter"));
                Assert.That(collection[1], Is.EqualTo("Maria"));
            }

            [Test]
            public void TestCollectionGetByInvalidIndex()
            {
                // Arrange
                var collection = new Collection<string>("Bob", "Joe");

                // Act & Assert
                Assert.That(() => { var item = collection[-1]; },
                    Throws.InstanceOf<ArgumentOutOfRangeException>());
                Assert.That(() => { var item = collection[2]; },
                    Throws.InstanceOf<ArgumentOutOfRangeException>());
                Assert.That(() => { var item = collection[500]; },
                    Throws.InstanceOf<ArgumentOutOfRangeException>());
                Assert.That(collection.ToString(), Is.EqualTo("[Bob, Joe]"));
            }

            [Test]
            public void TestCollectionSetByIndex()
            {
                // Arrange
                var collection = new Collection<string>("Peter", "Maria");

                // Act
                collection[0] = "John";

                // Assert
                Assert.That(collection[0], Is.EqualTo("John"));
                Assert.That(collection.ToString(), Is.EqualTo("[John, Maria]"));
            }

            [Test]
            public void TestCollectionSetByInvalidIndex()
            {
                // Arrange
                var collection = new Collection<string>("Bob", "Joe");

                // Act & Assert
                Assert.That(() => { collection[-1] = "John"; },
                    Throws.InstanceOf<ArgumentOutOfRangeException>());
                Assert.That(() => { collection[2] = "John"; },
                    Throws.InstanceOf<ArgumentOutOfRangeException>());
                Assert.That(collection.ToString(), Is.EqualTo("[Bob, Joe]"));
            }

            // InsertAt tests
            [Test]
            public void TestCollectionInsertAtStart()
            {
                // Arrange
                var collection = new Collection<int>(1, 2, 3);

                // Act
                collection.InsertAt(0, 0);

                // Assert
                Assert.That(collection.Count, Is.EqualTo(4));
                Assert.That(collection.ToString(), Is.EqualTo("[0, 1, 2, 3]"));
            }

            [Test]
            public void TestCollectionInsertAtEnd()
            {
                // Arrange
                var collection = new Collection<int>(1, 2, 3);

                // Act
                collection.InsertAt(3, 4);

                // Assert
                Assert.That(collection.Count, Is.EqualTo(4));
                Assert.That(collection.ToString(), Is.EqualTo("[1, 2, 3, 4]"));
            }

            [Test]
            public void TestCollectionInsertAtMiddle()
            {
                // Arrange
                var collection = new Collection<int>(1, 3);

                // Act
                collection.InsertAt(1, 2);

                // Assert
                Assert.That(collection.Count, Is.EqualTo(3));
                Assert.That(collection.ToString(), Is.EqualTo("[1, 2, 3]"));
            }

            [Test]
            public void TestCollectionInsertAtWithGrow()
            {
                // Arrange
                var collection = new Collection<int>();
                int oldCapacity = collection.Capacity;
                var newItems = Enumerable.Range(1, oldCapacity).ToArray();
                collection.AddRange(newItems);

                // Act
                collection.InsertAt(0, 0);

                // Assert
                Assert.That(collection.Capacity, Is.GreaterThanOrEqualTo(oldCapacity * 2));
                Assert.That(collection.Count, Is.EqualTo(oldCapacity + 1));
            }

            [Test]
            public void TestCollectionInsertAtInvalidIndex()
            {
                // Arrange
                var collection = new Collection<int>(1, 2);

                // Act & Assert
                Assert.That(() => collection.InsertAt(-1, 0),
                    Throws.InstanceOf<ArgumentOutOfRangeException>());
                Assert.That(() => collection.InsertAt(3, 0),
                    Throws.InstanceOf<ArgumentOutOfRangeException>());
            }

            // Exchange tests
            [Test]
            public void TestCollectionExchangeMiddle()
            {
                // Arrange
                var collection = new Collection<int>(1, 2, 3, 4);

                // Act
                collection.Exchange(1, 2);

                // Assert
                Assert.That(collection.ToString(), Is.EqualTo("[1, 3, 2, 4]"));
            }

            [Test]
            public void TestCollectionExchangeFirstLast()
            {
                // Arrange
                var collection = new Collection<int>(1, 2, 3, 4);

                // Act
                collection.Exchange(0, 3);

                // Assert
                Assert.That(collection.ToString(), Is.EqualTo("[4, 2, 3, 1]"));
            }

            [Test]
            public void TestCollectionExchangeInvalidIndexes()
            {
                // Arrange
                var collection = new Collection<int>(1, 2, 3);

                // Act & Assert
                Assert.That(() => collection.Exchange(-1, 1),
                    Throws.InstanceOf<ArgumentOutOfRangeException>());
                Assert.That(() => collection.Exchange(1, 3),
                    Throws.InstanceOf<ArgumentOutOfRangeException>());
            }

            // RemoveAt tests
            [Test]
            public void TestCollectionRemoveAtStart()
            {
                // Arrange
                var collection = new Collection<int>(1, 2, 3);

                // Act
                var removed = collection.RemoveAt(0);

                // Assert
                Assert.That(removed, Is.EqualTo(1));
                Assert.That(collection.ToString(), Is.EqualTo("[2, 3]"));
            }

            [Test]
            public void TestCollectionRemoveAtEnd()
            {
                // Arrange
                var collection = new Collection<int>(1, 2, 3);

                // Act
                var removed = collection.RemoveAt(2);

                // Assert
                Assert.That(removed, Is.EqualTo(3));
                Assert.That(collection.ToString(), Is.EqualTo("[1, 2]"));
            }

            [Test]
            public void TestCollectionRemoveAtMiddle()
            {
                // Arrange
                var collection = new Collection<int>(1, 2, 3);

                // Act
                var removed = collection.RemoveAt(1);

                // Assert
                Assert.That(removed, Is.EqualTo(2));
                Assert.That(collection.ToString(), Is.EqualTo("[1, 3]"));
            }

            [Test]
            public void TestCollectionRemoveAtInvalidIndex()
            {
                // Arrange
                var collection = new Collection<int>(1, 2);

                // Act & Assert
                Assert.That(() => collection.RemoveAt(-1),
                    Throws.InstanceOf<ArgumentOutOfRangeException>());
                Assert.That(() => collection.RemoveAt(2),
                    Throws.InstanceOf<ArgumentOutOfRangeException>());
            }

            // Clear test
            [Test]
            public void TestCollectionClear()
            {
                // Arrange
                var collection = new Collection<int>(1, 2, 3);

                // Act
                collection.Clear();

                // Assert
                Assert.That(collection.Count, Is.EqualTo(0));
                Assert.That(collection.ToString(), Is.EqualTo("[]"));
            }
        }
}
