namespace OCP_Open_Closed_Principle_Correct;

public class RegularCustomerDiscount : IDiscountStrategy
{
    public CustomerType CustomerType
    {
        get
        {
            return CustomerType.Regular;
        }
    }
    public decimal CalculateDiscount(decimal amount)
    {
        return amount * 0.05m;
    }   
}
