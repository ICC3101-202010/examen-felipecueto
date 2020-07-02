using System;
namespace Examen
{
    public class ChangePlayerEventArgs
    {
        public Player NewPlayer { get; set; }
        public Team team { get; set; }
        public Player OldPlayer { get; set; }

    }
    
}
