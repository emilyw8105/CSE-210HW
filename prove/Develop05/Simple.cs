public class Simple : Goal
{
    public Simple(string Name, string Description, int Value) : base (Name, Description, Value)
    {
        
    }
    public override int Do_Goal()
    {
        
        if (!_isComplete)
        {
            _isComplete = true;
            return _value;
            
        }
        return 0;
    }

    public override int Get_Score()
    {
        if (_isComplete == true)
            return _value;
        else
        return 0;
    }
}