namespace DIP_Dependency_Inversion_Principle_Correct;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== EJEMPLO CORRECTO - cumpliendo el principio DIP ===");
        Console.WriteLine();

       // Enviar mensaje por correo
       INotificationService  email = new EmailService();
       
        NotificationManager manager = new NotificationManager(email);
        manager.Send("Bienenido a la empresa");

        // Enviar mensaje por SMS
        INotificationService sms = new SmsService();
        NotificationManager smsManager = new NotificationManager(sms);
        smsManager.Send("Bienvenido vía SMS");

        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
    }
}
