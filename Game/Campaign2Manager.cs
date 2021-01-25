using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Campaign2Manager : ICampaignManager
    {

        public string CampaignName 
        {
            get 
            {
                return "Campaign 2 (%50)";
            }
            set 
            {
                CampaignName = value;
            }
        }
        public void Add()
        {
            Console.WriteLine("Campaign 2 (%50) implemented.");
        }

        public void Calculate(GameManager gameManager)
        {
            int newGamePrice = gameManager.gamePrice - ((gameManager.gamePrice * 50) / 100);
            Console.WriteLine("New game price after implementation of Campaign 2(%50): " + newGamePrice);
        }

        public double NewPriceToPrintMethod(GameManager gameManager)
        {
            return gameManager.gamePrice - ((gameManager.gamePrice * 50) / 100);
        }

        public void Delete()
        {
            Console.WriteLine("Campaign 2 (%50) removed.");
        }

        public void Update()
        {
            Console.WriteLine("Campaign 2 updated.");
        }
    }
}
