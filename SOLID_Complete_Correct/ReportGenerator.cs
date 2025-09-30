namespace SOLID_Complete_Correct;

// 2. Aplicamos OCP: Podemos agregar mas formatos para los reportes
//    sin modificar el código existente.
public class ReportGenerator
{
    private readonly IReport _report;

    public ReportGenerator(IReport report)
    {
        _report = report;
    }

    public void GenerateReport()
    {
        _report.Generate();
    }
}
