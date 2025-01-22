namespace use_case_1.DTOs;

public class PetDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public PetOwnerDTO? Owner { get; set; } = null!;
}
