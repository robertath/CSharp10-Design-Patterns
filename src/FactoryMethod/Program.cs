﻿using FactoryMethod;

Console.Title = "Factory Method";

var factories = new List<DiscountFactory> {
    new CodeDiscountFactory(Guid.NewGuid()),
    new CountryDiscountFactory("IE")
};

foreach (var fact in factories)
{
    var discountService = fact.CreateDiscountService();
    Console.WriteLine($"Percentage {discountService.DiscountPercentage} " +
        $"coming from {discountService} ");
}

Console.ReadLine();