using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    public void AddGoal(Goal g)
    {
        _goals.Add(g);
    }

    public int Get_Score()
    {
        int total = 0;
        foreach (Goal g in _goals)
            total += g.Get_Score();
        return total;
    }

    public Goal GetGoal(int index) => _goals[index];
    public int Count() => _goals.Count;
    public int getScore() => _score;
    public void setScore(int value) => _score = value;
    public void AddScore(int value) => _score += value;

    public void Save(string filename)
    {
        List<string> lines = new List<string>();

        lines.Add($"{_score}");

        foreach (Goal g in _goals)
        {
            if (g is Simple s)
                lines.Add($"Simple|{s.GetName()}|{s.GetDescription()}|{s.GetValue()}|{s.IsComplete()}");
            else if (g is Eternal e)
                lines.Add($"Eternal|{e.GetName()}|{e.GetDescription()}|{e.GetValue()}");
            else if (g is Checklist c)
                lines.Add($"Checklist|{c.GetName()}|{c.GetDescription()}|{c.GetValue()}|{c.GetBonus()}|{c.GetRequired()}|{c.GetNumCompleted()}");
        }
        File.WriteAllLines(filename, lines);
    }

    public void Load(string filename)
    {
        if (!File.Exists(filename)) return;

        _goals.Clear();
        var lines = File.ReadAllLines(filename);


        foreach (var line in lines)
        {
            var p = line.Split('|');
            switch (p[0])
            {
                case "Score":
                    _score = int.Parse(p[1]);
                    break;
                case "Simple":
                    var s = new Simple(p[1], p[2], int.Parse(p[3]));
                    s.Set_Complete(bool.Parse(p[4]));
                    _goals.Add(s);
                    break;
                case "Eternal":
                    
                    var e = new Eternal(p[1], p[2], int.Parse(p[3]));
                    _goals.Add(e);
                    break;
                case "Checklist":
                    int value = int.Parse(p[3]);
                    int bonus = int.Parse(p[4]);
                    int required = int.Parse(p[5]);
                    int NumCompleted = int.Parse(p[6]);
                    var c = new Checklist(p[1], p[2], value, bonus, required, NumCompleted);
                    _goals.Add(c);
                    break;
                default:
                    break;
            }
        }
    }
}