namespace DecoratorDesignPatternPOC
{
    public class VegPizzaDecorator : PizzaDecorator
    {
        protected IPizza _pizza;

        public VegPizzaDecorator(IPizza pizza) : base(pizza)
        {
            _pizza = pizza;
        }

        public override string MakePizza()
        {
            return _pizza.MakePizza() + AddVegetables();
        }

        private static string AddVegetables() => " + Vegetables Added";
    }
}
