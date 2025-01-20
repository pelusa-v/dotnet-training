namespace oop_interview_test_2;

public class PaymentProcessor
{
    private INotificator _notificator;

    public PaymentProcessor(INotificator notificator)
    {
        _notificator = notificator;    
    }

    public void UserProcessPayment(User user, Order order)
    {
        try
        {
            ProcessPayment(user.PaymentMethod, order);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            _notificator.Notify("Payment failed", user);
            // Log the exception and notify the user
        }

        _notificator.Notify("Payment successful", user);
    }

    private void ProcessPayment(IPayable paymentMethod, Order order)
    {
        var result = paymentMethod.Pay(order.PaymentData);
        if (!result)
            throw new Exception("Payment failed");
        
        order.MarkAsPaid();
    }
}

public class User
{
    public PaymentMethodResource PaymentMethod { get; set; }
    // Some user data
    public User(PaymentMethodResource paymentMethod)
    {
        PaymentMethod = paymentMethod;
    }
}

public interface INotificator
{
    void Notify(string message, User user);
}

public class Order
{
    public PaymentDetails PaymentData { get; set; }
    // Some order data
    public Order(PaymentDetails paymentData)
    {
        PaymentData = paymentData;
    }

    public void MarkAsPaid()
    {
        // Mark order as paid
    }
}

public abstract class PaymentMethodResource : IPayable
{
    // Some payment resource to reuse across all the resources here

    // Some contract methods (like interface)
    public abstract bool Pay(PaymentDetails paymentDetails);
}

public interface IPayable
{
    bool Pay(PaymentDetails paymentDetails);
}

public class CreditCardResource : PaymentMethodResource
{
    public string CardNumber { get; set; }
    public string ExpiryDate { get; set; }
    public string Cvv { get; set; }

    public override bool Pay(PaymentDetails paymentDetails)
    {
        // Credit card payment logic
        return true;
    }
}

public class BankAccountResource : PaymentMethodResource
{
    public string AccountNumber { get; set; }
    public string RoutingNumber { get; set; }

    public override bool Pay(PaymentDetails paymentDetails)
    {
        // bank payment logic
        return true;
    }
}

public class CashResource : PaymentMethodResource
{
    public string Currency { get; set; }
    public decimal Amount { get; set; }

    public override bool Pay(PaymentDetails paymentDetails)
    {
        // cash payment logic
        return true;
    }
}

public class PayPalResource : PaymentMethodResource
{
    public string Email { get; set; }
    public string Password { get; set; }

    public override bool Pay(PaymentDetails paymentDetails)
    {
        // PayPal payment logic
        return true;
    }
}

public class PaymentDetails
{
    // Some required payment data (Ammount of money, currency, etc.)
}