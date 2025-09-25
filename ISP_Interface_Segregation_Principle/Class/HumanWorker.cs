using ISP_Interface_Segregation_Principle.Interfaces;

namespace ISP_Interface_Segregation_Principle.Class;

public class HumanWorker : IWork, IEat, IStudy
{
    public void Work()
    {
        Console.WriteLine("El ser humano trabaja...");
    }
    public void Eat()
    {
        Console.WriteLine("El ser humano come...");
    }

    public void Study()
    {
        Console.WriteLine("El ser humano estudia...");
    }   
}
