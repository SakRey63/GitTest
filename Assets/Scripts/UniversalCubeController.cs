using UnityEngine;

public class UniversalCubeController : MonoBehaviour
{
    [SerializeField] private Vector3 _movementDirection;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _scaleSpeed;
    
    private float _maxSize = 4f;
    
    void Update()
    {
        transform.Translate(_movementDirection, Space.Self);
        transform.RotateAround(transform.position, transform.up, _rotationSpeed * Time.deltaTime);
        transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(_maxSize, _maxSize, _maxSize), _scaleSpeed * Time.deltaTime);
    }
}
