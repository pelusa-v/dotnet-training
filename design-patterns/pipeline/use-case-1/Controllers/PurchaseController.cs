using Microsoft.AspNetCore.Mvc;

namespace use_case_1;

[ApiController]
[Route("api/[controller]")]
public class PurchaseController : ControllerBase
{
    private readonly PurchaseService _purchaseService;

    public PurchaseController(PurchaseService purchaseService)
    {
        _purchaseService = purchaseService;
    }

    [HttpPost("calculate/user/{userId}/product/{productId}")]
    public ActionResult<PurchaseProcess> Purchase(int userId, int productId)
    {
        var purchase = new PurchaseProcess
        {
            UserId = userId,
            ProductId = productId,
        };
        _purchaseService.ExecutePurchaseProcess(purchase);
        if(purchase.Error)
            return StatusCode(500, "Error in purchase process");
        return purchase;
    }
}