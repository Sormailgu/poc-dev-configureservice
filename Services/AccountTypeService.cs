// Generate a service for the AccountTypeService
public class AccountTypeService : IAccountTypeService
{
    public IEnumerable<AccountType> GetAccountTypes()
    {
        // Mock data
        return new List<AccountType>
        {
            new AccountType { Id = "1", Name = "Savings", Description = "Savings account", IsActive = true },
            new AccountType { Id = "2", Name = "Checking", Description = "Checking account", IsActive = true },
            new AccountType { Id = "3", Name = "Fixed Deposit", Description = "Fixed deposit account", IsActive = true }
        };
    }   
}
