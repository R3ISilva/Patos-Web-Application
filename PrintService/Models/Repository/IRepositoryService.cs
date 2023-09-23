using PrintService.Models.Print;

namespace PrintService.Models.Repository;
public interface IRepositoryService
{
    void AddPrint(IPrint print);
    IEnumerable<IPrint> GetAllPrints();
    IPrint GetPrint(int id);
    IPrint UpdatePrint(IPrint print);
    void DeletePrint(int id);
}