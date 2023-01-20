using Ruber;
decimal totalPrice = 0;
decimal difference = 0;
Console.WriteLine(">>>Enjoy 20% OFF when spending over £40<<<");
Console.WriteLine(">>>PRINTING NORMAL MENU<<<");

Menu normalMenu = new Menu(false);
normalMenu.PrintMenu();

Console.WriteLine("\n\n>>>PRINTING VEGETERIAN MENU<<<");
Menu vegeterianMenu = new Menu(true);
vegeterianMenu.PrintMenu();

Console.WriteLine("Enter a dish number to order: ");
totalPrice = normalMenu.Match(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Do you want to continue? Enter Yes or No");
int loop = 1;
int loop1 = 1;
int loop2 = 1;
int loop3 = 1;
while (loop3 == 1)
    if (Console.ReadLine() == "Yes")
    {
        while (loop == 1)
        {
            Console.WriteLine("Enter a dish number to order: ");
            totalPrice += normalMenu.Match(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Do you want to continue? Enter Yes or No");
            if (Console.ReadLine() == "Yes")
            {
                loop = 1;
            }
            else
            {
                loop = 0;
            }
        }
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
                        totalPrice += normalMenu.Match(Convert.ToInt32(Console.ReadLine()));
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
                    totalPrice += normalMenu.Match(Convert.ToInt32(Console.ReadLine()));
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




















