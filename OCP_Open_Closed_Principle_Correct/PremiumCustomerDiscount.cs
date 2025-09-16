namespace OCP_Open_Closed_Principle_Correct;

public class PremiumCustomerDiscount : IDiscountStrategy
{
    public CustomerType CustomerType 
    { 
        get 
        {
            return CustomerType.Premium;
        }
    }
    public decimal CalculateDiscount(decimal amount)
    {
        return amount * 0.10m;
    }     
}
