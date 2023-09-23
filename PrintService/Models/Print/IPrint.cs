using System.Net.Mime;
using Microsoft.AspNetCore.Mvc.Formatters;
using PatosPrint.Models.Pla;

namespace PrintService.Models.Print;

public interface IPrint
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Pla Pla { get; set; }
    public int Weight { get; set; }
    public string Description { get; set; }
    public MediaType Image { get; set; }
    public int UserId { get; set; }
    
    /*
    To avoid violating SRP while still providing useful methods and behaviors, consider the following principles:

    Cohesion: Ensure that methods within a class are cohesive, meaning they are related and contribute to the core responsibility of the class. If you find that a class has multiple unrelated responsibilities, consider splitting it into multiple smaller classes, each with a single responsibility.

    Separation of Concerns: Use the concept of separation of concerns to divide your code into distinct modules or classes, each responsible for a specific concern or aspect of the system. This can help maintain SRP.

    Dependency Injection: If some methods require external dependencies or services, consider injecting those dependencies into the class rather than hardcoding them. This can help decouple responsibilities and improve testability.

    Extracting Utility Classes: If you have utility methods that are used by multiple classes and don't belong to any particular class's responsibility, consider extracting them into separate utility classes.
    */
}