using GroupA.Exceptions;
using GroupA.Services;
using Microsoft.AspNetCore.Mvc;

namespace GroupA.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomersController : ControllerBase
{
    private readonly IDbService _dbService;

    public CustomersController(IDbService dbService)
    {
        _dbService = dbService;
    }

    [HttpGet("{customerId}")]
    public async Task<IActionResult> GetCustomerPurchases(int customerId)
    {
        try
        {
            var result = await _dbService.GetCustomerPurchasesAsync(customerId);
            if (result is null)
                throw new NotFoundException($"Customer with id {customerId} not found");

            return Ok(result);
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
        catch (ConflictException e)
        {
            return Conflict(e.Message);
        }
        catch (Exception e)
        {
            return StatusCode(500, $"Unexpected error: {e.Message}");
        }
    }
}