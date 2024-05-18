using UnityEngine;

namespace Project_Files.Scripts.FallGuy
{
    [RequireComponent(typeof(CapsuleCollider))]
    public class FallGuyBehavior : FallGuyAnimator
    {
        [SerializeField] private ParticleSystem deathEffect;
        private CapsuleCollider _capsuleCollider;

        private void Start()
        {
            Init();
        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.layer != 6) return;
            
            var eff = Instantiate(deathEffect, other.transform);
            eff.Play();
            PlayDeathAnimation();
            Destroy(this);
        }

        public void StartMove() => PlayMoveAnimation();

        public void StartVictory() => PlayVictoryAnimation();

    }
}