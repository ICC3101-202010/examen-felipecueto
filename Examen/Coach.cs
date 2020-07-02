using System;
namespace Examen
{
    public class Coach:Person
    {
        private int tactitcaPoints;

        //Evento para avisarle al doctor que se lessiono un jugador
        public delegate void SendingMessegeToCoachHandler(object source, InjuryEventArgs args);
        public event SendingMessegeToCoachHandler Injury;

        //Evento para cambiar jugador en el partido
        public delegate void SendingMessegeToMatchHandler(object source, ChangePlayerEventArgs args);
        public event SendingMessegeToMatchHandler PlayerChanged;

        public Coach(string name, int age, string nationality, int salary,int tactitcaPoints) : base(name, age, nationality, salary)
        {
            this.tactitcaPoints = tactitcaPoints;
        }

        public int TactitcaPoints { get => tactitcaPoints; set => tactitcaPoints = value; }


        public void OnPlayerInjury(Object sender, InjuryEventArgs args)
        {
            CallDoctor(args.player);
            ChangePlayer(args.player);
        }
        public void CallDoctor(Player playerInjury)
        {
            if (Injury != null)
            {
                Injury(this, new InjuryEventArgs() { player = playerInjury });
            }
        }
        public void ChangePlayer(Player oldplayer)
        {
            Player newplayer = new Player("nombreJugador",0,"Nacionalidad",0,0,0,0); //El Entrenador debe elejir a quien entra a la cancha
            if (!newplayer.Injured)
            {
                if (PlayerChanged != null)
                {
                    PlayerChanged(this, new ChangePlayerEventArgs() { NewPlayer = newplayer, OldPlayer = oldplayer });
                }
            }
        }

    }
}
