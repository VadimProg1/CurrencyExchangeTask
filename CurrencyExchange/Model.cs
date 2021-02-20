using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchange
{
    class Model
    {
        private int investedMoney = 0, walletMoney = 0;
        public int days, daysPassed = 0;
        public double price, changeValue;
        const double k = 0.5;

        public void Setup(int price, int days, int walletMoney)
        {
            this.price = price;
            this.days = days;
            this.walletMoney = walletMoney;
        }
        public void TypicalWallStreetDay(double rand)
        {
            double newPrice = price * (1 + k * (rand - 0.5));
            changeValue = newPrice / price;
            price = newPrice;
            investedMoney = (int)(investedMoney * changeValue);
            daysPassed++;
        }

        public bool WallStreetIsOpened()
        {
            if(daysPassed < days)
            {
                return true;
            }
            else
            {
                daysPassed = 0;
                return false;
            }
        }

        public void InvestMoney(int buyMoney)
        {
            if(buyMoney <= walletMoney)
            {
                investedMoney += buyMoney;
                walletMoney -= buyMoney;
            }
            else
            {
                investedMoney += walletMoney;
                walletMoney = 0;
            }
        }

        public int GetInvestedMoney()
        {
            return investedMoney;
        }

        public void SellMoney(int sellMoney)
        {
            if(sellMoney <= investedMoney)
            {
                walletMoney += sellMoney;
                investedMoney -= sellMoney;
            }
            else
            {
                walletMoney += investedMoney;
                investedMoney = 0;
            }
        }

        public int GetWalletMoney()
        {
            return walletMoney;
        }
    }
}
