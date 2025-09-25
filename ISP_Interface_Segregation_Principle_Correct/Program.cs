using ISP_Interface_Segregation_Principle.Class;
using ISP_Interface_Segregation_Principle.Interfaces;
using System.Net.Http.Headers;

namespace ISP_Interface_Segregation_Principle_Correct;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("**** EJEMPLO CORRECTO USANDO EL PRINCIPIO SOLID ISP!");
        IWork human = new HumanWorker();
        human.Work();

        IWork robot = new RobotWorker();
        robot.Work();

        IEat eater = new HumanWorker();
        eater.Eat();

        IStudy studier = new HumanWorker();
        studier.Study();
        
        HumanWorker humanWorker = new HumanWorker();
        humanWorker.Work();
        humanWorker.Eat();
        humanWorker.Study();

        RobotWorker robotWorker = new RobotWorker();
        robotWorker.Work();
    }
}
