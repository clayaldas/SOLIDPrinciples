using ISP_Interface_Segregation_Principle.Interfaces;

namespace ISP_Interface_Segregation_Principle.Class;

public class RobotWorker : IWork
{
    public void Work()
    {
        Console.WriteLine("El robot trabaja...");
    }
}
