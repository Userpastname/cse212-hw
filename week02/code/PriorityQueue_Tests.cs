using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: add two items the one wit the higher priority is last and run the dequeue function. 
    // Expected Result: the queue should only show the first one.
    // Defect(s) Found: the index in the for loop to go till had a -1 change.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("not priority",30);
        priorityQueue.Enqueue("priority", 50);

        var taken = priorityQueue.Dequeue();

        if (taken != "priority")
        {
            Assert.Fail("it did not remove the priority item");
        }

    }

    [TestMethod]
    // Scenario: Dequeues with no assertion
    // Expected Result: an error
    // Defect(s) Found: none
    public void TestPriorityQueue_2()
    {
        try
        {
            var priorityQueue = new PriorityQueue();
            var taken = priorityQueue.Dequeue();
            Assert.Fail("it did not error");
        }
        catch (Exception ex)
        {
            Console.WriteLine("success");
        }

    }

    [TestMethod]
    // Add more test cases as needed below.
    // Scenario: dequeues with same priority
    // Expected Result: return the first one in order
    // Defect(s) Found:
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("random",30);
        priorityQueue.Enqueue("secondhigh",50);
        priorityQueue.Enqueue("firsthigh",50);

        var taken = priorityQueue.Dequeue();

        if(taken != "firsthigh")
        {
            Assert.Fail("did not remove the first instance of a priority item");
        }

    }
}