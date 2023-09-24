using PrintService.Models.Print;

namespace PrintService.Models.Balance;

public interface IBalanceService
{
    void UpdateBalance(IPrint print);
}