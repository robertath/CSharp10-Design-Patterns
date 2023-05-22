using AbstractFactory;

Console.Title = "Abstract Factory";

var irelandShoppingCartPurchaseFactory = new IrelandShoppingCartPurchaseFactory();
var shoppingCartForIreland = new ShoppingCart(irelandShoppingCartPurchaseFactory);
shoppingCartForIreland.CalculateCosts();

var englandShoppingCartPurchaseFactory = new EnglandShoppingCartPurchaseFactory();
var shoppingCartForEngland = new ShoppingCart(englandShoppingCartPurchaseFactory);
shoppingCartForEngland.CalculateCosts();

Console.ReadKey();