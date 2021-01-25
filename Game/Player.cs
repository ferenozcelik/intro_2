using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Player
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TcNo { get; set; }
        public int BirthDate { get; set; }
        public string CensoredTcNo 
        {
            get
            {
                int TcNoLength = TcNo.Length;
                string censoredTcNo = new string('*', TcNoLength);
                return censoredTcNo;
            }
            set 
            { 
                CensoredTcNo = value; 
            }
        }

        public Player(string name, string surname, string tcNo, int birthDate)
        {
            Name = name;
            Surname = surname;
            TcNo = tcNo;
            BirthDate = birthDate;
        }
    }
}
