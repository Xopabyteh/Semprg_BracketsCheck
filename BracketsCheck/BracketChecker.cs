using System.Linq;

namespace BracketsCheck;

public class BracketChecker
{
    protected static readonly (char, int)[] OpeningBracketsTuple = new (char, int)[]
    {
        ('(',1),
        ('[',2),
        ('{',3)
    };
    protected static readonly (char, int)[] ClosingBracketsTuple = new (char, int)[]
    {
        (')',1),
        (']',2),
        ('}',3)
    };
    protected virtual bool Test(string inp)
    {
        Stack<int> bracketIDStack = new Stack<int>();
        foreach (var c in inp)  
        {

            //Case opening bracket
            foreach ((char, int) valueTuple in OpeningBracketsTuple)
            {
                if (valueTuple.Item1.Equals(c))
                {
                    bracketIDStack.Push(valueTuple.Item2);
                    break;
                }
            }
            //Case closing bracket
            foreach (var valueTuple in ClosingBracketsTuple)
            {
                if (valueTuple.Item1.Equals(c))
                {
                    int lastBrackedID = bracketIDStack.Pop();
                    if (lastBrackedID != valueTuple.Item2)
                    {
                        return false;
                    }
                }
            }
        }
        return true;
    }

    public void WriteTest(string inp, bool expected)
    {
        bool result = Test(inp);
        string msg = string.Empty;
        if (expected == result)
        {
            msg = "SUCCESS";
            Console.BackgroundColor = ConsoleColor.DarkGreen;
        }
        else
        {
            msg = "FAIL";
            Console.BackgroundColor = ConsoleColor.DarkRed;
        }
        Console.WriteLine($"{msg.PadRight(15)} inp: {inp}, expect: {expected}, result: {result}");
        Console.BackgroundColor = ConsoleColor.Black; 
    }
}