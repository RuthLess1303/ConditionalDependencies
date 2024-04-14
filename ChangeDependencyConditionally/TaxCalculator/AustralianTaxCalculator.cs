using ChangeDependencyConditionally.ServiceDependencies.Interfaces;

namespace ChangeDependencyConditionally.ServiceDependencies;

public class AustralianTaxCalculator : ITaxCalculator
{
    public int GetTax()
    {
        return 10;
    }
}