namespace SOLID_Complete_Correct;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("PRINCIPIOS SOLID!");
        Console.WriteLine();

        IReport report = new PdfReport();
        IFileSaver fileSaver = new FileServer();
        IEmailSender emailSender = new EmailSender();

        ReportService reportService = new ReportService(fileSaver, emailSender);
        reportService.ProcessReport(report);

        // REFACTORIZACIÓN DE CODIGO
        // 1. SRP. Ahora tenemos varias clases (PdfReport, ExcelReport, FileServer, EmailServer)
        //    con una responsabilidad y una sola clase Report) que hacía varias funciones
        //    Ahora cada clase tiene una unica responsabilidad.
        // 2. OCP. Ahora la clase "ReportGenerator) usa "IReport", lo que permite agregar nuevos
        //    formatos de reportes sin modificar el codigo existente.
        // 3. LSP. Las clases "PdfReport, ExcelReport" heredan de "IReport" y pueden sustituir a 
        //    a las herdades.
        // 4. ISP: La separación de "IFileServer y IEmailServer" evita que clases heredades implementen
        //    codigo innecesario.
        // 5. DIP: "ReportService" clase de alto nivel no depende de clases
        //    concretas (FileServer, EmailServer) sino de interfaces lo que
        //    permite mayor flexibilidad (codigo modular, reutilizable y extensible).

    }
}
