namespace use_case_1;

public class PurchaseCalculationPipelineService
{
    private readonly DbContext _db;

    public PurchaseCalculationPipelineService(DbContext db)
    {
        _db = db;
    }

    public PurchaseProcess CalculateProductPrice(PurchaseProcess purchaseProcess)
    {
        var product = _db.Products.Find(p => p.Id == purchaseProcess.ProductId);
        if (product == null)
        {
            purchaseProcess.Error = true;
            return purchaseProcess;
        }

        purchaseProcess.Ammount = product.Price;
        return purchaseProcess;
    }

    public PurchaseProcess CalculateGeneralDiscount(PurchaseProcess purchaseProcess)
    {
        if (purchaseProcess.Ammount > 100)
        {
            purchaseProcess.Ammount *= 0.9m;
        }

        return purchaseProcess;
    }

    public PurchaseProcess ApplySpecialDayDiscount(PurchaseProcess purchaseProcess)
    {
        purchaseProcess.Ammount *= 0.95m;
        return purchaseProcess;
    }

    public PurchaseProcess ApplyUserCredits(PurchaseProcess purchaseProcess)
    {
        var user = _db.Users.Find(u => u.Id == purchaseProcess.UserId);
        if (user == null)
        {
            purchaseProcess.Error = true;
            return purchaseProcess;
        }

        if (user.Credit > 0)
        {
            purchaseProcess.Ammount -= user.Credit;
            if (purchaseProcess.Ammount < 0)
            {
                user.Credit = -purchaseProcess.Ammount;
                purchaseProcess.Ammount = 0;
                _db.UpdateUser(user);
            }
        }

        return purchaseProcess;
    }

    public PurchaseProcess CalculateTax(PurchaseProcess purchaseProcess)
    {
        purchaseProcess.Ammount *= 1.21m;
        return purchaseProcess;
    }
}
