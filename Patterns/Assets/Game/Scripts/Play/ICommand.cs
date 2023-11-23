using System.Threading.Tasks;

namespace Game.Scripts.Play
{
    public interface ICommand
    {
        Task Execute();
    }
}