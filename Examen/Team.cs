using System;
using System.Collections.Generic;

namespace Examen
{
    public class Team
    {
        private List<Player> players = new List<Player>();
        private Coach coach;
        private Doctor doctor;
        private string name;
        private TeamTypeEnumeration teamType;
        private string nationality;

        public Team(List<Player> players, Coach coach, Doctor doctor,string name, TeamTypeEnumeration teamType,string nationality)
        {
            if (players.Count != 15)
            {
                throw new System.ArgumentException("El equipo tiene que tener 15 jugadores","");
            }
            else
            {
                int count = 0;
                foreach (Player player in players)
                {
                    if(player is Goalkeeper)
                    {
                        count += 1;
                    }
                    player.Injury += coach.OnPlayerInjury;
                }
                if (count != 0)
                {
                    throw new System.ArgumentException("Debes tener Arquero", "");
                }

                if (TeamType == TeamTypeEnumeration.Nacionales)
                {
                    foreach (Player player in players)
                    {
                        if (player.Nationality != nationality)
                        {
                            throw new System.ArgumentException("No se aceptan jugadores extranjeros en un equipo nacional", "");
                        }

                    }
                }
                this.doctor = doctor;
                this.coach = coach;
                this.players = players;
                this.teamType = teamType;
                this.nationality = nationality;
                coach.Injury += doctor.OnPlayerInjury;
            }  
        }

        public List<Player> Players { get => players; set => players = value; }
        public Coach Coach { get => coach; set => coach = value; }
        public Doctor Doctor { get => doctor; set => doctor = value; }
        public string Name { get => name; set => name = value; }
        public TeamTypeEnumeration TeamType { get => teamType; set => teamType = value; }
        public string Nationality { get => nationality; set => nationality = value; }

        public Player InfoPlayer(int playerNumber)
        {
            foreach (Player player in players)
            {
                if (player.Number == playerNumber)
                {
                    return player;
                }
            }
            return null;
        }
    }
}
