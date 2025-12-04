abstract public class Goal
{
    protected string _name;
    protected string _description;
    protected int _value;
    protected bool _isComplete;


    public Goal(string Name, string Description, int Value)
    {
        _name = Name;
        _description = Description;
        _value = Value;
    }

    public string GetName() => _name;
    public string GetDescription() => _description;
    public int GetValue() => _value;
    public bool IsComplete() => _isComplete;

    
    public virtual int GetNumCompleted() => 0;

    public abstract int Do_Goal();
    public abstract int Get_Score();

    public void Set_Complete(bool value) => _isComplete = value;
        
}