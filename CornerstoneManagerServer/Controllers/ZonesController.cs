using Microsoft.AspNetCore.Mvc;

namespace CornerstoneManager.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ZonesController : ControllerBase
{
    [HttpGet]
    public string GetAll()
    {
        return "Reading all the zones";
    }

    [HttpGet]
    [Route("{id:int}")]
    public string GetById(int id)
    {
        return $"Reading zone with ID: {id}";
    }

    [HttpPost]
    public string Create()
    {
        return "Creating a zone";
    }

    [HttpPut]
    [Route("{id:int}")]
    public string Update(int id)
    {
        return $"Updating zone with ID: {id}";
    }

    [HttpDelete]
    [Route("{id:int}")]
    public string Delete(int id)
    {
        return $"Deleting zone with ID: {id}";
    }
}