namespace SRP_Single_Responsability_Principle_Correct;

/// <summary>
/// Responsabilidad única: Validar datos del usuario
/// </summary>
public class UserValidator
{
    /// <summary>
    /// Permite validar el nombre del usuario.
    /// </summary>
    /// <param name="name">Nombre el usuario</param>
    /// <returns>False si no pasa la validacíon y true si lo pasa.</returns>
    private bool IsNameValid(string name)
    {
        if (string.IsNullOrEmpty(name) || name.Length < 2)
        {
            Console.WriteLine("Error. El nombre debe tener la menos 2 caracteres");
            return false;
        }
        return true;
    }
    private bool IsEmailValid(string email)
    {
        if (string.IsNullOrEmpty(email) || !email.Contains("@"))
        {
            Console.WriteLine("Error: Correo no válido");
            //new Exception("Error: Correo no válido");
            return false;
        }
        return true;
    }

    private bool IsAgeValid(int age)
    {
        if (age < 18 || age > 110)
        {
            Console.WriteLine("Error: La edad debe estar entre 0 y 110 años");
            return false;
        }
        return true;
    }
    public bool IsValid(User user)
    {
      return IsNameValid(user.Name) &&
            IsEmailValid(user.Email) &&
            IsAgeValid(user.Age);
    }
}
