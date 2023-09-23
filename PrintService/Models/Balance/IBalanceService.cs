using PrintService.Models.Print;

namespace PrintService.Models.Balance;

public interface IBalanceService
{
    Balance UpdateBalance(IPrint print);
}