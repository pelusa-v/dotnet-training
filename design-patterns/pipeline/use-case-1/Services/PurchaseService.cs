namespace use_case_1;

public class PurchaseService(PurchaseCalculationPipelineService purchaseCalculationService)
{
    public PurchaseProcess ExecutePurchaseProcess(PurchaseProcess process)
    {
        var purchasePipeline = new Pipeline<PurchaseProcess>();
        purchasePipeline
            .AddStep(purchaseCalculationService.CalculateProductPrice)
            .AddStep(purchaseCalculationService.CalculateGeneralDiscount);
        
        if (IsSpecialDay())
            purchasePipeline.AddStep(purchaseCalculationService.ApplySpecialDayDiscount);
        
        purchasePipeline
            .AddStep(purchaseCalculationService.ApplyUserCredits)
            .AddStep(purchaseCalculationService.CalculateTax);
        
        purchasePipeline.Execute(process);
        
        if (process.IsError)
            Console.WriteLine("Error in purchase process");
        
        return process;
    }

    public bool IsSpecialDay()
    {
        return DateTime.Now.DayOfWeek == DayOfWeek.Friday;
    }
}
