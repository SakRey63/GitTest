using UnityEngine;

namespace Skripts
{
    public class MoveSkeleton : MonoBehaviour
    {
        [SerializeField] private Vector3 _movementDirection;
        private void Update()
        {
            transform.Translate(_movementDirection, Space.World);
        }
    }
}
