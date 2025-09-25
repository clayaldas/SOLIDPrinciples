namespace DIP_Dependency_Inversion_Principle_Correct;

// Clase de alto nivel (de logica de negocio)
public class NotificationManager
{
    // variable inmutable
    // Inversión de dependencias
    // Inversión de dependencias por CONSTRUCTOR
    // Debil ACOMPLAMIENTO
    private readonly INotificationService _notificationService;

    public NotificationManager(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    public void Send(string messaje)
    {
        _notificationService.Send(messaje);
    }
}
