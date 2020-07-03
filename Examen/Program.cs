using System;
using System.Collections.Generic;

namespace Examen
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Coach coach = new Coach("Nombre entrenador",0,"Nacionalidad",0,0); //Se debe rellenar los cambios (Nombre entrenador, edad,nacionalidad, salario, puntos tacticos
            Doctor doctor = new Doctor("Nombre Doctor", 0, "Nacionalidad", 0,0); //Se debe rellenar los cambios (Nombre entrenador, edad,nacionalidad, salario, puntos Experiencia
            Team team = new Team(coach, doctor, "Nombre Equipo", TeamTypeEnumeration.Liga, "Nacionalidad del equipo");//Se debe rellenar los cambios (Entrenador, Doctor,Nombre Equipo, TeamTypeEnumeration.Liga o TeamTypeEnumeration.Nacionales, Nacionalidad del equipo
            Player player = new Player("Nombre Jugador", 0, "Nacionalidad", 0, 0, 0, 0); //Se debe rellenar los cambios (Nombre Jugador, edad,nacionalidad, salario, puntos ataque, punto defensa, numero de la camiseta
            //Se pueden agregar hasta 14 Jugadores + el arquero = 15;
            Goalkeeper goalkeeper = new Goalkeeper("Nombre Arquero", 0, "Nacionalidad", 0, 0, 0, 0); //Se debe rellenar los cambios (Nombre Arquero, edad,nacionalidad, salario, puntos ataque, punto defensa, numero de la camiseta
            team.addPlayer(player);
            team.addPlayer(goalkeeper);
            Team getteam = team.GetTeam(); // Al tener el equipo, ya podemos conseguir todos los datos del equipo
            Console.WriteLine(getteam.Name);// Por Ejemplo el nombre

        }
    }
}
