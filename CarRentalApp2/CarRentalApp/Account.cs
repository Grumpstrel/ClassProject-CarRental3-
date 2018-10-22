using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalApp
{
    enum TypeOfUserAccount
    {
        Administrator,
        CustomerAccount
    }
    class CustomerAccounts
    {
        private static List<CustomerAccounts> accounts = new List<CustomerAccounts>();

        private static int lastAccountnumber = 1000;

        #region Customer Properties
        public TypeOfUserAccount AccountType { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerEmailAddress { get; set; }
        public string CustomerDriversLicenseNumber { get; set; }
        public string CustomerCreditCardNumber { get; set; }
        public int CustomerAccountNumber { get; set; }
        // need a reference to the class for insurance information  
        public DateTime CustomerAccountCreationDate { get; set; }
        #endregion

        #region Customer Account Management

        //Account Creation

        public static CustomerAccounts CreateAccount(string customerName, string customerAddress, string customerPhoneNumber, string customerEmailAddress, string customerDriverLicenseNumber, string customerCreditCardNumber)
        {
            var account = new CustomerAccounts
            {
                CustomerName = customerName,
                CustomerAddress = customerAddress,
                CustomerPhoneNumber = customerPhoneNumber,
                CustomerEmailAddress = customerEmailAddress,
                CustomerDriversLicenseNumber = customerDriverLicenseNumber,
                CustomerCreditCardNumber = customerCreditCardNumber,
            };

            accounts.Add(account);
            return account;
        }

        public CustomerAccounts()
        {
            CustomerAccountNumber = ++lastAccountnumber;
            CustomerAccountCreationDate = DateTime.Now;
        }

        public static IEnumerable<CustomerAccounts> GetAllAccounts()
        {
            return accounts;
        }

    }


        #endregion

}


