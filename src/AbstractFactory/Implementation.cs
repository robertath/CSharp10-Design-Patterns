namespace AbstractFactory
{
    public interface IShoppingCartPurchaseFactory
    {
        IDiscountService CreateDiscountService();
        IShoppingCostsService CreateShippingCostsService();
    }


    public interface IDiscountService
    {
        int DiscountPercentage { get; }
    }

    //Concrete product
    public class IrelandDiscountService : IDiscountService
    {
        public int DiscountPercentage => 20;
    }

    public class EnglandDiscountService : IDiscountService
    {
        public int DiscountPercentage => 10;
    }


    public interface IShoppingCostsService
    {
        decimal ShippingCosts { get; }
    }

    public class IrelandShippingCostsService : IShoppingCostsService
    {
        public decimal ShippingCosts => 25;
    }

    public class EnglandShippingCostsService : IShoppingCostsService
    {
        public decimal ShippingCosts => 15;
    }

    public class IrelandShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public IDiscountService CreateDiscountService()
        {
            return new IrelandDiscountService();
        }

        public IShoppingCostsService CreateShippingCostsService()
        {
            return new IrelandShippingCostsService();
        }
    }

    public class EnglandShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public IDiscountService CreateDiscountService()
        {
            return new EnglandDiscountService();
        }

        public IShoppingCostsService CreateShippingCostsService()
        {
            return new EnglandShippingCostsService();
        }
    }

    public class ShoppingCart
    {
        private readonly IDiscountService _discountService;
        private readonly IShoppingCostsService _shippingCostsService;
        private int _orderCosts;

        public ShoppingCart(IShoppingCartPurchaseFactory factory)
        {
            _discountService = factory.CreateDiscountService();
            _shippingCostsService = factory.CreateShippingCostsService();
            _orderCosts = 200;
        }

        public void CalculateCosts()
        {
            Console.WriteLine($"Total costs = " +
                $"{_orderCosts - (_orderCosts / 100 * _discountService.DiscountPercentage) + _shippingCostsService.ShippingCosts}");
        }


    }
}
