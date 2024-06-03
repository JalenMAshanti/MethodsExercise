using System.Reflection.Metadata.Ecma335;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Madlib Excercise
            StoryGenerator();


            // Calling Calculator method: this method requires one string and int params. the string must be one of the follow ( "+"  "-"   "/"   "*")
            Console.WriteLine(Calculate("-", 5, 5, 3, 1));
        }

        public static void StoryGenerator() 
        {

            Console.WriteLine("Enter a name: ");
            string name = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Enter your favorite color: ");
            string color = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter your favorite animal: ");
            string animal = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter your favorite band: ");
            string band = Console.ReadLine();
            Console.Clear();

            

            string story = $"Once upon a time there was ninja named {name}. {name} did not like wearing black so they picked out a {color} colored outfit. " +
                $"\n{name} was excited to dress up to see their favorite band {band}. {name} walked to the ticket counter and the operator was a {animal}.";

            Console.WriteLine(story);
        }


        public static int Calculate(string op, params int[] nums) 
        {
            int result = nums[0];

            if (op == "+")
            {
           
                for (int i = 1; i < nums.Length; i++)
                {
                    result += nums[i];
                }
               
            }

            else if (op == "-")
            {

                for (int i = 1; i < nums.Length; i++)
                {
                    result -= nums[i];
                }

            }
            else if (op == "*")
            {


                for (int i = 1; i < nums.Length; i++)
                {
                    result *= nums[i];
                }

            }
            else if (op == "/")
            {
                for (int i = 1; i < nums.Length; i++)
                {
                    result /= nums[i];
                }
            }
            else {

                Console.WriteLine("Invalid Operator please use ( + , - , * , /)");
            }

            return result;  

           
        }


        
     

    }
}
