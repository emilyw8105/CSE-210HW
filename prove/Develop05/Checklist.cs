using System.Reflection.Metadata.Ecma335;

public class Checklist : Goal
{
    private int _bonus;
    private int _required;
    private int _numCompleted;


    public Checklist(string Name, string Description, int Value, int Bonus, int Required, int numCompleted) : base (Name, Description, Value)
    {
        _bonus = Bonus;
        _required = Required;
        _numCompleted = numCompleted;

        if (_numCompleted >= _required)
            _isComplete = true;
        
    }


    public override int Get_Score()
    {
        int Score = _numCompleted * _value;
        if (_numCompleted >= _required)
            Score += _bonus;
        return Score;
    }
    public override int Do_Goal()
    {
        if (_isComplete)
            return 0;
        
        _numCompleted++;
        if (_numCompleted >= _required)
        {
            _isComplete = true;
            return _value + _bonus;
        }
        return _value;
    }

    public int GetBonus() => _bonus;
    public int GetRequired() => _required;
    public override int GetNumCompleted() => _numCompleted;
    

    
    
}