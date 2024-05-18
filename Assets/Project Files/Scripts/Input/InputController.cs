using Dreamteck;
using Dreamteck.Splines;
using Project_Files.Scripts.FallGuy;
using UnityEngine;
using UnityEngine.Serialization;

namespace Project_Files.Scripts.Input
{
    [RequireComponent(typeof(SplineFollower))]
    public class InputController : MonoBehaviour
    {
        [SerializeField] private SplineComputer splineComputer;
        private SplineFollower _splineFollower;
        private FallGuyBehavior[] _fallGuys;

        private void Start()
        {
            _splineFollower = GetComponent<SplineFollower>();
            _fallGuys = GetComponentsInChildren<FallGuyBehavior>();
            
            splineComputer.triggerGroups[0].triggers.ForEach(x => x.onCross.AddListener(LevelDone));
        }

        private void Update()
        {
            if (UnityEngine.Input.GetMouseButtonDown(0))
            {
                _fallGuys.ForEach(x => x.StartMove());
                _splineFollower.follow = true;
            }
        }

        private void LevelDone(SplineUser user)
        {
            _fallGuys.ForEach(x => x.StartVictory());
            _splineFollower.follow = false;
        }
    }
}