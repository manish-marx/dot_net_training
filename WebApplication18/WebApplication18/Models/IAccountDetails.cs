namespace WebApplication18.Models
{
    public interface IAccountDetails
    {
        public List<Account> GetAccounts();
    }
    public class AccountDetails : IAccountDetails
    {
        public List<Account> GetAccounts()
        {
            var accounts = new List<Account>()
            {
                new Account()
                {
                    ID = 1,
                    Name ="Manish",
                    Acntnum = 1234
                },
                new Account()
                {
                    ID = 2,
                    Name = "Prince",
                    Acntnum = 5678
                },
                new Account()
                {
                    ID = 3,
                    Name = "Prashant",
                    Acntnum = 3589
                }
            };
            return accounts;
        }
    }
}
