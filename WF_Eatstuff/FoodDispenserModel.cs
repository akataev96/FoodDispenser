using System;
using System.Collections.Generic;

namespace WF_Eatstuff
{
    public class FoodDispenserModel
    {
        /*Здесь можно сделать динамическую загрузку данных, например, из xml или подобных ему форматов*/

        #region hardcodeDictionary
        private Dictionary<string, int> DrinkItemsPrice = new Dictionary<string, int>()
        {
            ["Вода"] = 20,
            ["Чай черный"] = 25,
            ["Чай зеленый"] = 25,
            ["Эспрессо"] = 50
        };
        private Dictionary<string, int> FoodItemsPrice = new Dictionary<string, int>()
        {
            ["Хлеб"] = 10,
            ["Булочка"] = 15,
            ["Печенье"] = 29,
            ["Чипсы"] = 34
        };
        private Dictionary<string, int> DrinkAdditionItemsPrice = new Dictionary<string, int>()
        {
            ["Сахар"] = 3,
            ["Молоко"] = 10,
            ["Сироп"] = 5
        };
        private Dictionary<string, int> FoodAdditionItemsPrice = new Dictionary<string, int>()
        {
            ["Ветчина"] = 15,
            ["Сыр"] = 10,
            ["Джем"] = 7
        };
        #endregion

        public int CalculatePrice(Order order)
        {
            int price = 0, complexPrice = 90;
            int maxDrinkAdditionPrice = 0, maxFoodAdditionPrice = 0;
            foreach (string additionName in order.Addition.Keys)
            {
                if (order.Addition[additionName] == 0) { continue; }
                if (DrinkAdditionItemsPrice.ContainsKey(additionName))
                {
                    maxDrinkAdditionPrice = Math.Max(DrinkAdditionItemsPrice[additionName], maxDrinkAdditionPrice);
                    price += DrinkAdditionItemsPrice[additionName];
                }
                else
                {
                    maxFoodAdditionPrice = Math.Max(FoodAdditionItemsPrice[additionName], maxFoodAdditionPrice);
                    price += FoodAdditionItemsPrice[additionName];
                }
            }
            if (order.Complex)
            {   // в комплекс входит самая дорогая добавка из каждого блока добавок
                price += complexPrice - maxDrinkAdditionPrice - maxFoodAdditionPrice;
            }
            else
            {
                price += DrinkItemsPrice[order.Drink];
                price += FoodItemsPrice[order.Food];
            }
            return price;
        }

        public string CheckAndGive(Order order)
        {
            string finalDrink = "Напиток: " + order.Drink;
            string finalFood = "Еда: " + order.Food;
            string finalPrice = "Стоимость: " + CalculatePrice(order).ToString() + " руб.";
            string finalOrder;

            foreach (string additionName in order.Addition.Keys)
            {
                if (order.Addition[additionName] == 0) { continue; }
                switch (additionName)
                {
                    case "Сахар":
                        finalDrink += " + " + additionName + " " + 
                            order.Addition[additionName] + "шт.";
                        break;
                    case "Молоко":
                        if (order.Drink == "Вода")
                            return "Вода с молоком - не круто! :(";
                        else finalDrink += " + " + additionName;
                        break;
                    case "Сироп":
                        finalDrink += " + " + additionName;
                        break;
                    case "Ветчина":
                        if (order.Food == "Печенье")
                            return "Печенье с ветчиной - не круто! :(";
                        else if(order.Food == "Чипсы")
                            return "Чипсы с ветчиной - не круто! :(";
                        else finalFood += " + " + additionName;
                        break;
                    case "Сыр": 
                        if (order.Food == "Печенье")
                            return "Печенье с сыром - не круто! :(";
                        else if (order.Food == "Чипсы")
                            return "Чипсы с сыром - не круто! :(";
                        else finalFood += " + " + additionName;
                        break;
                    case "Джем":
                        finalFood += " + " + additionName;
                        break;
                }
            }
            finalOrder = finalDrink + "\n" + finalFood + "\n" + finalPrice;
            return finalOrder;
        }
    }
}
