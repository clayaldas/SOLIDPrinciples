namespace OCP_Open_Closed_Principle_Correct;

/// <summary>
/// Esta clase esta CERRADA para realizar modificaciones pero ABIERTA para
/// la extensión.
/// </summary>
public class DiscountCalculator
{
    public decimal CalculateDiscount(Customer customer, decimal amount)
    {
        // No es necesario modificar este método para agregar nuevos tipos de Customer.
        return customer.DiscountStrategy.CalculateDiscount(amount);
    }

    public void ShowDiscountInfo(Customer customer, decimal amount)
    {
        decimal discount = CalculateDiscount(customer, amount);
        decimal finalAmount = amount - discount;
        
        // Utilizando Enumaraciones
        Console.WriteLine($"Cliente: {customer.Name} ({customer.DiscountStrategy.CustomerType})");
        Console.WriteLine($"Monto original: ${amount:F2}");
        Console.WriteLine($"Descuento: ${discount:F2}");
        Console.WriteLine($"Monto final: ${finalAmount:F2}");
        Console.WriteLine(new string('-', 70));
    }
}
