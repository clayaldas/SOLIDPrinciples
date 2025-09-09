namespace SRP_Single_Responsability_Principle_Correct;

#region Propiedades C# 2.0

/*
public class User
{
    private string _name;
    private string _email;
    private int _age;

    public User(string name, string email, int age)
    {
        _name = name;
        _email = email;
        _age = age;
    }

    // Setter and Getter (Propiedades-metodos)
    //public void SetName(string name)
    //{
    //    _name = name;
    //}
    //public string GetName()
    //{
    //    return _name;
    //}

    public string Name
    {
        set
        {
            _name = value;
        }
        get
        {
            return _name;
        }
    }

    //public void SetEmail(string email)
    //{
    //    _email = email;
    //}
    //public string GetEmail()
    //{
    //    return _email;
    //}
    public string Email
    {
        set
        {
            _email = value;
        }
        get 
        { 
            return 
                _email;
        }
    }

    //public void SetAge(int age)
    //{
    //    _age = age;
    //}
    //public int GetAge()
    //{
    //    return _age;
    //}

    public int Age
    {
        set
        {
            _age = value;
        }
        get
        { 
            return 
                _age; 
        }
    }
}
*/

#endregion

#region Propiedades automáticas C# 3.0

public class User
{
    public string Name { get; set; }//private string _name;
    public string Email { get; set; }//private string _email
    public int Age {  get; set; } //private int _age

    public User(string name, string email, int age)
    {
        Name = name;//setName(name)
        Email = email; //setEmail(email)
        Age = age;//setAge(age)
    }
}
#endregion

#region Constructores primarios C# 12

#endregion