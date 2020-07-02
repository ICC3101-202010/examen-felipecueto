using System;
namespace Examen
{
    public class Match
    {
        private Team team1;
        private Team team2;
        private TeamTypeEnumeration teamType;
        private int durationTime;
        private int scoreTeam1;
        private int scoreTeam2;

        public Match(Team team1, Team team2, TeamTypeEnumeration teamType, int durationTime)
        {
            if (team1.TeamType != team2.TeamType)
            {
                throw new System.ArgumentException("Los equipos que se enfrentan son ambos nacionales o ambos de liga, pero no mezclados", "");
            }
            this.team1 = team1;
            this.team2 = team2;
            this.teamType = teamType;
            this.durationTime = durationTime;
            team1.Coach.PlayerChanged += OnChangePlayer;
            team2.Coach.PlayerChanged += OnChangePlayer;
        }

        public Team Team1 { get => team1; set => team1 = value; }
        public Team Team2 { get => team2; set => team2 = value; }
        public TeamTypeEnumeration TeamType { get => teamType; set => teamType = value; } //Tipo de Partido
        public int DurationTime { get => durationTime; set => durationTime = value; } //Duracion del partido
        public int ScoreTeam1 { get => scoreTeam1; set => scoreTeam1 = value; }
        public int ScoreTeam2 { get => scoreTeam2; set => scoreTeam2 = value; }

        public string GetResult()
        {
            return $"{team1.Name}:{scoreTeam1} | {team2.Name}:{scoreTeam2}";
        }

        public string GetMatch()
        {
            return $"{team1.Name} V/S {team2.Name}";
        }
        public void OnChangePlayer(object source, ChangePlayerEventArgs args)
        {
            Console.WriteLine($"Sale {args.OldPlayer.Number} | Entra {args.NewPlayer.Number}");
        }

       
    }
}
