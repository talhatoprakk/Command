using UnityEngine;

namespace Game.Scripts.Play
{
    [RequireComponent(typeof(AnimationController))]
    public class Player : MonoBehaviour ,IEntity
    {
        public void Idle()
        {
            
        }

        public void DropKick()
        {
            
        }

        public void GreatSwordJumpAttack()
        {
            
        }

        public void GreatSwordSlash()
        {
            
        }

        public void JumpAttack()
        {
            
        }

        public void SittingClap()
        {
            
        }

        public void StandingUp()
        {
            
        }

        public void FlyingKneePunchCombo()
        {
            
        }

        public AnimationController AnimationController => GetComponent<AnimationController>();
    }
}