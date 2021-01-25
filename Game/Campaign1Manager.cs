using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Campaign1Manager : ICampaignManager
    {

        public string CampaignName
        {
            get
            {
                return "Campaign 1 (%25)";
            }
            set
            {
                CampaignName = value;
            }
        }
        public void Add()
        {
            Console.WriteLine("Campaign 1 (%25) implemented.");
        }

        public void Calculate(GameManager gameManager)
        {
            int newGamePrice = gameManager.gamePrice - ((gameManager.gamePrice * 25) / 100);
            Console.WriteLine("New game price after implementation of Campaign 1(%25): " + newGamePrice);
        }

        public double NewPriceToPrintMethod(GameManager gameManager)
        {
            return gameManager.gamePrice - ((gameManager.gamePrice * 25) / 100);
        }

        public void Delete()
        {
            Console.WriteLine("Campaign 1 (%25) removed.");
        }

        public void Update()
        {
            Console.WriteLine("Campaign 1 updated.");
        }
    }
}
