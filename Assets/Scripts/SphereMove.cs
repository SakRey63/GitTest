using Unity.VisualScripting;
using UnityEngine;

public class SphereMove : MonoBehaviour
{
    [SerializeField] private Vector3 _movementDirection;
    private void Update()
    {
        transform.Translate(_movementDirection, Space.Self);
    }
}