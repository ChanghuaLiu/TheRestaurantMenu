namespace Ruber
{
    internal static class AdvancedConsole
    {
        internal static int ForceIntegerReadLine()
        {
            bool isNotValid = true;
            int result = 0;

            while (isNotValid)
            {
                isNotValid = !int.TryParse(Console.ReadLine(), out result);
                if (isNotValid)
                {
                    Console.WriteLine("Input should be an integer.");
                }
            }
            return result;
        }

        internal static int ForceIntegerReadLine(int min, int max)
        {
            bool isNotValid = true;
            int result = 0;

            while (isNotValid)
            {
                bool successfullyParsed = int.TryParse(Console.ReadLine(), out result);

                if (!successfullyParsed)
                {
                    Console.WriteLine("Input should be an integer.");
                    continue; //start from the loop again
                }

                if (result < min || result > max)
                {
                    Console.WriteLine($"The input should be between {min} and {max}");
                    continue;
                }

                isNotValid = false;
            }

            return result;
        }

        internal static bool ForceYesNoReadLine(string message)
        {
            Console.WriteLine(message + ". Enter Yes or No.");

            while (true)
            {
                string input = Console.ReadLine()?.ToLower();

                if (input == "yes")
                {
                    return true;
                }

                if (input == "no")
                {
                    return false;
                }

                Console.WriteLine("Please enter yes or no");
            }
        }



        internal static string ForceLowercase() // garbage
        {
            string input = Console.ReadLine();
            bool isNotValid = true;
            while (isNotValid)
            {
                int result = 0;
                bool inputIsNotString = int.TryParse(Console.ReadLine(), out result);
                return inputIsNotString.ToString();
                if (inputIsNotString)
                {
                    Console.WriteLine("Please enter yes or no.");
                    continue;
                }
                if (input.ToLower() != "yes" || input.ToLower() != "no")
                {
                    Console.WriteLine("Please enter yes or no.");
                    continue;
                }
                isNotValid = false;
            }
            input = input.ToLower();
            return input;
        }
    }
    //TODO Make something that can handle Yes, yes, yEs, No, NO, no
}

    
