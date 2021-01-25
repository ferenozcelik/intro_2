using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Eren", "Ozcelik", "190201006", 2001);
            Player player2 = new Player("Fatih", "Altayli", "190201009", 2002);

            PlayerManager playerManager = new PlayerManager();
            playerManager.Register(player1);
            playerManager.Delete(player1);
            playerManager.UpdateName(player1);
            playerManager.UpdateSurname(player1);
            playerManager.UpdateBirthdate(player1);
            playerManager.ShowUncensoredTcNo(player1);

            Console.WriteLine("---------------");

            GameManager gameManager1 = new GameManager
            {
                gameName = "Northgard", 
                gamePrice = 250
            };
            GameManager gameManager2 = new GameManager
            {
                gameName = "The Long Dark",
                gamePrice = 200
            };

            Console.WriteLine("Game 1:");
            ICampaignManager campaignManager1 = new Campaign1Manager();
            Console.WriteLine("Game name: " + gameManager1.gameName + "\nGame price: " + gameManager1.gamePrice);
            campaignManager1.Add();
            campaignManager1.Calculate(gameManager1);
            campaignManager1.Delete();
            campaignManager1.Update();

            Console.WriteLine("Game 2:");
            ICampaignManager campaignManager2 = new Campaign2Manager();
            Console.WriteLine("Game name: " + gameManager2.gameName + "\nGame price: " + gameManager2.gamePrice);
            campaignManager2.Add();
            campaignManager2.Calculate(gameManager2);
            campaignManager2.Delete();
            campaignManager2.Update();

            Console.WriteLine("Verification:");
            EDevletVerification eDevletVerification = new EDevletVerification();
            eDevletVerification.Verify(player1);
            eDevletVerification.Verify(player2);

            Console.WriteLine("--Game Sales--");
            GameSale gameSale1 = new GameSale();
            gameSale1.Buy(player1, gameManager1, campaignManager1);
            gameSale1.Buy(player2, gameManager2, campaignManager2);

            Console.WriteLine("ererere");

        }
    }
}
