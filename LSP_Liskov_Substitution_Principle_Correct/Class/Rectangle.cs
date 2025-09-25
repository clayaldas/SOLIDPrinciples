using LSP_Liskov_Substitution_Principle_Correct.Interfaces;

namespace LSP_Liskov_Substitution_Principle_Correct.Class;

public sealed class Rectangle : IShape
{
    private int _width;
    private int _height;

    public Rectangle(int width, int height)
    {
        _width = width;
        _height = height;        
    }

    // Propiedades
    public int Width
    {
        get { 
            return _width; 
        }
        set {
            _width = value; 
        }
    }

    public int Height
    {
        get 
        { 
            return _height; 
        }
        set 
        { 
            _height = value; 
        }
    }
    public int CalculateArea()
    {
        return _width * _height;
    }

    public void ShowInformation()
    {
        Console.WriteLine($"Rectángulo - Ancho: {_width}, Alto: {_height}, Área: {CalculateArea()}");
    }
}
