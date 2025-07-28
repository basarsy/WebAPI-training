using Microsoft.AspNetCore.Mvc;
using MyMicroservice.Models;

namespace MyMicroservice.Controllers;

[Route("api/[controller]")]
[ApiController]

public class ProductController : Controller
{
    public static List<Product> Products { get; set; }= new();
    
    [HttpPost]
    public IActionResult Create(Product product)
    {
        Products.Add(product);
        return Ok(new { message = "Product is successfully created." });
    }
    
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(Products);
    }
}
