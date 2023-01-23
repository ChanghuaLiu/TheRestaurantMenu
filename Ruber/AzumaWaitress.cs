using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruber
{
    internal static class AzumaWaitress
    {

        internal static decimal DoOrderRoutine(Menu normalMenu, int orderNumberMin, int orderNumberMax)
        {
            decimal totalPrice = 0;
            bool shouldKeepOrdering = true;

            while (shouldKeepOrdering)
            {
                Console.WriteLine("Enter a dish number to order: ");

                totalPrice += normalMenu.Match(AdvancedConsole.ForceIntegerReadLine(orderNumberMin, orderNumberMax));

                shouldKeepOrdering = AdvancedConsole.ForceYesNoReadLine("Do you want to continue?");
            }

            return totalPrice;

        }

    }
}
