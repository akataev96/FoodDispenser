using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WF_Eatstuff;

namespace FoodDispenserUnitTest
{
    [TestClass]
    public class ModelTest
    {
        [TestMethod]
        public void WaterMilk_CookieHam_errorReturned()
        {
            Order order = new Order
            {
                Drink = "Вода",
                Food = "Печенье",
                Addition = new Dictionary<string, int>
                {
                    ["Молоко"] = 1,
                    ["Ветчина"] = 1
                }
            };
            string expected = "Вода с молоком - не круто! :(";

            FoodDispenserModel _model = new FoodDispenserModel();
            string actual = _model.CheckAndGive(order);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void BlackteaSugar_CookiesJam()
        {
            Order order = new Order
            {
                Drink = "Чай черный",
                Food = "Печенье",
                Addition = new Dictionary<string, int>
                {
                    ["Сахар"] = 2,
                    ["Джем"] = 1
                }
            };
            string expected = "Напиток: Чай черный + Сахар 2шт.\nЕда: Печенье + Джем\nСтоимость: 64 руб.";

            FoodDispenserModel _model = new FoodDispenserModel();
            string actual = _model.CheckAndGive(order);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Complex_MostExpensiveAdditions_InIt()
        {
            Order order = new Order
            {
                Complex = true,
                Drink = "Эспрессо",
                Food = "Булочка",
                Addition = new Dictionary<string, int>
                {
                    ["Сахар"] = 4,
                    ["Молоко"] = 1,
                    ["Сироп"] = 1,
                    ["Ветчина"] = 1,
                    ["Джем"] = 1
                }
            };
            int expected = 105;

            FoodDispenserModel _model = new FoodDispenserModel();
            int actual = _model.CalculatePrice(order);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Complex_NoAdditions()
        {
            Order order = new Order
            {
                Complex = true,
                Drink = "Вода",
                Food = "Хлеб",
                Addition = new Dictionary<string, int>{}
            };
            int expected = 90;

            FoodDispenserModel _model = new FoodDispenserModel();
            int actual = _model.CalculatePrice(order);

            Assert.AreEqual(expected, actual);
        }
    }
}
