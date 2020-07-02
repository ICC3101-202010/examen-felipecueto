using System;
using System.Collections.Generic;

namespace Examen
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Player> players = new List<Player>();
            Goalkeeper goalkeeper = new Goalkeeper("Felipe", "19", "Chile", "1000", 200, 200, 100);
            Coach coach = new Coach("Dsds", "sdd", "sdsds", "dsdsds", 1222);
            goalkeeper.Injury += coach.OnPlayerInjury;
            goalkeeper.NotifyInjury();


        }
    }
}
