using System.Xml.Linq;

namespace LSP_Liskov_Substitution_Principle_Incorrect;

// EJEMPLO INCORRECTO - Viola el principio de sustitución de Liskov
//
// El principio de LSP indica que:
// "Los objetos de una clase derivada/hija deben poder reemplazar a los objetos
// de su clase base/padre sin alterar el correcto funcionamiento del programa".
//
// En otras palabras:
// a) Si tenemos un objeto base/padre de tipo Rectangle, y una clase hija
//    Square, deberíamos poder usar un objeto de tipo Square donde se espera
//    un objeto de tipo Rectangle sin romper la lógica del programa.
// b) Si la herencia rompe el comportamiento esperado, se viola el LSP.
public class Rectangle
{
  protected int _width;
  protected int _height;

  public Rectangle(int width, int height)
  {
    _width = width;
    _height = height;
  }

  public virtual int GetWidth()
  {
    return _width;
  }

  public virtual void SetWidth(int width)
  {
    _width = width;
  }

  public virtual int GetHeight()
  {
    return _height;
  }

  public virtual void SetHeight(int height)
  {
    _height = height;
  }

  public virtual int CalculateArea()
  {
    return _width * _height;
  }

  public virtual void ShowInfo()
  {
    Console.WriteLine($"Rectángulo - Ancho: {_width}, Alto: {_height}, Area: {CalculateArea()}");
    //Console.WriteLine($"Area: {CalculateArea()}");
  }
}

// Esta clase VIOLA el principio LSP porque la clase heredada/hija (Square) no se puede sustituir
// correctamente por la clase base/padre (Rectangle)
public class Square : Rectangle
{
  // Utilizar el constructor de la clase base/padre que tiene 2 parametros 
  //  (int width, int height)
  public Square(int side) : base(side, side)
  {
    // En Java sería: super(side, side);
  }

  // PROBLEMA: Al cambiar ancho (width), también se debe cambiar el alto (height)
  //           para que sea un cuadrado.
  // Esto NO es el comportamiento esperado para un Rectangle
  public override void SetWidth(int width)
  {
    _width = width;
    _height = width; // ¡Esto rompe las expectativas!
  }

  // PROBLEMA: Al cambiar el alto (height), también se debe cambiar el ancho (width)
  //           para que sea un cuadrado
  // Esto NO es el comportamiento esperado para un Rectangle
  public override void SetHeight(int height)
  {
    _width = height; // ¡Esto también rompe las expectativas!
    _height = height;
  }

  // Redefinimos el método para que muestre los datos de un cuadrado
  public override void ShowInfo()
  {
    Console.WriteLine($"Cuadrado  - Lado: {_width}, Area: {CalculateArea()}");
  }
}

class Program
{
  // Este método espera que un (Rectangle) se comporte como Rectangle
  // Es decir, que width y height sean propiedades independientes
  static void TestRectangle(Rectangle rectangle)
  {
    Console.WriteLine("=== PROBANDO EL COMPORTAMIENTO ===");
    Console.WriteLine("Datos iniciales");
    rectangle.ShowInfo();

    // Esperamos poder cambiar width sin afectar height
    Console.WriteLine("Se cambia el ancho a 5...");
    rectangle.SetWidth(5);

    // Esperamos poder cambiar height sin afectar width
    Console.WriteLine("Se cambia el alto a 10...");
    rectangle.SetHeight(10);

    Console.WriteLine($"RESULTADOS ESPERADOS: con Ancho=5, Alto=10, Area=50");
    Console.WriteLine("Datos luego del cambio realizado");
    rectangle.ShowInfo();
    Console.WriteLine();
  }

  static void Main(string[] args)
  {
    Console.WriteLine("=== EJEMPLO INCORRECTO - Violando el principio LSP ===");
    Console.WriteLine();

    Console.WriteLine("1. CON UN RECTÁNGULO NORMAL:");
    var rectangle = new Rectangle(3, 4);
    TestRectangle(rectangle); // Funciona como esperamos

    Console.WriteLine("2. CON UN SQUARE (que hereda de Rectangle):");
    Rectangle square = new Square(3); // ¡NO funciona como esperamos!
    // NOTA: Aquí se sustituye la clase padre (Rectangle) por la clase hija (Square)
    TestRectangle(square); // ¡NO funciona o no se comporta como esperamos!

    Console.WriteLine("PROBLEMA:");
    Console.WriteLine("El objeto Square se puede sustituir por el objeto Rectangle");
    Console.WriteLine("pero el objeto Square no se COMPORTA como un objeto Rectangle");
    Console.WriteLine("porque cambia el comportamiento esperado de un Rectangle.");
    Console.WriteLine("Cuando se cambia el Width, también se cambia el Height automáticamente.");
    Console.WriteLine("Por lo tanto no se cumple con el principio de sustitución de Liskov");

    Console.WriteLine("\nPresione cualquier tecla para continuar...");
    Console.ReadKey();
  }
}

