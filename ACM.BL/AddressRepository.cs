using System.Collections.Generic;

namespace CMS.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address { AddressId = addressId };

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.City = "Hobbiton";
                address.State = "The Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();

            Address address = new Address
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                City = "Hobbiton",
                State = "The Shire",
                Country = "Middle Earth",
                PostalCode = "144"
            };
            addressList.Add(address);

            address = new Address
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                City = "Bywater",
                State = "The Shire",
                Country = "Middle Earth",
                PostalCode = "145"
            };
            addressList.Add(address);

            return addressList;
        }

        public bool Save(Address address)
        {
            var success = true;

            if (address.Validate())
            {
                if (address.AddressId == 0)
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