using BracketsCheck;

BracketChecker bc = new BracketChecker();
bc.WriteTest("{[()]}", true);
bc.WriteTest("{(})", false);
bc.WriteTest("{[(])}", false);
bc.WriteTest("{{[[(())]]}}", true);
bc.WriteTest("(){}[]", true);
bc.WriteTest("(]", false);
bc.WriteTest("[(])", false);
bc.WriteTest("[({})](]", false);
bc.WriteTest("", true);
bc.WriteTest("pepa", true);
bc.WriteTest("(pepa)", true);
bc.WriteTest("10 * [123 + 7 (6 + 2)]", true);
bc.WriteTest("10 * [123 + 7 (6 + 2))", false);

Console.WriteLine();

StringBasedBracketChecker sbc = new StringBasedBracketChecker();
sbc.WriteTest("{[()]}", true);
sbc.WriteTest("()()", true);
sbc.WriteTest("{(})", false);
sbc.WriteTest("{[(])}", false);
sbc.WriteTest("{{[[(())]]}}", true);
sbc.WriteTest("(){}[]", true);
sbc.WriteTest("(]", false);
sbc.WriteTest("[(])", false);
sbc.WriteTest("[({})](]", false);
sbc.WriteTest("", true);
sbc.WriteTest("pepa", true);
sbc.WriteTest("(pepa)", true);
sbc.WriteTest("10 * [123 + 7 (6 + 2)]", true);
sbc.WriteTest("10 * [123 + 7 (6 + 2))", false);