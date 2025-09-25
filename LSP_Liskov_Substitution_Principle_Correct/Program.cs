//using System.Drawing;

using LSP_Liskov_Substitution_Principle_Correct.Class;
using LSP_Liskov_Substitution_Principle_Correct.Interfaces;

namespace LSP_Liskov_Substitution_Principle_Correct;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("************* EJEMPLO CORRECTO APLICANDO LSP *****************");
        Console.WriteLine();
        // Crear diferentes figuras
        Rectangle rectangle = new Rectangle(4, 6);
        //IShape rectangleExample = new Rectangle(4, 6);
        //// Parametros con o por nombre
        //Rectangle rectangle = new Rectangle(width: 4, height: 6);

        // var: Inferir el tipo de objeto:
        var square = new Square(5);

        Console.WriteLine("***** RECTANGULO *******");
        // Utilizar Rectangle con IShape
        IShape shape = rectangle;
        shape.ShowInformation();

        IShape shape1 = square;
        shape1.ShowInformation();

        // Modificar los valores para el Rectangulo
        rectangle.Width = 10;//set
        int height = rectangle.Height;//get
        //rectangle.SetWidth(10);
        //int height = rectangle.GetHeight();//get

        rectangle.Height = 6;
        rectangle.ShowInformation();

        // Modificar los valores para el Cuadrado
        square.Side = 10;
        square.ShowInformation();
    }
}
