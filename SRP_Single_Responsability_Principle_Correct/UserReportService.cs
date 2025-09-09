namespace SRP_Single_Responsability_Principle_Correct;

/// <summary>
/// Responsabilidad única: Generar reportes del usuario.
/// </summary>
public class UserReportService
{    
    public void GenerateReport(User user)
    {
        Console.WriteLine("*********** REPORTE DEL USUARIO ***************");
        Console.WriteLine($"Nombre: {user.Name}");
        Console.WriteLine($"Email: {user.Email}");
        Console.WriteLine($"Edad: {user.Age}");
        Console.WriteLine("**************************");
    }
}
