using ChangeDependencyConditionally.ServiceDependencies;
using ChangeDependencyConditionally.ServiceDependencies.Enums;
using ChangeDependencyConditionally.ServiceDependencies.Interfaces;
using ChangeDependencyConditionally.ServiceDependencies.Services;
using Microsoft.Extensions.DependencyInjection;

var collection = new ServiceCollection();
collection.AddScoped<AustralianTaxCalculator>();
collection.AddScoped<EuropeanTaxCalculator>();

collection.AddScoped<Func<CountryCodes, ITaxCalculator>>(
    serviceProvider => 
        key =>
        {
            switch (key)
            {
                case CountryCodes.Europe: return serviceProvider.GetService<EuropeanTaxCalculator>() ?? throw new Exception("EuropeanTaxCalculator Not Found");
                case CountryCodes.Australia: return serviceProvider.GetService<AustralianTaxCalculator>() ?? throw new Exception("AustralianTaxCalculator Not Found");
                default: return null;
            }
        });
collection.AddScoped<Purchase>();

var provider = collection.BuildServiceProvider();

var purchase = provider.GetService<Purchase>();

var australianPayment = purchase!.GetTotalPayment(CountryCodes.Australia);
var europeanPayment = purchase!.GetTotalPayment(CountryCodes.Europe);

Console.WriteLine($"Australian Payment: {australianPayment}\nEuropean Payment: {europeanPayment}");