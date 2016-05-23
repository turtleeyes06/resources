using System;
using System.Timers;

namespace SomeStateExamples
{
    public class Game
    {
        DamageModeState normalDamageModeState;
        DamageModeState invulnerableDamageModeState;

        AbilitiesState normalAbilityState;
        AbilitiesState superAbilityState;


        AbilitiesState currentAbilityState;
        DamageModeState currentDamageMode;

        bool timerExpired = false;
        public Game()
        {
            normalDamageModeState = new NormalDamageMode(this);
            invulnerableDamageModeState = new InvulnerableDamageMode(this);

            normalAbilityState = new NormalAbilityState(this);
            superAbilityState = new SuperAbilityState(this);

            currentAbilityState = normalAbilityState;
            currentDamageMode = normalDamageModeState;

        }






        //main test
        public void Run()
        {
            currentAbilityState.EatMushroom();
            currentAbilityState.EatMushroom();

            currentDamageMode.CollideWithEnemy();
            currentDamageMode.CollideWithEnemy();

            currentDamageMode.CollideWithEnemy();

            timerExpired = true;
            if (timerExpired)
            {
                currentDamageMode.TimerExpired();
            }

            currentAbilityState.EatMushroom();
            timerExpired = false;

 
            
            
            currentDamageMode.CollideWithEnemy();

            Console.ReadKey();
        }







        //getters and setters
        public DamageModeState GetNormalDamageMode()
        {
            return normalDamageModeState;
        }
        public DamageModeState GetInvulernableDamageMode()
        {
            return invulnerableDamageModeState;
        }
        public void SetDamageModeState(DamageModeState incomingDamageMode)
        {
            currentDamageMode = incomingDamageMode;
        }










        public AbilitiesState GetNormalAbilityState()
        {
            return normalAbilityState;
        }
        public AbilitiesState GetSuperAbiltiyState()
        {
            return superAbilityState;
        }
        public void SetAbilityState(AbilitiesState incomingAbilityState)
        {
            currentAbilityState = incomingAbilityState;
        }
        public AbilitiesState GetCurrentAbilitiesState()
        {
            return currentAbilityState;
        }



    }
}
