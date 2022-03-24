namespace BracketsCheck;
/// <summary>
/// Omezte se na implementaci, která nepoužívá žádné pokročilejší datové struktury než je prosté pole.
/// </summary>

public class StringBasedBracketChecker : BracketChecker
{
    protected override bool Test(string inp)
    {
        for (int i = 0; i < inp.Length; i++)
        {
            char current = inp[i]; 
            
            foreach ((char, int) valueTuple in OpeningBracketsTuple)
            {
                //Case opening bracket
                if (valueTuple.Item1.Equals(current))
                {
                    bool foundLastBracket = false;
                    for (int j = inp.Length-1; j > i; j--)
                    {
                        char fromBack = inp[j];
                        foreach ((char, int) endTuple in ClosingBracketsTuple)
                        {
                            //Case closing bracket
                            if (endTuple.Item1.Equals(fromBack))
                            {
                                if (endTuple.Item2 != valueTuple.Item2)
                                {
                                    return false;
                                }

                                inp = inp.Remove(j, 1);
                                foundLastBracket = true;
                                break;
                            }
                        }
                        if (foundLastBracket)
                        {
                            break;
                        }
                    }
                    break;
                }
            }
        }
        return true;
    }
}