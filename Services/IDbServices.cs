using GroupA.DTOs;


namespace GroupA.Services;

public interface IDbService
{
    Task<CustomerPurchasesDto?> GetCustomerPurchasesAsync(int customerId);
    Task AddWashingMachineWithProgramsAsync(AddWashingMachineDto dto);
}