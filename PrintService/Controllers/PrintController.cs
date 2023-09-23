using Microsoft.AspNetCore.Mvc;
using PrintService.Models.Print;

namespace PrintService.Controllers;

[Route("[controller]")]
[ApiController]
public class PrintController : ControllerBase
{
    private readonly IPrintService _printService;
    public PrintController(IPrintService printService)
    {
        _printService = printService;
    }
    
    [HttpPost(Name = "Create")]
    public IActionResult CreatePrint([FromBody] Print print)
    {
        _printService.AddPrint(print);
        return new ObjectResult(print);
    }
    
    [HttpGet(Name = "GetAll")]
    public IEnumerable<IPrint> GetAll()
    {
        return _printService.GetAllPrints();
    }
    
    [HttpGet("Get/{id}", Name = "GetPrint")]
    public IActionResult GetPrint([FromRoute] int id)
    {
        IPrint? print = _printService.GetPrint(id);
        if (print == null)
        {
            return NotFound();
        }

        return new ObjectResult(print);
    }
    
    [HttpPut(Name = "Update/{id}")]
    public IActionResult UpdatePrint([FromBody] IPrint print)
    {
        IPrint? updatedPrint = _printService.UpdatePrint(print);
        
        if (updatedPrint == null)
        {
            return NotFound();
        }
        return new ObjectResult(updatedPrint);
    }
    
    [HttpDelete(Name = "Delete/{id}")]
    public IActionResult DeletePrint([FromRoute] int id)
    {
        _printService.DeletePrint(id);
        return new NoContentResult();
    }
}