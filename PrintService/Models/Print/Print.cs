using Microsoft.AspNetCore.Mvc.Formatters;
using PatosPrint.Models.Pla;

namespace PrintService.Models.Print;

public class Print: IPrint
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Pla Pla { get; set; }
    public int Weight { get; set; }
    public string Description { get; set; }
    public MediaType Image { get; set; }
    public int UserId { get; set; }
}