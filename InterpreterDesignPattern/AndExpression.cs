namespace InterpreterDesignPattern
{
    // 非终结符表达式类，为文法中的非终结符实现解释操作，对文法中的每一条规则都需要一个具体的非终结符表达式
    public class AndExpression : Expression
    {
        private Expression _exp1;
        private Expression _exp2;
        public AndExpression(Expression exp1, Expression exp2)
        {
            _exp1 = exp1;
            _exp2 = exp2;
        }

        public override bool Interpret(string context)
        {
            return _exp1.Interpret(context) && _exp2.Interpret(context);
        }
    }
}