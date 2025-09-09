namespace SRP_Single_Responsability_Principle_Correct;

/// <summary>
/// Responsabilidad única: Administrar el envio de correos.
/// </summary>
public class EmailService
{
    public void SendWelcomeEmail(User user)
    {
        // Simular el envio del email
        //Console.WriteLine($"Correo de bienvenida enviado a: {user.GetEmail()}");
        Console.WriteLine($"Correo de bienvenida enviado a: {user.Email}");
        // Aquí la lógica real para enviar un correo.
    }
}
