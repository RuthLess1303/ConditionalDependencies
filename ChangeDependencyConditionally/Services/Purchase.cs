using ChangeDependencyConditionally.ServiceDependencies.Enums;
using ChangeDependencyConditionally.ServiceDependencies.Interfaces;

namespace ChangeDependencyConditionally.ServiceDependencies.Services;

public class Purchase(Func<CountryCodes, ITaxCalculator> accessor)
{
    public int GetTotalPayment(CountryCodes code)
    {
        var tax = accessor(code);
        
        return 100 + tax.GetTax();
    }
}