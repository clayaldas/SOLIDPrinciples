namespace OCP_Open_Closed_Principle_Correct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EJEMPLO CORRECTO - Usando OCP y sin Números Mágicos ===");

            var discountcalculator = new DiscountCalculator();

            // Crear clientes con diferentes tipos de estrategia de descuenta
            var regularCustomer = new Customer("Juan Pérez", new RegularCustomerDiscount());   
            var premiumCustomer = new Customer("María García", new PremiumCustomerDiscount()); 


            var vipCustomer = new Customer("María García", new VipCustomerDiscount()); 

            decimal purchaseAmount = 1000m;

            discountcalculator.ShowDiscountInfo(regularCustomer, purchaseAmount);
            discountcalculator.ShowDiscountInfo(premiumCustomer, purchaseAmount);

            discountcalculator.ShowDiscountInfo(vipCustomer, purchaseAmount);

            Console.WriteLine("\nPresione cualquier tecla para continuar...");            
        }
    }
}
