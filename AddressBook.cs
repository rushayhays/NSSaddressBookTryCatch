using System;
using System.Collections.Generic;

namespace AddrBook
{
    public class AddressBook
    {
        public Dictionary<string, Contact> BookOfAddresses = new Dictionary<string, Contact>();

        public void AddContact(Contact newContact)
        {
            try
            {
                BookOfAddresses.Add(newContact.Email, newContact);
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Error, this contact {newContact.Email} already exists, you can't add it again");
            }
        }

        public Contact GetByEmail(string anEmail)
        {   
            try
            {
                Contact foundContact = BookOfAddresses[anEmail];
                return foundContact;
            }
            catch(KeyNotFoundException)
            {
                Console.WriteLine($"The contact {anEmail} does not exist in your address book, it cannot retrieved");
                return null;
            }
        }
    }
}