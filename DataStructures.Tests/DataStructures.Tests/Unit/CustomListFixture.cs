using System;
using NUnit.Framework;

namespace DataStructures.Tests.Unit
{
    [TestFixture]
    public class CustomListFixture
    {
        [Test]
        public void GivenEmptyList_WhenAnItemIsAdded_ThenTheListIsNotEmpty()
        {
            var list = new CustomList<int>();
            list.AddItem(1);
            Assert.IsNotNull(list);
        }

        [Test]
        public void GivenEmptyList_WhenAnItemIsAdded_ThenTheCountOfTheListIsEqualToOne()
        {
            var list = new CustomList<int>();
            list.AddItem(1);
            Assert.AreEqual(1, list.Count);
        }

        [Test]
        public void GivenListWithTwoItems_WhenClearingTheList_ThenTheCountOfTheListAreZero()
        {
            var list = new CustomList<int>();
            list.AddItem(1);
            list.AddItem(2);
            list.Clear();
            Assert.AreEqual(0, list.Count);
        }

        [ExpectedException(typeof(InvalidOperationException), ExpectedMessage = "The list is empty")]
        [Test]
        public void GivenEmptyList_WhenAnItemIsRemoved_InvalidOperationExceptionIsThrown()
        {
            var list = new CustomList<string>();
            list.RemoveItem("Item that must be removed");
        }
    }
}
