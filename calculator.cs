public class Calculator
{

    private string sName;

    public string name{ 
        get
            {if(string.IsNullOrEmpty(sName))
                {
                    sName = "DefaultCalculator";
                }
                else
                {
                    name = sName;
                }   
                return sName;
            }
        set{ sName = value; }
        }

    public int result { get; set; }

    
    public Calculator(string s)
    {
        name = s;
    }

    public Calculator()
    {
        name = "DefaultCalculator";
    }


    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public double Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }
        return a / b;
    }



    public enum OperationType
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }



    public int Calculate (int a, int b, OperationType operation)
    {
        switch (operation)
        {
            case OperationType.Add:
                return Add(a, b);
            case OperationType.Subtract:
                return Subtract(a, b);
            case OperationType.Multiply:
                return Multiply(a, b);
            case OperationType.Divide:
                return (int)Divide(a, b);
            default:
                throw new InvalidOperationException("Invalid operation type.");
        }
    }
}