using System;
using static System.Console;
namespace SingleVertBarAgainstDoubleVertBar{
    class Program{
        static void Main(string[] args){
            //outputs : Evaluating first condition Evaluating second condition
            bool result_1 = EvaluateFirstCondition() | EvaluateSecondCondition();
            WriteLine("*******************************************************************");
            //outputs : Evaluating first condition
            bool result_2 = EvaluateFirstCondition() || EvaluateSecondCondition();
        }
        static bool EvaluateFirstCondition(){
            WriteLine("Evaluating first condition");
            return true;
        }
        static bool EvaluateSecondCondition()
        {
            WriteLine("Evaluating second condition");
            return false;
        }
    }
}