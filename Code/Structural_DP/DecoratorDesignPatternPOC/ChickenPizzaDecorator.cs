namespace DecoratorDesignPatternPOC
{
    public class ChickenPizzaDecorator : PizzaDecorator
    {
        protected IPizza _pizza;

        public ChickenPizzaDecorator(IPizza pizza) : base(pizza)
        {
            _pizza = pizza;
        }

        public override string MakePizza()
        {
            return _pizza.MakePizza() + AddChicken();
        }

        private static string AddChicken() => " + Chicken Added";
    }
}
