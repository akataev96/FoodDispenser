using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WF_Eatstuff
{
    public interface IView
    {
        int FinalPrice { set; }
        void ShowOrder(string orderString);
        void ShowError(string errorString);
    }

    public partial class MainForm : Form, IView
    {
        private FoodDispenserPresenter _presenter;
        public MainForm()
        {
            InitializeComponent();
            _presenter = new FoodDispenserPresenter(this);
        }
        public int FinalPrice
        {
            set
            {
                lblFinalPrice.Text = value + " руб.";
            }
        }
        public void ShowOrder(string orderString)
        {
            MessageBox.Show(orderString, "Заказ");
        }
        public void ShowError(string errorrString)
        {
            MessageBox.Show(errorrString, "Заказ невозможен!");
        }

        #region События
        private void chboxComplex_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.BoxCheck(chboxComplex.Tag.ToString(), chboxComplex.Checked);
        }
        private void rbDrinkWater_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.DrinkChange(rbDrinkWater.Tag.ToString());
        }

        private void rbDrinkBlacktea_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.DrinkChange(rbDrinkBlacktea.Tag.ToString());
        }

        private void rbDrinkGreentea_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.DrinkChange(rbDrinkGreentea.Tag.ToString());
        }

        private void rbDrinkEspresso_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.DrinkChange(rbDrinkEspresso.Tag.ToString());
        }

        private void numDrinkSugarCount_ValueChanged(object sender, EventArgs e)
        {
            _presenter.CountChange(numDrinkSugarCount.Tag.ToString(), (int)numDrinkSugarCount.Value);
        }

        private void chboxDrinkMilk_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.BoxCheck(chboxDrinkMilk.Tag.ToString(), chboxDrinkMilk.Checked);
        }

        private void chboxDrinkSyrup_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.BoxCheck(chboxDrinkSyrup.Tag.ToString(), chboxDrinkSyrup.Checked);
        }

        private void rbFoodBread_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.FoodChange(rbFoodBread.Tag.ToString());
        }

        private void rbFoodBun_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.FoodChange(rbFoodBun.Tag.ToString());
        }

        private void rbFoodCookie_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.FoodChange(rbFoodCookie.Tag.ToString());
        }

        private void rbFoodCrisps_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.FoodChange(rbFoodCrisps.Tag.ToString());
        }
        private void chboxFoodHam_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.BoxCheck(chboxFoodHam.Tag.ToString(), chboxFoodHam.Checked);
        }

        private void chboxFoodCheese_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.BoxCheck(chboxFoodCheese.Tag.ToString(), chboxFoodCheese.Checked);
        }

        private void chboxFoodJam_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.BoxCheck(chboxFoodJam.Tag.ToString(), chboxFoodJam.Checked);
        }
        private void btnRenewPrice_Click(object sender, EventArgs e)
        {
            _presenter.RenewPrice();
        }

        private void btnGiveOrder_Click(object sender, EventArgs e)
        {
            _presenter.GiveOrder();
        }
        #endregion
    }
}