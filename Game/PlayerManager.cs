using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class PlayerManager : IPlayerService
    {

        public void Register(Player player)
        {
            Console.WriteLine("Name: " + player.Name
                + "\nSurname: " + player.Surname
                + "\nBirthdate " + player.BirthDate
                + "\nTC No: " + player.CensoredTcNo
                + "\nUser registered.");
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Name: " + player.Name
                + "\nSurname: " + player.Surname
                + "\nBirthdate " + player.BirthDate
                + "\nTC No: " + player.CensoredTcNo
                + "\nUser removed.");
        }

        public void UpdateName(Player player)
        {
            Console.WriteLine("You wanted to change your name. Type your new name: ");
            string newName = Console.ReadLine();
            player.Name = newName;
            Console.WriteLine("Your name has changed. New name: " + newName);
        }

        public void UpdateSurname(Player player)
        {
            Console.WriteLine("You wanted to change your surname. Type your new surname: ");
            string newSurname = Console.ReadLine();
            player.Surname = newSurname;
            Console.WriteLine("Your surname has changed. New surname: " + newSurname);
        }

        public void UpdateBirthdate(Player player)
        {
            Console.WriteLine("You wanted to change your birthdate. Type your new birthdate: ");
            int newBirthdate = Convert.ToInt32(Console.ReadLine()); // type casting -> int
            player.BirthDate = newBirthdate;
            Console.WriteLine("Your birthdate has changed. New surname: " + newBirthdate);
        }

        public void ShowUncensoredTcNo(Player player)
        {
            Console.WriteLine(player.TcNo);
        }


    }
}
