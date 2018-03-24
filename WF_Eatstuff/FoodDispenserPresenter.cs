using System.Collections.Generic;

namespace WF_Eatstuff
{
    public class Order
    {
        public bool Complex { get; set; }
        public string Drink { get; set; }
        public string Food { get; set; }
        public Dictionary<string, int> Addition { get; set; }
    }
    class FoodDispenserPresenter
    {
        private readonly IView _view;
        private readonly FoodDispenserModel _model;
        private Order order;
        public FoodDispenserPresenter(IView view)
        {
            _view = view;
            _model = new FoodDispenserModel();

            order = new Order
            {
                Drink = "Вода",
                Food = "Хлеб",
                Addition = new Dictionary<string, int>()
            };
        }

        public void DrinkChange(string tag)
        {
            order.Drink = tag;
        }
        public void FoodChange(string tag)
        {
            order.Food = tag;
        }

        public void BoxCheck(string tag, bool state)
        {
            if (tag == "Комплекс")
            {
                order.Complex = state;
            }
            else
            {
                order.Addition[tag] = state ? 1 : 0;
            }
        }
        public void CountChange(string tag, int count)
        {
            order.Addition[tag] = count;
        }

        public void RenewPrice()
        {
            _view.FinalPrice = _model.CalculatePrice(order);
        }
        public void GiveOrder()
        {
            string orderFinal = _model.CheckAndGive(order);
            if (!orderFinal.Contains("не круто"))
            {
                _view.ShowOrder(orderFinal);
            }
            else
            {
                _view.ShowError(orderFinal);
            }
        }
    }
}
