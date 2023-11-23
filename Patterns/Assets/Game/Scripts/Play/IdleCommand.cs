using System.Threading.Tasks;
using UnityEngine;

namespace Game.Scripts.Play
{
    public class IdleCommand : HeroCommand
    {
        public IdleCommand(IEntity player) : base(player)
        {
            
        }

        public override async Task Execute()
        {
            player.Idle();
            await Awaitable.WaitForSecondsAsync(player.AnimationController.Idle());
            player.AnimationController.Idle();
        
        }
      
    }
}