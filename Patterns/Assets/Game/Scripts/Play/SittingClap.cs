using System.Threading.Tasks;
using UnityEngine;

namespace Game.Scripts.Play
{
    public class SittingClap : HeroCommand
    {
        public SittingClap(IEntity player) : base(player)
        {
        }

        public override async Task Execute()
        {
            player.SittingClap();
            await Awaitable.WaitForSecondsAsync(player.AnimationController.SittingClap());
            player.AnimationController.Idle();
        }
    }
}