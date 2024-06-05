using Microsoft.AspNetCore.Mvc;

namespace CornerstoneManager.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventsController : ControllerBase
{
    [HttpGet]
    public string GetAll()
    {
        return "Reading all the events";
    }

    [HttpGet]
    [Route("{id:int}")]
    public string GetById(int id)
    {
        return $"Reading event with ID: {id}";
    }

    [HttpPost]
    public string Create()
    {
        return "Creating a event";
    }

    [HttpPut]
    [Route("{id:int}")]
    public string Update(int id)
    {
        return $"Updating event with ID: {id}";
    }

    [HttpDelete]
    [Route("{id:int}")]
    public string Delete(int id)
    {
        return $"Deleting event with ID: {id}";
    }
}