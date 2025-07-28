namespace MyMicroservice.Dtos;

public class CreateProductDto
{
    public string ProductName { get; set; } = string.Empty;
    public int ProductPrice { get; set; } = 0;
}