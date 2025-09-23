namespace ISP_Interface_Segregation_Principle;

interface IWorker
{
  void Work();
  void Eat();
  void Study();
}

class HumanWorker : IWorker
{
  public void Work() => Console.WriteLine("El ser humano trabaja...");
  public void Eat() => Console.WriteLine("El ser humano come...");
  public void Study() => Console.WriteLine("El ser humano estudia...");
}

class RobotWorker : IWorker
{
  public void Work() => Console.WriteLine("Un robot trabaja...");

  // Métodos que no tienen sentido para un robot
  public void Eat() => throw new NotImplementedException("Un robot no come!");
  public void Study() => throw new NotImplementedException("Un robot no estudia!");
}

class Program
{
  static void Main()
  {
    IWorker human = new HumanWorker();
    IWorker robot = new RobotWorker();

    human.Work();
    human.Eat();
    human.Study();

    robot.Work();
    // Problema: el robot se ve obligado a implementar métodos inútiles
    Console.WriteLine("\nPresione cualquier tecla para continuar...");
    Console.ReadKey();
  }
}