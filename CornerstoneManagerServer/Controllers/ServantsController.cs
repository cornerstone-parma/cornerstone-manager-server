using Microsoft.AspNetCore.Mvc;

namespace CornerstoneManager.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ServantsController : ControllerBase
{
    [HttpGet]
    public string GetAll()
    {
        return "Reading all the servants";
    }

    [HttpGet]
    [Route("{id:int}")]
    public string GetById(int id)
    {
        return $"Reading servant with ID: {id}";
    }

    [HttpPost]
    public string Create()
    {
        return "Creating a servant";
    }

    [HttpPut]
    [Route("{id:int}")]
    public string Update(int id)
    {
        return $"Updating servant with ID: {id}";
    }

    [HttpDelete]
    [Route("{id:int}")]
    public string Delete(int id)
    {
        return $"Deleting servant with ID: {id}";
    }
}