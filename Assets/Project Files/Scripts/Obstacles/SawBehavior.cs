using UnityEngine;

namespace Project_Files.Scripts.Obstacles
{
    public class SawBehavior : MonoBehaviour
    {
        [SerializeField, Min(50f)] private float speed;
        private void Update()
        {
            transform.Rotate(Vector3.forward, speed * Time.deltaTime);
        }
    }
}
