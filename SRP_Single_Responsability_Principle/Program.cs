namespace SRP_Single_Responsability_Principle
{
    /// <summary>
    /// EJEMPLO INCORRECTO: SRP
    /// El siguiente proyecto la clase User tiene multiples responsabilidades.
    /// </summary>
    
    public class User
    {
        private string _name;
        private string _email;
        private int _age;

        public User(string name, string email, int age) 
        { 
            _name = name;
            _email = email;
            _age = age;
        }

        // Setter - Getter
        public void SetName(string name) 
        { 
            _name = name;
        }
        public string GetName() 
        {
            return _name;
        }
        public void SetEmail(string email)
        {
            _email = email;
        }
        public string GetEmail()
        {
            return _email;
        }
        public void SetAge(int age)
        {
            _age = age;
        }
        public int GetAge()
        { 
            return _age; 
        }

        // Responsabilidad 1: Validar los datos del usuario
        public bool ValidateUser()
        {
            if (string.IsNullOrEmpty(GetName()) || GetName().Length < 2)
            {
                Console.WriteLine("Error: El nombre debe tener al menos 2 caracteres y es requerido");
                return false;
            }

            if (string.IsNullOrEmpty(GetEmail()) || !GetEmail().Contains("@"))
            {
                Console.WriteLine("Error: Email no válido");
                return false;
            }

            if (GetAge() < 0 || GetAge() > 100)
            {
                Console.WriteLine("Error: La edad debe estar entre 0 y 100 años");
                return false;
            }


            return true;
        }

        // Responsabilidad 2: Guardar el usuario en la Base de Datos
        public void SaveToDataBase()
        {
            // Simular el guardado en BD.
            Console.WriteLine($"Usuario: {GetName()} guardado en la Base de Datos");
            // Aqui iria la logica real para guardar los datos.
        }

        // Responsabilidad 3: Enviar un email de bienvenida al usuario
        public void SendWelcomeEmail()
        {
            // Simular el envio de un email
            Console.WriteLine($"Correo de bienvenida enviado a: {GetEmail()}");
            // Aquí iría la lógica real para enviar un correo.
        }

        // Responsabilidad 4: Generar un reporte del usuario
        public void GenerateUserReport()
        {
            Console.WriteLine("*********** REPORTE DEL USUARIO ***************");
            Console.WriteLine($"Nombre: {GetName()}");
            Console.WriteLine($"Email: {GetEmail()}");
            Console.WriteLine($"Edad: {GetAge()}");
            Console.WriteLine("**************************");
        }
    }


    public class Program
    {       
        static void Main(string[] args)
        {
            Console.WriteLine("EJEMPLO INCORRECTO DEL PRINCIPIO SOLID: SRP!");
            //User user = new User("John Doe", "johndoe@gmail.com", 30);
            var user = new User("John Doe", "johndoe@gmail.com", 30);

            if (user.ValidateUser())
            {
                user.SaveToDataBase();
                user.SendWelcomeEmail();
                user.GenerateUserReport();
            }

            Console.WriteLine("\nPresione una tecla para continuar");
            Console.ReadKey();
        }
    }


    
}
