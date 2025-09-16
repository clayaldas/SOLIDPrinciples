namespace OCP_Open_Closed_Principle_Correct;

public interface IDiscountStrategy
{
    decimal CalculateDiscount(decimal amount);    

    // Utilizando Propiedades con enumeraciones.
    CustomerType CustomerType { get;}
}
