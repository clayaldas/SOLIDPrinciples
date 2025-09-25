using LSP_Liskov_Substitution_Principle_Correct.Interfaces;

namespace LSP_Liskov_Substitution_Principle_Correct.Class;

public class Square : IShape
{
    private int _side;

    public Square(int side)
    {
        _side = side;        
    }

    // Propiedades
    public int Side
    {
        get 
        { 
            return _side; 
        }
        set 
        { 
            _side = value; 
        }
    }
    public int CalculateArea()
    {
        return _side * _side;
    }

    public void ShowInformation()
    {
        Console.WriteLine($"Cuadrado-Lado: {_side}, Área: {CalculateArea()}");
    }
}
