namespace SimpleFactory
{
    class SimplePizzaFactory
    {
        public IPizza Create(string type)
        {
            IPizza pizza = null;

            if(type == "Cheese")
            {
                pizza = new CheesePizza();
            }
            else if(type == "Pepperoni")
            {
                pizza = new PepperoniPizza();
            }

            return pizza;
        }
    }
}
