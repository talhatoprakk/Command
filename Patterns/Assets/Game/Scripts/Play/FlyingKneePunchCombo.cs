using System.Threading.Tasks;
using UnityEngine;

namespace Game.Scripts.Play
{
    public class FlyingKneePunchCombo : HeroCommand
    {
        public FlyingKneePunchCombo(IEntity player) : base(player)
        {
        }

        public override async Task Execute()
        {
            player.FlyingKneePunchCombo();
            await Awaitable.WaitForSecondsAsync(player.AnimationController.FlyingKneePunchCombo());
            player.AnimationController.Idle();
        }
    }
}