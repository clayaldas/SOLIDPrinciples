namespace DIP_Dependency_Inversion_Principle_Incorrect;


// La clase de alto nivel (NotificationManager) depende directamente de un detalle (EmailService):
public class EmailService
{
  public void SendEmail(string message)
  {
    Console.WriteLine($"Enviando correo con el mensaje: {message}");
  }
}

// Problema: Si mañana se quiere enviar el mensaje por SMS en lugar de email, se tiene
// que modificar la clase de detalle "NotificationManager", lo que rompe DIP.
public class NotificationManager
{
  private EmailService _emailService = new EmailService();

  public void Send(string message)
  {
    _emailService.SendEmail(message);
  }
}

public class Program
{
  public static void Main(string[] args)
  {
    Console.WriteLine("=== EJEMPLO INCORRECTO - Violando el principio DIP ===");
    Console.WriteLine();

    NotificationManager manager = new NotificationManager();
    manager.Send("Bienvenido a la empresa!");

    Console.WriteLine("Presione una tecla para continuar...");
    Console.ReadKey();
  }
}
