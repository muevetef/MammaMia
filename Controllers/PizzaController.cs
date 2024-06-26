using MammaMia.Models;
using MammaMia.Services;
using Microsoft.AspNetCore.Mvc;

namespace MammaMia.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    public PizzaController() { }

    [HttpGet]
    public ActionResult<List<Pizza>> GetPizzas() => Ok(PizzaService.GetPizzas());
    [HttpGet("{id}")]
    public ActionResult<Pizza> GetPizza(int id)
    {
        var pizza = PizzaService.GetPizza(id);

        if (pizza == null) return NotFound();

        return Ok(pizza);
    }

    [HttpPost]
    public IActionResult CreatePizza(Pizza pizza)
    {
        PizzaService.AddPizza(pizza);
        return CreatedAtAction(nameof(GetPizza), new { id = pizza.Id }, pizza);
    }

    [HttpPut("{id}")]
    public IActionResult UpdatePizza(int id, Pizza pizza)
    {
        if (id != pizza.Id) return BadRequest();

        var existingPizza = PizzaService.GetPizza(id);

        if (existingPizza is null) return NotFound();

        PizzaService.UpdatePizza(pizza);

        return NoContent();

    }

    [HttpDelete("{id}")]
    public IActionResult RemovePizza(int id)
    {
        var pizza = PizzaService.GetPizza(id);

        if (pizza is null) return NotFound();

        PizzaService.RemovePizza(id);

        return NoContent();
    }
}