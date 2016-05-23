using System;

namespace SomeStateExamples
{
    public class InvulnerableDamageMode : DamageModeState
    {
        Game game;        

        public InvulnerableDamageMode(Game game)
        {
            this.game = game;            
        }

        public void CollideWithEnemy()
        {
            Console.WriteLine("Hit an enemy but you are invulnerable since you just got hit!");
        }

        public void TimerExpired()
        {
            Console.WriteLine("Timer expired, now normal damageMode");
            game.SetDamageModeState(game.GetNormalDamageMode());
        }
    }
}