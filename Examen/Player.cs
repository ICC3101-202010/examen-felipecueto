using System;
namespace Examen
{
    public class Player : Person
    {
        private int atackePoints;
        private int defensePoints;
        private int number;
        private bool injured = false; //Si el jugaro esta lessionado no puede jugar

        //Evento por si se lessiona
        public delegate void SendingMessegeToCoachHandler(object source, InjuryEventArgs args);
        public event SendingMessegeToCoachHandler Injury;

        public void NotifyInjury()
        {
            if (Injury!= null)
            {
                Injury(this, new InjuryEventArgs() {player=this});
            }
        }

        public Player(string name,int age,string nationality,int salary, int atackePoints,int defensePoints,int number) :base (name,age,nationality,salary)
        {
            this.atackePoints = atackePoints;
            this.defensePoints = defensePoints;
            this.number = number;       
        }

        public int AtackePoints { get => atackePoints; set => atackePoints = value; }
        public int DefensePoints { get => defensePoints; set => defensePoints = value; }
        public int Number { get => number; set => number = value; }
        public bool Injured { get => injured; set => injured = value; }

        public void Play()
        {

        }
    }
}
