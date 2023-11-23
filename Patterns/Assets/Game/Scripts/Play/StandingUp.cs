using System.Threading.Tasks;
using UnityEngine;

namespace Game.Scripts.Play
{
    public class StandingUp : HeroCommand
    {
        public StandingUp(IEntity player) : base(player)
        {
        }

        public override async Task Execute()
        {
            player.StandingUp();
            await Awaitable.WaitForSecondsAsync(player.AnimationController.StandingUp());
            player.AnimationController.Idle();
        }
    }
}