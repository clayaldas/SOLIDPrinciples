namespace SOLID_Complete_Correct;

//4. Aplicamos LSP. Cada clase derivada sigue funcionando sin romper el}
//   comportamiento esperado.
//   Una clase base/padre puede reemplazar a una clase hija.
public class FileServer : IFileSaver
{
    public void SaveToFile()
    {

        Console.WriteLine("Guardando reporte en un archivo...");
    }
}
