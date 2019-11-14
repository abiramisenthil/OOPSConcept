
namespace Customer
{
    public class Customer
    {
        
        public string CustomerCode { get; set; }

        public string CustomerName { get; set; }

        public int Age { get; set; }

        public void AddCustomerDataIntoDb()
        {
            Validate();
            CreateDBObjects();
            // Code implementation to add data into database
        }

        // Granular functions **** Made the these complicated methods as private (Encapsulation)

        private bool Validate()
        {
            // Validate customer code, name and age.
            return true;
        }

        private bool CreateDBObjects()
        {
            // DB connections, SQL etc
            return true;

        }

    }
}
