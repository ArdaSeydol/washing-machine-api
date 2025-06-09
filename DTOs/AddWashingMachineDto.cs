namespace GroupA.DTOs;

public class AddWashingMachineDto
{
    public CreatingWashingMachineDto WashingMachine { get; set; }
    public List<AvailableProgramsDto> AvailablePrograms { get; set; }
}

public class AvailableProgramsDto
{
    public string ProgramName { get; set; }
    public decimal Price { get; set; }
}

public class CreatingWashingMachineDto
{
    public decimal MaxWeight { get; set; }
    public string SerialNumber { get; set; }
}