using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    interface IPlayerService
    {
        void Register(Player player);
        void Delete(Player player);
        void UpdateName(Player player);
        void UpdateSurname(Player player);
        void UpdateBirthdate(Player player);
        void ShowUncensoredTcNo(Player player);



    }
}
