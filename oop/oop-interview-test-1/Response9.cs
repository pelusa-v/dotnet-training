namespace oop_interview_test_1;

public class BankAccount
{
    private decimal _balance;
    public decimal Balance { get { return _balance; } }

    public void Deposit(decimal amount)
    {
        _balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        _balance -= amount;
    }

    public BankAccount(decimal balance)
    {
        _balance = balance;
    }
}

public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public BankAccount BankAccount { get; set; }
}