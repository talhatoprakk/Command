using System.Collections.Generic;
using Game.Scripts.Utilities;
using UnityEngine;

namespace Game.Scripts.Play
{
    public class AnimationController : MonoBehaviour
    {

        #region Properties

        public Animator animator;
        private const float crossFadeDuration = 0.1f;

        private readonly Dictionary<int, float> animationDuration = new()
        {
            { DropKickHash, 2.9f },
            { GreatSwordJumpAttackHash, 2.167f },
            { GreatSwordSlashHash, 3.533f },
            { JumpAttackHash, 3.8f },
            { IdleHash, 0.033f },
            { SittingClapHash, 5.667f },
            { StandingUpHash, 6.033f },
            { FlyingKneePunchComboHash, 2.667f }
        };

        private static readonly int DropKickHash = Animator.StringToHash("DropKick");
        private static readonly int GreatSwordJumpAttackHash = Animator.StringToHash("GreatSwordJumpAttack");
        private static readonly int GreatSwordSlashHash = Animator.StringToHash("GreatSwordSlash");
        private static readonly int JumpAttackHash = Animator.StringToHash("JumpAttack");
        private static readonly int IdleHash = Animator.StringToHash("Idle");
        private static readonly int SittingClapHash = Animator.StringToHash("SittingClap");
        private static readonly int StandingUpHash = Animator.StringToHash("StandingUp");
        private static readonly int FlyingKneePunchComboHash = Animator.StringToHash("FlyingKneePunchCombo");

        #endregion

        #region Mono Methods

        private void Awake() => animator = GetComponent<Animator>();


        #endregion

        #region Animation Methods


        public float DropKick() => PlayAnimation(DropKickHash);
        public float GreatSwordJumpAttack() => PlayAnimation(GreatSwordJumpAttackHash);
        public float GreatSwordSlash() => PlayAnimation(GreatSwordSlashHash);
        public float JumpAttack() => PlayAnimation(JumpAttackHash);
        public float Idle() => PlayAnimation(IdleHash);

        public float SittingClap() => PlayAnimation(SittingClapHash);
        public float StandingUp() => PlayAnimation(StandingUpHash);
        public float FlyingKneePunchCombo() => PlayAnimation(FlyingKneePunchComboHash);

        #endregion


       

        private float PlayAnimation(int id)
        {
            animator.SetTrigger(id);
            return animationDuration[id];
        }
    }
}

