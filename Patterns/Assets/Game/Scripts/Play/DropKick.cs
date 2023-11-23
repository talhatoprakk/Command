using System.Threading.Tasks;
using UnityEngine;

namespace Game.Scripts.Play
{
    public class DropKick : HeroCommand
    {
        public DropKick(IEntity player) : base(player)
        {
        }

        public override async Task Execute()
        {
            player.DropKick();
            await Awaitable.WaitForSecondsAsync(player.AnimationController.DropKick());
            player.AnimationController.Idle();
        }
    }
}