namespace OCP_Open_Closed_Principle_Correct;

public class Customer
{
    public string Name { get; set; }
    public IDiscountStrategy DiscountStrategy { get; set; }

    public Customer(string name, IDiscountStrategy discountStrategy)
    {
        Name = name;
        DiscountStrategy = discountStrategy;
    }
}
