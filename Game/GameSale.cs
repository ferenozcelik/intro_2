using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class GameSale
    {
        public void Buy(Player player, GameManager gameManager, ICampaignManager campaignManager)
        {
            double newPriceToPrint = campaignManager.NewPriceToPrintMethod(gameManager);
            Console.WriteLine("The game named " + gameManager.gameName + " was purchased by " 
                + player.Name + " " + player.Surname
                + "\nGame Price: " + gameManager.gamePrice
                + "\nCampaign: " + campaignManager.CampaignName
                + "\nNew Game Price: " + newPriceToPrint);
        }

    }
}
