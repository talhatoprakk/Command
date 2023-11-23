using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using static System.Activator;

namespace Game.Scripts.Play
{
    public abstract class HeroCommand : ICommand
    {

        protected readonly IEntity player;

        protected  HeroCommand(IEntity player)
        {
            
            this.player = player;
        }
        public abstract Task Execute();

        public static T Create<T>(IEntity player) where T : HeroCommand
        {
            return (T)CreateInstance(typeof(T), player);
        }
    }
    
}