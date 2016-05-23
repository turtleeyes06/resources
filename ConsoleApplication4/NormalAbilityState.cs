using System;

namespace SomeStateExamples
{
    internal class NormalAbilityState : AbilitiesState
    {
        private Game game;

        public NormalAbilityState(Game game)
        {
            this.game = game;
        }

        public void EatMushroom()
        {
            Console.WriteLine("You ate a mushroom and are Now SUPER MARIO!!");
            game.SetAbilityState(game.GetSuperAbiltiyState()); 
        }
    }
}