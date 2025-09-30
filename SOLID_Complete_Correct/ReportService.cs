namespace SOLID_Complete_Correct;

//5. Aplicamos DIP. Usamos abstracciones en lugar de clases concretas
public class ReportService
{
    private readonly IFileSaver _fileSaver;
    private readonly IEmailSender _emailSender;

    // Inyección de dependencias por CONSTRUCTOR
    public ReportService(IFileSaver fileSaver, IEmailSender emailSender)
    {
        _fileSaver = fileSaver;
        _emailSender = emailSender;
    }

    public void ProcessReport (IReport report)
    {
        ReportGenerator generator = new ReportGenerator(report);
        generator.GenerateReport();
        _fileSaver.SaveToFile();
        _emailSender.SendEmail();
    }
}
