namespace DIP_Dependency_Inversion_Principle_Correct;

// Clase de bajo nivel o clase concreta
public class EmailService : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine($"Enviando correo con el mensaje: {message}");
    }
}
