namespace OCP_Open_Closed_Principle_Correct;

public class VipCustomerDiscount : IDiscountStrategy
{
    public CustomerType CustomerType
    {
        get 
        {
            return CustomerType.Vip; 
        }
    }

    public decimal CalculateDiscount(decimal amount)
    {
        return amount * 0.30m;
    }    
}
