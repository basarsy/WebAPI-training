using Microsoft.AspNetCore.Mvc;

namespace MyMicroservice.Controllers;

[Route("api/Values/[action]")]
[ApiController]

public sealed class ValueController : ControllerBase

{
    [HttpGet]
    public IActionResult Calculate1()
    {
        return Ok(5 + 4);
    }

    [HttpGet]
    public IActionResult Calculate2()
    {
        return Ok(5 + 5);
    }

    [HttpGet]
    public IActionResult QueryParam1(int x)
    {
        return Ok(new { message = "x is " + x });
    }

    [HttpGet]
    public IActionResult QueryParam2(int x, int y)
    {
        return Ok(new { message = "x + y is =" + ((x + y))*10 });
    }
    [HttpGet]
    public IActionResult Hello()
    {
        return Ok(new { message = "Hello World" });
    }

    [HttpGet]
    public IActionResult Merhaba()
    {
        return StatusCode(200, new { message = "merhaba" });
    }

    [HttpPost]
    public IActionResult CreateProduct(Product request)
    { 
        return Ok(new {message = request.Name + " is successfully created."});
    }

    [HttpPost]
    public IActionResult CreateProduct2(CreateProductDto request)
    {
        return Ok(new { message = "Product's name is " + request.ProductName + 
                                  " and price is " + request.ProductPrice });
    }
}

public class Product
{
    public string Name { get; set; } = string.Empty;
}

public class CreateProductDto
{
    public string ProductName { get; set; } = string.Empty;
    public int ProductPrice { get; set; } = 0;
}