using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScaleCapsule : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _maxSize = 2f;

    private void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(_maxSize, _maxSize, _maxSize), _speed * Time.deltaTime);
    }
}
