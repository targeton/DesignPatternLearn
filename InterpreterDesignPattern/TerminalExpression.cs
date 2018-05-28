namespace InterpreterDesignPattern
{
    //终结符表达式类，实现与文法中的终结符相关联的解释器操作
    public class TerminalExpression : Expression
    {
        private string _data;
        public TerminalExpression(string data)
        {
            _data = data;
        }

        public override bool Interpret(string context)
        {
            if (context.Contains(_data))
                return true;
            return false;
        }
    }
}