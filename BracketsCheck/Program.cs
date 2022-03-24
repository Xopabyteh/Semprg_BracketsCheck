// ( { [ ] } )
// ( -> push
// ) -> pop

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
