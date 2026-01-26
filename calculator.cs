public class Calculator
{
    // Backing field for name
    private string _name;

    // Public property for calculator name
    public string Name
    {
        get
        {
            if (string.IsNullOrEmpty(_name))
                _name = "DefaultCalculator";

            return _name;
        }
        set
        {
            _name = value;
        }
    }

    // Constructor with name
    public Calculator(string name)
    {
        Name = name;
    }

    // Default constructor
    public Calculator()
    {
        Name = "DefaultCalculator";
    }

    // Supported operations
    public enum OperationType
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }

    // Individual operations
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;

    public int Divide(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException("Division by zero is not allowed.");

        return a / b;
    }

    // Central calculation method
    public int Calculate(int a, int b, OperationType operation)
    {
        return operation switch
        {
            OperationType.Add => Add(a, b),
            OperationType.Subtract => Subtract(a, b),
            OperationType.Multiply => Multiply(a, b),
            OperationType.Divide => Divide(a, b),
            _ => throw new InvalidOperationException("Invalid operation type")
        };
    }
}
