using System;
using TDDLinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDLinkedListTests
{
    [TestClass]
    public class LinkedListTests
    {
        LinkedList<int> list;

        [TestInitialize]
        public void Init()
        {
            list = new LinkedList<int>();
        }

        [TestMethod]
        public void ListEmptyByDefault()
        {
            Assert.AreEqual(0, list.Size);
        }

        [TestMethod]
        public void AddIncreasesSize()
        {
            list.AddFirst(2);
            Assert.AreEqual(1, list.Size);
        }

        [TestMethod]
        public void SingleAddReturnsCorrectValue()
        {
            var node = list.AddFirst(5);
            Assert.AreEqual(5, node.Value);
        }

        [TestMethod]
        public void FirstNodeHasCorrectNext()
        {
            var secondNode = list.AddFirst(2);
            var firstNode = list.AddFirst(1);

            Assert.AreEqual(secondNode, firstNode.Next);
        }

        [TestMethod]
        public void LastNodeIsCorrect()
        {
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);

            Assert.AreEqual(1, list.Get(2).Value);
        }

        [TestMethod]
        public void FirstNodeIsCorrect()
        {
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);

            Assert.AreEqual(3, list.Get(0).Value);
        }
    }
}
