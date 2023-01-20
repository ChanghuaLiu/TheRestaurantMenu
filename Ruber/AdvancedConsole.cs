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
            }

            Console.Clear();

            return result;
        }

       
        internal static int ForceIntegerReadLine(int min, int max)
        {
            bool isNotValid = true;
            int result = 0;

            while (isNotValid)
            {
                if(int.TryParse(Console.ReadLine(), out result))
                {
                    if (result >= min && result <= max)
                    {
                        isNotValid = false;
                    }
                }
            }

            return result;
        }


        //TODO Make something that can handle Yes, yes, yEs, No, NO, no
    }



}
