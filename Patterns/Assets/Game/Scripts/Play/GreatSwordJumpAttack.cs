using System.Threading.Tasks;
using UnityEngine;

namespace Game.Scripts.Play
{
    public class GreatSwordJumpAttack : HeroCommand
    {
        public GreatSwordJumpAttack(IEntity player) : base(player)
        {
        }

        public override async Task Execute()
        {
            player.GreatSwordJumpAttack();
            await Awaitable.WaitForSecondsAsync(player.AnimationController.GreatSwordJumpAttack());
            player.AnimationController.Idle();
        }
    }
}