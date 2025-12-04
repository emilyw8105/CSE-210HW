public class Eternal : Goal
{
    private int _numCompleted;

    public Eternal(string Name, string Description, int Value) : base (Name, Description, Value)
    {
        
    }
    
    public override int Do_Goal()
    {
        _numCompleted++;
        return _value;
    }

    public override int Get_Score()
    {
        return _numCompleted * _value;
    }

    public override int GetNumCompleted()=>_numCompleted;
    
}