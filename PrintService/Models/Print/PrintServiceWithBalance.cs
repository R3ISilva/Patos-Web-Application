using System.Data.Common;
using PrintService.Models.Balance;
using PrintService.Models.Repository;

namespace PrintService.Models.Print;

public class PrintServiceWithBalance : IPrintService
{
    private readonly IBalanceService _balanceService;
    private readonly IRepositoryService _repositoryService;

    public PrintServiceWithBalance(IBalanceService balanceService, IRepositoryService repositoryService)
    {
        _balanceService = balanceService;
        _repositoryService = repositoryService;
    }

    public void AddPrint(IPrint print)
    {
        _balanceService.UpdateBalance(print);
        _repositoryService.AddPrint(print);
    }

    public IEnumerable<IPrint> GetAllPrints()
    {
        return _repositoryService.GetAllPrints();
    }
        
        

    public IPrint GetPrint(int id)
    {
        return _repositoryService.GetPrint(id);
    }

    public IPrint UpdatePrint(IPrint print)
    {
        _balanceService.UpdateBalance(print);
        return _repositoryService.UpdatePrint(print);
    }

    public void DeletePrint(int id)
    {
        IPrint print = _repositoryService.GetPrint(id);
        _balanceService.UpdateBalance(print);
        _repositoryService.DeletePrint(id);
    }
}