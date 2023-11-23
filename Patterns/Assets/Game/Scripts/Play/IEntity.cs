namespace Game.Scripts.Play
{
    public interface IEntity
    {
        void Idle();
        void DropKick();
        void GreatSwordJumpAttack();
        void GreatSwordSlash();
        void JumpAttack ();
        void SittingClap ();
        void StandingUp ();
        void FlyingKneePunchCombo();
        
        AnimationController AnimationController { get; }
    }
}