using System.Linq;

namespace CMS.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository;

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.org";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }

            return customer;
        }

        public bool Save(Customer customer)
        {
            var success = true;

            if (customer.Validate())
            {
                if (customer.AddressList != null)
                {
                    foreach (var address in customer.AddressList)
                    {
                        addressRepository.Save(address);
                    }
                }

                if (customer.CustomerId == 0)
                {
                  
                }
                else
                {
                  
                }
            }
            else
            {
                success = false;
            }

            return success;
        }
    }
}