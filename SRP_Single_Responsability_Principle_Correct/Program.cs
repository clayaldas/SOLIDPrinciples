using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

namespace SRP_Single_Responsability_Principle_Correct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EJEMPLO CORRECTO DEL PRINCIPIO SOLID: SRP!");

            //User user = new User("John", "Doe", 30);
            //user.Name = "Luis";//set(escritura)
            ////user.SetName("Luis");
            //string name = user.Name;//Luis
            ////String name = user.GetName();            

            //UserValidator validator = new UserValidator();
            var validator = new UserValidator();//inferencia
            var repository = new UserRepository();
            var emailService = new EmailService();
            var reportGenerator = new UserReportService();

            var registrationService = new UserRegistrationService(validator, 
                                                                  repository, 
                                                                  emailService, 
                                                                  reportGenerator);

            // Crear el usuario
            var user = new User("John Doe", "johndoe@gmail.com", 30);

            // Registrar el usuario
            bool isRegistered = registrationService.RegisterUser(user);

            if (isRegistered)
            {
                Console.WriteLine("Usuario registrado correctamente");
            }
            else 
            {
                Console.WriteLine("Error al registrar el usuario");
            }
        }
    }
}
