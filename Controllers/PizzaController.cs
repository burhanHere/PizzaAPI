using WetherForcast.Models;
using WetherForcast.Services;
using Microsoft.AspNetCore.Mvc;

namespace WetherForcast.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : Controller
{
    public PizzaController()
    { }

    // GET all action
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();

    // GET by Id action
    [HttpGet("id/{id}")]
    public ActionResult<Pizza> Get(int id)
    {
        Pizza MyPizza = PizzaService.Get(id);
        if (MyPizza.Id == 0)
        {
            return NotFound();
        }
        return Ok(MyPizza);
    }

    // POST new pizza action
    [HttpPost("name/{name}/isGlutenFree/{isGlutenFree}")]
    public IActionResult Post(string name, bool isGlutenFree)
    {
        Pizza newPizza = new() { Id = 0, Name = name, IsGlutenFree = isGlutenFree };
        PizzaService.Add(newPizza);
        return CreatedAtAction(nameof(Get), new { id = newPizza.Id }, newPizza);
    }

    // PUT update existing pizza action
    [HttpPut("id/{id}, name/{name}")]
    public IActionResult Put(int id, string name)
    {
        // check if the required item exists
        Pizza myPizza = PizzaService.Get(id);
        if (myPizza.Id == 0)
        {
            return NotFound();
        }
        myPizza.Name = name;
        PizzaService.Update(myPizza);
        return CreatedAtAction(nameof(Get), new { id = id }, myPizza);
    }
    [HttpPut("id/{id}, isGlutenFree/{isGlutenFree}")]
    public IActionResult Put(int id, bool isGlutenFree)
    {
        Pizza myPizza = PizzaService.Get(id);
        if (myPizza.Id == 0)
        {
            return NotFound();
        }
        myPizza.IsGlutenFree = isGlutenFree;
        PizzaService.Update(myPizza);
        return CreatedAtAction(nameof(Get), new { id = id }, myPizza);
    }
    [HttpPut("id/{id}, name/{name}/isGlutenFree/{isGlutenFree}")]
    public IActionResult Put(int id, string name, bool isGlutenFree)
    {
        Pizza myPizza = PizzaService.Get(id);
        if (myPizza.Id == 0)
        {
            return NotFound();
        }
        myPizza.Name = name;
        myPizza.IsGlutenFree = isGlutenFree;
        PizzaService.Update(myPizza);
        return CreatedAtAction(nameof(Get), new { id = id }, myPizza);
    }
    // DELETE action
    [HttpDelete("id/{id}")]
    public IActionResult Delete(int id)
    {
        if (PizzaService.Get(id).Id == 0)
        {
            return NotFound();
        }
        PizzaService.Delete(id);
        return NoContent();
    }
}