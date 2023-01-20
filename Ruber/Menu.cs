using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruber
{
    public class Menu
    {
        //declare and initialize our list 
        //property accessor, get and private set
        public List<Dish> Dishes = new List<Dish>();
        public Menu(bool isVegeterian)
        {
            
            Dishes.Add(new Dish()
            {
                DishNumber = 1,
                DishName = "Sticky Mango Rice",
                Price = 12m,
                IsGlutenFree = true,
                Discount = 0,
                IsNutFree = true,
                IsVegeterian = true,
                IsVegan = false,
            }
            
            );
            Dishes.Add(new Dish()
            {
                DishNumber = 2,
                DishName = "Vegetable Dumplings",
                Price = 8m,
                IsGlutenFree = false,
                Discount = 10,
                IsNutFree = true,
                IsVegeterian = true,
                IsVegan = true
            });

            Dishes.Add(new Dish()
            {
                DishNumber = 3,
                DishName = "Spicy Tofu",
                Price = 14m,
                IsGlutenFree = true,
                Discount = 0,
                IsNutFree = true,
                IsVegeterian = true,
                IsVegan = true
            });

            Dishes.Add(new Dish()
            {
                DishNumber = 4,
                DishName = "Sweet sour tomatoes and eggs",
                Price = 14m,
                IsGlutenFree = true,
                Discount = 10,
                IsNutFree = true,
                IsVegeterian = true,
                IsVegan = false
            });

            if (!isVegeterian)
            {
                Dishes.Add(new Dish()
                {
                    DishNumber = 5,
                    DishName = "Orange Beef",
                    Price = 22m,
                    IsGlutenFree = true,
                    Discount = 50,
                    IsNutFree = true,
                    IsVegeterian = false,
                    IsVegan = false
                });

                Dishes.Add(new Dish()
                {
                    DishNumber = 6,
                    DishName = "Salt and pepper prawn",
                    Price = 15,
                    IsGlutenFree = false,
                    Discount = 0,
                    IsNutFree = true,
                    IsVegeterian = false,
                    IsVegan = false
                });

                Dishes.Add(new Dish()
                {
                    DishNumber = 7,
                    DishName = "Sweet pork belly",
                    Price = 15,
                    IsGlutenFree = false,
                    Discount = 10,
                    IsNutFree = true,
                    IsVegeterian = false,
                    IsVegan = false
                });
            }
        }


        public void PrintMenu()
        {
            
            foreach (var dish in Dishes)
            {
                string result = $"{dish.DishNumber}. {dish.DishName} - £{dish.Price - dish.Price * dish.Discount / 100}";
                decimal actualprice = 0;
                if (dish.IsGlutenFree)
                {
                    result += " - GF";
                }
                if (dish.Discount < 100 && dish.Discount >0)
                {
                    result += $" - {dish.Discount}%OFF";
                }
                if (dish.IsNutFree)
                {
                    result += " - Nut Free";
                }
                if (dish.IsVegan)
                {
                    result += " - Vg";
                }
                Console.WriteLine(result);               
            }
        
        }
        public decimal Match(int dishnumber)
        {
            decimal price =0;
            decimal[] arr = new decimal[100];
            arr[0] = 0;
            foreach (var dish in Dishes)
            {
                arr[dish.DishNumber] = dish.Price - dish.Price * dish.Discount / 100;
            }

            if (dishnumber>0)
            { 
                price = arr[dishnumber];
            }
           return price;
        }
            //switch (dishnumber)
            //{
            //    case 0:
            //        price = 0m; break;
            //    case 1:
            //        price = 12m; break;
            //    case 2:
            //        price = 8m; break;
            //    case 3:
            //        price = 14m; break;
            //    case 4:
            //        price = 14m; break;
            //    case 5:
            //        price = 22m; break;
            //    case 6:
            //        price = 15m; break;
            //    case 7:
            //        price = 15m; break;
            //}

        //public decimal match(int dishnumber)
        //{
        //    decimal price = 0;
        //    if (dishnumber == 1)
        //    { 
        //    price = Dishes;
        //    }
        //    return price;
        //}

    }
}
