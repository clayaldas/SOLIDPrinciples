namespace SOLID_Complete_Incorrect;

class Report
{
    public void GenerateReport (string reportType)
    {
        if (reportType == "PDF")
        {
            Console.WriteLine("Generando reporte en PDF...");
        }
        else
            if (reportType == "Excel")
        {
            Console.WriteLine("Generando reporte en Excel...");
        }
        else
        {
            Console.WriteLine("Tipo de reporte no válido");
        }
    }
    public void SaveToFile()
    {
        Console.WriteLine("Guardando reporte en un archivo...");
    }
    public void SendEmail()
    {
        Console.WriteLine("Enviando reporte via correo...");
    }
}
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Principios SOLID!");
        Console.WriteLine();

        Report report = new Report();

        report.GenerateReport("PDF");
        report.SaveToFile();
        report.SendEmail();

        Console.WriteLine("Presione una tecla para continuar");
        Console.ReadKey();
    }
}


// ERRORES EN EL CÓDIGO (VIOLACIONES DE LOS PRINCIPIOS SOLID
//1. S: Single Responsability Principle (SRP). 
//      - La clase "Report" tienes multiples responsabilades
//2. O: Open/Closed Principle (OCP): Si queremos agregar un nuevo tipo de reporte
//      (por ejemplo "word"), tendriamos que  modificar la clases "Report" y
//      el método "GenerateReport", violando el principio abierto/cerrado.
//3. L: Liskov Sustitution Principle (LSP): Si más adelante queremos crear una
//      clase derivada/hija (Report) que modifique el método "GenerateReport", podriamos romper
//      el comportamiento esperado (código no predecible).
//4. I: Interface Segregation Principle (ISP): La clase "Report" obliga a implementar todos los métodos 
//      (GenerateReport, SaveToFile, SendEmail), incluso si no son necesarios para ciertos tipos
//      de reportes.
//5. D. Dependency Inversion Principle (DIP): La clas program depende directamente de la implementación 
//      la clase "Report" en lugar de depender de una abstracción.

