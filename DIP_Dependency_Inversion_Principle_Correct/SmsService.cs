namespace DIP_Dependency_Inversion_Principle_Correct;

// Implementación concreta: SMS
public class SmsService : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine($"Enviando mensaje via SMS: {message}");
    }
}
