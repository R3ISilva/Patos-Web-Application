namespace PrintService.Models.Print;

public interface IPrintService
{
    void AddPrint(IPrint print);
    IEnumerable<IPrint> GetAllPrints();
    IPrint GetPrint(int id);
    IPrint UpdatePrint(IPrint print);
    void DeletePrint(int id);
}