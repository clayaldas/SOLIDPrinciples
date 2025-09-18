namespace LSP_Liskov_Substitution_Principle_Incorrect;

// EJEMPLO INCORRECTO - Viola el principio de sustitución de Liskov

public class Rectangle
{
  public virtual int Width { get; set; }
  public virtual int Height { get; set; }

  public Rectangle(int width, int height)
  {
    Width = width;
    Height = height;
  }

  public virtual int CalculateArea()
  {
    return Width * Height;
  }

  public virtual void ShowInfo()
  {
    Console.WriteLine($"Rectángulo - Ancho: {Width}, Alto: {Height}, Área: {CalculateArea()}");
  }
}

// Esta clase VIOLA el LSP porque cambia el comportamiento esperado de Rectangle
public class Square : Rectangle
{
  public Square(int side) : base(side, side)
  {
  }

  // PROBLEMA: Al cambiar el ancho, también cambiamos el alto
  // Esto viola las expectativas de la clase Rectangle
  public override int Width
  {
    get { return base.Width; }
    set
    {
      base.Width = value;
      base.Height = value; // ¡Esto no es lo que espera el código cliente!
    }
  }

  // PROBLEMA: Al cambiar el alto, también cambiamos el ancho
  public override int Height
  {
    get { return base.Height; }
    set
    {
      base.Width = value; // ¡Esto tampoco es lo que espera el código cliente!
      base.Height = value;
    }
  }

  public override void ShowInfo()
  {
    Console.WriteLine($"Cuadrado - Lado: {Width}, Área: {CalculateArea()}");
  }
}
public class Program
{
  // Este método espera que un Rectangle se comporte como Rectangle
  static void TestRectangle(Rectangle rectangle)
  {
    Console.WriteLine("=== PROBANDO COMPORTAMIENTO ===");
    rectangle.ShowInfo();

    Console.WriteLine("Cambiando Width a 5...");
    rectangle.Width = 5;

    Console.WriteLine("Cambiando Height a 10...");
    rectangle.Height = 10;

    Console.WriteLine("Resultado esperado: Width=5, Height=10");
    rectangle.ShowInfo();
    Console.WriteLine();
  }
  static void Main(string[] args)
  {
    Console.WriteLine("=== EJEMPLO INCORRECTO - Violando LSP ===");

    Console.WriteLine("1. PROBANDO CON RECTÁNGULO NORMAL:");
    var rectangle = new Rectangle(3, 4);
    TestRectangle(rectangle); // Funciona como esperamos

    Console.WriteLine("2. PROBANDO CON CUADRADO (que hereda de Rectangle):");
    var square = new Square(3);
    TestRectangle(square); // ¡NO funciona como esperamos!

    Console.WriteLine("PROBLEMA: El Square no se puede sustituir por Rectangle");
    Console.WriteLine("porque cambia el comportamiento esperado.");
    Console.WriteLine("Cuando cambio Width, también cambia Height automáticamente.");
    Console.WriteLine("Esto VIOLA el principio de sustitución de Liskov");
  }
}
