using System;

namespace SomeStateExamples
{
    public class NormalDamageMode : DamageModeState
    {
        string deadMessage = "You Died!";
        string hitMessage = "Got hit by enemy!";
        string smallMario = "You are now little mario!";
        Game theGame;

        public NormalDamageMode(Game incomingGame)
        {
            this.theGame = incomingGame;
        }

        public void CollideWithEnemy()
        {
            Console.WriteLine(hitMessage);
            if(theGame.GetCurrentAbilitiesState() == theGame.GetNormalAbilityState())
            {
                Console.WriteLine(deadMessage);
            }else
            {
                Console.WriteLine(smallMario);
                theGame.SetAbilityState(theGame.GetNormalAbilityState());
                theGame.SetDamageModeState(theGame.GetInvulernableDamageMode());
            }
            
        }

        public void TimerExpired()
        {
            //noopt
        }
    }
}