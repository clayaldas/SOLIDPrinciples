namespace OCP_Open_Closed_Principle_Incorrect;

// EJEMPLO INCORRECTO - Viola el principio Abierto/Cerrado
// ADEMÁS usa números mágicos (mala práctica)
public class Customer
{
  public string Name { get; set; }
  public int Type { get; set; } // Usando int en lugar de enum - MALA PRÁCTICA

  public Customer(string name, int type)
  {
    Name = name;
    Type = type;
  }
}

// Esta clase VIOLA el OCP porque necesita ser MODIFICADA cada vez que agregamos un nuevo tipo de cliente
// ADEMÁS es ilegible por los números mágicos
public class DiscountCalculator
{
  public decimal CalculateDiscount(Customer customer, decimal amount)
  {
    // Números mágicos sin explicación - NADIE sabe qué significan 1, 2
    switch (customer.Type)
    {
      case 1: // ¿Qué es 1? ¿Regular? ¿Premium? ¿Quién sabe?
        return amount * 0.05m; // 5% descuento
      case 2: // ¿Qué es 2? Imposible saberlo sin documentación
        return amount * 0.10m; // 10% descuento
                               // Si se quiere agregar un cliente con otro tipo (3, 4), se tiene que MODIFICAR esta clase
                               // Y nadie sabrá qué significa el 3 o el 4
      default:
        return 0;
    }
  }

  public void ShowDiscountInfo(Customer customer, decimal amount)
  {
    decimal discount = CalculateDiscount(customer, amount);
    decimal finalAmount = amount - discount;

    // Más números mágicos para mostrar el tipo de cliente
    string customerTypeName = GetCustomerTypeName(customer.Type);

    Console.WriteLine($"Cliente: {customer.Name} ({customerTypeName})");
    Console.WriteLine($"Monto original: ${amount:F2}");
    Console.WriteLine($"Descuento: ${discount:F2}");
    Console.WriteLine($"Monto final: ${finalAmount:F2}");
    Console.WriteLine(new string('-', 70));
  }

  // Método adicional lleno de números mágicos
  private string GetCustomerTypeName(int type)
  {
    switch (type)
    {
      case 1: return "Regular";   // Nadie sabe por qué 1 = Regular
      case 2: return "Premium";   // Nadie sabe por qué 2 = Premium      
      default: return "Desconocido";
    }
  }
}

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("=== EJEMPLO INCORRECTO - Violando OCP y utiliza Números Mágicos ===");

    var discountcalculator = new DiscountCalculator();

    // Más números mágicos - ¿qué significan 1, 2?
    var regularCustomer = new Customer("Juan Pérez", 1);   // ¿Por qué es 1?
    var premiumCustomer = new Customer("María García", 2); // ¿Por qué es 2?    

    decimal purchaseAmount = 1000m;

    discountcalculator.ShowDiscountInfo(regularCustomer, purchaseAmount);
    discountcalculator.ShowDiscountInfo(premiumCustomer, purchaseAmount);

    Console.WriteLine("PROBLEMAS MÚLTIPLES:");
    Console.WriteLine("1. Si queremos agregar un cliente 'VIP' (¿tipo 3?),");
    Console.WriteLine("   tenemos que MODIFICAR la clase DiscountCalculator");
    Console.WriteLine("   Esto VIOLA el principio Abierto/Cerrado");
    Console.WriteLine("2. Los números mágicos (1,2) hacen el código ILEGIBLE");
    Console.WriteLine("3. Es fácil pasar valores incorrectos como 0, -1, 999");
    Console.WriteLine("4. Mantenimiento es un PROBLEMA");

    // Demostrando lo fácil que es meter errores con números mágicos
    Console.WriteLine("\nProbando con un tipo de cliente inválido (999):");
    var customerWithWrongType = new Customer("Cliente Erróneo", 999); // ¿Qué es 999?
    discountcalculator.ShowDiscountInfo(customerWithWrongType, purchaseAmount);

    Console.WriteLine("\nPresione cualquier tecla para continuar...");
    Console.ReadKey();
  }
}