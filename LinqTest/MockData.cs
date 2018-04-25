using System.Collections.Generic;
public class MockData
{
    public static List<Info> GetInfos(){
        Info info1 = new Info(){
        Name = "hehe",
        Id = 0,
        Details = new System.Collections.Generic.List<Detail>(){
            new Detail(){
                name ="eod",
                origin = 2,
                current = 4,
                values = new System.Collections.Generic.Dictionary<string, double>{
                    {"per",0.05}
                }
            },
            new Detail(){
                origin = 4,
                current = 5,
                values = new System.Collections.Generic.Dictionary<string, double>{
                    {"per",0.1}
                }
            },
            new Detail(){
                origin = 4,
                current = 5,
                values = new System.Collections.Generic.Dictionary<string, double>{
                    {"per",0.7}
                }
            }
        }
    };
    Info info2 = new Info(){
        Name = "haha",
        Id = 1,
        Details = new System.Collections.Generic.List<Detail>(){
            new Detail(){
                origin = 2,
                current = 4,
                values = new System.Collections.Generic.Dictionary<string, double>{
                    {"per",0.05}
                }
            },
            new Detail(){
                origin = 4,
                current = 5,
                values = new System.Collections.Generic.Dictionary<string, double>{
                    {"per",0.1}
                }
            },
            new Detail(){
                name ="eod",
                origin = 4,
                current = 5,
                values = new System.Collections.Generic.Dictionary<string, double>{
                    {"per",0.7}
                }
            }
        }
    };
        return new List<Info>(){info1,info2};
    }
    
}