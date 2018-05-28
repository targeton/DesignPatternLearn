using System;

namespace InterpreterDesignPattern
{
    class Program
    {
        // 规则： Robert和John是男性
        public static Expression GetMaleExpression()
        {
            Expression robert = new TerminalExpression("Robert");
            Expression john = new TerminalExpression("John");
            return new OrExpression(robert, john);
        }

        // 规则：Julie是一个已婚的女性
        public static Expression GetMarriedWomanExpression()
        {
            Expression julie = new TerminalExpression("Julie");
            Expression married = new TerminalExpression("Married");
            return new AndExpression(julie, married);
        }
        static void Main(string[] args)
        {
            /*
            # 解释器模式
                给定一个语言，定义它的文法的一种表示，并定义一个解释器，这个解释器使用该表示来解释语言中的句子。
            
            ## 应用场景
                如果一种特定类型的问题发生的频率足够高，那么可能就值得将该问题的各个实例表述为一个简单语言中的句子。
                这样就可以构建一个解释器，该解释器通过解释这些句子来解决该问题。

                当有一个语言需要解释执行，并且你可将该语言中的句子表示为一个抽象语法树时，可使用解释器模式。
                使用解释器模式，意味着可以很容易地改变和扩展文法，因为该模式使用类来表示文法规则，可以使用继承来改变或扩展该文法，
                也比较容易实现文法，因为定义抽象语法树中各个节点的类的实现大体类似，这些类都易于直接编写。

             */

            Expression isMale = GetMaleExpression();
            Expression isMarriedWoman = GetMarriedWomanExpression();
            System.Console.WriteLine("John is male? {0}",isMale.Interpret("John")); 
            System.Console.WriteLine("Julie is a married women? {0}",isMarriedWoman.Interpret("Julie Married"));
        }
    }
}
