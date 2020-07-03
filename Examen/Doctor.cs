using System;
namespace Examen
{
    public class Doctor:Person
    {
        private int experiencePoints;

        public Doctor(string name, int age, string nationality, int salary, int experiencePoints) : base(name, age, nationality, salary)
        {
           this.experiencePoints = experiencePoints;
        }

        public int ExperiencePoints { get => experiencePoints; set => experiencePoints = value; }

        public void OnPlayerInjury(Object sender, InjuryEventArgs args)
        {
            if (Evaluate(args.player))
            {
                Cure(args.player);
            }
        }
        public bool Evaluate(Player player)
        {
            bool needToCure = false;
            
            return needToCure;
        }

        public void Cure(Player player)
        {
            player.Injured = false; 
        }

    }

}
