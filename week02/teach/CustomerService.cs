/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be 
/// added and allows customers to be serviced.
/// </summary>
public class CustomerService {
    public static void Run() {
        // Example code to see what's in the customer service queue:
        Console.WriteLine("give me a number");
        int qeueSize = Convert.ToInt16(Console.ReadLine());
        CustomerService size = new CustomerService(qeueSize);

        string inputing = "";
        do
        {
            Console.WriteLine("1. Add customer");
            Console.WriteLine("2. Serve customer");
            Console.WriteLine("3. see details");
            Console.WriteLine("4. end");
            
            inputing = Console.ReadLine();

            if (inputing == "1")
            {
                size.AddNewCustomer();
            }
            else if (inputing == "2")
            {
                size.ServeCustomer();
            }
            else if(inputing == "3")
            {
                Console.WriteLine(size.ToString());
            }
        }
        while (inputing != "4");
        

        // Test Cases

        // Test 1
        // Scenario: serve a customer after adding a dude
        // Expected Result: he gets removed and served
        Console.WriteLine("Test 1");

        
        // Defect(s) Found: when trying to serve a customer, it would remove the instance of it before trying to access it to display the customers name.
        // fix was we made the disiplay of the name happen before the removal
        

        Console.WriteLine("=================");

        // Test 2
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 2");

        // Defect(s) Found: 

        Console.WriteLine("=================");

        // Add more Test Cases As Needed Below
    }

    private readonly List<Customer> _queue = new();
    private readonly int _maxSize;

    public CustomerService(int maxSize) {
        if (maxSize <= 0)
            _maxSize = 10;
        else
            _maxSize = maxSize;
    }

    /// <summary>
    /// Defines a Customer record for the service queue.
    /// This is an inner class.  Its real name is CustomerService.Customer
    /// </summary>
    private class Customer {
        public Customer(string name, string accountId, string problem) {
            Name = name;
            AccountId = accountId;
            Problem = problem;
        }

        private string Name { get; }
        private string AccountId { get; }
        private string Problem { get; }

        public override string ToString() {
            return $"{Name} ({AccountId})  : {Problem}";
        }
    }

    /// <summary>
    /// Prompt the user for the customer and problem information.  Put the 
    /// new record into the queue.
    /// </summary>
    private void AddNewCustomer() {
        // Verify there is room in the service queue
        if (_queue.Count > _maxSize) {
            Console.WriteLine("Maximum Number of Customers in Queue.");
            return;
        }

        Console.Write("Customer Name: ");
        var name = Console.ReadLine()!.Trim();
        Console.Write("Account Id: ");
        var accountId = Console.ReadLine()!.Trim();
        Console.Write("Problem: ");
        var problem = Console.ReadLine()!.Trim();

        // Create the customer object and add it to the queue
        var customer = new Customer(name, accountId, problem);
        _queue.Add(customer);
    }

    /// <summary>
    /// Dequeue the next customer and display the information.
    /// </summary>
    private void ServeCustomer() {
        var customer = _queue[0];
        Console.WriteLine(customer);
        _queue.RemoveAt(0);

    }

    /// <summary>
    /// Support the WriteLine function to provide a string representation of the
    /// customer service queue object. This is useful for debugging. If you have a 
    /// CustomerService object called cs, then you run Console.WriteLine(cs) to
    /// see the contents.
    /// </summary>
    /// <returns>A string representation of the queue</returns>
    public override string ToString() {
        return $"[size={_queue.Count} max_size={_maxSize} => " + string.Join(", ", _queue) + "]";
    }
}