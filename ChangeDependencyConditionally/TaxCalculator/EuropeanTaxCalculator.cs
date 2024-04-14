using ChangeDependencyConditionally.ServiceDependencies.Interfaces;

namespace ChangeDependencyConditionally.ServiceDependencies;

public class EuropeanTaxCalculator : ITaxCalculator
{
    public int GetTax()
    {
        return 20;
    }
}