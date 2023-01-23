using Ruber;
decimal totalPrice = 0;
decimal difference = 0;
int orderNumberMin = 1;
int orderNumberMax = 7;
Console.WriteLine(">>>Enjoy 20% OFF when spending over £40<<<");
Console.WriteLine(">>>PRINTING NORMAL MENU<<<");

Menu normalMenu = new Menu(false);
normalMenu.PrintMenu();

Console.WriteLine("\n\n>>>PRINTING VEGETERIAN MENU<<<");
Menu vegeterianMenu = new Menu(true);
vegeterianMenu.PrintMenu();


int loop = 1;
int loop1 = 1;
int loop2 = 1;


if (AdvancedConsole.ForceYesNoReadLine("Do you want to order?"))
{



    totalPrice = AzumaWaitress.DoOrderRoutine(normalMenu, orderNumberMin, orderNumberMax);











    if (totalPrice > 40)
    {
        totalPrice = totalPrice - totalPrice * 20 / 100;
    }
    else
    {
        while (loop2 == 1)
        {
            difference = 40 - totalPrice;
            Console.WriteLine($"Only £{difference} left you can enjoy our 20% off.");
            Console.WriteLine("Do you want to order more? Enter Yes or No");
            if (Console.ReadLine() == "Yes")
            {
                while (loop1 == 1)
                {
                    Console.WriteLine("Enter a dish number to order: ");
                    totalPrice += normalMenu.Match(AdvancedConsole.ForceIntegerReadLine(orderNumberMin, orderNumberMax));
                    Console.WriteLine("Do you want to continue? Enter Yes or No");
                    if (Console.ReadLine() == "Yes")
                    {
                        loop1 = 1;
                    }
                    else
                    {
                        loop1 = 0;
                    }
                }
                if (totalPrice > 40)
                {
                    totalPrice -= totalPrice * 20 / 100;
                    loop2 = 0;
                }
                else
                {
                    loop2 = 1;
                    loop1 = 1;
                }
            }
            else
            {
                loop2 = 0;
                Console.WriteLine($"Total price: £{totalPrice}");
            }
        }
    }
    Console.WriteLine($"Total price: £{totalPrice}");
}
else
{
    while (loop2 == 1)
    {
        difference = 40 - totalPrice;
        Console.WriteLine($"Only £{difference} left you can enjoy our 20% off.");
        Console.WriteLine("Do you want to order more? Enter Yes or No");
        if (Console.ReadLine() == "Yes")
        {
            while (loop1 == 1)
            {
                Console.WriteLine("Enter a dish number to order: ");
                totalPrice += normalMenu.Match(AdvancedConsole.ForceIntegerReadLine(orderNumberMin, orderNumberMax));
                Console.WriteLine("Do you want to continue? Enter Yes or No");
                if (Console.ReadLine() == "Yes")
                {
                    loop1 = 1;
                }
                else
                {
                    loop1 = 0;
                }
            }
            if (totalPrice > 40)
            {
                totalPrice -= totalPrice * 20 / 100;
                loop2 = 0;
            }
            else
            {
                loop2 = 1;
                loop1 = 1;
            }
        }
        else
        {
            loop2 = 0;
            Console.WriteLine($"Total price: £{totalPrice}");
        }
    }

}



















