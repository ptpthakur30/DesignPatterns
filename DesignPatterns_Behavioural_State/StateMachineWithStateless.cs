using Stateless;
using System;

namespace DesignPatterns_Behavioural_State
{
    //Below is state
    public enum Health
    {
        NonReproductive,
        Pregnant,
        Reproductive
    }

    //Below are triggers
    public enum Activity
    {
        GiveBirth,
        ReachPuberty,
        HaveAbortion,
        HaveUnprotectedSex,
        Historectomy
    }

    internal class Demo
    {
        private static void Main(string[] args)
        {
            //Initialize state machine with current state
            var stateMachine = new StateMachine<Health, Activity>(Health.NonReproductive);
            //current state trigger transitioned state
            stateMachine.Configure(Health.NonReproductive)
              .Permit(Activity.ReachPuberty, Health.Reproductive);
            stateMachine.Configure(Health.Reproductive)
              .Permit(Activity.Historectomy, Health.NonReproductive)
              .PermitIf(Activity.HaveUnprotectedSex, Health.Pregnant,
                () => ParentsNotWatching);
            stateMachine.Configure(Health.Pregnant)
              .Permit(Activity.GiveBirth, Health.Reproductive)
              .Permit(Activity.HaveAbortion, Health.Reproductive);

        }

        public static bool ParentsNotWatching
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }
}
