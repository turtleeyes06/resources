using System;

namespace SomeStateExamples
{
    internal class SuperAbilityState : AbilitiesState
    {
        private Game game;

        public SuperAbilityState(Game game)
        {
            this.game = game;
        }

        public void EatMushroom()
        {
            Console.WriteLine("You ate a mushroom but are already Super so no change!!!!");
        }
    }
}