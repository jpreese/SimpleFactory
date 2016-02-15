namespace SimpleFactory
{
    public class CheesePizza : IPizza
    {
        public string Name { get; }

        public CheesePizza()
        {
            Name = "Cheese Pizza";
        }
    }
}
