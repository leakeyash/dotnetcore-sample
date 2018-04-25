using System.Collections.Generic;
public class Info
{
    public int Id{get;set;}
    public string Name{get;set;}
    public List<Detail> Details{get;set;}

    public override string ToString(){
        return $"Id:{Id}, Name:{Name}, Details: {Details}";
    }
}

public class Detail
{
    public string name{get;set;}
    public object origin{get;set;}
    public object current{get;set;}
    public Dictionary<string,double> values{get;set;}
}