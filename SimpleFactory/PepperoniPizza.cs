namespace SimpleFactory
{
    public class PepperoniPizza : IPizza
    {
        public string Name { get; }

        public PepperoniPizza()
        {
            Name = "Pepperoni Pizza";
        }
    }
}
