using System;
namespace Examen
{
    public class Goalkeeper:Player,IKeeper
    {
        public Goalkeeper(string name, int age, string nationality, int salary, int atackePoints, int defensePoints, int number) : base(name, age, nationality, salary,atackePoints,defensePoints,number)
        {

        }

        public void Goalkeep()
        {

        }
    }
}
