using System.Threading.Tasks;
using UnityEngine;

namespace Game.Scripts.Play
{
    public class GreatSwordSlash : HeroCommand
    {
        public GreatSwordSlash(IEntity player) : base(player)
        {
        }

        public override async Task Execute()
        {
            player.GreatSwordSlash();
            await Awaitable.WaitForSecondsAsync(player.AnimationController.GreatSwordSlash());
            player.AnimationController.Idle();
        }
    }
}