using UnityEngine;

public class Scaled : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _magnification = 0.1f;
    private float _scaleSize;

    private void Update()
    {
        _scaleSize += _magnification;
        
        transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(_scaleSize, _scaleSize, _scaleSize), _speed * Time.deltaTime);
    }
}