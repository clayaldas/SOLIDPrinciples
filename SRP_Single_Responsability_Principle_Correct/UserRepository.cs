namespace SRP_Single_Responsability_Principle_Correct;

/// <summary>
/// Responsabilidad única: Persitir los usuarios en la base de datos.
/// </summary>
public class UserRepository
{
    public void Save(User user)
    {
        // Simular el guardado de datos en la base de datos
        Console.WriteLine($"Usuario: {user.Name} guardado en la base de datos");
        // Aquí iría la lógica real de conexión y guadado en la base de datos
    }
}
