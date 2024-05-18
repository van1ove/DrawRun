using UnityEngine;

namespace Project_Files.Scripts.FallGuy
{
    public class FallGuyAnimator : MonoBehaviour
    {
        private Animator _animator;
        
        protected void Init()
        {
            _animator = GetComponentInChildren<Animator>();
        }
        
        #region SwitchAnimation

        protected void PlayMoveAnimation() => _animator.SetTrigger("Move");

        protected void PlayVictoryAnimation() => _animator.SetTrigger("Won");

        protected void PlayDeathAnimation() => _animator.SetTrigger("Die");

        #endregion

    }
}
