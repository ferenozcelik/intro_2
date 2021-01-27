using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class EDevletVerificationManager : IVerificationServices
    {
        List<string> TcNoDatabase = new List<string>()
        {
            "190201001",
            "190201002",
            "190201003",
            "190201004",
            "190201005",
            "190201006",
            "190201007",
            "190201008",
            "190201009",
            "190201010"
        };
        public void Verify(Player player)
        {
            foreach (var TcNo in TcNoDatabase)
            {
                if(player.TcNo == TcNo)
                {
                    Console.WriteLine("Player is verified.");
                }
            }
        }
    }
}
