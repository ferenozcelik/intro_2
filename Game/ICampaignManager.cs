using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    interface ICampaignManager
    {
        public string CampaignName { get; set; }
        void Add();
        void Delete();
        void Calculate(GameManager gameManager);
        void Update();
        double NewPriceToPrintMethod(GameManager gameManager);

        
    }
}
