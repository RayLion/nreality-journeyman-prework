using NUnit.Framework;

namespace DataStructures.Tests.Unit
{
    [TestFixture]
    class CustomQueueFixture
    {
        [Test]
        public void GivenEmptyQueue_WhenEnqueue_ThenTheQueueIsNotEmpty()
        {
            var queue = new CustomQueue<int>();
            queue.Enqueue(1);
            Assert.IsNotNull(queue);
        }

        [Test]
        public void GivenEmptyQueue_WhenEnqueue_ThenTheCountOfTheQueueIsEqualToOne()
        {
            var queue = new CustomQueue<int>();
            queue.Enqueue(1);
            Assert.AreEqual(1, queue.Count);
        }

        [Test]
        public void GivenQueueWithFiveItemAndFirstItemIs84_WhenDequeue_ThenTheItemRemovedIsEqualTo84()
        {
            var queue = new CustomQueue<int>();
            queue.Enqueue(84);
            queue.Enqueue(77);
            queue.Enqueue(99);
            queue.Enqueue(71);
            queue.Enqueue(18);
            var result = queue.Dequeue();
            Assert.AreEqual(84, result);
        }
    }
}
