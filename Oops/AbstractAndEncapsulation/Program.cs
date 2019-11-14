
namespace AbstractAndEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer.Customer obj = new Customer.Customer();
            obj.CustomerCode = "CustomerCode";
            obj.CustomerName = "CustomerName";
            obj.Age = 35;
            
            
            /* The end user should not be exposed to Validate and CreateDBObjects functions.
             * We are complicating his life.
             * So, we can make these two functions are private to make these functions not exposed to end user
             *
             */
            // obj.Validate();
            // obj.CreateDBObjects();
            obj.AddCustomerDataIntoDb();
        }
    }
}
