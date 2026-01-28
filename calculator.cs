

namespace CalculatorDomainDemo;

/// <summary>
/// This class represents the DOMAIN BEHAVIOUR.
/// 
/// In real systems:
/// - This is where rules live
/// - This is where decisions are made
/// 
/// In the booking system, this is similar to:
/// - Booking management logic
/// </summary>
public class Calculator
{
    
    public int LastResult { get; private set; }

   
    public string Name { get; }

    public Calculator(string name)
    {
        // Guard clause:
        // We do NOT allow invalid objects to exist.
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Calculator must have a name");

        Name = name;
    }

   public IReadOnlyList<CalculationRequest> GetHistory()
    {
        return _History.ToList();
    }
   

    public int Calculate(int a, int b, OperationType operation)
    {
        // Switch expression ensures ALL enum cases are handled
        LastResult = operation switch
        {
            OperationType.Add => a + b,
            OperationType.Subtract => a - b,
            OperationType.Multiply => a * b,
            OperationType.Divide => a / b,

            // This should never happen if enums are used correctly
            _ => throw new InvalidOperationException("Invalid operation")
        };
        
        // Record the calculation in history
        CalculationRequest record = new CalculationRequest(a, b, operation);
        _History.Add(record);

        return LastResult;
    }

 /// fields    
    private readonly List<CalculationRequest> _History = new List<CalculationRequest>();   
    public IReadOnlyList<CalculationRequest> History 
        {
                get { return _History.AsReadOnly(); }

        }
                //=> _History.AsReadOnly();

    //how many operations were done in the calculator
    /*public List<CalculationRequest> GetAdditionHistory()
    {
        List<CalculationRequest> additionHistory = new List<CalculationRequest>();
        foreach (var record in _History)
        {
            if (record.Operation == OperationType.Add)
            {
                additionHistory.Add(record);
            }
        }
        return additionHistory;
    }*/
    //Same method using LINQ
    public List<CalculationRequest> GetAdditionHistory()
    {
        if(_History.Any(r => r.B == 0))
        {
            
        }
        else

        List<CalculationRequest> req = new List<CalculationRequest>();
        
        req = _History.Where(r => r.Operation == OperationType.Add).ToList();

        return req;
    }

    //Same method using LINQ for divide
    public List<CalculationRequest> GetDivideHistory()
    {   

        List<CalculationRequest> req = new List<CalculationRequest>();
        
        req = _History.Where(r => r.Operation == OperationType.Divide).ToList();

        return req;
    }

    public bool HasDivision()
    {
        bool hasDivision = _History.Any(r => r.Operation == OperationType.Divide);
        return hasDivision;
    }

    public double Divide(CalculationRequest request)
    {
        if (request.B == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        else
        {
            return request.A / request.B;
        }

        return (double)request.A / request.B;
    }


    public CalculationRequest? GetLastMultiplication()
    {
       return _History.LastOrDefault = _History.where(r => r.OperationType.Multiply.LastOrDefault); 

    }


       public Dictionary<OperationType, List<CalculationRequest>> grouped()
    {
        Dictionary<OperationType, List<CalculationRequest>> grouped = 
        new Dictionary<OperationType, List<CalculationRequest>>();

        foreach (CalculationRequest req in _History)
        {
            if (!grouped.ContainsKey(req.Operation))
            {
                grouped[req.Operation] = new List<CalculationRequest>();
            }
            grouped[req.Operation].Add(req);
        }

        return grouped;
    }
    //method to save history to a file
    public async Task SaveHistoryAsync(string filepath)
    {
        List<CalculationRequest> snapShot = _History.ToList();
        string json = JsonSerializer.Serialize(snapShot);
        await File.WriteAllTextAsync (filepath, json);
    }

    //method to save last calculation to a file
    public async Task SaveLastAsync(string filepath)
    {
        if (!_History.Any())
        {
            throw new InvalidOperationException("No calculations in history to save.");
        }
        CalculationRequest lastCalculation = _History.Last();
        string json = JsonSerializer.Serialize(lastCalculation);
        await File.WriteAllTextAsync(filepath, json);
    }

    //method to save history to a file
    public async Task SaveHistoryAsync(string filepath)
    {
        List<CalculationRequest> snapShot = _History.ToList();
        string json = JsonSerializer.Serialize(snapShot);
        await File.WriteAllTextAsync (filepath, json);
    }
        public async Task SaceLastAsync (string filepath);
        {
            List<CalculationRequest> snapShot = _History.ToList();
            
            string json = json.Filter.serialize(snapShot);
            await file.writealllast(filepath json);
        }
        //method to get history from a file
        public async Task<List<CalculationRequest>> GetHistoryAsync(string filepath)
        {
            if (File.Exists(filepath))
            {
                string json = await File.ReadAllTextAsync(filepath);
                List<CalculationRequest> history = JsonSerializer.Deserialize<List<CalculationRequest>>(json);
                return history ?? new List<CalculationRequest>();
            }
            else
            {
                throw new InvalidOperationException("File not found.");
            }
        }
        
}



/*
public CalculationRequest GetLastCalculation()
    {
        
        if(!_History.Any())
        {
            throw new InvalidOperationException("There is no calculations in history.");
        }
        else
        {
            return _History.Last();
        }

        //Handling the GetLastcalculation exception
        
        try
        {
            CalculationRequest request = calculator
            Console.WriteLine($" this is the last operation  performed" + );
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("No calculations in history.");
        }

        /*
        return request;
        
        if (_History.Count == 0)
        {
            return null;
        }
        return _History[_History.Count - 1];*/
    

