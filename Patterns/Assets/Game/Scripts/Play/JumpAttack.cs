using System.Threading.Tasks;
using UnityEngine;

namespace Game.Scripts.Play
{
    public class JumpAttack : HeroCommand
    {
        public JumpAttack(IEntity player) : base(player)
        {
        }

        public override async Task Execute()
        {
            player.JumpAttack();
            await Awaitable.WaitForSecondsAsync(player.AnimationController.JumpAttack());
            player.AnimationController.Idle();
        }
    }
}