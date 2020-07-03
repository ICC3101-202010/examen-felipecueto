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

        public Team(Coach coach, Doctor doctor,string name, TeamTypeEnumeration teamType,string nationality)
        {
                this.name = name;
                this.doctor = doctor;
                this.coach = coach;
                this.teamType = teamType;
                this.nationality = nationality;
                coach.Injury += doctor.OnPlayerInjury;  
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

        public Team GetTeam()
        {
            return this;
        }

        public void addPlayer(Player newplayer)
        {
            if (players.Count > 15)
            {
                throw new System.ArgumentException("El equipo ya tiene 15 jugadores", "");
            }
            else
            {
                if (players.Count > 0)
                {
                    foreach (Player player in players)
                    {
                        if (player.Name == newplayer.Name)
                        {
                            throw new System.ArgumentException("Ya existe este jugadro en este equipo", "");
                        }
                        bool notHavekeeper = true;

                        if (players.Count == 14)
                        {
                            if (player is Goalkeeper)
                            {
                                notHavekeeper = false;

                            }
                            if (notHavekeeper)
                            {
                                throw new System.ArgumentException("Debes tener almenos 1 Arquero", "");
                            }
                        }

                    }
                }
                    if (TeamType == TeamTypeEnumeration.Nacionales)
                    {
                        if (newplayer.Nationality != nationality)
                        {
                            throw new System.ArgumentException("No se aceptan jugadores extranjeros en un equipo nacional", "");
                        }
                    }
                
                players.Add(newplayer);
                newplayer.Injury += coach.OnPlayerInjury;
            }
        }

        public void RemovePlayer(Player removeplayer)
        {
            foreach (Player player in players)
            {
                if (player.Name == removeplayer.Name)
                {
                    players.Remove(removeplayer);
                }
            }
        }
    }
}
