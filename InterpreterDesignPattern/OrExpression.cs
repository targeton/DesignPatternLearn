namespace InterpreterDesignPattern
{
    public class OrExpression : Expression
    {
        private Expression _exp1;
        private Expression _exp2;
        public OrExpression(Expression exp1, Expression exp2)
        {
            _exp1 = exp1;
            _exp2 = exp2;
        }

        public override bool Interpret(string context)
        {
            return _exp1.Interpret(context) || _exp2.Interpret(context);
        }
    }
}