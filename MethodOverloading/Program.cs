//-JESUS
namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {

            var sum = Add(4, 3);
            var answer = Add(4.3, 6.8);
            var total=Add(5,3,true);
            var deTotal = Add(6.5m, 7.9m);
        }


        static int Add(int num1, int num2)
        {

            return num1 + num2;


        }

        static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;

        }

        //-Be careful and be aware of waht you are returning in the method, check if it is an integer or double or bool, just cause it is a method overload deosnt mean to copy everythign exactly or that wioll result in errors. 
        static double Add(double number1, double number2)
        {

            return number1 + number2;

        }

        //-Make sure the parenthesis thingy allign with the if statemtn lol
       //-Or else that will result in super ocnfusing errors

        static string Add(int numba1, int numba2, bool dollars)
        {
            if (dollars)
            {
                var answer = numba1 + numba2;

                if (answer == 1)
                {
                    return ($"{answer}dollar");
                }

                else
                {

                    return ($"{answer} dollars");

                }
            }
            else
            {
                return null;

            }



        }
    }
}


